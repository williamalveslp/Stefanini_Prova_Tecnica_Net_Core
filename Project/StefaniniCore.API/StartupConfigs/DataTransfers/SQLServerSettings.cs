﻿using System.ComponentModel;

namespace StefaniniCore.API.StartupConfigs.DataTransfers
{
    internal class SQLServerConnectionSettings
    {
        [Description("Connection String. Example: 'Data Source=.\\SQLEXPRESS;Initial Catalog=MyDatabaseName;Integrated Security=True'")]
        public string ConnectionString { get; set; }

        public string Environment { get; set; }

        public string DatabaseName { get; set; }
    }
}
