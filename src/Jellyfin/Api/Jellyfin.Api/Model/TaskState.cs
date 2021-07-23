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
    /// Enum TaskState.
    /// </summary>
    /// <value>Enum TaskState.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaskState
    {
        /// <summary>
        /// Enum Idle for value: Idle
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle = 1,

        /// <summary>
        /// Enum Cancelling for value: Cancelling
        /// </summary>
        [EnumMember(Value = "Cancelling")]
        Cancelling = 2,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 3

    }

}
