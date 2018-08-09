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
    public enum OrderByEnum
    {
        ASC, //TODO: Write general description for this method
        DESC, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type OrderByEnum
    /// </summary>
    public static class OrderByEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "asc", "desc" };

        /// <summary>
        /// Converts a OrderByEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The OrderByEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(OrderByEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case OrderByEnum.ASC:
                case OrderByEnum.DESC:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of OrderByEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of OrderByEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<OrderByEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into OrderByEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed OrderByEnum value</returns>
        public static OrderByEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type OrderByEnum", value));

            return (OrderByEnum) index;
        }
    }
} 