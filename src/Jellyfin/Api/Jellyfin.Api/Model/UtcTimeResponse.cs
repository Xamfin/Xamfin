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
    /// Class UtcTimeResponse.
    /// </summary>
    [DataContract]
    public partial class UtcTimeResponse :  IEquatable<UtcTimeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtcTimeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UtcTimeResponse()
        {
        }

        /// <summary>
        /// Gets the UTC time when request has been received.
        /// </summary>
        /// <value>Gets the UTC time when request has been received.</value>
        [DataMember(Name="RequestReceptionTime", EmitDefaultValue=false)]
        public DateTime RequestReceptionTime { get; private set; }

        /// <summary>
        /// Gets the UTC time when response has been sent.
        /// </summary>
        /// <value>Gets the UTC time when response has been sent.</value>
        [DataMember(Name="ResponseTransmissionTime", EmitDefaultValue=false)]
        public DateTime ResponseTransmissionTime { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UtcTimeResponse {\n");
            sb.Append("  RequestReceptionTime: ").Append(RequestReceptionTime).Append("\n");
            sb.Append("  ResponseTransmissionTime: ").Append(ResponseTransmissionTime).Append("\n");
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
            return this.Equals(input as UtcTimeResponse);
        }

        /// <summary>
        /// Returns true if UtcTimeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UtcTimeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UtcTimeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestReceptionTime == input.RequestReceptionTime ||
                    (this.RequestReceptionTime != null &&
                    this.RequestReceptionTime.Equals(input.RequestReceptionTime))
                ) && 
                (
                    this.ResponseTransmissionTime == input.ResponseTransmissionTime ||
                    (this.ResponseTransmissionTime != null &&
                    this.ResponseTransmissionTime.Equals(input.ResponseTransmissionTime))
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
                if (this.RequestReceptionTime != null)
                    hashCode = hashCode * 59 + this.RequestReceptionTime.GetHashCode();
                if (this.ResponseTransmissionTime != null)
                    hashCode = hashCode * 59 + this.ResponseTransmissionTime.GetHashCode();
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
