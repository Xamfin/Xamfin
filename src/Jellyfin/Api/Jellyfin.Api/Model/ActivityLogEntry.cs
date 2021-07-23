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
    /// ActivityLogEntry
    /// </summary>
    [DataContract]
    public partial class ActivityLogEntry :  IEquatable<ActivityLogEntry>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the log severity.
        /// </summary>
        /// <value>Gets or sets the log severity.</value>
        [DataMember(Name="Severity", EmitDefaultValue=false)]
        public LogLevel? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLogEntry" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the identifier..</param>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="overview">Gets or sets the overview..</param>
        /// <param name="shortOverview">Gets or sets the short overview..</param>
        /// <param name="type">Gets or sets the type..</param>
        /// <param name="itemId">Gets or sets the item identifier..</param>
        /// <param name="date">Gets or sets the date..</param>
        /// <param name="userId">Gets or sets the user identifier..</param>
        /// <param name="userPrimaryImageTag">Gets or sets the user primary image tag..</param>
        /// <param name="severity">Gets or sets the log severity..</param>
        public ActivityLogEntry(long id = default(long), string name = default(string), string overview = default(string), string shortOverview = default(string), string type = default(string), string itemId = default(string), DateTime date = default(DateTime), Guid userId = default(Guid), string userPrimaryImageTag = default(string), LogLevel? severity = default(LogLevel?))
        {
            this.Name = name;
            this.Overview = overview;
            this.ShortOverview = shortOverview;
            this.Type = type;
            this.ItemId = itemId;
            this.UserPrimaryImageTag = userPrimaryImageTag;
            this.Id = id;
            this.Name = name;
            this.Overview = overview;
            this.ShortOverview = shortOverview;
            this.Type = type;
            this.ItemId = itemId;
            this.Date = date;
            this.UserId = userId;
            this.UserPrimaryImageTag = userPrimaryImageTag;
            this.Severity = severity;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>Gets or sets the identifier.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>Gets or sets the overview.</value>
        [DataMember(Name="Overview", EmitDefaultValue=true)]
        public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the short overview.
        /// </summary>
        /// <value>Gets or sets the short overview.</value>
        [DataMember(Name="ShortOverview", EmitDefaultValue=true)]
        public string ShortOverview { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>Gets or sets the type.</value>
        [DataMember(Name="Type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>Gets or sets the item identifier.</value>
        [DataMember(Name="ItemId", EmitDefaultValue=true)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>Gets or sets the date.</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>Gets or sets the user identifier.</value>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the user primary image tag.
        /// </summary>
        /// <value>Gets or sets the user primary image tag.</value>
        [DataMember(Name="UserPrimaryImageTag", EmitDefaultValue=true)]
        public string UserPrimaryImageTag { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityLogEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Overview: ").Append(Overview).Append("\n");
            sb.Append("  ShortOverview: ").Append(ShortOverview).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserPrimaryImageTag: ").Append(UserPrimaryImageTag).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
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
            return this.Equals(input as ActivityLogEntry);
        }

        /// <summary>
        /// Returns true if ActivityLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityLogEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Overview == input.Overview ||
                    (this.Overview != null &&
                    this.Overview.Equals(input.Overview))
                ) && 
                (
                    this.ShortOverview == input.ShortOverview ||
                    (this.ShortOverview != null &&
                    this.ShortOverview.Equals(input.ShortOverview))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserPrimaryImageTag == input.UserPrimaryImageTag ||
                    (this.UserPrimaryImageTag != null &&
                    this.UserPrimaryImageTag.Equals(input.UserPrimaryImageTag))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Overview != null)
                    hashCode = hashCode * 59 + this.Overview.GetHashCode();
                if (this.ShortOverview != null)
                    hashCode = hashCode * 59 + this.ShortOverview.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserPrimaryImageTag != null)
                    hashCode = hashCode * 59 + this.UserPrimaryImageTag.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
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
