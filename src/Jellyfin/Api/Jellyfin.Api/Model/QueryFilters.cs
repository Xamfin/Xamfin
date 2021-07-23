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
    /// QueryFilters
    /// </summary>
    [DataContract]
    public partial class QueryFilters :  IEquatable<QueryFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFilters" /> class.
        /// </summary>
        /// <param name="genres">genres.</param>
        /// <param name="tags">tags.</param>
        public QueryFilters(List<NameGuidPair> genres = default(List<NameGuidPair>), List<string> tags = default(List<string>))
        {
            this.Genres = genres;
            this.Tags = tags;
            this.Genres = genres;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Genres
        /// </summary>
        [DataMember(Name="Genres", EmitDefaultValue=true)]
        public List<NameGuidPair> Genres { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="Tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryFilters {\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as QueryFilters);
        }

        /// <summary>
        /// Returns true if QueryFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryFilters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Genres == input.Genres ||
                    this.Genres != null &&
                    input.Genres != null &&
                    this.Genres.SequenceEqual(input.Genres)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Genres != null)
                    hashCode = hashCode * 59 + this.Genres.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
