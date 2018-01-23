using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GMG.Cobros.WindowsServiceBusRelay.Host
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();

            this.Committed += ServiceInstaller_Committed;
        }
        

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
        }

        public override void Commit(IDictionary savedState)
        {
            try
            {
                EjecutarBaseData();
                base.Commit(savedState);
            }
            catch (Exception e)
            {
                WriteOnLog("Fallo al actualizar el archivo de configuración del Servicio: " + e.Message);
                base.Rollback(savedState);
            }
        }

        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
        }
        public void EjecutarBaseData()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "1234";
            MySqlConnection conn = new MySqlConnection(builder.ToString());

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "CREATE DATABASE IF NOT EXISTS `bd_registro` /*!40100 DEFAULT CHARACTER SET latin1 */; USE `bd_registro`;" +
                             "CREATE TABLE bd_registro.registro ( id_registro int(11) NOT NULL AUTO_INCREMENT," +
                                                      "detalle varchar(50) DEFAULT NULL," +
                                                      "monto float DEFAULT NULL," +
                                                      "fecha date DEFAULT NULL," +
                                                      "estado varchar(50) DEFAULT NULL, " +
                                                      "PRIMARY KEY(id_registro));" +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.consulta_detalle(IN `det` VARCHAR(50)) BEGIN SELECT registro.id_registro,registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro WHERE detalle = det; END// \n DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.consulta_registro(IN `fechone` VARCHAR(50),     IN `fechtwo` VARCHAR(50),     IN `det` VARCHAR(50) )BEGIN SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro WHERE registro.fecha BETWEEN fechone AND fechtwo AND registro.estado != 'Eliminado'AND registro.detalle = 'DEPOSITO SOMOS VOZ'ORDER BY id_registro DESC;END//  DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.consulta_registroOtros( IN `fechone` VARCHAR(50),IN `fechtwo` VARCHAR(50)) BEGIN SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro WHERE registro.fecha BETWEEN fechone AND fechtwo AND registro.estado != 'Eliminado' AND registro.detalle != 'DEPOSITO SOMOS VOZ' ORDER BY id_registro DESC;END//  DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.eliminar_registros() BEGIN DELETE FROM registro WHERE registro.estado = 'Eliminado'; END//  DELIMITER; " +
                            "DELIMITER // CREATE DEFINER=`root`@`localhost` PROCEDURE  bd_registro.insertar_registro(	IN `detalle` VARCHAR(50),	IN `monto` FLOAT, 	IN `fecha` DATE,	IN `estado` VARCHAR(50))BEGIN INSERT INTO registro (registro.detalle,registro.monto,registro.fecha,registro.estado) VALUES(detalle,monto,fecha,estado); END// DELIMITER; " +
                            "DELIMITER // CREATE DEFINER=`root`@`localhost` PROCEDURE bd_registro.listar_registro() BEGIN	SELECT * FROM registro	WHERE registro.estado != 'Eliminado'	ORDER BY id_registro DESC; END// DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.listar_registro_eliminado() BEGIN SELECT* FROM registro WHERE registro.estado = 'Eliminado' ORDER BY id_registro DESC; END//  DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.modifica_registro(IN `id_registro` INT,IN `detalle` VARCHAR(50),IN `monto` FLOAT,IN `fecha` DATE,IN `estado` VARCHAR(50)) BEGIN UPDATE registro SET registro.detalle = detalle,registro.monto = monto,registro.fecha = fecha, registro.estado = estado WHERE registro.id_registro = id_registro; END// DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.Test(IN `Param1` DATE,IN `Param2` DATE) BEGIN SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro; END// DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.vaciar_registro() BEGIN DELETE FROM registro; ALTER TABLE registro AUTO_INCREMENT = 0; END// DELIMITER; ";

                MySqlScript script = new MySqlScript(conn, sql);


                int count = script.Execute();

                Console.WriteLine("Executed " + count + " statement(s).");
                Console.WriteLine("Delimiter: " + script.Delimiter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }
        }
  
        private void WriteOnLog(string message)
        {
            if (!EventLog.SourceExists("GMG.Cobros.WindowsServiceBusRelay.Host"))
            {
                EventLog.CreateEventSource("GMG.Cobros.WindowsServiceBusRelay.Host", "InstallerLog");
                Console.WriteLine(message);
                return;
            }
            EventLog myLog = new EventLog();
            myLog.Source = "GMG.Cobros.WindowsServiceBusRelay.Host";
            myLog.WriteEntry(message);
            throw new InstallException(message);
        }

        void ServiceInstaller_Committed(object sender, InstallEventArgs e)
        {
            using (ServiceController sc = new ServiceController(serviceInstaller1.ServiceName))
            {
                SetRecoveryOptions(serviceInstaller1.ServiceName);

                sc.Start();
            }
        }

        static void SetRecoveryOptions(string serviceName)
        {
            int exitCode;
            using (var process = new Process())
            {
                var startInfo = process.StartInfo;
                startInfo.FileName = "sc";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                // tell Windows that the service should restart if it fails
                startInfo.Arguments = string.Format("failure \"{0}\" reset= 0 actions= restart/60000", serviceName);
                process.Start();
                process.WaitForExit();
                exitCode = process.ExitCode;
            }

            if (exitCode != 0)
                throw new InvalidOperationException();
        }

    }
}
