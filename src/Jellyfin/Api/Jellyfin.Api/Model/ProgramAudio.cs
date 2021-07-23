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
    /// Defines ProgramAudio
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ProgramAudio
    {
        /// <summary>
        /// Enum Mono for value: Mono
        /// </summary>
        [EnumMember(Value = "Mono")]
        Mono = 1,

        /// <summary>
        /// Enum Stereo for value: Stereo
        /// </summary>
        [EnumMember(Value = "Stereo")]
        Stereo = 2,

        /// <summary>
        /// Enum Dolby for value: Dolby
        /// </summary>
        [EnumMember(Value = "Dolby")]
        Dolby = 3,

        /// <summary>
        /// Enum DolbyDigital for value: DolbyDigital
        /// </summary>
        [EnumMember(Value = "DolbyDigital")]
        DolbyDigital = 4,

        /// <summary>
        /// Enum Thx for value: Thx
        /// </summary>
        [EnumMember(Value = "Thx")]
        Thx = 5,

        /// <summary>
        /// Enum Atmos for value: Atmos
        /// </summary>
        [EnumMember(Value = "Atmos")]
        Atmos = 6

    }

}
