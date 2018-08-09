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
    public class ErrorField : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string imsxCodeMinorFieldName;
        private Models.ErrorCodeFieldValueEnum imsxCodeMinorFieldValue;

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("imsx_codeMinorFieldName")]
        public string ImsxCodeMinorFieldName 
        { 
            get 
            {
                return this.imsxCodeMinorFieldName; 
            } 
            set 
            {
                this.imsxCodeMinorFieldName = value;
                onPropertyChanged("ImsxCodeMinorFieldName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("imsx_codeMinorFieldValue", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.ErrorCodeFieldValueEnum ImsxCodeMinorFieldValue 
        { 
            get 
            {
                return this.imsxCodeMinorFieldValue; 
            } 
            set 
            {
                this.imsxCodeMinorFieldValue = value;
                onPropertyChanged("ImsxCodeMinorFieldValue");
            }
        }
    }
} 