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
    /// BookInfoRemoteSearchQuery
    /// </summary>
    [DataContract]
    public partial class BookInfoRemoteSearchQuery :  IEquatable<BookInfoRemoteSearchQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookInfoRemoteSearchQuery" /> class.
        /// </summary>
        /// <param name="searchInfo">searchInfo.</param>
        /// <param name="itemId">itemId.</param>
        /// <param name="searchProviderName">Will only search within the given provider when set..</param>
        /// <param name="includeDisabledProviders">Gets or sets a value indicating whether disabled providers should be included..</param>
        public BookInfoRemoteSearchQuery(BookInfo searchInfo = default(BookInfo), Guid itemId = default(Guid), string searchProviderName = default(string), bool includeDisabledProviders = default(bool))
        {
            this.SearchInfo = searchInfo;
            this.SearchProviderName = searchProviderName;
            this.SearchInfo = searchInfo;
            this.ItemId = itemId;
            this.SearchProviderName = searchProviderName;
            this.IncludeDisabledProviders = includeDisabledProviders;
        }

        /// <summary>
        /// Gets or Sets SearchInfo
        /// </summary>
        [DataMember(Name="SearchInfo", EmitDefaultValue=true)]
        public BookInfo SearchInfo { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="ItemId", EmitDefaultValue=false)]
        public Guid ItemId { get; set; }

        /// <summary>
        /// Will only search within the given provider when set.
        /// </summary>
        /// <value>Will only search within the given provider when set.</value>
        [DataMember(Name="SearchProviderName", EmitDefaultValue=true)]
        public string SearchProviderName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether disabled providers should be included.
        /// </summary>
        /// <value>Gets or sets a value indicating whether disabled providers should be included.</value>
        [DataMember(Name="IncludeDisabledProviders", EmitDefaultValue=false)]
        public bool IncludeDisabledProviders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookInfoRemoteSearchQuery {\n");
            sb.Append("  SearchInfo: ").Append(SearchInfo).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  SearchProviderName: ").Append(SearchProviderName).Append("\n");
            sb.Append("  IncludeDisabledProviders: ").Append(IncludeDisabledProviders).Append("\n");
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
            return this.Equals(input as BookInfoRemoteSearchQuery);
        }

        /// <summary>
        /// Returns true if BookInfoRemoteSearchQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of BookInfoRemoteSearchQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookInfoRemoteSearchQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchInfo == input.SearchInfo ||
                    (this.SearchInfo != null &&
                    this.SearchInfo.Equals(input.SearchInfo))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.SearchProviderName == input.SearchProviderName ||
                    (this.SearchProviderName != null &&
                    this.SearchProviderName.Equals(input.SearchProviderName))
                ) && 
                (
                    this.IncludeDisabledProviders == input.IncludeDisabledProviders ||
                    (this.IncludeDisabledProviders != null &&
                    this.IncludeDisabledProviders.Equals(input.IncludeDisabledProviders))
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
                if (this.SearchInfo != null)
                    hashCode = hashCode * 59 + this.SearchInfo.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.SearchProviderName != null)
                    hashCode = hashCode * 59 + this.SearchProviderName.GetHashCode();
                if (this.IncludeDisabledProviders != null)
                    hashCode = hashCode * 59 + this.IncludeDisabledProviders.GetHashCode();
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
