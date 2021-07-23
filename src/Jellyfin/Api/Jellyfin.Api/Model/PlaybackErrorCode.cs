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
    /// Defines PlaybackErrorCode
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PlaybackErrorCode
    {
        /// <summary>
        /// Enum NotAllowed for value: NotAllowed
        /// </summary>
        [EnumMember(Value = "NotAllowed")]
        NotAllowed = 1,

        /// <summary>
        /// Enum NoCompatibleStream for value: NoCompatibleStream
        /// </summary>
        [EnumMember(Value = "NoCompatibleStream")]
        NoCompatibleStream = 2,

        /// <summary>
        /// Enum RateLimitExceeded for value: RateLimitExceeded
        /// </summary>
        [EnumMember(Value = "RateLimitExceeded")]
        RateLimitExceeded = 3

    }

}