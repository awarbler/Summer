using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        // always visiable for everyone to see or read but only some can set 
        public static IDataConnection Connection { get; private set; } 
    

        public static void InitializeConnections(DatabaseType db)
        {
            /*switch (db)
            {
                case DatabaseType.Sql:
                    break;
                case DatabaseType.TextFile:
                    break;
                default:
                    break;
            }*/
            // call at the begininng of and base in database and textfile
            // dont over engineer your prgrams think about tomorrow 
            if (db == DatabaseType.Sql) //if you have a bool you dont have to put true (database == true)
            {
                // TODO -   set up the sql connector properly
                SqlConnector sql = new SqlConnector();
                Connection =sql;
            }
            // two if statements because i need both of these to be true
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the Text connection
                TextConnection text = new TextConnection();
                Connection= text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
