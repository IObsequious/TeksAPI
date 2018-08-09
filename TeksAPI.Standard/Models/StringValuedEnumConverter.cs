/*
 * TeksAPI.Standard
 *
 * This file was automatically generated for T.E.K.S. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections;
using System.Reflection;
using Newtonsoft.Json;

namespace TEKS.Models
{
    public class StringValuedEnumConverter : JsonConverter
    {
        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The json writer</param>
        /// <param name="value">The value to write</param>
        /// <param name="serializer">The calling serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            //handle string valued enums in dictionaries
            if (value is IDictionary)
            {
                writer.WriteStartObject();
                foreach (object keyValuePair in (value as IDictionary))
                {
                    var entry = (DictionaryEntry)keyValuePair;
                    writer.WritePropertyName(entry.Key.ToString());
                    writeStringValue(writer, entry.Value);
                }
                writer.WriteEndObject();
            }
            //handle string valued enums in lists
            else if (value is IEnumerable)
            {
                writer.WriteStartArray();
                foreach (var item in (value as IEnumerable))
                {
                    writeStringValue(writer, item);
                }
                writer.WriteEndArray();
            }
            //handle string valued enums
            else
            {
                writeStringValue(writer, value);
            }
        }

        /// <summary>
        /// Loads and writes the string value against a given enum element
        /// </summary>
        /// <param name="value">The string valued enum element value</param>
        private void writeStringValue(JsonWriter writer, object value)
        {
            System.Type enumHelperType = loadEnumHelperType(value.GetType());
#if WINDOWS_UWP || DNXCORE50 || NETSTANDARD1_3
            MethodInfo enumHelperMethod = enumHelperType.GetRuntimeMethod("ToValue", new[] { value.GetType() });
#else 
            MethodInfo enumHelperMethod = enumHelperType.GetMethod("ToValue", new[] { value.GetType() });
#endif
            object stringValue = enumHelperMethod.Invoke(null, new object[] { value });
            if (stringValue != null)
                writer.WriteValue(stringValue);
            else
                writer.WriteNull();
        }

        /// <summary>
        /// Load the enum helper class against a given enum type
        /// </summary>
        /// <param name="enumType">The enum type to locate the helper</param>
        /// <returns>System.Type of the helper class for the given enum type</returns>
        private static System.Type loadEnumHelperType(System.Type enumType)
        {

#if WINDOWS_UWP || DNXCORE50 || NETSTANDARD1_3
            bool isNullableGeneric = enumType.GetTypeInfo().IsGenericType && enumType.GetGenericTypeDefinition() == typeof(Nullable<>);
            Assembly assembly = isNullableGeneric ? Nullable.GetUnderlyingType(enumType).GetTypeInfo().Assembly : enumType.GetTypeInfo().Assembly;

#else
            bool isNullableGeneric = enumType.IsGenericType && enumType.GetGenericTypeDefinition() == typeof(Nullable<>);
            Assembly assembly = isNullableGeneric ? Nullable.GetUnderlyingType(enumType).Assembly : enumType.Assembly;
#endif
            string enumHelperClassName = string.Format("{0}Helper", isNullableGeneric ? Nullable.GetUnderlyingType(enumType).FullName : enumType.FullName);
            System.Type enumHelperType = assembly.GetType(enumHelperClassName);

            if (enumHelperType == null)
                throw new InvalidCastException("Unable to load enum helper for casting value");

            return enumHelperType;
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The json reader</param>
        /// <param name="objectType">Type of the object to be read</param>
        /// <param name="existingValue">The existing value of object being read</param>
        /// <param name="serializer">The calling serializer</param>
        /// <returns>The object value as enum element</returns>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            try
            {
                if (reader.TokenType == JsonToken.String)
                {
                    string enumStringValue = reader.Value.ToString();
                    System.Type enumHelperType = loadEnumHelperType(objectType);
#if NETSTANDARD1_3
                    MethodInfo enumHelperMethod = enumHelperType.GetRuntimeMethod("ParseString", new[] { typeof(System.String) });
#else
                    MethodInfo enumHelperMethod = enumHelperType.GetMethod("ParseString", new[] { typeof(string) });
#endif
                    object parsed = enumHelperMethod.Invoke(null, new object[] { enumStringValue });
                    return parsed;
                }
            }
            catch
            {
                throw new InvalidCastException(string.Format("Unable to cast value {0} to enum type {1}", reader.Value, objectType.Name));
            }

            throw new InvalidCastException(string.Format("Unexpected token {0} when parsing enum.", reader.TokenType));
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(System.Type objectType)
        {
            System.Type toCheck = objectType;
#if WINDOWS_UWP || DNXCORE50 || NETSTANDARD1_3
            System.Type[] genericArgs = objectType.GenericTypeArguments;
#else
            System.Type[] genericArgs = objectType.GetGenericArguments();
#endif
            if ((genericArgs != null) && (genericArgs.Length > 0))
                toCheck = genericArgs[genericArgs.Length - 1];
#if WINDOWS_UWP || DNXCORE50 || NETSTANDARD1_3
            var attributes = toCheck.GetTypeInfo().GetCustomAttributes(typeof(JsonConverterAttribute), false);
#else
            var attributes = toCheck.GetCustomAttributes(typeof(JsonConverterAttribute), false);
#endif
            if ((attributes == null))
                return false;

            foreach (var converterAttrib in attributes)
            {
                if (attributes == null)
                    continue;

                foreach (var attribute in attributes)
                {
                    var converterrType = (attribute as JsonConverterAttribute).ConverterType;
                    if (converterrType.FullName.Equals(this.GetType().FullName))
                        return true;
                }
            }

            return false;
        }
    }
}