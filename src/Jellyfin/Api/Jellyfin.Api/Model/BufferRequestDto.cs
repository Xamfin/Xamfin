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
    /// Class BufferRequestDto.
    /// </summary>
    [DataContract]
    public partial class BufferRequestDto :  IEquatable<BufferRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BufferRequestDto" /> class.
        /// </summary>
        /// <param name="when">Gets or sets when the request has been made by the client..</param>
        /// <param name="positionTicks">Gets or sets the position ticks..</param>
        /// <param name="isPlaying">Gets or sets a value indicating whether the client playback is unpaused..</param>
        /// <param name="playlistItemId">Gets or sets the playlist item identifier of the playing item..</param>
        public BufferRequestDto(DateTime when = default(DateTime), long positionTicks = default(long), bool isPlaying = default(bool), Guid playlistItemId = default(Guid))
        {
            this.When = when;
            this.PositionTicks = positionTicks;
            this.IsPlaying = isPlaying;
            this.PlaylistItemId = playlistItemId;
        }

        /// <summary>
        /// Gets or sets when the request has been made by the client.
        /// </summary>
        /// <value>Gets or sets when the request has been made by the client.</value>
        [DataMember(Name="When", EmitDefaultValue=false)]
        public DateTime When { get; set; }

        /// <summary>
        /// Gets or sets the position ticks.
        /// </summary>
        /// <value>Gets or sets the position ticks.</value>
        [DataMember(Name="PositionTicks", EmitDefaultValue=false)]
        public long PositionTicks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the client playback is unpaused.
        /// </summary>
        /// <value>Gets or sets a value indicating whether the client playback is unpaused.</value>
        [DataMember(Name="IsPlaying", EmitDefaultValue=false)]
        public bool IsPlaying { get; set; }

        /// <summary>
        /// Gets or sets the playlist item identifier of the playing item.
        /// </summary>
        /// <value>Gets or sets the playlist item identifier of the playing item.</value>
        [DataMember(Name="PlaylistItemId", EmitDefaultValue=false)]
        public Guid PlaylistItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BufferRequestDto {\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  PositionTicks: ").Append(PositionTicks).Append("\n");
            sb.Append("  IsPlaying: ").Append(IsPlaying).Append("\n");
            sb.Append("  PlaylistItemId: ").Append(PlaylistItemId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BufferRequestDto);
        }

        /// <summary>
        /// Returns true if BufferRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BufferRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BufferRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.When == input.When ||
                    (this.When != null &&
                    this.When.Equals(input.When))
                ) && 
                (
                    this.PositionTicks == input.PositionTicks ||
                    (this.PositionTicks != null &&
                    this.PositionTicks.Equals(input.PositionTicks))
                ) && 
                (
                    this.IsPlaying == input.IsPlaying ||
                    (this.IsPlaying != null &&
                    this.IsPlaying.Equals(input.IsPlaying))
                ) && 
                (
                    this.PlaylistItemId == input.PlaylistItemId ||
                    (this.PlaylistItemId != null &&
                    this.PlaylistItemId.Equals(input.PlaylistItemId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.When != null)
                    hashCode = hashCode * 59 + this.When.GetHashCode();
                if (this.PositionTicks != null)
                    hashCode = hashCode * 59 + this.PositionTicks.GetHashCode();
                if (this.IsPlaying != null)
                    hashCode = hashCode * 59 + this.IsPlaying.GetHashCode();
                if (this.PlaylistItemId != null)
                    hashCode = hashCode * 59 + this.PlaylistItemId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}