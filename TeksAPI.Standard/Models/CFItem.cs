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
    public class CFItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string identifier;
        private string fullStatement;
        private string uri;
        private DateTime lastChangeDateTime;
        private Models.LinkURI cFDocumentURI;
        private string alternativeLabel;
        private string cFItemType;
        private string humanCodingScheme;
        private string listEnumeration;
        private string abbreviatedStatement;
        private List<string> conceptKeywords;
        private Models.LinkURI conceptKeywordsURI;
        private string notes;
        private string language;
        private List<string> educationLevel;
        private Models.LinkURI cFItemTypeURI;
        private Models.LinkURI licenseURI;
        private DateTime? statusStartDate;
        private DateTime? statusEndDate;

        /// <summary>
        /// The data-type for establishing a Globally Unique Identifier (GUID). The form of the GUID is a Universally Unique Identifier (UUID) of 16 hexadecimal characters (lower case) in the format 8-4-4-4-12. All permitted versions (1-5) and variants (1-2) are supported.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier 
        { 
            get 
            {
                return this.identifier; 
            } 
            set 
            {
                this.identifier = value;
                onPropertyChanged("Identifier");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("fullStatement")]
        public string FullStatement 
        { 
            get 
            {
                return this.fullStatement; 
            } 
            set 
            {
                this.fullStatement = value;
                onPropertyChanged("FullStatement");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = AnyURI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri 
        { 
            get 
            {
                return this.uri; 
            } 
            set 
            {
                this.uri = value;
                onPropertyChanged("Uri");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastChangeDateTime")]
        public DateTime LastChangeDateTime 
        { 
            get 
            {
                return this.lastChangeDateTime; 
            } 
            set 
            {
                this.lastChangeDateTime = value;
                onPropertyChanged("LastChangeDateTime");
            }
        }

        /// <summary>
        /// A container for the information that is used to achieve the link data reference.
        /// </summary>
        [JsonProperty("CFDocumentURI")]
        public Models.LinkURI CFDocumentURI 
        { 
            get 
            {
                return this.cFDocumentURI; 
            } 
            set 
            {
                this.cFDocumentURI = value;
                onPropertyChanged("CFDocumentURI");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("alternativeLabel")]
        public string AlternativeLabel 
        { 
            get 
            {
                return this.alternativeLabel; 
            } 
            set 
            {
                this.alternativeLabel = value;
                onPropertyChanged("AlternativeLabel");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("CFItemType")]
        public string CFItemType 
        { 
            get 
            {
                return this.cFItemType; 
            } 
            set 
            {
                this.cFItemType = value;
                onPropertyChanged("CFItemType");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("humanCodingScheme")]
        public string HumanCodingScheme 
        { 
            get 
            {
                return this.humanCodingScheme; 
            } 
            set 
            {
                this.humanCodingScheme = value;
                onPropertyChanged("HumanCodingScheme");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("listEnumeration")]
        public string ListEnumeration 
        { 
            get 
            {
                return this.listEnumeration; 
            } 
            set 
            {
                this.listEnumeration = value;
                onPropertyChanged("ListEnumeration");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("abbreviatedStatement")]
        public string AbbreviatedStatement 
        { 
            get 
            {
                return this.abbreviatedStatement; 
            } 
            set 
            {
                this.abbreviatedStatement = value;
                onPropertyChanged("AbbreviatedStatement");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("conceptKeywords")]
        public List<string> ConceptKeywords 
        { 
            get 
            {
                return this.conceptKeywords; 
            } 
            set 
            {
                this.conceptKeywords = value;
                onPropertyChanged("ConceptKeywords");
            }
        }

        /// <summary>
        /// A container for the information that is used to achieve the link data reference.
        /// </summary>
        [JsonProperty("conceptKeywordsURI")]
        public Models.LinkURI ConceptKeywordsURI 
        { 
            get 
            {
                return this.conceptKeywordsURI; 
            } 
            set 
            {
                this.conceptKeywordsURI = value;
                onPropertyChanged("ConceptKeywordsURI");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("notes")]
        public string Notes 
        { 
            get 
            {
                return this.notes; 
            } 
            set 
            {
                this.notes = value;
                onPropertyChanged("Notes");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = Language
        /// </summary>
        [JsonProperty("language")]
        public string Language 
        { 
            get 
            {
                return this.language; 
            } 
            set 
            {
                this.language = value;
                onPropertyChanged("Language");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("educationLevel")]
        public List<string> EducationLevel 
        { 
            get 
            {
                return this.educationLevel; 
            } 
            set 
            {
                this.educationLevel = value;
                onPropertyChanged("EducationLevel");
            }
        }

        /// <summary>
        /// A container for the information that is used to achieve the link data reference.
        /// </summary>
        [JsonProperty("CFItemTypeURI")]
        public Models.LinkURI CFItemTypeURI 
        { 
            get 
            {
                return this.cFItemTypeURI; 
            } 
            set 
            {
                this.cFItemTypeURI = value;
                onPropertyChanged("CFItemTypeURI");
            }
        }

        /// <summary>
        /// A container for the information that is used to achieve the link data reference.
        /// </summary>
        [JsonProperty("licenseURI")]
        public Models.LinkURI LicenseURI 
        { 
            get 
            {
                return this.licenseURI; 
            } 
            set 
            {
                this.licenseURI = value;
                onPropertyChanged("LicenseURI");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = Date
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("statusStartDate")]
        public DateTime? StatusStartDate 
        { 
            get 
            {
                return this.statusStartDate; 
            } 
            set 
            {
                this.statusStartDate = value;
                onPropertyChanged("StatusStartDate");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = Date
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("statusEndDate")]
        public DateTime? StatusEndDate 
        { 
            get 
            {
                return this.statusEndDate; 
            } 
            set 
            {
                this.statusEndDate = value;
                onPropertyChanged("StatusEndDate");
            }
        }
    }
} 