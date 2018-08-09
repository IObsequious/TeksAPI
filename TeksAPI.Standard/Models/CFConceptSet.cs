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
    public class CFConceptSet : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.CFConcept> cFConcepts;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFConcepts")]
        public List<Models.CFConcept> CFConcepts 
        { 
            get 
            {
                return this.cFConcepts; 
            } 
            set 
            {
                this.cFConcepts = value;
                onPropertyChanged("CFConcepts");
            }
        }
    }
} 