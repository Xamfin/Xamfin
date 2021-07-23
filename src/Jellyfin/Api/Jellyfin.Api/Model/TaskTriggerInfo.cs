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
    /// Class TaskTriggerInfo.
    /// </summary>
    [DataContract]
    public partial class TaskTriggerInfo :  IEquatable<TaskTriggerInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the day of week.
        /// </summary>
        /// <value>Gets or sets the day of week.</value>
        [DataMember(Name="DayOfWeek", EmitDefaultValue=true)]
        public DayOfWeek? DayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskTriggerInfo" /> class.
        /// </summary>
        /// <param name="type">Gets or sets the type..</param>
        /// <param name="timeOfDayTicks">Gets or sets the time of day..</param>
        /// <param name="intervalTicks">Gets or sets the interval..</param>
        /// <param name="dayOfWeek">Gets or sets the day of week..</param>
        /// <param name="maxRuntimeTicks">Gets or sets the maximum runtime ticks..</param>
        public TaskTriggerInfo(string type = default(string), long? timeOfDayTicks = default(long?), long? intervalTicks = default(long?), DayOfWeek? dayOfWeek = default(DayOfWeek?), long? maxRuntimeTicks = default(long?))
        {
            this.Type = type;
            this.TimeOfDayTicks = timeOfDayTicks;
            this.IntervalTicks = intervalTicks;
            this.DayOfWeek = dayOfWeek;
            this.MaxRuntimeTicks = maxRuntimeTicks;
            this.Type = type;
            this.TimeOfDayTicks = timeOfDayTicks;
            this.IntervalTicks = intervalTicks;
            this.DayOfWeek = dayOfWeek;
            this.MaxRuntimeTicks = maxRuntimeTicks;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>Gets or sets the type.</value>
        [DataMember(Name="Type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the time of day.
        /// </summary>
        /// <value>Gets or sets the time of day.</value>
        [DataMember(Name="TimeOfDayTicks", EmitDefaultValue=true)]
        public long? TimeOfDayTicks { get; set; }

        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        /// <value>Gets or sets the interval.</value>
        [DataMember(Name="IntervalTicks", EmitDefaultValue=true)]
        public long? IntervalTicks { get; set; }


        /// <summary>
        /// Gets or sets the maximum runtime ticks.
        /// </summary>
        /// <value>Gets or sets the maximum runtime ticks.</value>
        [DataMember(Name="MaxRuntimeTicks", EmitDefaultValue=true)]
        public long? MaxRuntimeTicks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskTriggerInfo {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeOfDayTicks: ").Append(TimeOfDayTicks).Append("\n");
            sb.Append("  IntervalTicks: ").Append(IntervalTicks).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  MaxRuntimeTicks: ").Append(MaxRuntimeTicks).Append("\n");
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
            return this.Equals(input as TaskTriggerInfo);
        }

        /// <summary>
        /// Returns true if TaskTriggerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskTriggerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskTriggerInfo input)
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
                    this.TimeOfDayTicks == input.TimeOfDayTicks ||
                    (this.TimeOfDayTicks != null &&
                    this.TimeOfDayTicks.Equals(input.TimeOfDayTicks))
                ) && 
                (
                    this.IntervalTicks == input.IntervalTicks ||
                    (this.IntervalTicks != null &&
                    this.IntervalTicks.Equals(input.IntervalTicks))
                ) && 
                (
                    this.DayOfWeek == input.DayOfWeek ||
                    (this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(input.DayOfWeek))
                ) && 
                (
                    this.MaxRuntimeTicks == input.MaxRuntimeTicks ||
                    (this.MaxRuntimeTicks != null &&
                    this.MaxRuntimeTicks.Equals(input.MaxRuntimeTicks))
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
                if (this.TimeOfDayTicks != null)
                    hashCode = hashCode * 59 + this.TimeOfDayTicks.GetHashCode();
                if (this.IntervalTicks != null)
                    hashCode = hashCode * 59 + this.IntervalTicks.GetHashCode();
                if (this.DayOfWeek != null)
                    hashCode = hashCode * 59 + this.DayOfWeek.GetHashCode();
                if (this.MaxRuntimeTicks != null)
                    hashCode = hashCode * 59 + this.MaxRuntimeTicks.GetHashCode();
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