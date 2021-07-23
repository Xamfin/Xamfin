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
    /// Class ServiceInfo.
    /// </summary>
    [DataContract]
    public partial class LiveTvServiceInfo :  IEquatable<LiveTvServiceInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>Gets or sets the status.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public LiveTvServiceStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTvServiceInfo" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="homePageUrl">Gets or sets the home page URL..</param>
        /// <param name="status">Gets or sets the status..</param>
        /// <param name="statusMessage">Gets or sets the status message..</param>
        /// <param name="version">Gets or sets the version..</param>
        /// <param name="hasUpdateAvailable">Gets or sets a value indicating whether this instance has update available..</param>
        /// <param name="isVisible">Gets or sets a value indicating whether this instance is visible..</param>
        /// <param name="tuners">tuners.</param>
        public LiveTvServiceInfo(string name = default(string), string homePageUrl = default(string), LiveTvServiceStatus? status = default(LiveTvServiceStatus?), string statusMessage = default(string), string version = default(string), bool hasUpdateAvailable = default(bool), bool isVisible = default(bool), List<string> tuners = default(List<string>))
        {
            this.Name = name;
            this.HomePageUrl = homePageUrl;
            this.StatusMessage = statusMessage;
            this.Version = version;
            this.Tuners = tuners;
            this.Name = name;
            this.HomePageUrl = homePageUrl;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.Version = version;
            this.HasUpdateAvailable = hasUpdateAvailable;
            this.IsVisible = isVisible;
            this.Tuners = tuners;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the home page URL.
        /// </summary>
        /// <value>Gets or sets the home page URL.</value>
        [DataMember(Name="HomePageUrl", EmitDefaultValue=true)]
        public string HomePageUrl { get; set; }


        /// <summary>
        /// Gets or sets the status message.
        /// </summary>
        /// <value>Gets or sets the status message.</value>
        [DataMember(Name="StatusMessage", EmitDefaultValue=true)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>Gets or sets the version.</value>
        [DataMember(Name="Version", EmitDefaultValue=true)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has update available.
        /// </summary>
        /// <value>Gets or sets a value indicating whether this instance has update available.</value>
        [DataMember(Name="HasUpdateAvailable", EmitDefaultValue=false)]
        public bool HasUpdateAvailable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is visible.
        /// </summary>
        /// <value>Gets or sets a value indicating whether this instance is visible.</value>
        [DataMember(Name="IsVisible", EmitDefaultValue=false)]
        public bool IsVisible { get; set; }

        /// <summary>
        /// Gets or Sets Tuners
        /// </summary>
        [DataMember(Name="Tuners", EmitDefaultValue=true)]
        public List<string> Tuners { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveTvServiceInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HomePageUrl: ").Append(HomePageUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  HasUpdateAvailable: ").Append(HasUpdateAvailable).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  Tuners: ").Append(Tuners).Append("\n");
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
            return this.Equals(input as LiveTvServiceInfo);
        }

        /// <summary>
        /// Returns true if LiveTvServiceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LiveTvServiceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiveTvServiceInfo input)
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
                    this.HomePageUrl == input.HomePageUrl ||
                    (this.HomePageUrl != null &&
                    this.HomePageUrl.Equals(input.HomePageUrl))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.HasUpdateAvailable == input.HasUpdateAvailable ||
                    (this.HasUpdateAvailable != null &&
                    this.HasUpdateAvailable.Equals(input.HasUpdateAvailable))
                ) && 
                (
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    this.Tuners == input.Tuners ||
                    this.Tuners != null &&
                    input.Tuners != null &&
                    this.Tuners.SequenceEqual(input.Tuners)
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
                if (this.HomePageUrl != null)
                    hashCode = hashCode * 59 + this.HomePageUrl.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.HasUpdateAvailable != null)
                    hashCode = hashCode * 59 + this.HasUpdateAvailable.GetHashCode();
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
                if (this.Tuners != null)
                    hashCode = hashCode * 59 + this.Tuners.GetHashCode();
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