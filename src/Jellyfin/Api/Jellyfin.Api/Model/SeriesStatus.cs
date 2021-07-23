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
    /// Enum SeriesStatus.
    /// </summary>
    /// <value>Enum SeriesStatus.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SeriesStatus
    {
        /// <summary>
        /// Enum Continuing for value: Continuing
        /// </summary>
        [EnumMember(Value = "Continuing")]
        Continuing = 1,

        /// <summary>
        /// Enum Ended for value: Ended
        /// </summary>
        [EnumMember(Value = "Ended")]
        Ended = 2

    }

}