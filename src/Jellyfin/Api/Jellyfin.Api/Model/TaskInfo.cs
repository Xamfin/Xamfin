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
    /// Class TaskInfo.
    /// </summary>
    [DataContract]
    public partial class TaskInfo :  IEquatable<TaskInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the state of the task.
        /// </summary>
        /// <value>Gets or sets the state of the task.</value>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public TaskState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInfo" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="state">Gets or sets the state of the task..</param>
        /// <param name="currentProgressPercentage">Gets or sets the progress..</param>
        /// <param name="id">Gets or sets the id..</param>
        /// <param name="lastExecutionResult">Gets or sets the last execution result..</param>
        /// <param name="triggers">Gets or sets the triggers..</param>
        /// <param name="description">Gets or sets the description..</param>
        /// <param name="category">Gets or sets the category..</param>
        /// <param name="isHidden">Gets or sets a value indicating whether this instance is hidden..</param>
        /// <param name="key">Gets or sets the key..</param>
        public TaskInfo(string name = default(string), TaskState? state = default(TaskState?), double? currentProgressPercentage = default(double?), string id = default(string), TaskResult lastExecutionResult = default(TaskResult), List<TaskTriggerInfo> triggers = default(List<TaskTriggerInfo>), string description = default(string), string category = default(string), bool isHidden = default(bool), string key = default(string))
        {
            this.Name = name;
            this.CurrentProgressPercentage = currentProgressPercentage;
            this.Id = id;
            this.LastExecutionResult = lastExecutionResult;
            this.Triggers = triggers;
            this.Description = description;
            this.Category = category;
            this.Key = key;
            this.Name = name;
            this.State = state;
            this.CurrentProgressPercentage = currentProgressPercentage;
            this.Id = id;
            this.LastExecutionResult = lastExecutionResult;
            this.Triggers = triggers;
            this.Description = description;
            this.Category = category;
            this.IsHidden = isHidden;
            this.Key = key;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the progress.
        /// </summary>
        /// <value>Gets or sets the progress.</value>
        [DataMember(Name="CurrentProgressPercentage", EmitDefaultValue=true)]
        public double? CurrentProgressPercentage { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>Gets or sets the id.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the last execution result.
        /// </summary>
        /// <value>Gets or sets the last execution result.</value>
        [DataMember(Name="LastExecutionResult", EmitDefaultValue=true)]
        public TaskResult LastExecutionResult { get; set; }

        /// <summary>
        /// Gets or sets the triggers.
        /// </summary>
        /// <value>Gets or sets the triggers.</value>
        [DataMember(Name="Triggers", EmitDefaultValue=true)]
        public List<TaskTriggerInfo> Triggers { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>Gets or sets the description.</value>
        [DataMember(Name="Description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>Gets or sets the category.</value>
        [DataMember(Name="Category", EmitDefaultValue=true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is hidden.
        /// </summary>
        /// <value>Gets or sets a value indicating whether this instance is hidden.</value>
        [DataMember(Name="IsHidden", EmitDefaultValue=false)]
        public bool IsHidden { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>Gets or sets the key.</value>
        [DataMember(Name="Key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CurrentProgressPercentage: ").Append(CurrentProgressPercentage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastExecutionResult: ").Append(LastExecutionResult).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as TaskInfo);
        }

        /// <summary>
        /// Returns true if TaskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskInfo input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CurrentProgressPercentage == input.CurrentProgressPercentage ||
                    (this.CurrentProgressPercentage != null &&
                    this.CurrentProgressPercentage.Equals(input.CurrentProgressPercentage))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastExecutionResult == input.LastExecutionResult ||
                    (this.LastExecutionResult != null &&
                    this.LastExecutionResult.Equals(input.LastExecutionResult))
                ) && 
                (
                    this.Triggers == input.Triggers ||
                    this.Triggers != null &&
                    input.Triggers != null &&
                    this.Triggers.SequenceEqual(input.Triggers)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.IsHidden == input.IsHidden ||
                    (this.IsHidden != null &&
                    this.IsHidden.Equals(input.IsHidden))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CurrentProgressPercentage != null)
                    hashCode = hashCode * 59 + this.CurrentProgressPercentage.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastExecutionResult != null)
                    hashCode = hashCode * 59 + this.LastExecutionResult.GetHashCode();
                if (this.Triggers != null)
                    hashCode = hashCode * 59 + this.Triggers.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.IsHidden != null)
                    hashCode = hashCode * 59 + this.IsHidden.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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