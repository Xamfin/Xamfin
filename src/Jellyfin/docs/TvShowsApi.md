# Jellyfin.Api.Api.TvShowsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEpisodes**](TvShowsApi.md#getepisodes) | **GET** /Shows/{seriesId}/Episodes | Gets episodes for a tv season.
[**GetNextUp**](TvShowsApi.md#getnextup) | **GET** /Shows/NextUp | Gets a list of next up episodes.
[**GetSeasons**](TvShowsApi.md#getseasons) | **GET** /Shows/{seriesId}/Seasons | Gets seasons for a tv series.
[**GetUpcomingEpisodes**](TvShowsApi.md#getupcomingepisodes) | **GET** /Shows/Upcoming | Gets a list of upcoming episodes.



## GetEpisodes

> BaseItemDtoQueryResult GetEpisodes (Guid seriesId, Guid? userId = null, List<ItemFields> fields = null, int? season = null, Guid? seasonId = null, bool? isMissing = null, string adjacentTo = null, Guid? startItemId = null, int? startIndex = null, int? limit = null, bool? enableImages = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, bool? enableUserData = null, string sortBy = null)

Gets episodes for a tv season.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetEpisodesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new TvShowsApi(Configuration.Default);
            var seriesId = new Guid(); // Guid | The series id.
            var userId = new Guid?(); // Guid? | The user id. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. (optional) 
            var season = 56;  // int? | Optional filter by season number. (optional) 
            var seasonId = new Guid?(); // Guid? | Optional. Filter by season id. (optional) 
            var isMissing = true;  // bool? | Optional. Filter by items that are missing episodes or not. (optional) 
            var adjacentTo = adjacentTo_example;  // string | Optional. Return items that are siblings of a supplied item. (optional) 
            var startItemId = new Guid?(); // Guid? | Optional. Skip through the list until a given item is found. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var enableImages = true;  // bool? | Optional, include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional, the max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var sortBy = sortBy_example;  // string | Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. (optional) 

            try
            {
                // Gets episodes for a tv season.
                BaseItemDtoQueryResult result = apiInstance.GetEpisodes(seriesId, userId, fields, season, seasonId, isMissing, adjacentTo, startItemId, startIndex, limit, enableImages, imageTypeLimit, enableImageTypes, enableUserData, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TvShowsApi.GetEpisodes: " + e.Message );
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
 **seriesId** | [**Guid**](Guid.md)| The series id. | 
 **userId** | [**Guid?**](Guid?.md)| The user id. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. | [optional] 
 **season** | **int?**| Optional filter by season number. | [optional] 
 **seasonId** | [**Guid?**](Guid?.md)| Optional. Filter by season id. | [optional] 
 **isMissing** | **bool?**| Optional. Filter by items that are missing episodes or not. | [optional] 
 **adjacentTo** | **string**| Optional. Return items that are siblings of a supplied item. | [optional] 
 **startItemId** | [**Guid?**](Guid?.md)| Optional. Skip through the list until a given item is found. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **enableImages** | **bool?**| Optional, include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional, the max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **sortBy** | **string**| Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. | [optional] 

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetNextUp

> BaseItemDtoQueryResult GetNextUp (Guid? userId = null, int? startIndex = null, int? limit = null, List<ItemFields> fields = null, string seriesId = null, Guid? parentId = null, bool? enableImges = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, bool? enableUserData = null, bool? enableTotalRecordCount = null, bool? disableFirstEpisode = null)

Gets a list of next up episodes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetNextUpExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new TvShowsApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | The user id of the user to get the next up episodes for. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var seriesId = seriesId_example;  // string | Optional. Filter by series id. (optional) 
            var parentId = new Guid?(); // Guid? | Optional. Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var enableImges = true;  // bool? | Optional. Include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var enableTotalRecordCount = true;  // bool? | Whether to enable the total records count. Defaults to true. (optional)  (default to true)
            var disableFirstEpisode = true;  // bool? | Whether to disable sending the first episode in a series as next up. (optional)  (default to false)

            try
            {
                // Gets a list of next up episodes.
                BaseItemDtoQueryResult result = apiInstance.GetNextUp(userId, startIndex, limit, fields, seriesId, parentId, enableImges, imageTypeLimit, enableImageTypes, enableUserData, enableTotalRecordCount, disableFirstEpisode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TvShowsApi.GetNextUp: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| The user id of the user to get the next up episodes for. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **seriesId** | **string**| Optional. Filter by series id. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Optional. Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **enableImges** | **bool?**| Optional. Include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **enableTotalRecordCount** | **bool?**| Whether to enable the total records count. Defaults to true. | [optional] [default to true]
 **disableFirstEpisode** | **bool?**| Whether to disable sending the first episode in a series as next up. | [optional] [default to false]

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


## GetSeasons

> BaseItemDtoQueryResult GetSeasons (Guid seriesId, Guid? userId = null, List<ItemFields> fields = null, bool? isSpecialSeason = null, bool? isMissing = null, string adjacentTo = null, bool? enableImages = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, bool? enableUserData = null)

Gets seasons for a tv series.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSeasonsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new TvShowsApi(Configuration.Default);
            var seriesId = new Guid(); // Guid | The series id.
            var userId = new Guid?(); // Guid? | The user id. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. (optional) 
            var isSpecialSeason = true;  // bool? | Optional. Filter by special season. (optional) 
            var isMissing = true;  // bool? | Optional. Filter by items that are missing episodes or not. (optional) 
            var adjacentTo = adjacentTo_example;  // string | Optional. Return items that are siblings of a supplied item. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 

            try
            {
                // Gets seasons for a tv series.
                BaseItemDtoQueryResult result = apiInstance.GetSeasons(seriesId, userId, fields, isSpecialSeason, isMissing, adjacentTo, enableImages, imageTypeLimit, enableImageTypes, enableUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TvShowsApi.GetSeasons: " + e.Message );
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
 **seriesId** | [**Guid**](Guid.md)| The series id. | 
 **userId** | [**Guid?**](Guid?.md)| The user id. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. | [optional] 
 **isSpecialSeason** | **bool?**| Optional. Filter by special season. | [optional] 
 **isMissing** | **bool?**| Optional. Filter by items that are missing episodes or not. | [optional] 
 **adjacentTo** | **string**| Optional. Return items that are siblings of a supplied item. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUpcomingEpisodes

> BaseItemDtoQueryResult GetUpcomingEpisodes (Guid? userId = null, int? startIndex = null, int? limit = null, List<ItemFields> fields = null, Guid? parentId = null, bool? enableImges = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, bool? enableUserData = null)

Gets a list of upcoming episodes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetUpcomingEpisodesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new TvShowsApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | The user id of the user to get the upcoming episodes for. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var parentId = new Guid?(); // Guid? | Optional. Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var enableImges = true;  // bool? | Optional. Include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 

            try
            {
                // Gets a list of upcoming episodes.
                BaseItemDtoQueryResult result = apiInstance.GetUpcomingEpisodes(userId, startIndex, limit, fields, parentId, enableImges, imageTypeLimit, enableImageTypes, enableUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TvShowsApi.GetUpcomingEpisodes: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| The user id of the user to get the upcoming episodes for. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Optional. Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **enableImges** | **bool?**| Optional. Include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 

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

