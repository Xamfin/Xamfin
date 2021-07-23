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
    /// Class TaskExecutionInfo.
    /// </summary>
    [DataContract]
    public partial class TaskResult :  IEquatable<TaskResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>Gets or sets the status.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public TaskCompletionStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResult" /> class.
        /// </summary>
        /// <param name="startTimeUtc">Gets or sets the start time UTC..</param>
        /// <param name="endTimeUtc">Gets or sets the end time UTC..</param>
        /// <param name="status">Gets or sets the status..</param>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="key">Gets or sets the key..</param>
        /// <param name="id">Gets or sets the id..</param>
        /// <param name="errorMessage">Gets or sets the error message..</param>
        /// <param name="longErrorMessage">Gets or sets the long error message..</param>
        public TaskResult(DateTime startTimeUtc = default(DateTime), DateTime endTimeUtc = default(DateTime), TaskCompletionStatus? status = default(TaskCompletionStatus?), string name = default(string), string key = default(string), string id = default(string), string errorMessage = default(string), string longErrorMessage = default(string))
        {
            this.Name = name;
            this.Key = key;
            this.Id = id;
            this.ErrorMessage = errorMessage;
            this.LongErrorMessage = longErrorMessage;
            this.StartTimeUtc = startTimeUtc;
            this.EndTimeUtc = endTimeUtc;
            this.Status = status;
            this.Name = name;
            this.Key = key;
            this.Id = id;
            this.ErrorMessage = errorMessage;
            this.LongErrorMessage = longErrorMessage;
        }

        /// <summary>
        /// Gets or sets the start time UTC.
        /// </summary>
        /// <value>Gets or sets the start time UTC.</value>
        [DataMember(Name="StartTimeUtc", EmitDefaultValue=false)]
        public DateTime StartTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the end time UTC.
        /// </summary>
        /// <value>Gets or sets the end time UTC.</value>
        [DataMember(Name="EndTimeUtc", EmitDefaultValue=false)]
        public DateTime EndTimeUtc { get; set; }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>Gets or sets the key.</value>
        [DataMember(Name="Key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>Gets or sets the id.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>Gets or sets the error message.</value>
        [DataMember(Name="ErrorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the long error message.
        /// </summary>
        /// <value>Gets or sets the long error message.</value>
        [DataMember(Name="LongErrorMessage", EmitDefaultValue=true)]
        public string LongErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskResult {\n");
            sb.Append("  StartTimeUtc: ").Append(StartTimeUtc).Append("\n");
            sb.Append("  EndTimeUtc: ").Append(EndTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  LongErrorMessage: ").Append(LongErrorMessage).Append("\n");
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
            return this.Equals(input as TaskResult);
        }

        /// <summary>
        /// Returns true if TaskResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTimeUtc == input.StartTimeUtc ||
                    (this.StartTimeUtc != null &&
                    this.StartTimeUtc.Equals(input.StartTimeUtc))
                ) && 
                (
                    this.EndTimeUtc == input.EndTimeUtc ||
                    (this.EndTimeUtc != null &&
                    this.EndTimeUtc.Equals(input.EndTimeUtc))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.LongErrorMessage == input.LongErrorMessage ||
                    (this.LongErrorMessage != null &&
                    this.LongErrorMessage.Equals(input.LongErrorMessage))
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
                if (this.StartTimeUtc != null)
                    hashCode = hashCode * 59 + this.StartTimeUtc.GetHashCode();
                if (this.EndTimeUtc != null)
                    hashCode = hashCode * 59 + this.EndTimeUtc.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.LongErrorMessage != null)
                    hashCode = hashCode * 59 + this.LongErrorMessage.GetHashCode();
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
