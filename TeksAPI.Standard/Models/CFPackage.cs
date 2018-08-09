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
    public class CFPackage : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.CFPckgDocument cFDocument;
        private List<Models.CFPckgItem> cFItems;
        private List<Models.CFPckgAssociation> cFAssociations;
        private Models.CFDefinition cFDefinitions;
        private List<Models.CFRubricType> cFRubrics;

        /// <summary>
        /// The container for the data about a competency framework document (CFDocument) within a CFPackage. A CFDocument is the root for the creation of a learning standard/competency.
        /// </summary>
        [JsonProperty("CFDocument")]
        public Models.CFPckgDocument CFDocument 
        { 
            get 
            {
                return this.cFDocument; 
            } 
            set 
            {
                this.cFDocument = value;
                onPropertyChanged("CFDocument");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFItems")]
        public List<Models.CFPckgItem> CFItems 
        { 
            get 
            {
                return this.cFItems; 
            } 
            set 
            {
                this.cFItems = value;
                onPropertyChanged("CFItems");
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

        /// <summary>
        /// The container for the set of definitions used for the competency framework i.e. the set of CFSubjects, CFConcepts, CFItemTypes, CFAssociationGroupings and CFLicenses.
        /// </summary>
        [JsonProperty("CFDefinitions")]
        public Models.CFDefinition CFDefinitions 
        { 
            get 
            {
                return this.cFDefinitions; 
            } 
            set 
            {
                this.cFDefinitions = value;
                onPropertyChanged("CFDefinitions");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFRubrics")]
        public List<Models.CFRubricType> CFRubrics 
        { 
            get 
            {
                return this.cFRubrics; 
            } 
            set 
            {
                this.cFRubrics = value;
                onPropertyChanged("CFRubrics");
            }
        }
    }
} 