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
    /// Class SearchHintResult.
    /// </summary>
    [DataContract]
    public partial class SearchHintResult :  IEquatable<SearchHintResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHintResult" /> class.
        /// </summary>
        /// <param name="searchHints">Gets or sets the search hints..</param>
        /// <param name="totalRecordCount">Gets or sets the total record count..</param>
        public SearchHintResult(List<SearchHint> searchHints = default(List<SearchHint>), int totalRecordCount = default(int))
        {
            this.SearchHints = searchHints;
            this.SearchHints = searchHints;
            this.TotalRecordCount = totalRecordCount;
        }

        /// <summary>
        /// Gets or sets the search hints.
        /// </summary>
        /// <value>Gets or sets the search hints.</value>
        [DataMember(Name="SearchHints", EmitDefaultValue=true)]
        public List<SearchHint> SearchHints { get; set; }

        /// <summary>
        /// Gets or sets the total record count.
        /// </summary>
        /// <value>Gets or sets the total record count.</value>
        [DataMember(Name="TotalRecordCount", EmitDefaultValue=false)]
        public int TotalRecordCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchHintResult {\n");
            sb.Append("  SearchHints: ").Append(SearchHints).Append("\n");
            sb.Append("  TotalRecordCount: ").Append(TotalRecordCount).Append("\n");
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
            return this.Equals(input as SearchHintResult);
        }

        /// <summary>
        /// Returns true if SearchHintResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchHintResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchHintResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchHints == input.SearchHints ||
                    this.SearchHints != null &&
                    input.SearchHints != null &&
                    this.SearchHints.SequenceEqual(input.SearchHints)
                ) && 
                (
                    this.TotalRecordCount == input.TotalRecordCount ||
                    (this.TotalRecordCount != null &&
                    this.TotalRecordCount.Equals(input.TotalRecordCount))
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
                if (this.SearchHints != null)
                    hashCode = hashCode * 59 + this.SearchHints.GetHashCode();
                if (this.TotalRecordCount != null)
                    hashCode = hashCode * 59 + this.TotalRecordCount.GetHashCode();
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
