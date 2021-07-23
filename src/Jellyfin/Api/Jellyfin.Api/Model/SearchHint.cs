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
    /// Class SearchHintResult.
    /// </summary>
    [DataContract]
    public partial class SearchHint :  IEquatable<SearchHint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHint" /> class.
        /// </summary>
        /// <param name="itemId">Gets or sets the item id..</param>
        /// <param name="id">id.</param>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="matchedTerm">Gets or sets the matched term..</param>
        /// <param name="indexNumber">Gets or sets the index number..</param>
        /// <param name="productionYear">Gets or sets the production year..</param>
        /// <param name="parentIndexNumber">Gets or sets the parent index number..</param>
        /// <param name="primaryImageTag">Gets or sets the image tag..</param>
        /// <param name="thumbImageTag">Gets or sets the thumb image tag..</param>
        /// <param name="thumbImageItemId">Gets or sets the thumb image item identifier..</param>
        /// <param name="backdropImageTag">Gets or sets the backdrop image tag..</param>
        /// <param name="backdropImageItemId">Gets or sets the backdrop image item identifier..</param>
        /// <param name="type">Gets or sets the type..</param>
        /// <param name="isFolder">isFolder.</param>
        /// <param name="runTimeTicks">Gets or sets the run time ticks..</param>
        /// <param name="mediaType">Gets or sets the type of the media..</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="series">Gets or sets the series..</param>
        /// <param name="status">status.</param>
        /// <param name="album">Gets or sets the album..</param>
        /// <param name="albumId">albumId.</param>
        /// <param name="albumArtist">Gets or sets the album artist..</param>
        /// <param name="artists">Gets or sets the artists..</param>
        /// <param name="songCount">Gets or sets the song count..</param>
        /// <param name="episodeCount">Gets or sets the episode count..</param>
        /// <param name="channelId">Gets or sets the channel identifier..</param>
        /// <param name="channelName">Gets or sets the name of the channel..</param>
        /// <param name="primaryImageAspectRatio">Gets or sets the primary image aspect ratio..</param>
        public SearchHint(Guid itemId = default(Guid), Guid id = default(Guid), string name = default(string), string matchedTerm = default(string), int? indexNumber = default(int?), int? productionYear = default(int?), int? parentIndexNumber = default(int?), string primaryImageTag = default(string), string thumbImageTag = default(string), string thumbImageItemId = default(string), string backdropImageTag = default(string), string backdropImageItemId = default(string), string type = default(string), bool? isFolder = default(bool?), long? runTimeTicks = default(long?), string mediaType = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string series = default(string), string status = default(string), string album = default(string), Guid albumId = default(Guid), string albumArtist = default(string), List<string> artists = default(List<string>), int? songCount = default(int?), int? episodeCount = default(int?), Guid channelId = default(Guid), string channelName = default(string), double? primaryImageAspectRatio = default(double?))
        {
            this.Name = name;
            this.MatchedTerm = matchedTerm;
            this.IndexNumber = indexNumber;
            this.ProductionYear = productionYear;
            this.ParentIndexNumber = parentIndexNumber;
            this.PrimaryImageTag = primaryImageTag;
            this.ThumbImageTag = thumbImageTag;
            this.ThumbImageItemId = thumbImageItemId;
            this.BackdropImageTag = backdropImageTag;
            this.BackdropImageItemId = backdropImageItemId;
            this.Type = type;
            this.IsFolder = isFolder;
            this.RunTimeTicks = runTimeTicks;
            this.MediaType = mediaType;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Series = series;
            this.Status = status;
            this.Album = album;
            this.AlbumArtist = albumArtist;
            this.Artists = artists;
            this.SongCount = songCount;
            this.EpisodeCount = episodeCount;
            this.ChannelName = channelName;
            this.PrimaryImageAspectRatio = primaryImageAspectRatio;
            this.ItemId = itemId;
            this.Id = id;
            this.Name = name;
            this.MatchedTerm = matchedTerm;
            this.IndexNumber = indexNumber;
            this.ProductionYear = productionYear;
            this.ParentIndexNumber = parentIndexNumber;
            this.PrimaryImageTag = primaryImageTag;
            this.ThumbImageTag = thumbImageTag;
            this.ThumbImageItemId = thumbImageItemId;
            this.BackdropImageTag = backdropImageTag;
            this.BackdropImageItemId = backdropImageItemId;
            this.Type = type;
            this.IsFolder = isFolder;
            this.RunTimeTicks = runTimeTicks;
            this.MediaType = mediaType;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Series = series;
            this.Status = status;
            this.Album = album;
            this.AlbumId = albumId;
            this.AlbumArtist = albumArtist;
            this.Artists = artists;
            this.SongCount = songCount;
            this.EpisodeCount = episodeCount;
            this.ChannelId = channelId;
            this.ChannelName = channelName;
            this.PrimaryImageAspectRatio = primaryImageAspectRatio;
        }

        /// <summary>
        /// Gets or sets the item id.
        /// </summary>
        /// <value>Gets or sets the item id.</value>
        [DataMember(Name="ItemId", EmitDefaultValue=false)]
        public Guid ItemId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name="Name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the matched term.
        /// </summary>
        /// <value>Gets or sets the matched term.</value>
        [DataMember(Name="MatchedTerm", EmitDefaultValue=true)]
        public string MatchedTerm { get; set; }

        /// <summary>
        /// Gets or sets the index number.
        /// </summary>
        /// <value>Gets or sets the index number.</value>
        [DataMember(Name="IndexNumber", EmitDefaultValue=true)]
        public int? IndexNumber { get; set; }

        /// <summary>
        /// Gets or sets the production year.
        /// </summary>
        /// <value>Gets or sets the production year.</value>
        [DataMember(Name="ProductionYear", EmitDefaultValue=true)]
        public int? ProductionYear { get; set; }

        /// <summary>
        /// Gets or sets the parent index number.
        /// </summary>
        /// <value>Gets or sets the parent index number.</value>
        [DataMember(Name="ParentIndexNumber", EmitDefaultValue=true)]
        public int? ParentIndexNumber { get; set; }

        /// <summary>
        /// Gets or sets the image tag.
        /// </summary>
        /// <value>Gets or sets the image tag.</value>
        [DataMember(Name="PrimaryImageTag", EmitDefaultValue=true)]
        public string PrimaryImageTag { get; set; }

        /// <summary>
        /// Gets or sets the thumb image tag.
        /// </summary>
        /// <value>Gets or sets the thumb image tag.</value>
        [DataMember(Name="ThumbImageTag", EmitDefaultValue=true)]
        public string ThumbImageTag { get; set; }

        /// <summary>
        /// Gets or sets the thumb image item identifier.
        /// </summary>
        /// <value>Gets or sets the thumb image item identifier.</value>
        [DataMember(Name="ThumbImageItemId", EmitDefaultValue=true)]
        public string ThumbImageItemId { get; set; }

        /// <summary>
        /// Gets or sets the backdrop image tag.
        /// </summary>
        /// <value>Gets or sets the backdrop image tag.</value>
        [DataMember(Name="BackdropImageTag", EmitDefaultValue=true)]
        public string BackdropImageTag { get; set; }

        /// <summary>
        /// Gets or sets the backdrop image item identifier.
        /// </summary>
        /// <value>Gets or sets the backdrop image item identifier.</value>
        [DataMember(Name="BackdropImageItemId", EmitDefaultValue=true)]
        public string BackdropImageItemId { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>Gets or sets the type.</value>
        [DataMember(Name="Type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets IsFolder
        /// </summary>
        [DataMember(Name="IsFolder", EmitDefaultValue=true)]
        public bool? IsFolder { get; set; }

        /// <summary>
        /// Gets or sets the run time ticks.
        /// </summary>
        /// <value>Gets or sets the run time ticks.</value>
        [DataMember(Name="RunTimeTicks", EmitDefaultValue=true)]
        public long? RunTimeTicks { get; set; }

        /// <summary>
        /// Gets or sets the type of the media.
        /// </summary>
        /// <value>Gets or sets the type of the media.</value>
        [DataMember(Name="MediaType", EmitDefaultValue=true)]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>Gets or sets the series.</value>
        [DataMember(Name="Series", EmitDefaultValue=true)]
        public string Series { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the album.
        /// </summary>
        /// <value>Gets or sets the album.</value>
        [DataMember(Name="Album", EmitDefaultValue=true)]
        public string Album { get; set; }

        /// <summary>
        /// Gets or Sets AlbumId
        /// </summary>
        [DataMember(Name="AlbumId", EmitDefaultValue=false)]
        public Guid AlbumId { get; set; }

        /// <summary>
        /// Gets or sets the album artist.
        /// </summary>
        /// <value>Gets or sets the album artist.</value>
        [DataMember(Name="AlbumArtist", EmitDefaultValue=true)]
        public string AlbumArtist { get; set; }

        /// <summary>
        /// Gets or sets the artists.
        /// </summary>
        /// <value>Gets or sets the artists.</value>
        [DataMember(Name="Artists", EmitDefaultValue=true)]
        public List<string> Artists { get; set; }

        /// <summary>
        /// Gets or sets the song count.
        /// </summary>
        /// <value>Gets or sets the song count.</value>
        [DataMember(Name="SongCount", EmitDefaultValue=true)]
        public int? SongCount { get; set; }

        /// <summary>
        /// Gets or sets the episode count.
        /// </summary>
        /// <value>Gets or sets the episode count.</value>
        [DataMember(Name="EpisodeCount", EmitDefaultValue=true)]
        public int? EpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the channel identifier.
        /// </summary>
        /// <value>Gets or sets the channel identifier.</value>
        [DataMember(Name="ChannelId", EmitDefaultValue=false)]
        public Guid ChannelId { get; set; }

        /// <summary>
        /// Gets or sets the name of the channel.
        /// </summary>
        /// <value>Gets or sets the name of the channel.</value>
        [DataMember(Name="ChannelName", EmitDefaultValue=true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Gets or sets the primary image aspect ratio.
        /// </summary>
        /// <value>Gets or sets the primary image aspect ratio.</value>
        [DataMember(Name="PrimaryImageAspectRatio", EmitDefaultValue=true)]
        public double? PrimaryImageAspectRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchHint {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MatchedTerm: ").Append(MatchedTerm).Append("\n");
            sb.Append("  IndexNumber: ").Append(IndexNumber).Append("\n");
            sb.Append("  ProductionYear: ").Append(ProductionYear).Append("\n");
            sb.Append("  ParentIndexNumber: ").Append(ParentIndexNumber).Append("\n");
            sb.Append("  PrimaryImageTag: ").Append(PrimaryImageTag).Append("\n");
            sb.Append("  ThumbImageTag: ").Append(ThumbImageTag).Append("\n");
            sb.Append("  ThumbImageItemId: ").Append(ThumbImageItemId).Append("\n");
            sb.Append("  BackdropImageTag: ").Append(BackdropImageTag).Append("\n");
            sb.Append("  BackdropImageItemId: ").Append(BackdropImageItemId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsFolder: ").Append(IsFolder).Append("\n");
            sb.Append("  RunTimeTicks: ").Append(RunTimeTicks).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Album: ").Append(Album).Append("\n");
            sb.Append("  AlbumId: ").Append(AlbumId).Append("\n");
            sb.Append("  AlbumArtist: ").Append(AlbumArtist).Append("\n");
            sb.Append("  Artists: ").Append(Artists).Append("\n");
            sb.Append("  SongCount: ").Append(SongCount).Append("\n");
            sb.Append("  EpisodeCount: ").Append(EpisodeCount).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  PrimaryImageAspectRatio: ").Append(PrimaryImageAspectRatio).Append("\n");
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
            return this.Equals(input as SearchHint);
        }

        /// <summary>
        /// Returns true if SearchHint instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchHint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchHint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
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
                    this.MatchedTerm == input.MatchedTerm ||
                    (this.MatchedTerm != null &&
                    this.MatchedTerm.Equals(input.MatchedTerm))
                ) && 
                (
                    this.IndexNumber == input.IndexNumber ||
                    (this.IndexNumber != null &&
                    this.IndexNumber.Equals(input.IndexNumber))
                ) && 
                (
                    this.ProductionYear == input.ProductionYear ||
                    (this.ProductionYear != null &&
                    this.ProductionYear.Equals(input.ProductionYear))
                ) && 
                (
                    this.ParentIndexNumber == input.ParentIndexNumber ||
                    (this.ParentIndexNumber != null &&
                    this.ParentIndexNumber.Equals(input.ParentIndexNumber))
                ) && 
                (
                    this.PrimaryImageTag == input.PrimaryImageTag ||
                    (this.PrimaryImageTag != null &&
                    this.PrimaryImageTag.Equals(input.PrimaryImageTag))
                ) && 
                (
                    this.ThumbImageTag == input.ThumbImageTag ||
                    (this.ThumbImageTag != null &&
                    this.ThumbImageTag.Equals(input.ThumbImageTag))
                ) && 
                (
                    this.ThumbImageItemId == input.ThumbImageItemId ||
                    (this.ThumbImageItemId != null &&
                    this.ThumbImageItemId.Equals(input.ThumbImageItemId))
                ) && 
                (
                    this.BackdropImageTag == input.BackdropImageTag ||
                    (this.BackdropImageTag != null &&
                    this.BackdropImageTag.Equals(input.BackdropImageTag))
                ) && 
                (
                    this.BackdropImageItemId == input.BackdropImageItemId ||
                    (this.BackdropImageItemId != null &&
                    this.BackdropImageItemId.Equals(input.BackdropImageItemId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsFolder == input.IsFolder ||
                    (this.IsFolder != null &&
                    this.IsFolder.Equals(input.IsFolder))
                ) && 
                (
                    this.RunTimeTicks == input.RunTimeTicks ||
                    (this.RunTimeTicks != null &&
                    this.RunTimeTicks.Equals(input.RunTimeTicks))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Series == input.Series ||
                    (this.Series != null &&
                    this.Series.Equals(input.Series))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Album == input.Album ||
                    (this.Album != null &&
                    this.Album.Equals(input.Album))
                ) && 
                (
                    this.AlbumId == input.AlbumId ||
                    (this.AlbumId != null &&
                    this.AlbumId.Equals(input.AlbumId))
                ) && 
                (
                    this.AlbumArtist == input.AlbumArtist ||
                    (this.AlbumArtist != null &&
                    this.AlbumArtist.Equals(input.AlbumArtist))
                ) && 
                (
                    this.Artists == input.Artists ||
                    this.Artists != null &&
                    input.Artists != null &&
                    this.Artists.SequenceEqual(input.Artists)
                ) && 
                (
                    this.SongCount == input.SongCount ||
                    (this.SongCount != null &&
                    this.SongCount.Equals(input.SongCount))
                ) && 
                (
                    this.EpisodeCount == input.EpisodeCount ||
                    (this.EpisodeCount != null &&
                    this.EpisodeCount.Equals(input.EpisodeCount))
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.PrimaryImageAspectRatio == input.PrimaryImageAspectRatio ||
                    (this.PrimaryImageAspectRatio != null &&
                    this.PrimaryImageAspectRatio.Equals(input.PrimaryImageAspectRatio))
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MatchedTerm != null)
                    hashCode = hashCode * 59 + this.MatchedTerm.GetHashCode();
                if (this.IndexNumber != null)
                    hashCode = hashCode * 59 + this.IndexNumber.GetHashCode();
                if (this.ProductionYear != null)
                    hashCode = hashCode * 59 + this.ProductionYear.GetHashCode();
                if (this.ParentIndexNumber != null)
                    hashCode = hashCode * 59 + this.ParentIndexNumber.GetHashCode();
                if (this.PrimaryImageTag != null)
                    hashCode = hashCode * 59 + this.PrimaryImageTag.GetHashCode();
                if (this.ThumbImageTag != null)
                    hashCode = hashCode * 59 + this.ThumbImageTag.GetHashCode();
                if (this.ThumbImageItemId != null)
                    hashCode = hashCode * 59 + this.ThumbImageItemId.GetHashCode();
                if (this.BackdropImageTag != null)
                    hashCode = hashCode * 59 + this.BackdropImageTag.GetHashCode();
                if (this.BackdropImageItemId != null)
                    hashCode = hashCode * 59 + this.BackdropImageItemId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsFolder != null)
                    hashCode = hashCode * 59 + this.IsFolder.GetHashCode();
                if (this.RunTimeTicks != null)
                    hashCode = hashCode * 59 + this.RunTimeTicks.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Series != null)
                    hashCode = hashCode * 59 + this.Series.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Album != null)
                    hashCode = hashCode * 59 + this.Album.GetHashCode();
                if (this.AlbumId != null)
                    hashCode = hashCode * 59 + this.AlbumId.GetHashCode();
                if (this.AlbumArtist != null)
                    hashCode = hashCode * 59 + this.AlbumArtist.GetHashCode();
                if (this.Artists != null)
                    hashCode = hashCode * 59 + this.Artists.GetHashCode();
                if (this.SongCount != null)
                    hashCode = hashCode * 59 + this.SongCount.GetHashCode();
                if (this.EpisodeCount != null)
                    hashCode = hashCode * 59 + this.EpisodeCount.GetHashCode();
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.ChannelName != null)
                    hashCode = hashCode * 59 + this.ChannelName.GetHashCode();
                if (this.PrimaryImageAspectRatio != null)
                    hashCode = hashCode * 59 + this.PrimaryImageAspectRatio.GetHashCode();
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