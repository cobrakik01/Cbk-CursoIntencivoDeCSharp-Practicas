using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Curso.Libreria.Util
{
    public sealed class DataSourceFactory
    {
        private static DataSourceFactory dsf;
        private PropertiesReader ConnectiondConfig;
        private PropertiesReader DepenencieInyection;

        private IDbCommand _Command;
        private IDbConnection _Connection;

        /*
        private readonly string DATABASE_NAME = "ado";
        private readonly string SERVER_NAME = "localhost";
        private readonly string USER_NAME = "root";
        private readonly string PASSWORD = "";
        */

        public DataSourceFactory()
        {
            ConnectiondConfig = new PropertiesReader(new System.IO.StreamReader("DBConfig.properties"));
            DepenencieInyection = new PropertiesReader(new System.IO.StreamReader("dependencies.properties"));
            _Connection = CreateConnection();
            _Command = CreateCommand(_Connection);
        }

        private IDbConnection CreateConnection()
        {
            IDbConnection cn;
            string db = ConnectiondConfig.GetPropertie("Database");
            string ds = ConnectiondConfig.GetPropertie("DataSource");
            string ui = ConnectiondConfig.GetPropertie("UserId");
            string psw = ConnectiondConfig.GetPropertie("Password");

            string ConenctionDependency = DepenencieInyection.GetPropertie("sqlConnection");
            Type tConnection = Type.GetType("MySql.Data.MySqlClient.MySqlConnection");
            Console.WriteLine(tConnection);

            /*
            Type[] types = new Type[1];
            types[0] = typeof(string);
            System.Reflection.ConstructorInfo tConstructor = tConnection.GetConstructor(types);

            Console.WriteLine(tConstructor.ToString());
            
            cn = (IDbConnection)tConnection.GetConstructor(new Type[] { typeof(string) }).Invoke(tConnection, new object[]{
                string.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, ds, ui, psw)
            });
             */
            cn = new MySql.Data.MySqlClient.MySqlConnection(string.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, ds, ui, psw));
            cn.Open();
            return cn;
        }

        private IDbCommand CreateCommand(IDbConnection cn)
        {
            IDbCommand cmd = null;
            cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = cn;
            return cmd;
        }

        public static DataSourceFactory GetDataSource()
        {
            if (dsf == null)
            {
                dsf = new DataSourceFactory();
            }
            return dsf;
        }

        public IDbConnection GetConnection()
        {
            return _Connection;
        }

        public IDbCommand GetCommand()
        {
            return _Command;
        }

        public object GetParameter(string parameterName, string value)
        {
            return new MySql.Data.MySqlClient.MySqlParameter(parameterName, value);
        }
    }
}
