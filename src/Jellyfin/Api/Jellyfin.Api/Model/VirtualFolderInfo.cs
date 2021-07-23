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
    /// Used to hold information about a user&#39;s list of configured virtual folders.
    /// </summary>
    [DataContract]
    public partial class VirtualFolderInfo :  IEquatable<VirtualFolderInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the type of the collection.
        /// </summary>
        /// <value>Gets or sets the type of the collection.</value>
        [DataMember(Name="CollectionType", EmitDefaultValue=true)]
        public CollectionTypeOptions? CollectionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualFolderInfo" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="locations">Gets or sets the locations..</param>
        /// <param name="collectionType">Gets or sets the type of the collection..</param>
        /// <param name="libraryOptions">libraryOptions.</param>
        /// <param name="itemId">Gets or sets the item identifier..</param>
        /// <param name="primaryImageItemId">Gets or sets the primary image item identifier..</param>
        /// <param name="refreshProgress">refreshProgress.</param>
        /// <param name="refreshStatus">refreshStatus.</param>
        public VirtualFolderInfo(string name = default(string), List<string> locations = default(List<string>), CollectionTypeOptions? collectionType = default(CollectionTypeOptions?), LibraryOptions libraryOptions = default(LibraryOptions), string itemId = default(string), string primaryImageItemId = default(string), double? refreshProgress = default(double?), string refreshStatus = default(string))
        {
            this.Name = name;
            this.Locations = locations;
            this.CollectionType = collectionType;
            this.LibraryOptions = libraryOptions;
            this.ItemId = itemId;
            this.PrimaryImageItemId = primaryImageItemId;
            this.RefreshProgress = refreshProgress;
            this.RefreshStatus = refreshStatus;
            this.Name = name;
            this.Locations = locations;
            this.CollectionType = collectionType;
            this.LibraryOptions = libraryOptions;
            this.ItemId = itemId;
            this.PrimaryImageItemId = primaryImageItemId;
            this.RefreshProgress = refreshProgress;
            this.RefreshStatus = refreshStatus;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        /// <value>Gets or sets the locations.</value>
        [DataMember(Name="Locations", EmitDefaultValue=true)]
        public List<string> Locations { get; set; }


        /// <summary>
        /// Gets or Sets LibraryOptions
        /// </summary>
        [DataMember(Name="LibraryOptions", EmitDefaultValue=true)]
        public LibraryOptions LibraryOptions { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>Gets or sets the item identifier.</value>
        [DataMember(Name="ItemId", EmitDefaultValue=true)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the primary image item identifier.
        /// </summary>
        /// <value>Gets or sets the primary image item identifier.</value>
        [DataMember(Name="PrimaryImageItemId", EmitDefaultValue=true)]
        public string PrimaryImageItemId { get; set; }

        /// <summary>
        /// Gets or Sets RefreshProgress
        /// </summary>
        [DataMember(Name="RefreshProgress", EmitDefaultValue=true)]
        public double? RefreshProgress { get; set; }

        /// <summary>
        /// Gets or Sets RefreshStatus
        /// </summary>
        [DataMember(Name="RefreshStatus", EmitDefaultValue=true)]
        public string RefreshStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualFolderInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  CollectionType: ").Append(CollectionType).Append("\n");
            sb.Append("  LibraryOptions: ").Append(LibraryOptions).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  PrimaryImageItemId: ").Append(PrimaryImageItemId).Append("\n");
            sb.Append("  RefreshProgress: ").Append(RefreshProgress).Append("\n");
            sb.Append("  RefreshStatus: ").Append(RefreshStatus).Append("\n");
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
            return this.Equals(input as VirtualFolderInfo);
        }

        /// <summary>
        /// Returns true if VirtualFolderInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualFolderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualFolderInfo input)
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
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    input.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
                ) && 
                (
                    this.CollectionType == input.CollectionType ||
                    (this.CollectionType != null &&
                    this.CollectionType.Equals(input.CollectionType))
                ) && 
                (
                    this.LibraryOptions == input.LibraryOptions ||
                    (this.LibraryOptions != null &&
                    this.LibraryOptions.Equals(input.LibraryOptions))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.PrimaryImageItemId == input.PrimaryImageItemId ||
                    (this.PrimaryImageItemId != null &&
                    this.PrimaryImageItemId.Equals(input.PrimaryImageItemId))
                ) && 
                (
                    this.RefreshProgress == input.RefreshProgress ||
                    (this.RefreshProgress != null &&
                    this.RefreshProgress.Equals(input.RefreshProgress))
                ) && 
                (
                    this.RefreshStatus == input.RefreshStatus ||
                    (this.RefreshStatus != null &&
                    this.RefreshStatus.Equals(input.RefreshStatus))
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
                if (this.Locations != null)
                    hashCode = hashCode * 59 + this.Locations.GetHashCode();
                if (this.CollectionType != null)
                    hashCode = hashCode * 59 + this.CollectionType.GetHashCode();
                if (this.LibraryOptions != null)
                    hashCode = hashCode * 59 + this.LibraryOptions.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.PrimaryImageItemId != null)
                    hashCode = hashCode * 59 + this.PrimaryImageItemId.GetHashCode();
                if (this.RefreshProgress != null)
                    hashCode = hashCode * 59 + this.RefreshProgress.GetHashCode();
                if (this.RefreshStatus != null)
                    hashCode = hashCode * 59 + this.RefreshStatus.GetHashCode();
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