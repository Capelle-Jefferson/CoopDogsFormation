using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Utilities
{
    internal static class BddConnect
    {
        private static string Server = "mysql8001.site4now.net";
        private static string User = "a8ccad_coopdog";
        private static string Password = "Lixy07042015";
        private static string Database = "db_a8ccad_coopdog";


        internal static string ConnectChain = $"Server={Server};user={User};password={Password};database={Database}";
    }
}
