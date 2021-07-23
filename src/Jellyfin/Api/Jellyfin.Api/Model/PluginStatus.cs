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
    /// Plugin load status.
    /// </summary>
    /// <value>Plugin load status.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PluginStatus
    {
        /// <summary>
        /// Enum Active for value: Active
        /// </summary>
        [EnumMember(Value = "Active")]
        Active = 1,

        /// <summary>
        /// Enum Restart for value: Restart
        /// </summary>
        [EnumMember(Value = "Restart")]
        Restart = 2,

        /// <summary>
        /// Enum Deleted for value: Deleted
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted = 3,

        /// <summary>
        /// Enum Superceded for value: Superceded
        /// </summary>
        [EnumMember(Value = "Superceded")]
        Superceded = 4,

        /// <summary>
        /// Enum Malfunctioned for value: Malfunctioned
        /// </summary>
        [EnumMember(Value = "Malfunctioned")]
        Malfunctioned = 5,

        /// <summary>
        /// Enum NotSupported for value: NotSupported
        /// </summary>
        [EnumMember(Value = "NotSupported")]
        NotSupported = 6,

        /// <summary>
        /// Enum Disabled for value: Disabled
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled = 7

    }

}
