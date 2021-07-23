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
    /// DeviceInfo
    /// </summary>
    [DataContract]
    public partial class DeviceInfo :  IEquatable<DeviceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInfo" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="id">Gets or sets the identifier..</param>
        /// <param name="lastUserName">Gets or sets the last name of the user..</param>
        /// <param name="appName">Gets or sets the name of the application..</param>
        /// <param name="appVersion">Gets or sets the application version..</param>
        /// <param name="lastUserId">Gets or sets the last user identifier..</param>
        /// <param name="dateLastActivity">Gets or sets the date last modified..</param>
        /// <param name="capabilities">Gets or sets the capabilities..</param>
        /// <param name="iconUrl">iconUrl.</param>
        public DeviceInfo(string name = default(string), string id = default(string), string lastUserName = default(string), string appName = default(string), string appVersion = default(string), Guid lastUserId = default(Guid), DateTime dateLastActivity = default(DateTime), ClientCapabilities capabilities = default(ClientCapabilities), string iconUrl = default(string))
        {
            this.Name = name;
            this.Id = id;
            this.LastUserName = lastUserName;
            this.AppName = appName;
            this.AppVersion = appVersion;
            this.Capabilities = capabilities;
            this.IconUrl = iconUrl;
            this.Name = name;
            this.Id = id;
            this.LastUserName = lastUserName;
            this.AppName = appName;
            this.AppVersion = appVersion;
            this.LastUserId = lastUserId;
            this.DateLastActivity = dateLastActivity;
            this.Capabilities = capabilities;
            this.IconUrl = iconUrl;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>Gets or sets the identifier.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        /// <value>Gets or sets the last name of the user.</value>
        [DataMember(Name="LastUserName", EmitDefaultValue=true)]
        public string LastUserName { get; set; }

        /// <summary>
        /// Gets or sets the name of the application.
        /// </summary>
        /// <value>Gets or sets the name of the application.</value>
        [DataMember(Name="AppName", EmitDefaultValue=true)]
        public string AppName { get; set; }

        /// <summary>
        /// Gets or sets the application version.
        /// </summary>
        /// <value>Gets or sets the application version.</value>
        [DataMember(Name="AppVersion", EmitDefaultValue=true)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or sets the last user identifier.
        /// </summary>
        /// <value>Gets or sets the last user identifier.</value>
        [DataMember(Name="LastUserId", EmitDefaultValue=false)]
        public Guid LastUserId { get; set; }

        /// <summary>
        /// Gets or sets the date last modified.
        /// </summary>
        /// <value>Gets or sets the date last modified.</value>
        [DataMember(Name="DateLastActivity", EmitDefaultValue=false)]
        public DateTime DateLastActivity { get; set; }

        /// <summary>
        /// Gets or sets the capabilities.
        /// </summary>
        /// <value>Gets or sets the capabilities.</value>
        [DataMember(Name="Capabilities", EmitDefaultValue=true)]
        public ClientCapabilities Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="IconUrl", EmitDefaultValue=true)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastUserName: ").Append(LastUserName).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  LastUserId: ").Append(LastUserId).Append("\n");
            sb.Append("  DateLastActivity: ").Append(DateLastActivity).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
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
            return this.Equals(input as DeviceInfo);
        }

        /// <summary>
        /// Returns true if DeviceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceInfo input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastUserName == input.LastUserName ||
                    (this.LastUserName != null &&
                    this.LastUserName.Equals(input.LastUserName))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.LastUserId == input.LastUserId ||
                    (this.LastUserId != null &&
                    this.LastUserId.Equals(input.LastUserId))
                ) && 
                (
                    this.DateLastActivity == input.DateLastActivity ||
                    (this.DateLastActivity != null &&
                    this.DateLastActivity.Equals(input.DateLastActivity))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastUserName != null)
                    hashCode = hashCode * 59 + this.LastUserName.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.LastUserId != null)
                    hashCode = hashCode * 59 + this.LastUserId.GetHashCode();
                if (this.DateLastActivity != null)
                    hashCode = hashCode * 59 + this.DateLastActivity.GetHashCode();
                if (this.Capabilities != null)
                    hashCode = hashCode * 59 + this.Capabilities.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
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
