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
    public class CFDocumentType : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string identifier;
        private string uri;
        private string creator;
        private string title;
        private DateTime lastChangeDateTime;
        private Models.LinkURI cFPackageURI;
        private string officialSourceURL;
        private string publisher;
        private string description;
        private List<string> subject;
        private List<Models.LinkURI> subjectURI;
        private string language;
        private string version;
        private string adoptionStatus;
        private DateTime? statusStartDate;
        private DateTime? statusEndDate;
        private Models.LinkURI licenseURI;
        private string notes;

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
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("creator")]
        public string Creator 
        { 
            get 
            {
                return this.creator; 
            } 
            set 
            {
                this.creator = value;
                onPropertyChanged("Creator");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("title")]
        public string Title 
        { 
            get 
            {
                return this.title; 
            } 
            set 
            {
                this.title = value;
                onPropertyChanged("Title");
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
        [JsonProperty("CFPackageURI")]
        public Models.LinkURI CFPackageURI 
        { 
            get 
            {
                return this.cFPackageURI; 
            } 
            set 
            {
                this.cFPackageURI = value;
                onPropertyChanged("CFPackageURI");
            }
        }

        /// <summary>
        /// The data-type for establishing a Uniform Resource Locator (URL) as defined by W3C.
        /// </summary>
        [JsonProperty("officialSourceURL")]
        public string OfficialSourceURL 
        { 
            get 
            {
                return this.officialSourceURL; 
            } 
            set 
            {
                this.officialSourceURL = value;
                onPropertyChanged("OfficialSourceURL");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("publisher")]
        public string Publisher 
        { 
            get 
            {
                return this.publisher; 
            } 
            set 
            {
                this.publisher = value;
                onPropertyChanged("Publisher");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("subject")]
        public List<string> Subject 
        { 
            get 
            {
                return this.subject; 
            } 
            set 
            {
                this.subject = value;
                onPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("subjectURI")]
        public List<Models.LinkURI> SubjectURI 
        { 
            get 
            {
                return this.subjectURI; 
            } 
            set 
            {
                this.subjectURI = value;
                onPropertyChanged("SubjectURI");
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
        [JsonProperty("version")]
        public string Version 
        { 
            get 
            {
                return this.version; 
            } 
            set 
            {
                this.version = value;
                onPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("adoptionStatus")]
        public string AdoptionStatus 
        { 
            get 
            {
                return this.adoptionStatus; 
            } 
            set 
            {
                this.adoptionStatus = value;
                onPropertyChanged("AdoptionStatus");
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
    }
} 