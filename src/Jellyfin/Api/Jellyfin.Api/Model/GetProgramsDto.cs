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
    /// Get programs dto.
    /// </summary>
    [DataContract]
    public partial class GetProgramsDto :  IEquatable<GetProgramsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProgramsDto" /> class.
        /// </summary>
        /// <param name="channelIds">Gets or sets the channels to return guide information for..</param>
        /// <param name="userId">Gets or sets optional. Filter by user id..</param>
        /// <param name="minStartDate">Gets or sets the minimum premiere start date.  Optional..</param>
        /// <param name="hasAired">Gets or sets filter by programs that have completed airing, or not.  Optional..</param>
        /// <param name="isAiring">Gets or sets filter by programs that are currently airing, or not.  Optional..</param>
        /// <param name="maxStartDate">Gets or sets the maximum premiere start date.  Optional..</param>
        /// <param name="minEndDate">Gets or sets the minimum premiere end date.  Optional..</param>
        /// <param name="maxEndDate">Gets or sets the maximum premiere end date.  Optional..</param>
        /// <param name="isMovie">Gets or sets filter for movies.  Optional..</param>
        /// <param name="isSeries">Gets or sets filter for series.  Optional..</param>
        /// <param name="isNews">Gets or sets filter for news.  Optional..</param>
        /// <param name="isKids">Gets or sets filter for kids.  Optional..</param>
        /// <param name="isSports">Gets or sets filter for sports.  Optional..</param>
        /// <param name="startIndex">Gets or sets the record index to start at. All items with a lower index will be dropped from the results.  Optional..</param>
        /// <param name="limit">Gets or sets the maximum number of records to return.  Optional..</param>
        /// <param name="sortBy">Gets or sets specify one or more sort orders, comma delimited. Options: Name, StartDate.  Optional..</param>
        /// <param name="sortOrder">Gets or sets sort Order - Ascending,Descending..</param>
        /// <param name="genres">Gets or sets the genres to return guide information for..</param>
        /// <param name="genreIds">Gets or sets the genre ids to return guide information for..</param>
        /// <param name="enableImages">Gets or sets include image information in output.  Optional..</param>
        /// <param name="enableTotalRecordCount">Gets or sets a value indicating whether retrieve total record count..</param>
        /// <param name="imageTypeLimit">Gets or sets the max number of images to return, per image type.  Optional..</param>
        /// <param name="enableImageTypes">Gets or sets the image types to include in the output.  Optional..</param>
        /// <param name="enableUserData">Gets or sets include user data.  Optional..</param>
        /// <param name="seriesTimerId">Gets or sets filter by series timer id.  Optional..</param>
        /// <param name="librarySeriesId">Gets or sets filter by library series id.  Optional..</param>
        /// <param name="fields">Gets or sets specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines.  Optional..</param>
        public GetProgramsDto(List<Guid> channelIds = default(List<Guid>), Guid userId = default(Guid), DateTime? minStartDate = default(DateTime?), bool? hasAired = default(bool?), bool? isAiring = default(bool?), DateTime? maxStartDate = default(DateTime?), DateTime? minEndDate = default(DateTime?), DateTime? maxEndDate = default(DateTime?), bool? isMovie = default(bool?), bool? isSeries = default(bool?), bool? isNews = default(bool?), bool? isKids = default(bool?), bool? isSports = default(bool?), int? startIndex = default(int?), int? limit = default(int?), List<string> sortBy = default(List<string>), List<SortOrder> sortOrder = default(List<SortOrder>), List<string> genres = default(List<string>), List<Guid> genreIds = default(List<Guid>), bool? enableImages = default(bool?), bool enableTotalRecordCount = default(bool), int? imageTypeLimit = default(int?), List<ImageType> enableImageTypes = default(List<ImageType>), bool? enableUserData = default(bool?), string seriesTimerId = default(string), Guid librarySeriesId = default(Guid), List<ItemFields> fields = default(List<ItemFields>))
        {
            this.ChannelIds = channelIds;
            this.MinStartDate = minStartDate;
            this.HasAired = hasAired;
            this.IsAiring = isAiring;
            this.MaxStartDate = maxStartDate;
            this.MinEndDate = minEndDate;
            this.MaxEndDate = maxEndDate;
            this.IsMovie = isMovie;
            this.IsSeries = isSeries;
            this.IsNews = isNews;
            this.IsKids = isKids;
            this.IsSports = isSports;
            this.StartIndex = startIndex;
            this.Limit = limit;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.Genres = genres;
            this.GenreIds = genreIds;
            this.EnableImages = enableImages;
            this.ImageTypeLimit = imageTypeLimit;
            this.EnableImageTypes = enableImageTypes;
            this.EnableUserData = enableUserData;
            this.SeriesTimerId = seriesTimerId;
            this.Fields = fields;
            this.ChannelIds = channelIds;
            this.UserId = userId;
            this.MinStartDate = minStartDate;
            this.HasAired = hasAired;
            this.IsAiring = isAiring;
            this.MaxStartDate = maxStartDate;
            this.MinEndDate = minEndDate;
            this.MaxEndDate = maxEndDate;
            this.IsMovie = isMovie;
            this.IsSeries = isSeries;
            this.IsNews = isNews;
            this.IsKids = isKids;
            this.IsSports = isSports;
            this.StartIndex = startIndex;
            this.Limit = limit;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.Genres = genres;
            this.GenreIds = genreIds;
            this.EnableImages = enableImages;
            this.EnableTotalRecordCount = enableTotalRecordCount;
            this.ImageTypeLimit = imageTypeLimit;
            this.EnableImageTypes = enableImageTypes;
            this.EnableUserData = enableUserData;
            this.SeriesTimerId = seriesTimerId;
            this.LibrarySeriesId = librarySeriesId;
            this.Fields = fields;
        }

        /// <summary>
        /// Gets or sets the channels to return guide information for.
        /// </summary>
        /// <value>Gets or sets the channels to return guide information for.</value>
        [DataMember(Name="ChannelIds", EmitDefaultValue=true)]
        public List<Guid> ChannelIds { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by user id.
        /// </summary>
        /// <value>Gets or sets optional. Filter by user id.</value>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the minimum premiere start date.  Optional.
        /// </summary>
        /// <value>Gets or sets the minimum premiere start date.  Optional.</value>
        [DataMember(Name="MinStartDate", EmitDefaultValue=true)]
        public DateTime? MinStartDate { get; set; }

        /// <summary>
        /// Gets or sets filter by programs that have completed airing, or not.  Optional.
        /// </summary>
        /// <value>Gets or sets filter by programs that have completed airing, or not.  Optional.</value>
        [DataMember(Name="HasAired", EmitDefaultValue=true)]
        public bool? HasAired { get; set; }

        /// <summary>
        /// Gets or sets filter by programs that are currently airing, or not.  Optional.
        /// </summary>
        /// <value>Gets or sets filter by programs that are currently airing, or not.  Optional.</value>
        [DataMember(Name="IsAiring", EmitDefaultValue=true)]
        public bool? IsAiring { get; set; }

        /// <summary>
        /// Gets or sets the maximum premiere start date.  Optional.
        /// </summary>
        /// <value>Gets or sets the maximum premiere start date.  Optional.</value>
        [DataMember(Name="MaxStartDate", EmitDefaultValue=true)]
        public DateTime? MaxStartDate { get; set; }

        /// <summary>
        /// Gets or sets the minimum premiere end date.  Optional.
        /// </summary>
        /// <value>Gets or sets the minimum premiere end date.  Optional.</value>
        [DataMember(Name="MinEndDate", EmitDefaultValue=true)]
        public DateTime? MinEndDate { get; set; }

        /// <summary>
        /// Gets or sets the maximum premiere end date.  Optional.
        /// </summary>
        /// <value>Gets or sets the maximum premiere end date.  Optional.</value>
        [DataMember(Name="MaxEndDate", EmitDefaultValue=true)]
        public DateTime? MaxEndDate { get; set; }

        /// <summary>
        /// Gets or sets filter for movies.  Optional.
        /// </summary>
        /// <value>Gets or sets filter for movies.  Optional.</value>
        [DataMember(Name="IsMovie", EmitDefaultValue=true)]
        public bool? IsMovie { get; set; }

        /// <summary>
        /// Gets or sets filter for series.  Optional.
        /// </summary>
        /// <value>Gets or sets filter for series.  Optional.</value>
        [DataMember(Name="IsSeries", EmitDefaultValue=true)]
        public bool? IsSeries { get; set; }

        /// <summary>
        /// Gets or sets filter for news.  Optional.
        /// </summary>
        /// <value>Gets or sets filter for news.  Optional.</value>
        [DataMember(Name="IsNews", EmitDefaultValue=true)]
        public bool? IsNews { get; set; }

        /// <summary>
        /// Gets or sets filter for kids.  Optional.
        /// </summary>
        /// <value>Gets or sets filter for kids.  Optional.</value>
        [DataMember(Name="IsKids", EmitDefaultValue=true)]
        public bool? IsKids { get; set; }

        /// <summary>
        /// Gets or sets filter for sports.  Optional.
        /// </summary>
        /// <value>Gets or sets filter for sports.  Optional.</value>
        [DataMember(Name="IsSports", EmitDefaultValue=true)]
        public bool? IsSports { get; set; }

        /// <summary>
        /// Gets or sets the record index to start at. All items with a lower index will be dropped from the results.  Optional.
        /// </summary>
        /// <value>Gets or sets the record index to start at. All items with a lower index will be dropped from the results.  Optional.</value>
        [DataMember(Name="StartIndex", EmitDefaultValue=true)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of records to return.  Optional.
        /// </summary>
        /// <value>Gets or sets the maximum number of records to return.  Optional.</value>
        [DataMember(Name="Limit", EmitDefaultValue=true)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets specify one or more sort orders, comma delimited. Options: Name, StartDate.  Optional.
        /// </summary>
        /// <value>Gets or sets specify one or more sort orders, comma delimited. Options: Name, StartDate.  Optional.</value>
        [DataMember(Name="SortBy", EmitDefaultValue=true)]
        public List<string> SortBy { get; set; }

        /// <summary>
        /// Gets or sets sort Order - Ascending,Descending.
        /// </summary>
        /// <value>Gets or sets sort Order - Ascending,Descending.</value>
        [DataMember(Name="SortOrder", EmitDefaultValue=true)]
        public List<SortOrder> SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the genres to return guide information for.
        /// </summary>
        /// <value>Gets or sets the genres to return guide information for.</value>
        [DataMember(Name="Genres", EmitDefaultValue=true)]
        public List<string> Genres { get; set; }

        /// <summary>
        /// Gets or sets the genre ids to return guide information for.
        /// </summary>
        /// <value>Gets or sets the genre ids to return guide information for.</value>
        [DataMember(Name="GenreIds", EmitDefaultValue=true)]
        public List<Guid> GenreIds { get; set; }

        /// <summary>
        /// Gets or sets include image information in output.  Optional.
        /// </summary>
        /// <value>Gets or sets include image information in output.  Optional.</value>
        [DataMember(Name="EnableImages", EmitDefaultValue=true)]
        public bool? EnableImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether retrieve total record count.
        /// </summary>
        /// <value>Gets or sets a value indicating whether retrieve total record count.</value>
        [DataMember(Name="EnableTotalRecordCount", EmitDefaultValue=false)]
        public bool EnableTotalRecordCount { get; set; }

        /// <summary>
        /// Gets or sets the max number of images to return, per image type.  Optional.
        /// </summary>
        /// <value>Gets or sets the max number of images to return, per image type.  Optional.</value>
        [DataMember(Name="ImageTypeLimit", EmitDefaultValue=true)]
        public int? ImageTypeLimit { get; set; }

        /// <summary>
        /// Gets or sets the image types to include in the output.  Optional.
        /// </summary>
        /// <value>Gets or sets the image types to include in the output.  Optional.</value>
        [DataMember(Name="EnableImageTypes", EmitDefaultValue=true)]
        public List<ImageType> EnableImageTypes { get; set; }

        /// <summary>
        /// Gets or sets include user data.  Optional.
        /// </summary>
        /// <value>Gets or sets include user data.  Optional.</value>
        [DataMember(Name="EnableUserData", EmitDefaultValue=true)]
        public bool? EnableUserData { get; set; }

        /// <summary>
        /// Gets or sets filter by series timer id.  Optional.
        /// </summary>
        /// <value>Gets or sets filter by series timer id.  Optional.</value>
        [DataMember(Name="SeriesTimerId", EmitDefaultValue=true)]
        public string SeriesTimerId { get; set; }

        /// <summary>
        /// Gets or sets filter by library series id.  Optional.
        /// </summary>
        /// <value>Gets or sets filter by library series id.  Optional.</value>
        [DataMember(Name="LibrarySeriesId", EmitDefaultValue=false)]
        public Guid LibrarySeriesId { get; set; }

        /// <summary>
        /// Gets or sets specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines.  Optional.
        /// </summary>
        /// <value>Gets or sets specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines.  Optional.</value>
        [DataMember(Name="Fields", EmitDefaultValue=true)]
        public List<ItemFields> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProgramsDto {\n");
            sb.Append("  ChannelIds: ").Append(ChannelIds).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  MinStartDate: ").Append(MinStartDate).Append("\n");
            sb.Append("  HasAired: ").Append(HasAired).Append("\n");
            sb.Append("  IsAiring: ").Append(IsAiring).Append("\n");
            sb.Append("  MaxStartDate: ").Append(MaxStartDate).Append("\n");
            sb.Append("  MinEndDate: ").Append(MinEndDate).Append("\n");
            sb.Append("  MaxEndDate: ").Append(MaxEndDate).Append("\n");
            sb.Append("  IsMovie: ").Append(IsMovie).Append("\n");
            sb.Append("  IsSeries: ").Append(IsSeries).Append("\n");
            sb.Append("  IsNews: ").Append(IsNews).Append("\n");
            sb.Append("  IsKids: ").Append(IsKids).Append("\n");
            sb.Append("  IsSports: ").Append(IsSports).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  GenreIds: ").Append(GenreIds).Append("\n");
            sb.Append("  EnableImages: ").Append(EnableImages).Append("\n");
            sb.Append("  EnableTotalRecordCount: ").Append(EnableTotalRecordCount).Append("\n");
            sb.Append("  ImageTypeLimit: ").Append(ImageTypeLimit).Append("\n");
            sb.Append("  EnableImageTypes: ").Append(EnableImageTypes).Append("\n");
            sb.Append("  EnableUserData: ").Append(EnableUserData).Append("\n");
            sb.Append("  SeriesTimerId: ").Append(SeriesTimerId).Append("\n");
            sb.Append("  LibrarySeriesId: ").Append(LibrarySeriesId).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as GetProgramsDto);
        }

        /// <summary>
        /// Returns true if GetProgramsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProgramsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProgramsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelIds == input.ChannelIds ||
                    this.ChannelIds != null &&
                    input.ChannelIds != null &&
                    this.ChannelIds.SequenceEqual(input.ChannelIds)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.MinStartDate == input.MinStartDate ||
                    (this.MinStartDate != null &&
                    this.MinStartDate.Equals(input.MinStartDate))
                ) && 
                (
                    this.HasAired == input.HasAired ||
                    (this.HasAired != null &&
                    this.HasAired.Equals(input.HasAired))
                ) && 
                (
                    this.IsAiring == input.IsAiring ||
                    (this.IsAiring != null &&
                    this.IsAiring.Equals(input.IsAiring))
                ) && 
                (
                    this.MaxStartDate == input.MaxStartDate ||
                    (this.MaxStartDate != null &&
                    this.MaxStartDate.Equals(input.MaxStartDate))
                ) && 
                (
                    this.MinEndDate == input.MinEndDate ||
                    (this.MinEndDate != null &&
                    this.MinEndDate.Equals(input.MinEndDate))
                ) && 
                (
                    this.MaxEndDate == input.MaxEndDate ||
                    (this.MaxEndDate != null &&
                    this.MaxEndDate.Equals(input.MaxEndDate))
                ) && 
                (
                    this.IsMovie == input.IsMovie ||
                    (this.IsMovie != null &&
                    this.IsMovie.Equals(input.IsMovie))
                ) && 
                (
                    this.IsSeries == input.IsSeries ||
                    (this.IsSeries != null &&
                    this.IsSeries.Equals(input.IsSeries))
                ) && 
                (
                    this.IsNews == input.IsNews ||
                    (this.IsNews != null &&
                    this.IsNews.Equals(input.IsNews))
                ) && 
                (
                    this.IsKids == input.IsKids ||
                    (this.IsKids != null &&
                    this.IsKids.Equals(input.IsKids))
                ) && 
                (
                    this.IsSports == input.IsSports ||
                    (this.IsSports != null &&
                    this.IsSports.Equals(input.IsSports))
                ) && 
                (
                    this.StartIndex == input.StartIndex ||
                    (this.StartIndex != null &&
                    this.StartIndex.Equals(input.StartIndex))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    this.SortBy != null &&
                    input.SortBy != null &&
                    this.SortBy.SequenceEqual(input.SortBy)
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder != null &&
                    input.SortOrder != null &&
                    this.SortOrder.SequenceEqual(input.SortOrder)
                ) && 
                (
                    this.Genres == input.Genres ||
                    this.Genres != null &&
                    input.Genres != null &&
                    this.Genres.SequenceEqual(input.Genres)
                ) && 
                (
                    this.GenreIds == input.GenreIds ||
                    this.GenreIds != null &&
                    input.GenreIds != null &&
                    this.GenreIds.SequenceEqual(input.GenreIds)
                ) && 
                (
                    this.EnableImages == input.EnableImages ||
                    (this.EnableImages != null &&
                    this.EnableImages.Equals(input.EnableImages))
                ) && 
                (
                    this.EnableTotalRecordCount == input.EnableTotalRecordCount ||
                    (this.EnableTotalRecordCount != null &&
                    this.EnableTotalRecordCount.Equals(input.EnableTotalRecordCount))
                ) && 
                (
                    this.ImageTypeLimit == input.ImageTypeLimit ||
                    (this.ImageTypeLimit != null &&
                    this.ImageTypeLimit.Equals(input.ImageTypeLimit))
                ) && 
                (
                    this.EnableImageTypes == input.EnableImageTypes ||
                    this.EnableImageTypes != null &&
                    input.EnableImageTypes != null &&
                    this.EnableImageTypes.SequenceEqual(input.EnableImageTypes)
                ) && 
                (
                    this.EnableUserData == input.EnableUserData ||
                    (this.EnableUserData != null &&
                    this.EnableUserData.Equals(input.EnableUserData))
                ) && 
                (
                    this.SeriesTimerId == input.SeriesTimerId ||
                    (this.SeriesTimerId != null &&
                    this.SeriesTimerId.Equals(input.SeriesTimerId))
                ) && 
                (
                    this.LibrarySeriesId == input.LibrarySeriesId ||
                    (this.LibrarySeriesId != null &&
                    this.LibrarySeriesId.Equals(input.LibrarySeriesId))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.ChannelIds != null)
                    hashCode = hashCode * 59 + this.ChannelIds.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.MinStartDate != null)
                    hashCode = hashCode * 59 + this.MinStartDate.GetHashCode();
                if (this.HasAired != null)
                    hashCode = hashCode * 59 + this.HasAired.GetHashCode();
                if (this.IsAiring != null)
                    hashCode = hashCode * 59 + this.IsAiring.GetHashCode();
                if (this.MaxStartDate != null)
                    hashCode = hashCode * 59 + this.MaxStartDate.GetHashCode();
                if (this.MinEndDate != null)
                    hashCode = hashCode * 59 + this.MinEndDate.GetHashCode();
                if (this.MaxEndDate != null)
                    hashCode = hashCode * 59 + this.MaxEndDate.GetHashCode();
                if (this.IsMovie != null)
                    hashCode = hashCode * 59 + this.IsMovie.GetHashCode();
                if (this.IsSeries != null)
                    hashCode = hashCode * 59 + this.IsSeries.GetHashCode();
                if (this.IsNews != null)
                    hashCode = hashCode * 59 + this.IsNews.GetHashCode();
                if (this.IsKids != null)
                    hashCode = hashCode * 59 + this.IsKids.GetHashCode();
                if (this.IsSports != null)
                    hashCode = hashCode * 59 + this.IsSports.GetHashCode();
                if (this.StartIndex != null)
                    hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Genres != null)
                    hashCode = hashCode * 59 + this.Genres.GetHashCode();
                if (this.GenreIds != null)
                    hashCode = hashCode * 59 + this.GenreIds.GetHashCode();
                if (this.EnableImages != null)
                    hashCode = hashCode * 59 + this.EnableImages.GetHashCode();
                if (this.EnableTotalRecordCount != null)
                    hashCode = hashCode * 59 + this.EnableTotalRecordCount.GetHashCode();
                if (this.ImageTypeLimit != null)
                    hashCode = hashCode * 59 + this.ImageTypeLimit.GetHashCode();
                if (this.EnableImageTypes != null)
                    hashCode = hashCode * 59 + this.EnableImageTypes.GetHashCode();
                if (this.EnableUserData != null)
                    hashCode = hashCode * 59 + this.EnableUserData.GetHashCode();
                if (this.SeriesTimerId != null)
                    hashCode = hashCode * 59 + this.SeriesTimerId.GetHashCode();
                if (this.LibrarySeriesId != null)
                    hashCode = hashCode * 59 + this.LibrarySeriesId.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
