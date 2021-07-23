/*
 * Jellyfin API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 10.7.6
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Jellyfin.Api.Client.OpenAPIDateConverter;

namespace Jellyfin.Api.Model
{
    /// <summary>
    /// Defines MediaSourceType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MediaSourceType
    {
        /// <summary>
        /// Enum Default for value: Default
        /// </summary>
        [EnumMember(Value = "Default")]
        Default = 1,

        /// <summary>
        /// Enum Grouping for value: Grouping
        /// </summary>
        [EnumMember(Value = "Grouping")]
        Grouping = 2,

        /// <summary>
        /// Enum Placeholder for value: Placeholder
        /// </summary>
        [EnumMember(Value = "Placeholder")]
        Placeholder = 3

    }

}
