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
    /// AlbumInfo
    /// </summary>
    [DataContract]
    public partial class AlbumInfo :  IEquatable<AlbumInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumInfo" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="path">Gets or sets the path..</param>
        /// <param name="metadataLanguage">Gets or sets the metadata language..</param>
        /// <param name="metadataCountryCode">Gets or sets the metadata country code..</param>
        /// <param name="providerIds">Gets or sets the provider ids..</param>
        /// <param name="year">Gets or sets the year..</param>
        /// <param name="indexNumber">indexNumber.</param>
        /// <param name="parentIndexNumber">parentIndexNumber.</param>
        /// <param name="premiereDate">premiereDate.</param>
        /// <param name="isAutomated">isAutomated.</param>
        /// <param name="albumArtists">Gets or sets the album artist..</param>
        /// <param name="artistProviderIds">Gets or sets the artist provider ids..</param>
        /// <param name="songInfos">songInfos.</param>
        public AlbumInfo(string name = default(string), string path = default(string), string metadataLanguage = default(string), string metadataCountryCode = default(string), Dictionary<string, string> providerIds = default(Dictionary<string, string>), int? year = default(int?), int? indexNumber = default(int?), int? parentIndexNumber = default(int?), DateTime? premiereDate = default(DateTime?), bool isAutomated = default(bool), List<string> albumArtists = default(List<string>), Dictionary<string, string> artistProviderIds = default(Dictionary<string, string>), List<SongInfo> songInfos = default(List<SongInfo>))
        {
            this.Name = name;
            this.Path = path;
            this.MetadataLanguage = metadataLanguage;
            this.MetadataCountryCode = metadataCountryCode;
            this.ProviderIds = providerIds;
            this.Year = year;
            this.IndexNumber = indexNumber;
            this.ParentIndexNumber = parentIndexNumber;
            this.PremiereDate = premiereDate;
            this.AlbumArtists = albumArtists;
            this.ArtistProviderIds = artistProviderIds;
            this.SongInfos = songInfos;
            this.Name = name;
            this.Path = path;
            this.MetadataLanguage = metadataLanguage;
            this.MetadataCountryCode = metadataCountryCode;
            this.ProviderIds = providerIds;
            this.Year = year;
            this.IndexNumber = indexNumber;
            this.ParentIndexNumber = parentIndexNumber;
            this.PremiereDate = premiereDate;
            this.IsAutomated = isAutomated;
            this.AlbumArtists = albumArtists;
            this.ArtistProviderIds = artistProviderIds;
            this.SongInfos = songInfos;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>Gets or sets the path.</value>
        [DataMember(Name="Path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the metadata language.
        /// </summary>
        /// <value>Gets or sets the metadata language.</value>
        [DataMember(Name="MetadataLanguage", EmitDefaultValue=true)]
        public string MetadataLanguage { get; set; }

        /// <summary>
        /// Gets or sets the metadata country code.
        /// </summary>
        /// <value>Gets or sets the metadata country code.</value>
        [DataMember(Name="MetadataCountryCode", EmitDefaultValue=true)]
        public string MetadataCountryCode { get; set; }

        /// <summary>
        /// Gets or sets the provider ids.
        /// </summary>
        /// <value>Gets or sets the provider ids.</value>
        [DataMember(Name="ProviderIds", EmitDefaultValue=true)]
        public Dictionary<string, string> ProviderIds { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>Gets or sets the year.</value>
        [DataMember(Name="Year", EmitDefaultValue=true)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets IndexNumber
        /// </summary>
        [DataMember(Name="IndexNumber", EmitDefaultValue=true)]
        public int? IndexNumber { get; set; }

        /// <summary>
        /// Gets or Sets ParentIndexNumber
        /// </summary>
        [DataMember(Name="ParentIndexNumber", EmitDefaultValue=true)]
        public int? ParentIndexNumber { get; set; }

        /// <summary>
        /// Gets or Sets PremiereDate
        /// </summary>
        [DataMember(Name="PremiereDate", EmitDefaultValue=true)]
        public DateTime? PremiereDate { get; set; }

        /// <summary>
        /// Gets or Sets IsAutomated
        /// </summary>
        [DataMember(Name="IsAutomated", EmitDefaultValue=false)]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// Gets or sets the album artist.
        /// </summary>
        /// <value>Gets or sets the album artist.</value>
        [DataMember(Name="AlbumArtists", EmitDefaultValue=true)]
        public List<string> AlbumArtists { get; set; }

        /// <summary>
        /// Gets or sets the artist provider ids.
        /// </summary>
        /// <value>Gets or sets the artist provider ids.</value>
        [DataMember(Name="ArtistProviderIds", EmitDefaultValue=true)]
        public Dictionary<string, string> ArtistProviderIds { get; set; }

        /// <summary>
        /// Gets or Sets SongInfos
        /// </summary>
        [DataMember(Name="SongInfos", EmitDefaultValue=true)]
        public List<SongInfo> SongInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlbumInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  MetadataLanguage: ").Append(MetadataLanguage).Append("\n");
            sb.Append("  MetadataCountryCode: ").Append(MetadataCountryCode).Append("\n");
            sb.Append("  ProviderIds: ").Append(ProviderIds).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  IndexNumber: ").Append(IndexNumber).Append("\n");
            sb.Append("  ParentIndexNumber: ").Append(ParentIndexNumber).Append("\n");
            sb.Append("  PremiereDate: ").Append(PremiereDate).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  AlbumArtists: ").Append(AlbumArtists).Append("\n");
            sb.Append("  ArtistProviderIds: ").Append(ArtistProviderIds).Append("\n");
            sb.Append("  SongInfos: ").Append(SongInfos).Append("\n");
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
            return this.Equals(input as AlbumInfo);
        }

        /// <summary>
        /// Returns true if AlbumInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AlbumInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlbumInfo input)
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
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.MetadataLanguage == input.MetadataLanguage ||
                    (this.MetadataLanguage != null &&
                    this.MetadataLanguage.Equals(input.MetadataLanguage))
                ) && 
                (
                    this.MetadataCountryCode == input.MetadataCountryCode ||
                    (this.MetadataCountryCode != null &&
                    this.MetadataCountryCode.Equals(input.MetadataCountryCode))
                ) && 
                (
                    this.ProviderIds == input.ProviderIds ||
                    this.ProviderIds != null &&
                    input.ProviderIds != null &&
                    this.ProviderIds.SequenceEqual(input.ProviderIds)
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.IndexNumber == input.IndexNumber ||
                    (this.IndexNumber != null &&
                    this.IndexNumber.Equals(input.IndexNumber))
                ) && 
                (
                    this.ParentIndexNumber == input.ParentIndexNumber ||
                    (this.ParentIndexNumber != null &&
                    this.ParentIndexNumber.Equals(input.ParentIndexNumber))
                ) && 
                (
                    this.PremiereDate == input.PremiereDate ||
                    (this.PremiereDate != null &&
                    this.PremiereDate.Equals(input.PremiereDate))
                ) && 
                (
                    this.IsAutomated == input.IsAutomated ||
                    (this.IsAutomated != null &&
                    this.IsAutomated.Equals(input.IsAutomated))
                ) && 
                (
                    this.AlbumArtists == input.AlbumArtists ||
                    this.AlbumArtists != null &&
                    input.AlbumArtists != null &&
                    this.AlbumArtists.SequenceEqual(input.AlbumArtists)
                ) && 
                (
                    this.ArtistProviderIds == input.ArtistProviderIds ||
                    this.ArtistProviderIds != null &&
                    input.ArtistProviderIds != null &&
                    this.ArtistProviderIds.SequenceEqual(input.ArtistProviderIds)
                ) && 
                (
                    this.SongInfos == input.SongInfos ||
                    this.SongInfos != null &&
                    input.SongInfos != null &&
                    this.SongInfos.SequenceEqual(input.SongInfos)
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.MetadataLanguage != null)
                    hashCode = hashCode * 59 + this.MetadataLanguage.GetHashCode();
                if (this.MetadataCountryCode != null)
                    hashCode = hashCode * 59 + this.MetadataCountryCode.GetHashCode();
                if (this.ProviderIds != null)
                    hashCode = hashCode * 59 + this.ProviderIds.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.IndexNumber != null)
                    hashCode = hashCode * 59 + this.IndexNumber.GetHashCode();
                if (this.ParentIndexNumber != null)
                    hashCode = hashCode * 59 + this.ParentIndexNumber.GetHashCode();
                if (this.PremiereDate != null)
                    hashCode = hashCode * 59 + this.PremiereDate.GetHashCode();
                if (this.IsAutomated != null)
                    hashCode = hashCode * 59 + this.IsAutomated.GetHashCode();
                if (this.AlbumArtists != null)
                    hashCode = hashCode * 59 + this.AlbumArtists.GetHashCode();
                if (this.ArtistProviderIds != null)
                    hashCode = hashCode * 59 + this.ArtistProviderIds.GetHashCode();
                if (this.SongInfos != null)
                    hashCode = hashCode * 59 + this.SongInfos.GetHashCode();
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