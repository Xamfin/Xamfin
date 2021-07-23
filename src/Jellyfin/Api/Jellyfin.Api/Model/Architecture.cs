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
    /// Defines Architecture
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Architecture
    {
        /// <summary>
        /// Enum X86 for value: X86
        /// </summary>
        [EnumMember(Value = "X86")]
        X86 = 1,

        /// <summary>
        /// Enum X64 for value: X64
        /// </summary>
        [EnumMember(Value = "X64")]
        X64 = 2,

        /// <summary>
        /// Enum Arm for value: Arm
        /// </summary>
        [EnumMember(Value = "Arm")]
        Arm = 3,

        /// <summary>
        /// Enum Arm64 for value: Arm64
        /// </summary>
        [EnumMember(Value = "Arm64")]
        Arm64 = 4,

        /// <summary>
        /// Enum Wasm for value: Wasm
        /// </summary>
        [EnumMember(Value = "Wasm")]
        Wasm = 5

    }

}
