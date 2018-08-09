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
    public class CFDefinition : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.CFConcept> cFConcepts;
        private List<Models.CFSubject> cFSubjects;
        private List<Models.CFLicense> cFLicenses;
        private List<Models.CFItemType> cFItemTypes;
        private List<Models.CFAssociationGrouping> cFAssociationGroupings;

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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFSubjects")]
        public List<Models.CFSubject> CFSubjects 
        { 
            get 
            {
                return this.cFSubjects; 
            } 
            set 
            {
                this.cFSubjects = value;
                onPropertyChanged("CFSubjects");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFLicenses")]
        public List<Models.CFLicense> CFLicenses 
        { 
            get 
            {
                return this.cFLicenses; 
            } 
            set 
            {
                this.cFLicenses = value;
                onPropertyChanged("CFLicenses");
            }
        }

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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFAssociationGroupings")]
        public List<Models.CFAssociationGrouping> CFAssociationGroupings 
        { 
            get 
            {
                return this.cFAssociationGroupings; 
            } 
            set 
            {
                this.cFAssociationGroupings = value;
                onPropertyChanged("CFAssociationGroupings");
            }
        }
    }
} 