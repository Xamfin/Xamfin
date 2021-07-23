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
    /// Enum ChannelType.
    /// </summary>
    /// <value>Enum ChannelType.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ChannelType
    {
        /// <summary>
        /// Enum TV for value: TV
        /// </summary>
        [EnumMember(Value = "TV")]
        TV = 1,

        /// <summary>
        /// Enum Radio for value: Radio
        /// </summary>
        [EnumMember(Value = "Radio")]
        Radio = 2

    }

}
