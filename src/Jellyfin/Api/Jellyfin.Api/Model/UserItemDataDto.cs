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
    /// Class UserItemDataDto.
    /// </summary>
    [DataContract]
    public partial class UserItemDataDto :  IEquatable<UserItemDataDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserItemDataDto" /> class.
        /// </summary>
        /// <param name="rating">Gets or sets the rating..</param>
        /// <param name="playedPercentage">Gets or sets the played percentage..</param>
        /// <param name="unplayedItemCount">Gets or sets the unplayed item count..</param>
        /// <param name="playbackPositionTicks">Gets or sets the playback position ticks..</param>
        /// <param name="playCount">Gets or sets the play count..</param>
        /// <param name="isFavorite">Gets or sets a value indicating whether this instance is favorite..</param>
        /// <param name="likes">Gets or sets a value indicating whether this MediaBrowser.Model.Dto.UserItemDataDto is likes..</param>
        /// <param name="lastPlayedDate">Gets or sets the last played date..</param>
        /// <param name="played">Gets or sets a value indicating whether this MediaBrowser.Model.Dto.UserItemDataDto is played..</param>
        /// <param name="key">Gets or sets the key..</param>
        /// <param name="itemId">Gets or sets the item identifier..</param>
        public UserItemDataDto(double? rating = default(double?), double? playedPercentage = default(double?), int? unplayedItemCount = default(int?), long playbackPositionTicks = default(long), int playCount = default(int), bool isFavorite = default(bool), bool? likes = default(bool?), DateTime? lastPlayedDate = default(DateTime?), bool played = default(bool), string key = default(string), string itemId = default(string))
        {
            this.Rating = rating;
            this.PlayedPercentage = playedPercentage;
            this.UnplayedItemCount = unplayedItemCount;
            this.Likes = likes;
            this.LastPlayedDate = lastPlayedDate;
            this.Key = key;
            this.ItemId = itemId;
            this.Rating = rating;
            this.PlayedPercentage = playedPercentage;
            this.UnplayedItemCount = unplayedItemCount;
            this.PlaybackPositionTicks = playbackPositionTicks;
            this.PlayCount = playCount;
            this.IsFavorite = isFavorite;
            this.Likes = likes;
            this.LastPlayedDate = lastPlayedDate;
            this.Played = played;
            this.Key = key;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>Gets or sets the rating.</value>
        [DataMember(Name="Rating", EmitDefaultValue=true)]
        public double? Rating { get; set; }

        /// <summary>
        /// Gets or sets the played percentage.
        /// </summary>
        /// <value>Gets or sets the played percentage.</value>
        [DataMember(Name="PlayedPercentage", EmitDefaultValue=true)]
        public double? PlayedPercentage { get; set; }

        /// <summary>
        /// Gets or sets the unplayed item count.
        /// </summary>
        /// <value>Gets or sets the unplayed item count.</value>
        [DataMember(Name="UnplayedItemCount", EmitDefaultValue=true)]
        public int? UnplayedItemCount { get; set; }

        /// <summary>
        /// Gets or sets the playback position ticks.
        /// </summary>
        /// <value>Gets or sets the playback position ticks.</value>
        [DataMember(Name="PlaybackPositionTicks", EmitDefaultValue=false)]
        public long PlaybackPositionTicks { get; set; }

        /// <summary>
        /// Gets or sets the play count.
        /// </summary>
        /// <value>Gets or sets the play count.</value>
        [DataMember(Name="PlayCount", EmitDefaultValue=false)]
        public int PlayCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is favorite.
        /// </summary>
        /// <value>Gets or sets a value indicating whether this instance is favorite.</value>
        [DataMember(Name="IsFavorite", EmitDefaultValue=false)]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this MediaBrowser.Model.Dto.UserItemDataDto is likes.
        /// </summary>
        /// <value>Gets or sets a value indicating whether this MediaBrowser.Model.Dto.UserItemDataDto is likes.</value>
        [DataMember(Name="Likes", EmitDefaultValue=true)]
        public bool? Likes { get; set; }

        /// <summary>
        /// Gets or sets the last played date.
        /// </summary>
        /// <value>Gets or sets the last played date.</value>
        [DataMember(Name="LastPlayedDate", EmitDefaultValue=true)]
        public DateTime? LastPlayedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this MediaBrowser.Model.Dto.UserItemDataDto is played.
        /// </summary>
        /// <value>Gets or sets a value indicating whether this MediaBrowser.Model.Dto.UserItemDataDto is played.</value>
        [DataMember(Name="Played", EmitDefaultValue=false)]
        public bool Played { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>Gets or sets the key.</value>
        [DataMember(Name="Key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>Gets or sets the item identifier.</value>
        [DataMember(Name="ItemId", EmitDefaultValue=true)]
        public string ItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserItemDataDto {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  PlayedPercentage: ").Append(PlayedPercentage).Append("\n");
            sb.Append("  UnplayedItemCount: ").Append(UnplayedItemCount).Append("\n");
            sb.Append("  PlaybackPositionTicks: ").Append(PlaybackPositionTicks).Append("\n");
            sb.Append("  PlayCount: ").Append(PlayCount).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  Likes: ").Append(Likes).Append("\n");
            sb.Append("  LastPlayedDate: ").Append(LastPlayedDate).Append("\n");
            sb.Append("  Played: ").Append(Played).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
            return this.Equals(input as UserItemDataDto);
        }

        /// <summary>
        /// Returns true if UserItemDataDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserItemDataDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserItemDataDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.PlayedPercentage == input.PlayedPercentage ||
                    (this.PlayedPercentage != null &&
                    this.PlayedPercentage.Equals(input.PlayedPercentage))
                ) && 
                (
                    this.UnplayedItemCount == input.UnplayedItemCount ||
                    (this.UnplayedItemCount != null &&
                    this.UnplayedItemCount.Equals(input.UnplayedItemCount))
                ) && 
                (
                    this.PlaybackPositionTicks == input.PlaybackPositionTicks ||
                    (this.PlaybackPositionTicks != null &&
                    this.PlaybackPositionTicks.Equals(input.PlaybackPositionTicks))
                ) && 
                (
                    this.PlayCount == input.PlayCount ||
                    (this.PlayCount != null &&
                    this.PlayCount.Equals(input.PlayCount))
                ) && 
                (
                    this.IsFavorite == input.IsFavorite ||
                    (this.IsFavorite != null &&
                    this.IsFavorite.Equals(input.IsFavorite))
                ) && 
                (
                    this.Likes == input.Likes ||
                    (this.Likes != null &&
                    this.Likes.Equals(input.Likes))
                ) && 
                (
                    this.LastPlayedDate == input.LastPlayedDate ||
                    (this.LastPlayedDate != null &&
                    this.LastPlayedDate.Equals(input.LastPlayedDate))
                ) && 
                (
                    this.Played == input.Played ||
                    (this.Played != null &&
                    this.Played.Equals(input.Played))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
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
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.PlayedPercentage != null)
                    hashCode = hashCode * 59 + this.PlayedPercentage.GetHashCode();
                if (this.UnplayedItemCount != null)
                    hashCode = hashCode * 59 + this.UnplayedItemCount.GetHashCode();
                if (this.PlaybackPositionTicks != null)
                    hashCode = hashCode * 59 + this.PlaybackPositionTicks.GetHashCode();
                if (this.PlayCount != null)
                    hashCode = hashCode * 59 + this.PlayCount.GetHashCode();
                if (this.IsFavorite != null)
                    hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.Likes != null)
                    hashCode = hashCode * 59 + this.Likes.GetHashCode();
                if (this.LastPlayedDate != null)
                    hashCode = hashCode * 59 + this.LastPlayedDate.GetHashCode();
                if (this.Played != null)
                    hashCode = hashCode * 59 + this.Played.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
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