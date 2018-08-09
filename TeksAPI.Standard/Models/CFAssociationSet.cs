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
    public class CFAssociationSet : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.CFItem cFItem;
        private List<Models.CFPckgAssociation> cFAssociations;

        /// <summary>
        /// This is the container for the CFItem data outside of the context of a CFPackage. This is the content that either describes a specific competency (learning objective) or describes a grouping of competencies within the taxonomy of a Competency Framework Document.
        /// </summary>
        [JsonProperty("CFItem")]
        public Models.CFItem CFItem 
        { 
            get 
            {
                return this.cFItem; 
            } 
            set 
            {
                this.cFItem = value;
                onPropertyChanged("CFItem");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFAssociations")]
        public List<Models.CFPckgAssociation> CFAssociations 
        { 
            get 
            {
                return this.cFAssociations; 
            } 
            set 
            {
                this.cFAssociations = value;
                onPropertyChanged("CFAssociations");
            }
        }
    }
} 