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
    /// MessageCommand
    /// </summary>
    [DataContract]
    public partial class MessageCommand :  IEquatable<MessageCommand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageCommand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCommand" /> class.
        /// </summary>
        /// <param name="header">header.</param>
        /// <param name="text">text (required).</param>
        /// <param name="timeoutMs">timeoutMs.</param>
        public MessageCommand(string header = default(string), string text = default(string), long? timeoutMs = default(long?))
        {
            this.Header = header;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for MessageCommand and cannot be null");
            }
            else
            {
                this.Text = text;
            }

            this.TimeoutMs = timeoutMs;
            this.Header = header;
            this.TimeoutMs = timeoutMs;
        }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name="Header", EmitDefaultValue=true)]
        public string Header { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="Text", EmitDefaultValue=true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutMs
        /// </summary>
        [DataMember(Name="TimeoutMs", EmitDefaultValue=true)]
        public long? TimeoutMs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageCommand {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  TimeoutMs: ").Append(TimeoutMs).Append("\n");
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
            return this.Equals(input as MessageCommand);
        }

        /// <summary>
        /// Returns true if MessageCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageCommand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.TimeoutMs == input.TimeoutMs ||
                    (this.TimeoutMs != null &&
                    this.TimeoutMs.Equals(input.TimeoutMs))
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
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.TimeoutMs != null)
                    hashCode = hashCode * 59 + this.TimeoutMs.GetHashCode();
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
