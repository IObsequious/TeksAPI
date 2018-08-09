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
    public enum ErrorCodeEnum
    {
        SUCCESS, //TODO: Write general description for this method
        PROCESSING, //TODO: Write general description for this method
        FAILURE, //TODO: Write general description for this method
        UNSUPPORTED, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ErrorCodeEnum
    /// </summary>
    public static class ErrorCodeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "success", "processing", "failure", "unsupported" };

        /// <summary>
        /// Converts a ErrorCodeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ErrorCodeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ErrorCodeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ErrorCodeEnum.SUCCESS:
                case ErrorCodeEnum.PROCESSING:
                case ErrorCodeEnum.FAILURE:
                case ErrorCodeEnum.UNSUPPORTED:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ErrorCodeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ErrorCodeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ErrorCodeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into ErrorCodeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ErrorCodeEnum value</returns>
        public static ErrorCodeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type ErrorCodeEnum", value));

            return (ErrorCodeEnum) index;
        }
    }
} 