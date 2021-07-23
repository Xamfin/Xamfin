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
    /// Enum ImageOutputFormat.
    /// </summary>
    /// <value>Enum ImageOutputFormat.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ImageFormat
    {
        /// <summary>
        /// Enum Bmp for value: Bmp
        /// </summary>
        [EnumMember(Value = "Bmp")]
        Bmp = 1,

        /// <summary>
        /// Enum Gif for value: Gif
        /// </summary>
        [EnumMember(Value = "Gif")]
        Gif = 2,

        /// <summary>
        /// Enum Jpg for value: Jpg
        /// </summary>
        [EnumMember(Value = "Jpg")]
        Jpg = 3,

        /// <summary>
        /// Enum Png for value: Png
        /// </summary>
        [EnumMember(Value = "Png")]
        Png = 4,

        /// <summary>
        /// Enum Webp for value: Webp
        /// </summary>
        [EnumMember(Value = "Webp")]
        Webp = 5

    }

}