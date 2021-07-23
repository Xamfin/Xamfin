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
    /// Library options result dto.
    /// </summary>
    [DataContract]
    public partial class LibraryOptionsResultDto :  IEquatable<LibraryOptionsResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryOptionsResultDto" /> class.
        /// </summary>
        /// <param name="metadataSavers">Gets or sets the metadata savers..</param>
        /// <param name="metadataReaders">Gets or sets the metadata readers..</param>
        /// <param name="subtitleFetchers">Gets or sets the subtitle fetchers..</param>
        /// <param name="typeOptions">Gets or sets the type options..</param>
        public LibraryOptionsResultDto(List<LibraryOptionInfoDto> metadataSavers = default(List<LibraryOptionInfoDto>), List<LibraryOptionInfoDto> metadataReaders = default(List<LibraryOptionInfoDto>), List<LibraryOptionInfoDto> subtitleFetchers = default(List<LibraryOptionInfoDto>), List<LibraryTypeOptionsDto> typeOptions = default(List<LibraryTypeOptionsDto>))
        {
            this.MetadataSavers = metadataSavers;
            this.MetadataReaders = metadataReaders;
            this.SubtitleFetchers = subtitleFetchers;
            this.TypeOptions = typeOptions;
            this.MetadataSavers = metadataSavers;
            this.MetadataReaders = metadataReaders;
            this.SubtitleFetchers = subtitleFetchers;
            this.TypeOptions = typeOptions;
        }

        /// <summary>
        /// Gets or sets the metadata savers.
        /// </summary>
        /// <value>Gets or sets the metadata savers.</value>
        [DataMember(Name="MetadataSavers", EmitDefaultValue=true)]
        public List<LibraryOptionInfoDto> MetadataSavers { get; set; }

        /// <summary>
        /// Gets or sets the metadata readers.
        /// </summary>
        /// <value>Gets or sets the metadata readers.</value>
        [DataMember(Name="MetadataReaders", EmitDefaultValue=true)]
        public List<LibraryOptionInfoDto> MetadataReaders { get; set; }

        /// <summary>
        /// Gets or sets the subtitle fetchers.
        /// </summary>
        /// <value>Gets or sets the subtitle fetchers.</value>
        [DataMember(Name="SubtitleFetchers", EmitDefaultValue=true)]
        public List<LibraryOptionInfoDto> SubtitleFetchers { get; set; }

        /// <summary>
        /// Gets or sets the type options.
        /// </summary>
        /// <value>Gets or sets the type options.</value>
        [DataMember(Name="TypeOptions", EmitDefaultValue=true)]
        public List<LibraryTypeOptionsDto> TypeOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LibraryOptionsResultDto {\n");
            sb.Append("  MetadataSavers: ").Append(MetadataSavers).Append("\n");
            sb.Append("  MetadataReaders: ").Append(MetadataReaders).Append("\n");
            sb.Append("  SubtitleFetchers: ").Append(SubtitleFetchers).Append("\n");
            sb.Append("  TypeOptions: ").Append(TypeOptions).Append("\n");
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
            return this.Equals(input as LibraryOptionsResultDto);
        }

        /// <summary>
        /// Returns true if LibraryOptionsResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LibraryOptionsResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LibraryOptionsResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetadataSavers == input.MetadataSavers ||
                    this.MetadataSavers != null &&
                    input.MetadataSavers != null &&
                    this.MetadataSavers.SequenceEqual(input.MetadataSavers)
                ) && 
                (
                    this.MetadataReaders == input.MetadataReaders ||
                    this.MetadataReaders != null &&
                    input.MetadataReaders != null &&
                    this.MetadataReaders.SequenceEqual(input.MetadataReaders)
                ) && 
                (
                    this.SubtitleFetchers == input.SubtitleFetchers ||
                    this.SubtitleFetchers != null &&
                    input.SubtitleFetchers != null &&
                    this.SubtitleFetchers.SequenceEqual(input.SubtitleFetchers)
                ) && 
                (
                    this.TypeOptions == input.TypeOptions ||
                    this.TypeOptions != null &&
                    input.TypeOptions != null &&
                    this.TypeOptions.SequenceEqual(input.TypeOptions)
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
                if (this.MetadataSavers != null)
                    hashCode = hashCode * 59 + this.MetadataSavers.GetHashCode();
                if (this.MetadataReaders != null)
                    hashCode = hashCode * 59 + this.MetadataReaders.GetHashCode();
                if (this.SubtitleFetchers != null)
                    hashCode = hashCode * 59 + this.SubtitleFetchers.GetHashCode();
                if (this.TypeOptions != null)
                    hashCode = hashCode * 59 + this.TypeOptions.GetHashCode();
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