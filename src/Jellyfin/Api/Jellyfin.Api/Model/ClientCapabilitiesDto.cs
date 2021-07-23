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
    /// Client capabilities dto.
    /// </summary>
    [DataContract]
    public partial class ClientCapabilitiesDto :  IEquatable<ClientCapabilitiesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCapabilitiesDto" /> class.
        /// </summary>
        /// <param name="playableMediaTypes">Gets or sets the list of playable media types..</param>
        /// <param name="supportedCommands">Gets or sets the list of supported commands..</param>
        /// <param name="supportsMediaControl">Gets or sets a value indicating whether session supports media control..</param>
        /// <param name="supportsContentUploading">Gets or sets a value indicating whether session supports content uploading..</param>
        /// <param name="messageCallbackUrl">Gets or sets the message callback url..</param>
        /// <param name="supportsPersistentIdentifier">Gets or sets a value indicating whether session supports a persistent identifier..</param>
        /// <param name="supportsSync">Gets or sets a value indicating whether session supports sync..</param>
        /// <param name="deviceProfile">Gets or sets the device profile..</param>
        /// <param name="appStoreUrl">Gets or sets the app store url..</param>
        /// <param name="iconUrl">Gets or sets the icon url..</param>
        public ClientCapabilitiesDto(List<string> playableMediaTypes = default(List<string>), List<GeneralCommandType> supportedCommands = default(List<GeneralCommandType>), bool supportsMediaControl = default(bool), bool supportsContentUploading = default(bool), string messageCallbackUrl = default(string), bool supportsPersistentIdentifier = default(bool), bool supportsSync = default(bool), DeviceProfile deviceProfile = default(DeviceProfile), string appStoreUrl = default(string), string iconUrl = default(string))
        {
            this.PlayableMediaTypes = playableMediaTypes;
            this.SupportedCommands = supportedCommands;
            this.MessageCallbackUrl = messageCallbackUrl;
            this.DeviceProfile = deviceProfile;
            this.AppStoreUrl = appStoreUrl;
            this.IconUrl = iconUrl;
            this.PlayableMediaTypes = playableMediaTypes;
            this.SupportedCommands = supportedCommands;
            this.SupportsMediaControl = supportsMediaControl;
            this.SupportsContentUploading = supportsContentUploading;
            this.MessageCallbackUrl = messageCallbackUrl;
            this.SupportsPersistentIdentifier = supportsPersistentIdentifier;
            this.SupportsSync = supportsSync;
            this.DeviceProfile = deviceProfile;
            this.AppStoreUrl = appStoreUrl;
            this.IconUrl = iconUrl;
        }

        /// <summary>
        /// Gets or sets the list of playable media types.
        /// </summary>
        /// <value>Gets or sets the list of playable media types.</value>
        [DataMember(Name="PlayableMediaTypes", EmitDefaultValue=true)]
        public List<string> PlayableMediaTypes { get; set; }

        /// <summary>
        /// Gets or sets the list of supported commands.
        /// </summary>
        /// <value>Gets or sets the list of supported commands.</value>
        [DataMember(Name="SupportedCommands", EmitDefaultValue=true)]
        public List<GeneralCommandType> SupportedCommands { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether session supports media control.
        /// </summary>
        /// <value>Gets or sets a value indicating whether session supports media control.</value>
        [DataMember(Name="SupportsMediaControl", EmitDefaultValue=false)]
        public bool SupportsMediaControl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether session supports content uploading.
        /// </summary>
        /// <value>Gets or sets a value indicating whether session supports content uploading.</value>
        [DataMember(Name="SupportsContentUploading", EmitDefaultValue=false)]
        public bool SupportsContentUploading { get; set; }

        /// <summary>
        /// Gets or sets the message callback url.
        /// </summary>
        /// <value>Gets or sets the message callback url.</value>
        [DataMember(Name="MessageCallbackUrl", EmitDefaultValue=true)]
        public string MessageCallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether session supports a persistent identifier.
        /// </summary>
        /// <value>Gets or sets a value indicating whether session supports a persistent identifier.</value>
        [DataMember(Name="SupportsPersistentIdentifier", EmitDefaultValue=false)]
        public bool SupportsPersistentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether session supports sync.
        /// </summary>
        /// <value>Gets or sets a value indicating whether session supports sync.</value>
        [DataMember(Name="SupportsSync", EmitDefaultValue=false)]
        public bool SupportsSync { get; set; }

        /// <summary>
        /// Gets or sets the device profile.
        /// </summary>
        /// <value>Gets or sets the device profile.</value>
        [DataMember(Name="DeviceProfile", EmitDefaultValue=true)]
        public DeviceProfile DeviceProfile { get; set; }

        /// <summary>
        /// Gets or sets the app store url.
        /// </summary>
        /// <value>Gets or sets the app store url.</value>
        [DataMember(Name="AppStoreUrl", EmitDefaultValue=true)]
        public string AppStoreUrl { get; set; }

        /// <summary>
        /// Gets or sets the icon url.
        /// </summary>
        /// <value>Gets or sets the icon url.</value>
        [DataMember(Name="IconUrl", EmitDefaultValue=true)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientCapabilitiesDto {\n");
            sb.Append("  PlayableMediaTypes: ").Append(PlayableMediaTypes).Append("\n");
            sb.Append("  SupportedCommands: ").Append(SupportedCommands).Append("\n");
            sb.Append("  SupportsMediaControl: ").Append(SupportsMediaControl).Append("\n");
            sb.Append("  SupportsContentUploading: ").Append(SupportsContentUploading).Append("\n");
            sb.Append("  MessageCallbackUrl: ").Append(MessageCallbackUrl).Append("\n");
            sb.Append("  SupportsPersistentIdentifier: ").Append(SupportsPersistentIdentifier).Append("\n");
            sb.Append("  SupportsSync: ").Append(SupportsSync).Append("\n");
            sb.Append("  DeviceProfile: ").Append(DeviceProfile).Append("\n");
            sb.Append("  AppStoreUrl: ").Append(AppStoreUrl).Append("\n");
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
            return this.Equals(input as ClientCapabilitiesDto);
        }

        /// <summary>
        /// Returns true if ClientCapabilitiesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCapabilitiesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCapabilitiesDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlayableMediaTypes == input.PlayableMediaTypes ||
                    this.PlayableMediaTypes != null &&
                    input.PlayableMediaTypes != null &&
                    this.PlayableMediaTypes.SequenceEqual(input.PlayableMediaTypes)
                ) && 
                (
                    this.SupportedCommands == input.SupportedCommands ||
                    this.SupportedCommands != null &&
                    input.SupportedCommands != null &&
                    this.SupportedCommands.SequenceEqual(input.SupportedCommands)
                ) && 
                (
                    this.SupportsMediaControl == input.SupportsMediaControl ||
                    (this.SupportsMediaControl != null &&
                    this.SupportsMediaControl.Equals(input.SupportsMediaControl))
                ) && 
                (
                    this.SupportsContentUploading == input.SupportsContentUploading ||
                    (this.SupportsContentUploading != null &&
                    this.SupportsContentUploading.Equals(input.SupportsContentUploading))
                ) && 
                (
                    this.MessageCallbackUrl == input.MessageCallbackUrl ||
                    (this.MessageCallbackUrl != null &&
                    this.MessageCallbackUrl.Equals(input.MessageCallbackUrl))
                ) && 
                (
                    this.SupportsPersistentIdentifier == input.SupportsPersistentIdentifier ||
                    (this.SupportsPersistentIdentifier != null &&
                    this.SupportsPersistentIdentifier.Equals(input.SupportsPersistentIdentifier))
                ) && 
                (
                    this.SupportsSync == input.SupportsSync ||
                    (this.SupportsSync != null &&
                    this.SupportsSync.Equals(input.SupportsSync))
                ) && 
                (
                    this.DeviceProfile == input.DeviceProfile ||
                    (this.DeviceProfile != null &&
                    this.DeviceProfile.Equals(input.DeviceProfile))
                ) && 
                (
                    this.AppStoreUrl == input.AppStoreUrl ||
                    (this.AppStoreUrl != null &&
                    this.AppStoreUrl.Equals(input.AppStoreUrl))
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
                if (this.PlayableMediaTypes != null)
                    hashCode = hashCode * 59 + this.PlayableMediaTypes.GetHashCode();
                if (this.SupportedCommands != null)
                    hashCode = hashCode * 59 + this.SupportedCommands.GetHashCode();
                if (this.SupportsMediaControl != null)
                    hashCode = hashCode * 59 + this.SupportsMediaControl.GetHashCode();
                if (this.SupportsContentUploading != null)
                    hashCode = hashCode * 59 + this.SupportsContentUploading.GetHashCode();
                if (this.MessageCallbackUrl != null)
                    hashCode = hashCode * 59 + this.MessageCallbackUrl.GetHashCode();
                if (this.SupportsPersistentIdentifier != null)
                    hashCode = hashCode * 59 + this.SupportsPersistentIdentifier.GetHashCode();
                if (this.SupportsSync != null)
                    hashCode = hashCode * 59 + this.SupportsSync.GetHashCode();
                if (this.DeviceProfile != null)
                    hashCode = hashCode * 59 + this.DeviceProfile.GetHashCode();
                if (this.AppStoreUrl != null)
                    hashCode = hashCode * 59 + this.AppStoreUrl.GetHashCode();
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
