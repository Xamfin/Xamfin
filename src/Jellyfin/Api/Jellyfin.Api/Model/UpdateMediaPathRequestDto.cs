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
    /// Update library options dto.
    /// </summary>
    [DataContract]
    public partial class UpdateMediaPathRequestDto :  IEquatable<UpdateMediaPathRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMediaPathRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateMediaPathRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMediaPathRequestDto" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the library name. (required).</param>
        /// <param name="pathInfo">Gets or sets library folder path information. (required).</param>
        public UpdateMediaPathRequestDto(string name = default(string), MediaPathInfo pathInfo = default(MediaPathInfo))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UpdateMediaPathRequestDto and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "pathInfo" is required (not null)
            if (pathInfo == null)
            {
                throw new InvalidDataException("pathInfo is a required property for UpdateMediaPathRequestDto and cannot be null");
            }
            else
            {
                this.PathInfo = pathInfo;
            }

        }

        /// <summary>
        /// Gets or sets the library name.
        /// </summary>
        /// <value>Gets or sets the library name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets library folder path information.
        /// </summary>
        /// <value>Gets or sets library folder path information.</value>
        [DataMember(Name="PathInfo", EmitDefaultValue=true)]
        public MediaPathInfo PathInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMediaPathRequestDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PathInfo: ").Append(PathInfo).Append("\n");
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
            return this.Equals(input as UpdateMediaPathRequestDto);
        }

        /// <summary>
        /// Returns true if UpdateMediaPathRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMediaPathRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMediaPathRequestDto input)
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
                    this.PathInfo == input.PathInfo ||
                    (this.PathInfo != null &&
                    this.PathInfo.Equals(input.PathInfo))
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
                if (this.PathInfo != null)
                    hashCode = hashCode * 59 + this.PathInfo.GetHashCode();
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