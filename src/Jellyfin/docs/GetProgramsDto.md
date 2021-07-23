
# Jellyfin.Api.Model.GetProgramsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelIds** | **List&lt;Guid&gt;** | Gets or sets the channels to return guide information for. | [optional] 
**UserId** | **Guid** | Gets or sets optional. Filter by user id. | [optional] 
**MinStartDate** | **DateTime?** | Gets or sets the minimum premiere start date.  Optional. | [optional] 
**HasAired** | **bool?** | Gets or sets filter by programs that have completed airing, or not.  Optional. | [optional] 
**IsAiring** | **bool?** | Gets or sets filter by programs that are currently airing, or not.  Optional. | [optional] 
**MaxStartDate** | **DateTime?** | Gets or sets the maximum premiere start date.  Optional. | [optional] 
**MinEndDate** | **DateTime?** | Gets or sets the minimum premiere end date.  Optional. | [optional] 
**MaxEndDate** | **DateTime?** | Gets or sets the maximum premiere end date.  Optional. | [optional] 
**IsMovie** | **bool?** | Gets or sets filter for movies.  Optional. | [optional] 
**IsSeries** | **bool?** | Gets or sets filter for series.  Optional. | [optional] 
**IsNews** | **bool?** | Gets or sets filter for news.  Optional. | [optional] 
**IsKids** | **bool?** | Gets or sets filter for kids.  Optional. | [optional] 
**IsSports** | **bool?** | Gets or sets filter for sports.  Optional. | [optional] 
**StartIndex** | **int?** | Gets or sets the record index to start at. All items with a lower index will be dropped from the results.  Optional. | [optional] 
**Limit** | **int?** | Gets or sets the maximum number of records to return.  Optional. | [optional] 
**SortBy** | **List&lt;string&gt;** | Gets or sets specify one or more sort orders, comma delimited. Options: Name, StartDate.  Optional. | [optional] 
**SortOrder** | [**List&lt;SortOrder&gt;**](SortOrder.md) | Gets or sets sort Order - Ascending,Descending. | [optional] 
**Genres** | **List&lt;string&gt;** | Gets or sets the genres to return guide information for. | [optional] 
**GenreIds** | **List&lt;Guid&gt;** | Gets or sets the genre ids to return guide information for. | [optional] 
**EnableImages** | **bool?** | Gets or sets include image information in output.  Optional. | [optional] 
**EnableTotalRecordCount** | **bool** | Gets or sets a value indicating whether retrieve total record count. | [optional] 
**ImageTypeLimit** | **int?** | Gets or sets the max number of images to return, per image type.  Optional. | [optional] 
**EnableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md) | Gets or sets the image types to include in the output.  Optional. | [optional] 
**EnableUserData** | **bool?** | Gets or sets include user data.  Optional. | [optional] 
**SeriesTimerId** | **string** | Gets or sets filter by series timer id.  Optional. | [optional] 
**LibrarySeriesId** | **Guid** | Gets or sets filter by library series id.  Optional. | [optional] 
**Fields** | [**List&lt;ItemFields&gt;**](ItemFields.md) | Gets or sets specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines.  Optional. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

