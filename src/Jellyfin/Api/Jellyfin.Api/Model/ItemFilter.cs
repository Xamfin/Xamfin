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
    /// Enum ItemFilter.
    /// </summary>
    /// <value>Enum ItemFilter.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ItemFilter
    {
        /// <summary>
        /// Enum IsFolder for value: IsFolder
        /// </summary>
        [EnumMember(Value = "IsFolder")]
        IsFolder = 1,

        /// <summary>
        /// Enum IsNotFolder for value: IsNotFolder
        /// </summary>
        [EnumMember(Value = "IsNotFolder")]
        IsNotFolder = 2,

        /// <summary>
        /// Enum IsUnplayed for value: IsUnplayed
        /// </summary>
        [EnumMember(Value = "IsUnplayed")]
        IsUnplayed = 3,

        /// <summary>
        /// Enum IsPlayed for value: IsPlayed
        /// </summary>
        [EnumMember(Value = "IsPlayed")]
        IsPlayed = 4,

        /// <summary>
        /// Enum IsFavorite for value: IsFavorite
        /// </summary>
        [EnumMember(Value = "IsFavorite")]
        IsFavorite = 5,

        /// <summary>
        /// Enum IsResumable for value: IsResumable
        /// </summary>
        [EnumMember(Value = "IsResumable")]
        IsResumable = 6,

        /// <summary>
        /// Enum Likes for value: Likes
        /// </summary>
        [EnumMember(Value = "Likes")]
        Likes = 7,

        /// <summary>
        /// Enum Dislikes for value: Dislikes
        /// </summary>
        [EnumMember(Value = "Dislikes")]
        Dislikes = 8,

        /// <summary>
        /// Enum IsFavoriteOrLikes for value: IsFavoriteOrLikes
        /// </summary>
        [EnumMember(Value = "IsFavoriteOrLikes")]
        IsFavoriteOrLikes = 9

    }

}