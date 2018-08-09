using System.Collections.Generic;
using System.Text;
using TEKS.Utilities;
using TEKS.Models;
namespace TEKS
{
    public partial class Configuration
    {

        public enum Environments
        {
            PRODUCTION,
            //teks-api.com
            TEKS_API_COM,
        }
        public enum Servers
        {
            ENUM_DEFAULT,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"http://teks-api.texasgateway.org/ims/case/v1p0" },
                    }
                },
                { 
                    Environments.TEKS_API_COM,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"teks-api.com/api/v1" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.ENUM_DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}