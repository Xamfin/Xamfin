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
    /// Quick connect state.
    /// </summary>
    /// <value>Quick connect state.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum QuickConnectState
    {
        /// <summary>
        /// Enum Unavailable for value: Unavailable
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable = 1,

        /// <summary>
        /// Enum Available for value: Available
        /// </summary>
        [EnumMember(Value = "Available")]
        Available = 2,

        /// <summary>
        /// Enum Active for value: Active
        /// </summary>
        [EnumMember(Value = "Active")]
        Active = 3

    }

}
