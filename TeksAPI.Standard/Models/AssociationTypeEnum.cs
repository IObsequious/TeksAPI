/*
 * TeksAPI.Standard
 *
 * This file was automatically generated for T.E.K.S. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TEKS;
using TEKS.Utilities;

namespace TEKS.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AssociationTypeEnum
    {
        ISCHILDOF, //TODO: Write general description for this method
        ISPEEROF, //TODO: Write general description for this method
        ISPARTOF, //TODO: Write general description for this method
        EXACTMATCHOF, //TODO: Write general description for this method
        PRECEDES, //TODO: Write general description for this method
        ISRELATEDTO, //TODO: Write general description for this method
        REPLACEDBY, //TODO: Write general description for this method
        EXEMPLAR, //TODO: Write general description for this method
        HASSKILLLEVEL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type AssociationTypeEnum
    /// </summary>
    public static class AssociationTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "isChildOf", "isPeerOf", "isPartOf", "exactMatchOf", "precedes", "isRelatedTo", "replacedBy", "exemplar", "hasSkillLevel" };

        /// <summary>
        /// Converts a AssociationTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AssociationTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AssociationTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AssociationTypeEnum.ISCHILDOF:
                case AssociationTypeEnum.ISPEEROF:
                case AssociationTypeEnum.ISPARTOF:
                case AssociationTypeEnum.EXACTMATCHOF:
                case AssociationTypeEnum.PRECEDES:
                case AssociationTypeEnum.ISRELATEDTO:
                case AssociationTypeEnum.REPLACEDBY:
                case AssociationTypeEnum.EXEMPLAR:
                case AssociationTypeEnum.HASSKILLLEVEL:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AssociationTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AssociationTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AssociationTypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into AssociationTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AssociationTypeEnum value</returns>
        public static AssociationTypeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type AssociationTypeEnum", value));

            return (AssociationTypeEnum) index;
        }
    }
} 