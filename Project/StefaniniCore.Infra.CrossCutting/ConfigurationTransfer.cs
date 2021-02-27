using Microsoft.Extensions.Configuration;
using System;

namespace StefaniniCore.Infra.CrossCutting
{
    public static class ConfigurationTransfer
    {
        /// <summary>
        /// Convert Configuration application to object.
        /// </summary>
        /// <typeparam name="T">Object that you want to use.</typeparam>
        /// <param name="configuration"></param>
        /// <param name="customObjectPath">Custom path used to sub-paths. Example: "MyObject.MySubObject.Title"</param>
        /// <returns></returns>
        public static T GetObject<T>(IConfiguration configuration, string customObjectPath = null)
        {
            Type type = typeof(T);
            string sectionName = string.IsNullOrEmpty(customObjectPath) ? type.Name : customObjectPath;

            var objectData = configuration.GetSection(sectionName).Get<T>();
            return objectData;
        }
    }
}
