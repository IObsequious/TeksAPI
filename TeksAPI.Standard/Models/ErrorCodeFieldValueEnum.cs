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
    public enum ErrorCodeFieldValueEnum
    {
        FULLSUCCESS, //TODO: Write general description for this method
        INVALID_SORT_FIELD, //TODO: Write general description for this method
        INVALID_SELECTION_FIELD, //TODO: Write general description for this method
        FORBIDDEN, //TODO: Write general description for this method
        UNAUTHORISEDREQUEST, //TODO: Write general description for this method
        INTERNAL_SERVER_ERROR, //TODO: Write general description for this method
        UNKNOWNOBJECT, //TODO: Write general description for this method
        SERVER_BUSY, //TODO: Write general description for this method
        INVALIDUUID, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ErrorCodeFieldValueEnum
    /// </summary>
    public static class ErrorCodeFieldValueEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "fullsuccess", "invalid_sort_field", "invalid_selection_field", "forbidden", "unauthorisedrequest", "internal_server_error", "unknownobject", "server_busy", "invaliduuid" };

        /// <summary>
        /// Converts a ErrorCodeFieldValueEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ErrorCodeFieldValueEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ErrorCodeFieldValueEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ErrorCodeFieldValueEnum.FULLSUCCESS:
                case ErrorCodeFieldValueEnum.INVALID_SORT_FIELD:
                case ErrorCodeFieldValueEnum.INVALID_SELECTION_FIELD:
                case ErrorCodeFieldValueEnum.FORBIDDEN:
                case ErrorCodeFieldValueEnum.UNAUTHORISEDREQUEST:
                case ErrorCodeFieldValueEnum.INTERNAL_SERVER_ERROR:
                case ErrorCodeFieldValueEnum.UNKNOWNOBJECT:
                case ErrorCodeFieldValueEnum.SERVER_BUSY:
                case ErrorCodeFieldValueEnum.INVALIDUUID:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ErrorCodeFieldValueEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ErrorCodeFieldValueEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ErrorCodeFieldValueEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into ErrorCodeFieldValueEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ErrorCodeFieldValueEnum value</returns>
        public static ErrorCodeFieldValueEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type ErrorCodeFieldValueEnum", value));

            return (ErrorCodeFieldValueEnum) index;
        }
    }
} 