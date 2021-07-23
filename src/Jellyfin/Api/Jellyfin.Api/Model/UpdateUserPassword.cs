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
    /// The update user password request body.
    /// </summary>
    [DataContract]
    public partial class UpdateUserPassword :  IEquatable<UpdateUserPassword>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserPassword" /> class.
        /// </summary>
        /// <param name="currentPassword">Gets or sets the current sha1-hashed password..</param>
        /// <param name="currentPw">Gets or sets the current plain text password..</param>
        /// <param name="newPw">Gets or sets the new plain text password..</param>
        /// <param name="resetPassword">Gets or sets a value indicating whether to reset the password..</param>
        public UpdateUserPassword(string currentPassword = default(string), string currentPw = default(string), string newPw = default(string), bool resetPassword = default(bool))
        {
            this.CurrentPassword = currentPassword;
            this.CurrentPw = currentPw;
            this.NewPw = newPw;
            this.CurrentPassword = currentPassword;
            this.CurrentPw = currentPw;
            this.NewPw = newPw;
            this.ResetPassword = resetPassword;
        }

        /// <summary>
        /// Gets or sets the current sha1-hashed password.
        /// </summary>
        /// <value>Gets or sets the current sha1-hashed password.</value>
        [DataMember(Name="CurrentPassword", EmitDefaultValue=true)]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// Gets or sets the current plain text password.
        /// </summary>
        /// <value>Gets or sets the current plain text password.</value>
        [DataMember(Name="CurrentPw", EmitDefaultValue=true)]
        public string CurrentPw { get; set; }

        /// <summary>
        /// Gets or sets the new plain text password.
        /// </summary>
        /// <value>Gets or sets the new plain text password.</value>
        [DataMember(Name="NewPw", EmitDefaultValue=true)]
        public string NewPw { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to reset the password.
        /// </summary>
        /// <value>Gets or sets a value indicating whether to reset the password.</value>
        [DataMember(Name="ResetPassword", EmitDefaultValue=false)]
        public bool ResetPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserPassword {\n");
            sb.Append("  CurrentPassword: ").Append(CurrentPassword).Append("\n");
            sb.Append("  CurrentPw: ").Append(CurrentPw).Append("\n");
            sb.Append("  NewPw: ").Append(NewPw).Append("\n");
            sb.Append("  ResetPassword: ").Append(ResetPassword).Append("\n");
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
            return this.Equals(input as UpdateUserPassword);
        }

        /// <summary>
        /// Returns true if UpdateUserPassword instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUserPassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUserPassword input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentPassword == input.CurrentPassword ||
                    (this.CurrentPassword != null &&
                    this.CurrentPassword.Equals(input.CurrentPassword))
                ) && 
                (
                    this.CurrentPw == input.CurrentPw ||
                    (this.CurrentPw != null &&
                    this.CurrentPw.Equals(input.CurrentPw))
                ) && 
                (
                    this.NewPw == input.NewPw ||
                    (this.NewPw != null &&
                    this.NewPw.Equals(input.NewPw))
                ) && 
                (
                    this.ResetPassword == input.ResetPassword ||
                    (this.ResetPassword != null &&
                    this.ResetPassword.Equals(input.ResetPassword))
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
                if (this.CurrentPassword != null)
                    hashCode = hashCode * 59 + this.CurrentPassword.GetHashCode();
                if (this.CurrentPw != null)
                    hashCode = hashCode * 59 + this.CurrentPw.GetHashCode();
                if (this.NewPw != null)
                    hashCode = hashCode * 59 + this.NewPw.GetHashCode();
                if (this.ResetPassword != null)
                    hashCode = hashCode * 59 + this.ResetPassword.GetHashCode();
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