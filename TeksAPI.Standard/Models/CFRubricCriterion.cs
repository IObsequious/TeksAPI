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
    public class CFRubricCriterion : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string identifier;
        private string uri;
        private DateTime lastChangeDateTime;
        private string category;
        private string description;
        private Models.LinkURI cFItemURI;
        private double? weight;
        private int? position;
        private string rubricId;
        private List<Models.CFRubricCriterionLevel> cFRubricCriterionLevels;

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
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("category")]
        public string Category 
        { 
            get 
            {
                return this.category; 
            } 
            set 
            {
                this.category = value;
                onPropertyChanged("Category");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = String
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
        /// A container for the information that is used to achieve the link data reference.
        /// </summary>
        [JsonProperty("CFItemURI")]
        public Models.LinkURI CFItemURI 
        { 
            get 
            {
                return this.cFItemURI; 
            } 
            set 
            {
                this.cFItemURI = value;
                onPropertyChanged("CFItemURI");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = Float
        /// </summary>
        [JsonProperty("weight")]
        public double? Weight 
        { 
            get 
            {
                return this.weight; 
            } 
            set 
            {
                this.weight = value;
                onPropertyChanged("Weight");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = Integer
        /// </summary>
        [JsonProperty("position")]
        public int? Position 
        { 
            get 
            {
                return this.position; 
            } 
            set 
            {
                this.position = value;
                onPropertyChanged("Position");
            }
        }

        /// <summary>
        /// The data-type for establishing a Globally Unique Identifier (GUID). The form of the GUID is a Universally Unique Identifier (UUID) of 16 hexadecimal characters (lower case) in the format 8-4-4-4-12. All permitted versions (1-5) and variants (1-2) are supported.
        /// </summary>
        [JsonProperty("rubricId")]
        public string RubricId 
        { 
            get 
            {
                return this.rubricId; 
            } 
            set 
            {
                this.rubricId = value;
                onPropertyChanged("RubricId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CFRubricCriterionLevels")]
        public List<Models.CFRubricCriterionLevel> CFRubricCriterionLevels 
        { 
            get 
            {
                return this.cFRubricCriterionLevels; 
            } 
            set 
            {
                this.cFRubricCriterionLevels = value;
                onPropertyChanged("CFRubricCriterionLevels");
            }
        }
    }
} 