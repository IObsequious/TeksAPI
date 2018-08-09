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
    public class CFRubricCriterionLevel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string identifier;
        private string uri;
        private DateTime lastChangeDateTime;
        private string description;
        private string quality;
        private double? score;
        private string feedback;
        private int? position;
        private string rubricCriterionId;

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
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("quality")]
        public string Quality 
        { 
            get 
            {
                return this.quality; 
            } 
            set 
            {
                this.quality = value;
                onPropertyChanged("Quality");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = Float
        /// </summary>
        [JsonProperty("score")]
        public double? Score 
        { 
            get 
            {
                return this.score; 
            } 
            set 
            {
                this.score = value;
                onPropertyChanged("Score");
            }
        }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("feedback")]
        public string Feedback 
        { 
            get 
            {
                return this.feedback; 
            } 
            set 
            {
                this.feedback = value;
                onPropertyChanged("Feedback");
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
        [JsonProperty("rubricCriterionId")]
        public string RubricCriterionId 
        { 
            get 
            {
                return this.rubricCriterionId; 
            } 
            set 
            {
                this.rubricCriterionId = value;
                onPropertyChanged("RubricCriterionId");
            }
        }
    }
} 