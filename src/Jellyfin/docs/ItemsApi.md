# Jellyfin.Api.Api.ItemsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItems**](ItemsApi.md#getitems) | **GET** /Items | Gets items based on a query.
[**GetItemsByUserId**](ItemsApi.md#getitemsbyuserid) | **GET** /Users/{userId}/Items | Gets items based on a query.
[**GetResumeItems**](ItemsApi.md#getresumeitems) | **GET** /Users/{userId}/Items/Resume | Gets items based on a query.



## GetItems

> BaseItemDtoQueryResult GetItems (Guid? userId = null, string maxOfficialRating = null, bool? hasThemeSong = null, bool? hasThemeVideo = null, bool? hasSubtitles = null, bool? hasSpecialFeature = null, bool? hasTrailer = null, string adjacentTo = null, int? parentIndexNumber = null, bool? hasParentalRating = null, bool? isHd = null, bool? is4K = null, List<LocationType> locationTypes = null, List<LocationType> excludeLocationTypes = null, bool? isMissing = null, bool? isUnaired = null, double? minCommunityRating = null, double? minCriticRating = null, DateTime? minPremiereDate = null, DateTime? minDateLastSaved = null, DateTime? minDateLastSavedForUser = null, DateTime? maxPremiereDate = null, bool? hasOverview = null, bool? hasImdbId = null, bool? hasTmdbId = null, bool? hasTvdbId = null, List<Guid> excludeItemIds = null, int? startIndex = null, int? limit = null, bool? recursive = null, string searchTerm = null, List<SortOrder> sortOrder = null, Guid? parentId = null, List<ItemFields> fields = null, List<string> excludeItemTypes = null, List<string> includeItemTypes = null, List<ItemFilter> filters = null, bool? isFavorite = null, List<string> mediaTypes = null, List<ImageType> imageTypes = null, List<string> sortBy = null, bool? isPlayed = null, List<string> genres = null, List<string> officialRatings = null, List<string> tags = null, List<int> years = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, string person = null, List<Guid> personIds = null, List<string> personTypes = null, List<string> studios = null, List<string> artists = null, List<Guid> excludeArtistIds = null, List<Guid> artistIds = null, List<Guid> albumArtistIds = null, List<Guid> contributingArtistIds = null, List<string> albums = null, List<Guid> albumIds = null, List<Guid> ids = null, List<VideoType> videoTypes = null, string minOfficialRating = null, bool? isLocked = null, bool? isPlaceHolder = null, bool? hasOfficialRating = null, bool? collapseBoxSetItems = null, int? minWidth = null, int? minHeight = null, int? maxWidth = null, int? maxHeight = null, bool? is3D = null, List<SeriesStatus> seriesStatus = null, string nameStartsWithOrGreater = null, string nameStartsWith = null, string nameLessThan = null, List<Guid> studioIds = null, List<Guid> genreIds = null, bool? enableTotalRecordCount = null, bool? enableImages = null)

Gets items based on a query.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ItemsApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | The user id supplied as query parameter. (optional) 
            var maxOfficialRating = maxOfficialRating_example;  // string | Optional filter by maximum official rating (PG, PG-13, TV-MA, etc). (optional) 
            var hasThemeSong = true;  // bool? | Optional filter by items with theme songs. (optional) 
            var hasThemeVideo = true;  // bool? | Optional filter by items with theme videos. (optional) 
            var hasSubtitles = true;  // bool? | Optional filter by items with subtitles. (optional) 
            var hasSpecialFeature = true;  // bool? | Optional filter by items with special features. (optional) 
            var hasTrailer = true;  // bool? | Optional filter by items with trailers. (optional) 
            var adjacentTo = adjacentTo_example;  // string | Optional. Return items that are siblings of a supplied item. (optional) 
            var parentIndexNumber = 56;  // int? | Optional filter by parent index number. (optional) 
            var hasParentalRating = true;  // bool? | Optional filter by items that have or do not have a parental rating. (optional) 
            var isHd = true;  // bool? | Optional filter by items that are HD or not. (optional) 
            var is4K = true;  // bool? | Optional filter by items that are 4K or not. (optional) 
            var locationTypes = new List<LocationType>(); // List<LocationType> | Optional. If specified, results will be filtered based on LocationType. This allows multiple, comma delimited. (optional) 
            var excludeLocationTypes = new List<LocationType>(); // List<LocationType> | Optional. If specified, results will be filtered based on the LocationType. This allows multiple, comma delimited. (optional) 
            var isMissing = true;  // bool? | Optional filter by items that are missing episodes or not. (optional) 
            var isUnaired = true;  // bool? | Optional filter by items that are unaired episodes or not. (optional) 
            var minCommunityRating = 1.2D;  // double? | Optional filter by minimum community rating. (optional) 
            var minCriticRating = 1.2D;  // double? | Optional filter by minimum critic rating. (optional) 
            var minPremiereDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum premiere date. Format = ISO. (optional) 
            var minDateLastSaved = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum last saved date. Format = ISO. (optional) 
            var minDateLastSavedForUser = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum last saved date for the current user. Format = ISO. (optional) 
            var maxPremiereDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The maximum premiere date. Format = ISO. (optional) 
            var hasOverview = true;  // bool? | Optional filter by items that have an overview or not. (optional) 
            var hasImdbId = true;  // bool? | Optional filter by items that have an imdb id or not. (optional) 
            var hasTmdbId = true;  // bool? | Optional filter by items that have a tmdb id or not. (optional) 
            var hasTvdbId = true;  // bool? | Optional filter by items that have a tvdb id or not. (optional) 
            var excludeItemIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered by excluding item ids. This allows multiple, comma delimited. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var recursive = true;  // bool? | When searching within folders, this determines whether or not the search will be recursive. true/false. (optional) 
            var searchTerm = searchTerm_example;  // string | Optional. Filter based on a search term. (optional) 
            var sortOrder = new List<SortOrder>(); // List<SortOrder> | Sort Order - Ascending,Descending. (optional) 
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines. (optional) 
            var excludeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on the item type. This allows multiple, comma delimited. (optional) 
            var filters = new List<ItemFilter>(); // List<ItemFilter> | Optional. Specify additional filters to apply. This allows multiple, comma delimited. Options: IsFolder, IsNotFolder, IsUnplayed, IsPlayed, IsFavorite, IsResumable, Likes, Dislikes. (optional) 
            var isFavorite = true;  // bool? | Optional filter by items that are marked as favorite, or not. (optional) 
            var mediaTypes = new List<string>(); // List<string> | Optional filter by MediaType. Allows multiple, comma delimited. (optional) 
            var imageTypes = new List<ImageType>(); // List<ImageType> | Optional. If specified, results will be filtered based on those containing image types. This allows multiple, comma delimited. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. (optional) 
            var isPlayed = true;  // bool? | Optional filter by items that are played, or not. (optional) 
            var genres = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimited. (optional) 
            var officialRatings = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimited. (optional) 
            var tags = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimited. (optional) 
            var years = new List<int>(); // List<int> | Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimited. (optional) 
            var enableUserData = true;  // bool? | Optional, include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional, the max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var person = person_example;  // string | Optional. If specified, results will be filtered to include only those containing the specified person. (optional) 
            var personIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified person id. (optional) 
            var personTypes = new List<string>(); // List<string> | Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited. (optional) 
            var studios = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimited. (optional) 
            var artists = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on artists. This allows multiple, pipe delimited. (optional) 
            var excludeArtistIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on artist id. This allows multiple, pipe delimited. (optional) 
            var artistIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified artist id. (optional) 
            var albumArtistIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified album artist id. (optional) 
            var contributingArtistIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified contributing artist id. (optional) 
            var albums = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on album. This allows multiple, pipe delimited. (optional) 
            var albumIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on album id. This allows multiple, pipe delimited. (optional) 
            var ids = new List<Guid>(); // List<Guid> | Optional. If specific items are needed, specify a list of item id's to retrieve. This allows multiple, comma delimited. (optional) 
            var videoTypes = new List<VideoType>(); // List<VideoType> | Optional filter by VideoType (videofile, dvd, bluray, iso). Allows multiple, comma delimited. (optional) 
            var minOfficialRating = minOfficialRating_example;  // string | Optional filter by minimum official rating (PG, PG-13, TV-MA, etc). (optional) 
            var isLocked = true;  // bool? | Optional filter by items that are locked. (optional) 
            var isPlaceHolder = true;  // bool? | Optional filter by items that are placeholders. (optional) 
            var hasOfficialRating = true;  // bool? | Optional filter by items that have official ratings. (optional) 
            var collapseBoxSetItems = true;  // bool? | Whether or not to hide items behind their boxsets. (optional) 
            var minWidth = 56;  // int? | Optional. Filter by the minimum width of the item. (optional) 
            var minHeight = 56;  // int? | Optional. Filter by the minimum height of the item. (optional) 
            var maxWidth = 56;  // int? | Optional. Filter by the maximum width of the item. (optional) 
            var maxHeight = 56;  // int? | Optional. Filter by the maximum height of the item. (optional) 
            var is3D = true;  // bool? | Optional filter by items that are 3D, or not. (optional) 
            var seriesStatus = new List<SeriesStatus>(); // List<SeriesStatus> | Optional filter by Series Status. Allows multiple, comma delimited. (optional) 
            var nameStartsWithOrGreater = nameStartsWithOrGreater_example;  // string | Optional filter by items whose name is sorted equally or greater than a given input string. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Optional filter by items whose name is sorted equally than a given input string. (optional) 
            var nameLessThan = nameLessThan_example;  // string | Optional filter by items whose name is equally or lesser than a given input string. (optional) 
            var studioIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimited. (optional) 
            var genreIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimited. (optional) 
            var enableTotalRecordCount = true;  // bool? | Optional. Enable the total record count. (optional)  (default to true)
            var enableImages = true;  // bool? | Optional, include image information in output. (optional)  (default to true)

            try
            {
                // Gets items based on a query.
                BaseItemDtoQueryResult result = apiInstance.GetItems(userId, maxOfficialRating, hasThemeSong, hasThemeVideo, hasSubtitles, hasSpecialFeature, hasTrailer, adjacentTo, parentIndexNumber, hasParentalRating, isHd, is4K, locationTypes, excludeLocationTypes, isMissing, isUnaired, minCommunityRating, minCriticRating, minPremiereDate, minDateLastSaved, minDateLastSavedForUser, maxPremiereDate, hasOverview, hasImdbId, hasTmdbId, hasTvdbId, excludeItemIds, startIndex, limit, recursive, searchTerm, sortOrder, parentId, fields, excludeItemTypes, includeItemTypes, filters, isFavorite, mediaTypes, imageTypes, sortBy, isPlayed, genres, officialRatings, tags, years, enableUserData, imageTypeLimit, enableImageTypes, person, personIds, personTypes, studios, artists, excludeArtistIds, artistIds, albumArtistIds, contributingArtistIds, albums, albumIds, ids, videoTypes, minOfficialRating, isLocked, isPlaceHolder, hasOfficialRating, collapseBoxSetItems, minWidth, minHeight, maxWidth, maxHeight, is3D, seriesStatus, nameStartsWithOrGreater, nameStartsWith, nameLessThan, studioIds, genreIds, enableTotalRecordCount, enableImages);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | [**Guid?**](Guid?.md)| The user id supplied as query parameter. | [optional] 
 **maxOfficialRating** | **string**| Optional filter by maximum official rating (PG, PG-13, TV-MA, etc). | [optional] 
 **hasThemeSong** | **bool?**| Optional filter by items with theme songs. | [optional] 
 **hasThemeVideo** | **bool?**| Optional filter by items with theme videos. | [optional] 
 **hasSubtitles** | **bool?**| Optional filter by items with subtitles. | [optional] 
 **hasSpecialFeature** | **bool?**| Optional filter by items with special features. | [optional] 
 **hasTrailer** | **bool?**| Optional filter by items with trailers. | [optional] 
 **adjacentTo** | **string**| Optional. Return items that are siblings of a supplied item. | [optional] 
 **parentIndexNumber** | **int?**| Optional filter by parent index number. | [optional] 
 **hasParentalRating** | **bool?**| Optional filter by items that have or do not have a parental rating. | [optional] 
 **isHd** | **bool?**| Optional filter by items that are HD or not. | [optional] 
 **is4K** | **bool?**| Optional filter by items that are 4K or not. | [optional] 
 **locationTypes** | [**List&lt;LocationType&gt;**](LocationType.md)| Optional. If specified, results will be filtered based on LocationType. This allows multiple, comma delimited. | [optional] 
 **excludeLocationTypes** | [**List&lt;LocationType&gt;**](LocationType.md)| Optional. If specified, results will be filtered based on the LocationType. This allows multiple, comma delimited. | [optional] 
 **isMissing** | **bool?**| Optional filter by items that are missing episodes or not. | [optional] 
 **isUnaired** | **bool?**| Optional filter by items that are unaired episodes or not. | [optional] 
 **minCommunityRating** | **double?**| Optional filter by minimum community rating. | [optional] 
 **minCriticRating** | **double?**| Optional filter by minimum critic rating. | [optional] 
 **minPremiereDate** | **DateTime?**| Optional. The minimum premiere date. Format &#x3D; ISO. | [optional] 
 **minDateLastSaved** | **DateTime?**| Optional. The minimum last saved date. Format &#x3D; ISO. | [optional] 
 **minDateLastSavedForUser** | **DateTime?**| Optional. The minimum last saved date for the current user. Format &#x3D; ISO. | [optional] 
 **maxPremiereDate** | **DateTime?**| Optional. The maximum premiere date. Format &#x3D; ISO. | [optional] 
 **hasOverview** | **bool?**| Optional filter by items that have an overview or not. | [optional] 
 **hasImdbId** | **bool?**| Optional filter by items that have an imdb id or not. | [optional] 
 **hasTmdbId** | **bool?**| Optional filter by items that have a tmdb id or not. | [optional] 
 **hasTvdbId** | **bool?**| Optional filter by items that have a tvdb id or not. | [optional] 
 **excludeItemIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered by excluding item ids. This allows multiple, comma delimited. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **recursive** | **bool?**| When searching within folders, this determines whether or not the search will be recursive. true/false. | [optional] 
 **searchTerm** | **string**| Optional. Filter based on a search term. | [optional] 
 **sortOrder** | [**List&lt;SortOrder&gt;**](SortOrder.md)| Sort Order - Ascending,Descending. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines. | [optional] 
 **excludeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on the item type. This allows multiple, comma delimited. | [optional] 
 **filters** | [**List&lt;ItemFilter&gt;**](ItemFilter.md)| Optional. Specify additional filters to apply. This allows multiple, comma delimited. Options: IsFolder, IsNotFolder, IsUnplayed, IsPlayed, IsFavorite, IsResumable, Likes, Dislikes. | [optional] 
 **isFavorite** | **bool?**| Optional filter by items that are marked as favorite, or not. | [optional] 
 **mediaTypes** | [**List&lt;string&gt;**](string.md)| Optional filter by MediaType. Allows multiple, comma delimited. | [optional] 
 **imageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. If specified, results will be filtered based on those containing image types. This allows multiple, comma delimited. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. | [optional] 
 **isPlayed** | **bool?**| Optional filter by items that are played, or not. | [optional] 
 **genres** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimited. | [optional] 
 **officialRatings** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimited. | [optional] 
 **tags** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimited. | [optional] 
 **years** | [**List&lt;int&gt;**](int.md)| Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimited. | [optional] 
 **enableUserData** | **bool?**| Optional, include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional, the max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **person** | **string**| Optional. If specified, results will be filtered to include only those containing the specified person. | [optional] 
 **personIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified person id. | [optional] 
 **personTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited. | [optional] 
 **studios** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimited. | [optional] 
 **artists** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on artists. This allows multiple, pipe delimited. | [optional] 
 **excludeArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on artist id. This allows multiple, pipe delimited. | [optional] 
 **artistIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified artist id. | [optional] 
 **albumArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified album artist id. | [optional] 
 **contributingArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified contributing artist id. | [optional] 
 **albums** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on album. This allows multiple, pipe delimited. | [optional] 
 **albumIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on album id. This allows multiple, pipe delimited. | [optional] 
 **ids** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specific items are needed, specify a list of item id&#39;s to retrieve. This allows multiple, comma delimited. | [optional] 
 **videoTypes** | [**List&lt;VideoType&gt;**](VideoType.md)| Optional filter by VideoType (videofile, dvd, bluray, iso). Allows multiple, comma delimited. | [optional] 
 **minOfficialRating** | **string**| Optional filter by minimum official rating (PG, PG-13, TV-MA, etc). | [optional] 
 **isLocked** | **bool?**| Optional filter by items that are locked. | [optional] 
 **isPlaceHolder** | **bool?**| Optional filter by items that are placeholders. | [optional] 
 **hasOfficialRating** | **bool?**| Optional filter by items that have official ratings. | [optional] 
 **collapseBoxSetItems** | **bool?**| Whether or not to hide items behind their boxsets. | [optional] 
 **minWidth** | **int?**| Optional. Filter by the minimum width of the item. | [optional] 
 **minHeight** | **int?**| Optional. Filter by the minimum height of the item. | [optional] 
 **maxWidth** | **int?**| Optional. Filter by the maximum width of the item. | [optional] 
 **maxHeight** | **int?**| Optional. Filter by the maximum height of the item. | [optional] 
 **is3D** | **bool?**| Optional filter by items that are 3D, or not. | [optional] 
 **seriesStatus** | [**List&lt;SeriesStatus&gt;**](SeriesStatus.md)| Optional filter by Series Status. Allows multiple, comma delimited. | [optional] 
 **nameStartsWithOrGreater** | **string**| Optional filter by items whose name is sorted equally or greater than a given input string. | [optional] 
 **nameStartsWith** | **string**| Optional filter by items whose name is sorted equally than a given input string. | [optional] 
 **nameLessThan** | **string**| Optional filter by items whose name is equally or lesser than a given input string. | [optional] 
 **studioIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimited. | [optional] 
 **genreIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimited. | [optional] 
 **enableTotalRecordCount** | **bool?**| Optional. Enable the total record count. | [optional] [default to true]
 **enableImages** | **bool?**| Optional, include image information in output. | [optional] [default to true]

### Return type

[**BaseItemDtoQueryResult**](BaseItemDtoQueryResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetItemsByUserId

> BaseItemDtoQueryResult GetItemsByUserId (Guid userId, string maxOfficialRating = null, bool? hasThemeSong = null, bool? hasThemeVideo = null, bool? hasSubtitles = null, bool? hasSpecialFeature = null, bool? hasTrailer = null, string adjacentTo = null, int? parentIndexNumber = null, bool? hasParentalRating = null, bool? isHd = null, bool? is4K = null, List<LocationType> locationTypes = null, List<LocationType> excludeLocationTypes = null, bool? isMissing = null, bool? isUnaired = null, double? minCommunityRating = null, double? minCriticRating = null, DateTime? minPremiereDate = null, DateTime? minDateLastSaved = null, DateTime? minDateLastSavedForUser = null, DateTime? maxPremiereDate = null, bool? hasOverview = null, bool? hasImdbId = null, bool? hasTmdbId = null, bool? hasTvdbId = null, List<Guid> excludeItemIds = null, int? startIndex = null, int? limit = null, bool? recursive = null, string searchTerm = null, List<SortOrder> sortOrder = null, Guid? parentId = null, List<ItemFields> fields = null, List<string> excludeItemTypes = null, List<string> includeItemTypes = null, List<ItemFilter> filters = null, bool? isFavorite = null, List<string> mediaTypes = null, List<ImageType> imageTypes = null, List<string> sortBy = null, bool? isPlayed = null, List<string> genres = null, List<string> officialRatings = null, List<string> tags = null, List<int> years = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, string person = null, List<Guid> personIds = null, List<string> personTypes = null, List<string> studios = null, List<string> artists = null, List<Guid> excludeArtistIds = null, List<Guid> artistIds = null, List<Guid> albumArtistIds = null, List<Guid> contributingArtistIds = null, List<string> albums = null, List<Guid> albumIds = null, List<Guid> ids = null, List<VideoType> videoTypes = null, string minOfficialRating = null, bool? isLocked = null, bool? isPlaceHolder = null, bool? hasOfficialRating = null, bool? collapseBoxSetItems = null, int? minWidth = null, int? minHeight = null, int? maxWidth = null, int? maxHeight = null, bool? is3D = null, List<SeriesStatus> seriesStatus = null, string nameStartsWithOrGreater = null, string nameStartsWith = null, string nameLessThan = null, List<Guid> studioIds = null, List<Guid> genreIds = null, bool? enableTotalRecordCount = null, bool? enableImages = null)

Gets items based on a query.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetItemsByUserIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ItemsApi(Configuration.Default);
            var userId = new Guid(); // Guid | The user id supplied as query parameter.
            var maxOfficialRating = maxOfficialRating_example;  // string | Optional filter by maximum official rating (PG, PG-13, TV-MA, etc). (optional) 
            var hasThemeSong = true;  // bool? | Optional filter by items with theme songs. (optional) 
            var hasThemeVideo = true;  // bool? | Optional filter by items with theme videos. (optional) 
            var hasSubtitles = true;  // bool? | Optional filter by items with subtitles. (optional) 
            var hasSpecialFeature = true;  // bool? | Optional filter by items with special features. (optional) 
            var hasTrailer = true;  // bool? | Optional filter by items with trailers. (optional) 
            var adjacentTo = adjacentTo_example;  // string | Optional. Return items that are siblings of a supplied item. (optional) 
            var parentIndexNumber = 56;  // int? | Optional filter by parent index number. (optional) 
            var hasParentalRating = true;  // bool? | Optional filter by items that have or do not have a parental rating. (optional) 
            var isHd = true;  // bool? | Optional filter by items that are HD or not. (optional) 
            var is4K = true;  // bool? | Optional filter by items that are 4K or not. (optional) 
            var locationTypes = new List<LocationType>(); // List<LocationType> | Optional. If specified, results will be filtered based on LocationType. This allows multiple, comma delimeted. (optional) 
            var excludeLocationTypes = new List<LocationType>(); // List<LocationType> | Optional. If specified, results will be filtered based on the LocationType. This allows multiple, comma delimeted. (optional) 
            var isMissing = true;  // bool? | Optional filter by items that are missing episodes or not. (optional) 
            var isUnaired = true;  // bool? | Optional filter by items that are unaired episodes or not. (optional) 
            var minCommunityRating = 1.2D;  // double? | Optional filter by minimum community rating. (optional) 
            var minCriticRating = 1.2D;  // double? | Optional filter by minimum critic rating. (optional) 
            var minPremiereDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum premiere date. Format = ISO. (optional) 
            var minDateLastSaved = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum last saved date. Format = ISO. (optional) 
            var minDateLastSavedForUser = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum last saved date for the current user. Format = ISO. (optional) 
            var maxPremiereDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The maximum premiere date. Format = ISO. (optional) 
            var hasOverview = true;  // bool? | Optional filter by items that have an overview or not. (optional) 
            var hasImdbId = true;  // bool? | Optional filter by items that have an imdb id or not. (optional) 
            var hasTmdbId = true;  // bool? | Optional filter by items that have a tmdb id or not. (optional) 
            var hasTvdbId = true;  // bool? | Optional filter by items that have a tvdb id or not. (optional) 
            var excludeItemIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered by exxcluding item ids. This allows multiple, comma delimeted. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var recursive = true;  // bool? | When searching within folders, this determines whether or not the search will be recursive. true/false. (optional) 
            var searchTerm = searchTerm_example;  // string | Optional. Filter based on a search term. (optional) 
            var sortOrder = new List<SortOrder>(); // List<SortOrder> | Sort Order - Ascending,Descending. (optional) 
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimeted. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines. (optional) 
            var excludeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimeted. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on the item type. This allows multiple, comma delimeted. (optional) 
            var filters = new List<ItemFilter>(); // List<ItemFilter> | Optional. Specify additional filters to apply. This allows multiple, comma delimeted. Options: IsFolder, IsNotFolder, IsUnplayed, IsPlayed, IsFavorite, IsResumable, Likes, Dislikes. (optional) 
            var isFavorite = true;  // bool? | Optional filter by items that are marked as favorite, or not. (optional) 
            var mediaTypes = new List<string>(); // List<string> | Optional filter by MediaType. Allows multiple, comma delimited. (optional) 
            var imageTypes = new List<ImageType>(); // List<ImageType> | Optional. If specified, results will be filtered based on those containing image types. This allows multiple, comma delimited. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Specify one or more sort orders, comma delimeted. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. (optional) 
            var isPlayed = true;  // bool? | Optional filter by items that are played, or not. (optional) 
            var genres = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimeted. (optional) 
            var officialRatings = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimeted. (optional) 
            var tags = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimeted. (optional) 
            var years = new List<int>(); // List<int> | Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimeted. (optional) 
            var enableUserData = true;  // bool? | Optional, include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional, the max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var person = person_example;  // string | Optional. If specified, results will be filtered to include only those containing the specified person. (optional) 
            var personIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified person id. (optional) 
            var personTypes = new List<string>(); // List<string> | Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited. (optional) 
            var studios = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimeted. (optional) 
            var artists = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on artists. This allows multiple, pipe delimeted. (optional) 
            var excludeArtistIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on artist id. This allows multiple, pipe delimeted. (optional) 
            var artistIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified artist id. (optional) 
            var albumArtistIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified album artist id. (optional) 
            var contributingArtistIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified contributing artist id. (optional) 
            var albums = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on album. This allows multiple, pipe delimeted. (optional) 
            var albumIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on album id. This allows multiple, pipe delimeted. (optional) 
            var ids = new List<Guid>(); // List<Guid> | Optional. If specific items are needed, specify a list of item id's to retrieve. This allows multiple, comma delimited. (optional) 
            var videoTypes = new List<VideoType>(); // List<VideoType> | Optional filter by VideoType (videofile, dvd, bluray, iso). Allows multiple, comma delimeted. (optional) 
            var minOfficialRating = minOfficialRating_example;  // string | Optional filter by minimum official rating (PG, PG-13, TV-MA, etc). (optional) 
            var isLocked = true;  // bool? | Optional filter by items that are locked. (optional) 
            var isPlaceHolder = true;  // bool? | Optional filter by items that are placeholders. (optional) 
            var hasOfficialRating = true;  // bool? | Optional filter by items that have official ratings. (optional) 
            var collapseBoxSetItems = true;  // bool? | Whether or not to hide items behind their boxsets. (optional) 
            var minWidth = 56;  // int? | Optional. Filter by the minimum width of the item. (optional) 
            var minHeight = 56;  // int? | Optional. Filter by the minimum height of the item. (optional) 
            var maxWidth = 56;  // int? | Optional. Filter by the maximum width of the item. (optional) 
            var maxHeight = 56;  // int? | Optional. Filter by the maximum height of the item. (optional) 
            var is3D = true;  // bool? | Optional filter by items that are 3D, or not. (optional) 
            var seriesStatus = new List<SeriesStatus>(); // List<SeriesStatus> | Optional filter by Series Status. Allows multiple, comma delimeted. (optional) 
            var nameStartsWithOrGreater = nameStartsWithOrGreater_example;  // string | Optional filter by items whose name is sorted equally or greater than a given input string. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Optional filter by items whose name is sorted equally than a given input string. (optional) 
            var nameLessThan = nameLessThan_example;  // string | Optional filter by items whose name is equally or lesser than a given input string. (optional) 
            var studioIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimeted. (optional) 
            var genreIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimeted. (optional) 
            var enableTotalRecordCount = true;  // bool? | Optional. Enable the total record count. (optional)  (default to true)
            var enableImages = true;  // bool? | Optional, include image information in output. (optional)  (default to true)

            try
            {
                // Gets items based on a query.
                BaseItemDtoQueryResult result = apiInstance.GetItemsByUserId(userId, maxOfficialRating, hasThemeSong, hasThemeVideo, hasSubtitles, hasSpecialFeature, hasTrailer, adjacentTo, parentIndexNumber, hasParentalRating, isHd, is4K, locationTypes, excludeLocationTypes, isMissing, isUnaired, minCommunityRating, minCriticRating, minPremiereDate, minDateLastSaved, minDateLastSavedForUser, maxPremiereDate, hasOverview, hasImdbId, hasTmdbId, hasTvdbId, excludeItemIds, startIndex, limit, recursive, searchTerm, sortOrder, parentId, fields, excludeItemTypes, includeItemTypes, filters, isFavorite, mediaTypes, imageTypes, sortBy, isPlayed, genres, officialRatings, tags, years, enableUserData, imageTypeLimit, enableImageTypes, person, personIds, personTypes, studios, artists, excludeArtistIds, artistIds, albumArtistIds, contributingArtistIds, albums, albumIds, ids, videoTypes, minOfficialRating, isLocked, isPlaceHolder, hasOfficialRating, collapseBoxSetItems, minWidth, minHeight, maxWidth, maxHeight, is3D, seriesStatus, nameStartsWithOrGreater, nameStartsWith, nameLessThan, studioIds, genreIds, enableTotalRecordCount, enableImages);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetItemsByUserId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | [**Guid**](Guid.md)| The user id supplied as query parameter. | 
 **maxOfficialRating** | **string**| Optional filter by maximum official rating (PG, PG-13, TV-MA, etc). | [optional] 
 **hasThemeSong** | **bool?**| Optional filter by items with theme songs. | [optional] 
 **hasThemeVideo** | **bool?**| Optional filter by items with theme videos. | [optional] 
 **hasSubtitles** | **bool?**| Optional filter by items with subtitles. | [optional] 
 **hasSpecialFeature** | **bool?**| Optional filter by items with special features. | [optional] 
 **hasTrailer** | **bool?**| Optional filter by items with trailers. | [optional] 
 **adjacentTo** | **string**| Optional. Return items that are siblings of a supplied item. | [optional] 
 **parentIndexNumber** | **int?**| Optional filter by parent index number. | [optional] 
 **hasParentalRating** | **bool?**| Optional filter by items that have or do not have a parental rating. | [optional] 
 **isHd** | **bool?**| Optional filter by items that are HD or not. | [optional] 
 **is4K** | **bool?**| Optional filter by items that are 4K or not. | [optional] 
 **locationTypes** | [**List&lt;LocationType&gt;**](LocationType.md)| Optional. If specified, results will be filtered based on LocationType. This allows multiple, comma delimeted. | [optional] 
 **excludeLocationTypes** | [**List&lt;LocationType&gt;**](LocationType.md)| Optional. If specified, results will be filtered based on the LocationType. This allows multiple, comma delimeted. | [optional] 
 **isMissing** | **bool?**| Optional filter by items that are missing episodes or not. | [optional] 
 **isUnaired** | **bool?**| Optional filter by items that are unaired episodes or not. | [optional] 
 **minCommunityRating** | **double?**| Optional filter by minimum community rating. | [optional] 
 **minCriticRating** | **double?**| Optional filter by minimum critic rating. | [optional] 
 **minPremiereDate** | **DateTime?**| Optional. The minimum premiere date. Format &#x3D; ISO. | [optional] 
 **minDateLastSaved** | **DateTime?**| Optional. The minimum last saved date. Format &#x3D; ISO. | [optional] 
 **minDateLastSavedForUser** | **DateTime?**| Optional. The minimum last saved date for the current user. Format &#x3D; ISO. | [optional] 
 **maxPremiereDate** | **DateTime?**| Optional. The maximum premiere date. Format &#x3D; ISO. | [optional] 
 **hasOverview** | **bool?**| Optional filter by items that have an overview or not. | [optional] 
 **hasImdbId** | **bool?**| Optional filter by items that have an imdb id or not. | [optional] 
 **hasTmdbId** | **bool?**| Optional filter by items that have a tmdb id or not. | [optional] 
 **hasTvdbId** | **bool?**| Optional filter by items that have a tvdb id or not. | [optional] 
 **excludeItemIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered by exxcluding item ids. This allows multiple, comma delimeted. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **recursive** | **bool?**| When searching within folders, this determines whether or not the search will be recursive. true/false. | [optional] 
 **searchTerm** | **string**| Optional. Filter based on a search term. | [optional] 
 **sortOrder** | [**List&lt;SortOrder&gt;**](SortOrder.md)| Sort Order - Ascending,Descending. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimeted. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines. | [optional] 
 **excludeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimeted. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on the item type. This allows multiple, comma delimeted. | [optional] 
 **filters** | [**List&lt;ItemFilter&gt;**](ItemFilter.md)| Optional. Specify additional filters to apply. This allows multiple, comma delimeted. Options: IsFolder, IsNotFolder, IsUnplayed, IsPlayed, IsFavorite, IsResumable, Likes, Dislikes. | [optional] 
 **isFavorite** | **bool?**| Optional filter by items that are marked as favorite, or not. | [optional] 
 **mediaTypes** | [**List&lt;string&gt;**](string.md)| Optional filter by MediaType. Allows multiple, comma delimited. | [optional] 
 **imageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. If specified, results will be filtered based on those containing image types. This allows multiple, comma delimited. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Specify one or more sort orders, comma delimeted. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. | [optional] 
 **isPlayed** | **bool?**| Optional filter by items that are played, or not. | [optional] 
 **genres** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimeted. | [optional] 
 **officialRatings** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimeted. | [optional] 
 **tags** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimeted. | [optional] 
 **years** | [**List&lt;int&gt;**](int.md)| Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimeted. | [optional] 
 **enableUserData** | **bool?**| Optional, include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional, the max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **person** | **string**| Optional. If specified, results will be filtered to include only those containing the specified person. | [optional] 
 **personIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified person id. | [optional] 
 **personTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited. | [optional] 
 **studios** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimeted. | [optional] 
 **artists** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on artists. This allows multiple, pipe delimeted. | [optional] 
 **excludeArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on artist id. This allows multiple, pipe delimeted. | [optional] 
 **artistIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified artist id. | [optional] 
 **albumArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified album artist id. | [optional] 
 **contributingArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified contributing artist id. | [optional] 
 **albums** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on album. This allows multiple, pipe delimeted. | [optional] 
 **albumIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on album id. This allows multiple, pipe delimeted. | [optional] 
 **ids** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specific items are needed, specify a list of item id&#39;s to retrieve. This allows multiple, comma delimited. | [optional] 
 **videoTypes** | [**List&lt;VideoType&gt;**](VideoType.md)| Optional filter by VideoType (videofile, dvd, bluray, iso). Allows multiple, comma delimeted. | [optional] 
 **minOfficialRating** | **string**| Optional filter by minimum official rating (PG, PG-13, TV-MA, etc). | [optional] 
 **isLocked** | **bool?**| Optional filter by items that are locked. | [optional] 
 **isPlaceHolder** | **bool?**| Optional filter by items that are placeholders. | [optional] 
 **hasOfficialRating** | **bool?**| Optional filter by items that have official ratings. | [optional] 
 **collapseBoxSetItems** | **bool?**| Whether or not to hide items behind their boxsets. | [optional] 
 **minWidth** | **int?**| Optional. Filter by the minimum width of the item. | [optional] 
 **minHeight** | **int?**| Optional. Filter by the minimum height of the item. | [optional] 
 **maxWidth** | **int?**| Optional. Filter by the maximum width of the item. | [optional] 
 **maxHeight** | **int?**| Optional. Filter by the maximum height of the item. | [optional] 
 **is3D** | **bool?**| Optional filter by items that are 3D, or not. | [optional] 
 **seriesStatus** | [**List&lt;SeriesStatus&gt;**](SeriesStatus.md)| Optional filter by Series Status. Allows multiple, comma delimeted. | [optional] 
 **nameStartsWithOrGreater** | **string**| Optional filter by items whose name is sorted equally or greater than a given input string. | [optional] 
 **nameStartsWith** | **string**| Optional filter by items whose name is sorted equally than a given input string. | [optional] 
 **nameLessThan** | **string**| Optional filter by items whose name is equally or lesser than a given input string. | [optional] 
 **studioIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimeted. | [optional] 
 **genreIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimeted. | [optional] 
 **enableTotalRecordCount** | **bool?**| Optional. Enable the total record count. | [optional] [default to true]
 **enableImages** | **bool?**| Optional, include image information in output. | [optional] [default to true]

### Return type

[**BaseItemDtoQueryResult**](BaseItemDtoQueryResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetResumeItems

> BaseItemDtoQueryResult GetResumeItems (Guid userId, int? startIndex = null, int? limit = null, string searchTerm = null, Guid? parentId = null, List<ItemFields> fields = null, List<string> mediaTypes = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, List<string> excludeItemTypes = null, List<string> includeItemTypes = null, bool? enableTotalRecordCount = null, bool? enableImages = null)

Gets items based on a query.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetResumeItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ItemsApi(Configuration.Default);
            var userId = new Guid(); // Guid | The user id.
            var startIndex = 56;  // int? | The start index. (optional) 
            var limit = 56;  // int? | The item limit. (optional) 
            var searchTerm = searchTerm_example;  // string | The search term. (optional) 
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines. (optional) 
            var mediaTypes = new List<string>(); // List<string> | Optional. Filter by MediaType. Allows multiple, comma delimited. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var excludeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on the item type. This allows multiple, comma delimited. (optional) 
            var enableTotalRecordCount = true;  // bool? | Optional. Enable the total record count. (optional)  (default to true)
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional)  (default to true)

            try
            {
                // Gets items based on a query.
                BaseItemDtoQueryResult result = apiInstance.GetResumeItems(userId, startIndex, limit, searchTerm, parentId, fields, mediaTypes, enableUserData, imageTypeLimit, enableImageTypes, excludeItemTypes, includeItemTypes, enableTotalRecordCount, enableImages);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetResumeItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | [**Guid**](Guid.md)| The user id. | 
 **startIndex** | **int?**| The start index. | [optional] 
 **limit** | **int?**| The item limit. | [optional] 
 **searchTerm** | **string**| The search term. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines. | [optional] 
 **mediaTypes** | [**List&lt;string&gt;**](string.md)| Optional. Filter by MediaType. Allows multiple, comma delimited. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **excludeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on the item type. This allows multiple, comma delimited. | [optional] 
 **enableTotalRecordCount** | **bool?**| Optional. Enable the total record count. | [optional] [default to true]
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] [default to true]

### Return type

[**BaseItemDtoQueryResult**](BaseItemDtoQueryResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

