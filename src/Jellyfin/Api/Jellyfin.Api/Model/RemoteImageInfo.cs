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
    /// Class RemoteImageInfo.
    /// </summary>
    [DataContract]
    public partial class RemoteImageInfo :  IEquatable<RemoteImageInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>Gets or sets the type.</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public ImageType? Type { get; set; }
        /// <summary>
        /// Gets or sets the type of the rating.
        /// </summary>
        /// <value>Gets or sets the type of the rating.</value>
        [DataMember(Name="RatingType", EmitDefaultValue=false)]
        public RatingType? RatingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteImageInfo" /> class.
        /// </summary>
        /// <param name="providerName">Gets or sets the name of the provider..</param>
        /// <param name="url">Gets or sets the URL..</param>
        /// <param name="thumbnailUrl">Gets a url used for previewing a smaller version..</param>
        /// <param name="height">Gets or sets the height..</param>
        /// <param name="width">Gets or sets the width..</param>
        /// <param name="communityRating">Gets or sets the community rating..</param>
        /// <param name="voteCount">Gets or sets the vote count..</param>
        /// <param name="language">Gets or sets the language..</param>
        /// <param name="type">Gets or sets the type..</param>
        /// <param name="ratingType">Gets or sets the type of the rating..</param>
        public RemoteImageInfo(string providerName = default(string), string url = default(string), string thumbnailUrl = default(string), int? height = default(int?), int? width = default(int?), double? communityRating = default(double?), int? voteCount = default(int?), string language = default(string), ImageType? type = default(ImageType?), RatingType? ratingType = default(RatingType?))
        {
            this.ProviderName = providerName;
            this.Url = url;
            this.ThumbnailUrl = thumbnailUrl;
            this.Height = height;
            this.Width = width;
            this.CommunityRating = communityRating;
            this.VoteCount = voteCount;
            this.Language = language;
            this.ProviderName = providerName;
            this.Url = url;
            this.ThumbnailUrl = thumbnailUrl;
            this.Height = height;
            this.Width = width;
            this.CommunityRating = communityRating;
            this.VoteCount = voteCount;
            this.Language = language;
            this.Type = type;
            this.RatingType = ratingType;
        }

        /// <summary>
        /// Gets or sets the name of the provider.
        /// </summary>
        /// <value>Gets or sets the name of the provider.</value>
        [DataMember(Name="ProviderName", EmitDefaultValue=true)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>Gets or sets the URL.</value>
        [DataMember(Name="Url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets a url used for previewing a smaller version.
        /// </summary>
        /// <value>Gets a url used for previewing a smaller version.</value>
        [DataMember(Name="ThumbnailUrl", EmitDefaultValue=true)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>Gets or sets the height.</value>
        [DataMember(Name="Height", EmitDefaultValue=true)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>Gets or sets the width.</value>
        [DataMember(Name="Width", EmitDefaultValue=true)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the community rating.
        /// </summary>
        /// <value>Gets or sets the community rating.</value>
        [DataMember(Name="CommunityRating", EmitDefaultValue=true)]
        public double? CommunityRating { get; set; }

        /// <summary>
        /// Gets or sets the vote count.
        /// </summary>
        /// <value>Gets or sets the vote count.</value>
        [DataMember(Name="VoteCount", EmitDefaultValue=true)]
        public int? VoteCount { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>Gets or sets the language.</value>
        [DataMember(Name="Language", EmitDefaultValue=true)]
        public string Language { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteImageInfo {\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  CommunityRating: ").Append(CommunityRating).Append("\n");
            sb.Append("  VoteCount: ").Append(VoteCount).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RatingType: ").Append(RatingType).Append("\n");
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
            return this.Equals(input as RemoteImageInfo);
        }

        /// <summary>
        /// Returns true if RemoteImageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteImageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteImageInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ThumbnailUrl == input.ThumbnailUrl ||
                    (this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(input.ThumbnailUrl))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.CommunityRating == input.CommunityRating ||
                    (this.CommunityRating != null &&
                    this.CommunityRating.Equals(input.CommunityRating))
                ) && 
                (
                    this.VoteCount == input.VoteCount ||
                    (this.VoteCount != null &&
                    this.VoteCount.Equals(input.VoteCount))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.RatingType == input.RatingType ||
                    (this.RatingType != null &&
                    this.RatingType.Equals(input.RatingType))
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
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.CommunityRating != null)
                    hashCode = hashCode * 59 + this.CommunityRating.GetHashCode();
                if (this.VoteCount != null)
                    hashCode = hashCode * 59 + this.VoteCount.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.RatingType != null)
                    hashCode = hashCode * 59 + this.RatingType.GetHashCode();
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
