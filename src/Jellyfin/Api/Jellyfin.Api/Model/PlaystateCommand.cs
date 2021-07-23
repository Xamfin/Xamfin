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
    /// Enum PlaystateCommand.
    /// </summary>
    /// <value>Enum PlaystateCommand.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PlaystateCommand
    {
        /// <summary>
        /// Enum Stop for value: Stop
        /// </summary>
        [EnumMember(Value = "Stop")]
        Stop = 1,

        /// <summary>
        /// Enum Pause for value: Pause
        /// </summary>
        [EnumMember(Value = "Pause")]
        Pause = 2,

        /// <summary>
        /// Enum Unpause for value: Unpause
        /// </summary>
        [EnumMember(Value = "Unpause")]
        Unpause = 3,

        /// <summary>
        /// Enum NextTrack for value: NextTrack
        /// </summary>
        [EnumMember(Value = "NextTrack")]
        NextTrack = 4,

        /// <summary>
        /// Enum PreviousTrack for value: PreviousTrack
        /// </summary>
        [EnumMember(Value = "PreviousTrack")]
        PreviousTrack = 5,

        /// <summary>
        /// Enum Seek for value: Seek
        /// </summary>
        [EnumMember(Value = "Seek")]
        Seek = 6,

        /// <summary>
        /// Enum Rewind for value: Rewind
        /// </summary>
        [EnumMember(Value = "Rewind")]
        Rewind = 7,

        /// <summary>
        /// Enum FastForward for value: FastForward
        /// </summary>
        [EnumMember(Value = "FastForward")]
        FastForward = 8,

        /// <summary>
        /// Enum PlayPause for value: PlayPause
        /// </summary>
        [EnumMember(Value = "PlayPause")]
        PlayPause = 9

    }

}
