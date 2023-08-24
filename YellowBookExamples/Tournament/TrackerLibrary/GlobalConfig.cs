using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        // always visiable for everyone to see or read but only some can set 
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            // call at the begininng of and base in database and textfile
            // dont over engineer your prgrams think about tomorrow 
            if (database) //if you have a bool you dont have to put true (database == true)
            {
                // TODO -   Create the sql connection do something
            }
            if (textFiles)
            {
                // TODO - Create the Text connection
            }
        }
    }
}
