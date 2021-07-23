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
    /// ContainerProfile
    /// </summary>
    [DataContract]
    public partial class ContainerProfile :  IEquatable<ContainerProfile>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public DlnaProfileType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerProfile" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="conditions">conditions.</param>
        /// <param name="container">container.</param>
        public ContainerProfile(DlnaProfileType? type = default(DlnaProfileType?), List<ProfileCondition> conditions = default(List<ProfileCondition>), string container = default(string))
        {
            this.Conditions = conditions;
            this.Container = container;
            this.Type = type;
            this.Conditions = conditions;
            this.Container = container;
        }


        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name="Conditions", EmitDefaultValue=true)]
        public List<ProfileCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or Sets Container
        /// </summary>
        [DataMember(Name="Container", EmitDefaultValue=true)]
        public string Container { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerProfile {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
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
            return this.Equals(input as ContainerProfile);
        }

        /// <summary>
        /// Returns true if ContainerProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainerProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainerProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.Container == input.Container ||
                    (this.Container != null &&
                    this.Container.Equals(input.Container))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Container != null)
                    hashCode = hashCode * 59 + this.Container.GetHashCode();
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
