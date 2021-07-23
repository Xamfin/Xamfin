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
    /// Enum MetadataFields.
    /// </summary>
    /// <value>Enum MetadataFields.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MetadataField
    {
        /// <summary>
        /// Enum Cast for value: Cast
        /// </summary>
        [EnumMember(Value = "Cast")]
        Cast = 1,

        /// <summary>
        /// Enum Genres for value: Genres
        /// </summary>
        [EnumMember(Value = "Genres")]
        Genres = 2,

        /// <summary>
        /// Enum ProductionLocations for value: ProductionLocations
        /// </summary>
        [EnumMember(Value = "ProductionLocations")]
        ProductionLocations = 3,

        /// <summary>
        /// Enum Studios for value: Studios
        /// </summary>
        [EnumMember(Value = "Studios")]
        Studios = 4,

        /// <summary>
        /// Enum Tags for value: Tags
        /// </summary>
        [EnumMember(Value = "Tags")]
        Tags = 5,

        /// <summary>
        /// Enum Name for value: Name
        /// </summary>
        [EnumMember(Value = "Name")]
        Name = 6,

        /// <summary>
        /// Enum Overview for value: Overview
        /// </summary>
        [EnumMember(Value = "Overview")]
        Overview = 7,

        /// <summary>
        /// Enum Runtime for value: Runtime
        /// </summary>
        [EnumMember(Value = "Runtime")]
        Runtime = 8,

        /// <summary>
        /// Enum OfficialRating for value: OfficialRating
        /// </summary>
        [EnumMember(Value = "OfficialRating")]
        OfficialRating = 9

    }

}
