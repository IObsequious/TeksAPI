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
using TEKS.Http.Client;

using TEKS.Models;
using TEKS;
using TEKS.Utilities;


namespace TEKS.Exceptions
{
    public class ImsxStatusInfoException : APIException 
    {
        // These fields hold the values for the public properties.
        private Models.ErrorCodeEnum imsxCodeMajor;
        private Models.ErrorSeverityEnum imsxSeverity;
        private string imsxDescription;
        private Models.Error imsxCodeMinor;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("imsx_codeMajor", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.ErrorCodeEnum ImsxCodeMajor 
        { 
            get 
            {
                return this.imsxCodeMajor; 
            } 
            private set 
            {
                this.imsxCodeMajor = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("imsx_severity", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.ErrorSeverityEnum ImsxSeverity 
        { 
            get 
            {
                return this.imsxSeverity; 
            } 
            private set 
            {
                this.imsxSeverity = value;
            }
        }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("imsx_description")]
        public string ImsxDescription 
        { 
            get 
            {
                return this.imsxDescription; 
            } 
            private set 
            {
                this.imsxDescription = value;
            }
        }

        /// <summary>
        /// This is the container for the set of code minor status codes reported in the responses from the Service Provider.
        /// </summary>
        [JsonProperty("imsx_codeMinor")]
        public Models.Error ImsxCodeMinor 
        { 
            get 
            {
                return this.imsxCodeMinor; 
            } 
            private set 
            {
                this.imsxCodeMinor = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ImsxStatusInfoException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 