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
    /// The admin notification dto.
    /// </summary>
    [DataContract]
    public partial class AdminNotificationDto :  IEquatable<AdminNotificationDto>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the notification level.
        /// </summary>
        /// <value>Gets or sets the notification level.</value>
        [DataMember(Name="NotificationLevel", EmitDefaultValue=true)]
        public NotificationLevel? NotificationLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminNotificationDto" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the notification name..</param>
        /// <param name="description">Gets or sets the notification description..</param>
        /// <param name="notificationLevel">Gets or sets the notification level..</param>
        /// <param name="url">Gets or sets the notification url..</param>
        public AdminNotificationDto(string name = default(string), string description = default(string), NotificationLevel? notificationLevel = default(NotificationLevel?), string url = default(string))
        {
            this.Name = name;
            this.Description = description;
            this.NotificationLevel = notificationLevel;
            this.Url = url;
            this.Name = name;
            this.Description = description;
            this.NotificationLevel = notificationLevel;
            this.Url = url;
        }

        /// <summary>
        /// Gets or sets the notification name.
        /// </summary>
        /// <value>Gets or sets the notification name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the notification description.
        /// </summary>
        /// <value>Gets or sets the notification description.</value>
        [DataMember(Name="Description", EmitDefaultValue=true)]
        public string Description { get; set; }


        /// <summary>
        /// Gets or sets the notification url.
        /// </summary>
        /// <value>Gets or sets the notification url.</value>
        [DataMember(Name="Url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminNotificationDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NotificationLevel: ").Append(NotificationLevel).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as AdminNotificationDto);
        }

        /// <summary>
        /// Returns true if AdminNotificationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AdminNotificationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminNotificationDto input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.NotificationLevel == input.NotificationLevel ||
                    (this.NotificationLevel != null &&
                    this.NotificationLevel.Equals(input.NotificationLevel))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.NotificationLevel != null)
                    hashCode = hashCode * 59 + this.NotificationLevel.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
