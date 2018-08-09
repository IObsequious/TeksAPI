/*
 * TeksAPI.Standard
 *
 * This file was automatically generated for T.E.K.S. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TEKS;
using TEKS.Utilities;


namespace TEKS.Models
{
    public class CFItemTypeSet : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.CFItemType> cFItemTypes;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFItemTypes")]
        public List<Models.CFItemType> CFItemTypes 
        { 
            get 
            {
                return this.cFItemTypes; 
            } 
            set 
            {
                this.cFItemTypes = value;
                onPropertyChanged("CFItemTypes");
            }
        }
    }
} 