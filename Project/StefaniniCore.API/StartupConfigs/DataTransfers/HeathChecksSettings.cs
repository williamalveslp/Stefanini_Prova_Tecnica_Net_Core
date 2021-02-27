﻿using System.ComponentModel;

namespace StefaniniCore.API.StartupConfigs.DataTransfers
{
    internal class HeathChecksSettings
    {
        public AppBuilderDto AppBuilder { get; set; }
        public ServiceCollectionDto ServiceCollection { get; set; }

        public class AppBuilderDto
        {
            [Description("Path for HealthChecks. Example: '/healthchecks'.")]
            public string PathString { get; set; }

            [Description("Path for HealthChecks UI. Example: '/healthchecks-ui'.")]
            public string PathStringUI { get; set; }
        }
      
        public class ServiceCollectionDto
        {
            [Description("Garbage Collector informations. Example: 'GarbageCollector'")]
            public string GCInfo { get; set; }

            public UrlGroupDto UrlGroup { get; set; }

            internal class UrlGroupDto
            {
                public string Name { get; set; }


                [Description("Url path. Example: 'https://www.google.com/'")]
                public string Url { get; set; }
            }
        }
    }
}
