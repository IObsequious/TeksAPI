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
    public class CFPckgAssociation : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string identifier;
        private Models.AssociationTypeEnum associationType;
        private string uri;
        private Models.LinkGenURI originNodeURI;
        private Models.LinkGenURI destinationNodeURI;
        private DateTime lastChangeDateTime;
        private int? sequenceNumber;
        private Models.LinkURI cFAssociationGroupingURI;

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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("associationType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.AssociationTypeEnum AssociationType 
        { 
            get 
            {
                return this.associationType; 
            } 
            set 
            {
                this.associationType = value;
                onPropertyChanged("AssociationType");
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
        /// A container for the information that is used to achieve the link data reference.
        /// </summary>
        [JsonProperty("originNodeURI")]
        public Models.LinkGenURI OriginNodeURI 
        { 
            get 
            {
                return this.originNodeURI; 
            } 
            set 
            {
                this.originNodeURI = value;
                onPropertyChanged("OriginNodeURI");
            }
        }

        /// <summary>
        /// A container for the information that is used to achieve the link data reference.
        /// </summary>
        [JsonProperty("destinationNodeURI")]
        public Models.LinkGenURI DestinationNodeURI 
        { 
            get 
            {
                return this.destinationNodeURI; 
            } 
            set 
            {
                this.destinationNodeURI = value;
                onPropertyChanged("DestinationNodeURI");
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
        /// Model Primitive Datatype = Integer
        /// </summary>
        [JsonProperty("sequenceNumber")]
        public int? SequenceNumber 
        { 
            get 
            {
                return this.sequenceNumber; 
            } 
            set 
            {
                this.sequenceNumber = value;
                onPropertyChanged("SequenceNumber");
            }
        }

        /// <summary>
        /// A container for the information that is used to achieve the link data reference.
        /// </summary>
        [JsonProperty("CFAssociationGroupingURI")]
        public Models.LinkURI CFAssociationGroupingURI 
        { 
            get 
            {
                return this.cFAssociationGroupingURI; 
            } 
            set 
            {
                this.cFAssociationGroupingURI = value;
                onPropertyChanged("CFAssociationGroupingURI");
            }
        }
    }
} 