using SitechInventorySystem.Data_Layer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitechInventorySystem.Data_Layer.Data_Access
{
    public class Database
    {
        public static string ConnectionString
        {
            get
            {
                return DataAccessSettings.Default.ConnectionString;
            }

            set
            {
                DataAccessSettings.Default.ConnectionString = value;
                DataAccessSettings.Default.Save();
            }
        }
    }
}
