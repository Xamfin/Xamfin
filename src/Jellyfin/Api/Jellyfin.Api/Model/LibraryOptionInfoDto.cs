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
    /// Library option info dto.
    /// </summary>
    [DataContract]
    public partial class LibraryOptionInfoDto :  IEquatable<LibraryOptionInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryOptionInfoDto" /> class.
        /// </summary>
        /// <param name="name">Gets or sets name..</param>
        /// <param name="defaultEnabled">Gets or sets a value indicating whether default enabled..</param>
        public LibraryOptionInfoDto(string name = default(string), bool defaultEnabled = default(bool))
        {
            this.Name = name;
            this.Name = name;
            this.DefaultEnabled = defaultEnabled;
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        /// <value>Gets or sets name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether default enabled.
        /// </summary>
        /// <value>Gets or sets a value indicating whether default enabled.</value>
        [DataMember(Name="DefaultEnabled", EmitDefaultValue=false)]
        public bool DefaultEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LibraryOptionInfoDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultEnabled: ").Append(DefaultEnabled).Append("\n");
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
            return this.Equals(input as LibraryOptionInfoDto);
        }

        /// <summary>
        /// Returns true if LibraryOptionInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LibraryOptionInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LibraryOptionInfoDto input)
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
                    this.DefaultEnabled == input.DefaultEnabled ||
                    (this.DefaultEnabled != null &&
                    this.DefaultEnabled.Equals(input.DefaultEnabled))
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
                if (this.DefaultEnabled != null)
                    hashCode = hashCode * 59 + this.DefaultEnabled.GetHashCode();
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