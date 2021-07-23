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
    /// Class CountryInfo.
    /// </summary>
    [DataContract]
    public partial class CountryInfo :  IEquatable<CountryInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryInfo" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="displayName">Gets or sets the display name..</param>
        /// <param name="twoLetterISORegionName">Gets or sets the name of the two letter ISO region..</param>
        /// <param name="threeLetterISORegionName">Gets or sets the name of the three letter ISO region..</param>
        public CountryInfo(string name = default(string), string displayName = default(string), string twoLetterISORegionName = default(string), string threeLetterISORegionName = default(string))
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.TwoLetterISORegionName = twoLetterISORegionName;
            this.ThreeLetterISORegionName = threeLetterISORegionName;
            this.Name = name;
            this.DisplayName = displayName;
            this.TwoLetterISORegionName = twoLetterISORegionName;
            this.ThreeLetterISORegionName = threeLetterISORegionName;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>Gets or sets the display name.</value>
        [DataMember(Name="DisplayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name of the two letter ISO region.
        /// </summary>
        /// <value>Gets or sets the name of the two letter ISO region.</value>
        [DataMember(Name="TwoLetterISORegionName", EmitDefaultValue=true)]
        public string TwoLetterISORegionName { get; set; }

        /// <summary>
        /// Gets or sets the name of the three letter ISO region.
        /// </summary>
        /// <value>Gets or sets the name of the three letter ISO region.</value>
        [DataMember(Name="ThreeLetterISORegionName", EmitDefaultValue=true)]
        public string ThreeLetterISORegionName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountryInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  TwoLetterISORegionName: ").Append(TwoLetterISORegionName).Append("\n");
            sb.Append("  ThreeLetterISORegionName: ").Append(ThreeLetterISORegionName).Append("\n");
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
            return this.Equals(input as CountryInfo);
        }

        /// <summary>
        /// Returns true if CountryInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CountryInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountryInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.TwoLetterISORegionName == input.TwoLetterISORegionName ||
                    (this.TwoLetterISORegionName != null &&
                    this.TwoLetterISORegionName.Equals(input.TwoLetterISORegionName))
                ) && 
                (
                    this.ThreeLetterISORegionName == input.ThreeLetterISORegionName ||
                    (this.ThreeLetterISORegionName != null &&
                    this.ThreeLetterISORegionName.Equals(input.ThreeLetterISORegionName))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.TwoLetterISORegionName != null)
                    hashCode = hashCode * 59 + this.TwoLetterISORegionName.GetHashCode();
                if (this.ThreeLetterISORegionName != null)
                    hashCode = hashCode * 59 + this.ThreeLetterISORegionName.GetHashCode();
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