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
    public class Error : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.ErrorField> imsxCodeMinorField;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("imsx_codeMinorField")]
        public List<Models.ErrorField> ImsxCodeMinorField 
        { 
            get 
            {
                return this.imsxCodeMinorField; 
            } 
            set 
            {
                this.imsxCodeMinorField = value;
                onPropertyChanged("ImsxCodeMinorField");
            }
        }
    }
} 