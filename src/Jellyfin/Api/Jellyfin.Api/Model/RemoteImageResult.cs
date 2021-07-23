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
    /// Class RemoteImageResult.
    /// </summary>
    [DataContract]
    public partial class RemoteImageResult :  IEquatable<RemoteImageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteImageResult" /> class.
        /// </summary>
        /// <param name="images">Gets or sets the images..</param>
        /// <param name="totalRecordCount">Gets or sets the total record count..</param>
        /// <param name="providers">Gets or sets the providers..</param>
        public RemoteImageResult(List<RemoteImageInfo> images = default(List<RemoteImageInfo>), int totalRecordCount = default(int), List<string> providers = default(List<string>))
        {
            this.Images = images;
            this.Providers = providers;
            this.Images = images;
            this.TotalRecordCount = totalRecordCount;
            this.Providers = providers;
        }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>Gets or sets the images.</value>
        [DataMember(Name="Images", EmitDefaultValue=true)]
        public List<RemoteImageInfo> Images { get; set; }

        /// <summary>
        /// Gets or sets the total record count.
        /// </summary>
        /// <value>Gets or sets the total record count.</value>
        [DataMember(Name="TotalRecordCount", EmitDefaultValue=false)]
        public int TotalRecordCount { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        /// <value>Gets or sets the providers.</value>
        [DataMember(Name="Providers", EmitDefaultValue=true)]
        public List<string> Providers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteImageResult {\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  TotalRecordCount: ").Append(TotalRecordCount).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
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
            return this.Equals(input as RemoteImageResult);
        }

        /// <summary>
        /// Returns true if RemoteImageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteImageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteImageResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.TotalRecordCount == input.TotalRecordCount ||
                    (this.TotalRecordCount != null &&
                    this.TotalRecordCount.Equals(input.TotalRecordCount))
                ) && 
                (
                    this.Providers == input.Providers ||
                    this.Providers != null &&
                    input.Providers != null &&
                    this.Providers.SequenceEqual(input.Providers)
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
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.TotalRecordCount != null)
                    hashCode = hashCode * 59 + this.TotalRecordCount.GetHashCode();
                if (this.Providers != null)
                    hashCode = hashCode * 59 + this.Providers.GetHashCode();
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