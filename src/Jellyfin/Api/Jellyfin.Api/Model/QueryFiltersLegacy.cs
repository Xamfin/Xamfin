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
    /// QueryFiltersLegacy
    /// </summary>
    [DataContract]
    public partial class QueryFiltersLegacy :  IEquatable<QueryFiltersLegacy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFiltersLegacy" /> class.
        /// </summary>
        /// <param name="genres">genres.</param>
        /// <param name="tags">tags.</param>
        /// <param name="officialRatings">officialRatings.</param>
        /// <param name="years">years.</param>
        public QueryFiltersLegacy(List<string> genres = default(List<string>), List<string> tags = default(List<string>), List<string> officialRatings = default(List<string>), List<int> years = default(List<int>))
        {
            this.Genres = genres;
            this.Tags = tags;
            this.OfficialRatings = officialRatings;
            this.Years = years;
            this.Genres = genres;
            this.Tags = tags;
            this.OfficialRatings = officialRatings;
            this.Years = years;
        }

        /// <summary>
        /// Gets or Sets Genres
        /// </summary>
        [DataMember(Name="Genres", EmitDefaultValue=true)]
        public List<string> Genres { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="Tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets OfficialRatings
        /// </summary>
        [DataMember(Name="OfficialRatings", EmitDefaultValue=true)]
        public List<string> OfficialRatings { get; set; }

        /// <summary>
        /// Gets or Sets Years
        /// </summary>
        [DataMember(Name="Years", EmitDefaultValue=true)]
        public List<int> Years { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryFiltersLegacy {\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  OfficialRatings: ").Append(OfficialRatings).Append("\n");
            sb.Append("  Years: ").Append(Years).Append("\n");
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
            return this.Equals(input as QueryFiltersLegacy);
        }

        /// <summary>
        /// Returns true if QueryFiltersLegacy instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryFiltersLegacy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryFiltersLegacy input)
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
                ) && 
                (
                    this.OfficialRatings == input.OfficialRatings ||
                    this.OfficialRatings != null &&
                    input.OfficialRatings != null &&
                    this.OfficialRatings.SequenceEqual(input.OfficialRatings)
                ) && 
                (
                    this.Years == input.Years ||
                    this.Years != null &&
                    input.Years != null &&
                    this.Years.SequenceEqual(input.Years)
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
                if (this.OfficialRatings != null)
                    hashCode = hashCode * 59 + this.OfficialRatings.GetHashCode();
                if (this.Years != null)
                    hashCode = hashCode * 59 + this.Years.GetHashCode();
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