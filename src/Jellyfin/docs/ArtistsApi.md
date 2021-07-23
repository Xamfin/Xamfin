# Jellyfin.Api.Api.ArtistsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAlbumArtists**](ArtistsApi.md#getalbumartists) | **GET** /Artists/AlbumArtists | Gets all album artists from a given item, folder, or the entire library.
[**GetArtistByName**](ArtistsApi.md#getartistbyname) | **GET** /Artists/{name} | Gets an artist by name.
[**GetArtists**](ArtistsApi.md#getartists) | **GET** /Artists | Gets all artists from a given item, folder, or the entire library.



## GetAlbumArtists

> BaseItemDtoQueryResult GetAlbumArtists (double? minCommunityRating = null, int? startIndex = null, int? limit = null, string searchTerm = null, Guid? parentId = null, List<ItemFields> fields = null, List<string> excludeItemTypes = null, List<string> includeItemTypes = null, List<ItemFilter> filters = null, bool? isFavorite = null, List<string> mediaTypes = null, List<string> genres = null, List<Guid> genreIds = null, List<string> officialRatings = null, List<string> tags = null, List<int> years = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, string person = null, List<Guid> personIds = null, List<string> personTypes = null, List<string> studios = null, List<Guid> studioIds = null, Guid? userId = null, string nameStartsWithOrGreater = null, string nameStartsWith = null, string nameLessThan = null, bool? enableImages = null, bool? enableTotalRecordCount = null)

Gets all album artists from a given item, folder, or the entire library.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetAlbumArtistsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ArtistsApi(Configuration.Default);
            var minCommunityRating = 1.2D;  // double? | Optional filter by minimum community rating. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var searchTerm = searchTerm_example;  // string | Optional. Search term. (optional) 
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var excludeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered out based on item type. This allows multiple, comma delimited. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. (optional) 
            var filters = new List<ItemFilter>(); // List<ItemFilter> | Optional. Specify additional filters to apply. (optional) 
            var isFavorite = true;  // bool? | Optional filter by items that are marked as favorite, or not. (optional) 
            var mediaTypes = new List<string>(); // List<string> | Optional filter by MediaType. Allows multiple, comma delimited. (optional) 
            var genres = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimited. (optional) 
            var genreIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimited. (optional) 
            var officialRatings = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimited. (optional) 
            var tags = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimited. (optional) 
            var years = new List<int>(); // List<int> | Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimited. (optional) 
            var enableUserData = true;  // bool? | Optional, include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional, the max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var person = person_example;  // string | Optional. If specified, results will be filtered to include only those containing the specified person. (optional) 
            var personIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified person ids. (optional) 
            var personTypes = new List<string>(); // List<string> | Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited. (optional) 
            var studios = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimited. (optional) 
            var studioIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimited. (optional) 
            var userId = new Guid?(); // Guid? | User id. (optional) 
            var nameStartsWithOrGreater = nameStartsWithOrGreater_example;  // string | Optional filter by items whose name is sorted equally or greater than a given input string. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Optional filter by items whose name is sorted equally than a given input string. (optional) 
            var nameLessThan = nameLessThan_example;  // string | Optional filter by items whose name is equally or lesser than a given input string. (optional) 
            var enableImages = true;  // bool? | Optional, include image information in output. (optional)  (default to true)
            var enableTotalRecordCount = true;  // bool? | Total record count. (optional)  (default to true)

            try
            {
                // Gets all album artists from a given item, folder, or the entire library.
                BaseItemDtoQueryResult result = apiInstance.GetAlbumArtists(minCommunityRating, startIndex, limit, searchTerm, parentId, fields, excludeItemTypes, includeItemTypes, filters, isFavorite, mediaTypes, genres, genreIds, officialRatings, tags, years, enableUserData, imageTypeLimit, enableImageTypes, person, personIds, personTypes, studios, studioIds, userId, nameStartsWithOrGreater, nameStartsWith, nameLessThan, enableImages, enableTotalRecordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArtistsApi.GetAlbumArtists: " + e.Message );
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
 **minCommunityRating** | **double?**| Optional filter by minimum community rating. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **searchTerm** | **string**| Optional. Search term. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **excludeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered out based on item type. This allows multiple, comma delimited. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. | [optional] 
 **filters** | [**List&lt;ItemFilter&gt;**](ItemFilter.md)| Optional. Specify additional filters to apply. | [optional] 
 **isFavorite** | **bool?**| Optional filter by items that are marked as favorite, or not. | [optional] 
 **mediaTypes** | [**List&lt;string&gt;**](string.md)| Optional filter by MediaType. Allows multiple, comma delimited. | [optional] 
 **genres** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimited. | [optional] 
 **genreIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimited. | [optional] 
 **officialRatings** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimited. | [optional] 
 **tags** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimited. | [optional] 
 **years** | [**List&lt;int&gt;**](int.md)| Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimited. | [optional] 
 **enableUserData** | **bool?**| Optional, include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional, the max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **person** | **string**| Optional. If specified, results will be filtered to include only those containing the specified person. | [optional] 
 **personIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified person ids. | [optional] 
 **personTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited. | [optional] 
 **studios** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimited. | [optional] 
 **studioIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimited. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| User id. | [optional] 
 **nameStartsWithOrGreater** | **string**| Optional filter by items whose name is sorted equally or greater than a given input string. | [optional] 
 **nameStartsWith** | **string**| Optional filter by items whose name is sorted equally than a given input string. | [optional] 
 **nameLessThan** | **string**| Optional filter by items whose name is equally or lesser than a given input string. | [optional] 
 **enableImages** | **bool?**| Optional, include image information in output. | [optional] [default to true]
 **enableTotalRecordCount** | **bool?**| Total record count. | [optional] [default to true]

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
| **200** | Album artists returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArtistByName

> BaseItemDto GetArtistByName (string name, Guid? userId = null)

Gets an artist by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetArtistByNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ArtistsApi(Configuration.Default);
            var name = name_example;  // string | Studio name.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 

            try
            {
                // Gets an artist by name.
                BaseItemDto result = apiInstance.GetArtistByName(name, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArtistsApi.GetArtistByName: " + e.Message );
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
 **name** | **string**| Studio name. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 

### Return type

[**BaseItemDto**](BaseItemDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Artist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArtists

> BaseItemDtoQueryResult GetArtists (double? minCommunityRating = null, int? startIndex = null, int? limit = null, string searchTerm = null, Guid? parentId = null, List<ItemFields> fields = null, List<string> excludeItemTypes = null, List<string> includeItemTypes = null, List<ItemFilter> filters = null, bool? isFavorite = null, List<string> mediaTypes = null, List<string> genres = null, List<Guid> genreIds = null, List<string> officialRatings = null, List<string> tags = null, List<int> years = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, string person = null, List<Guid> personIds = null, List<string> personTypes = null, List<string> studios = null, List<Guid> studioIds = null, Guid? userId = null, string nameStartsWithOrGreater = null, string nameStartsWith = null, string nameLessThan = null, bool? enableImages = null, bool? enableTotalRecordCount = null)

Gets all artists from a given item, folder, or the entire library.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetArtistsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ArtistsApi(Configuration.Default);
            var minCommunityRating = 1.2D;  // double? | Optional filter by minimum community rating. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var searchTerm = searchTerm_example;  // string | Optional. Search term. (optional) 
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var excludeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered out based on item type. This allows multiple, comma delimited. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. (optional) 
            var filters = new List<ItemFilter>(); // List<ItemFilter> | Optional. Specify additional filters to apply. (optional) 
            var isFavorite = true;  // bool? | Optional filter by items that are marked as favorite, or not. (optional) 
            var mediaTypes = new List<string>(); // List<string> | Optional filter by MediaType. Allows multiple, comma delimited. (optional) 
            var genres = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimited. (optional) 
            var genreIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimited. (optional) 
            var officialRatings = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimited. (optional) 
            var tags = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimited. (optional) 
            var years = new List<int>(); // List<int> | Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimited. (optional) 
            var enableUserData = true;  // bool? | Optional, include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional, the max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var person = person_example;  // string | Optional. If specified, results will be filtered to include only those containing the specified person. (optional) 
            var personIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered to include only those containing the specified person ids. (optional) 
            var personTypes = new List<string>(); // List<string> | Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited. (optional) 
            var studios = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimited. (optional) 
            var studioIds = new List<Guid>(); // List<Guid> | Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimited. (optional) 
            var userId = new Guid?(); // Guid? | User id. (optional) 
            var nameStartsWithOrGreater = nameStartsWithOrGreater_example;  // string | Optional filter by items whose name is sorted equally or greater than a given input string. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Optional filter by items whose name is sorted equally than a given input string. (optional) 
            var nameLessThan = nameLessThan_example;  // string | Optional filter by items whose name is equally or lesser than a given input string. (optional) 
            var enableImages = true;  // bool? | Optional, include image information in output. (optional)  (default to true)
            var enableTotalRecordCount = true;  // bool? | Total record count. (optional)  (default to true)

            try
            {
                // Gets all artists from a given item, folder, or the entire library.
                BaseItemDtoQueryResult result = apiInstance.GetArtists(minCommunityRating, startIndex, limit, searchTerm, parentId, fields, excludeItemTypes, includeItemTypes, filters, isFavorite, mediaTypes, genres, genreIds, officialRatings, tags, years, enableUserData, imageTypeLimit, enableImageTypes, person, personIds, personTypes, studios, studioIds, userId, nameStartsWithOrGreater, nameStartsWith, nameLessThan, enableImages, enableTotalRecordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArtistsApi.GetArtists: " + e.Message );
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
 **minCommunityRating** | **double?**| Optional filter by minimum community rating. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **searchTerm** | **string**| Optional. Search term. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **excludeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered out based on item type. This allows multiple, comma delimited. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. | [optional] 
 **filters** | [**List&lt;ItemFilter&gt;**](ItemFilter.md)| Optional. Specify additional filters to apply. | [optional] 
 **isFavorite** | **bool?**| Optional filter by items that are marked as favorite, or not. | [optional] 
 **mediaTypes** | [**List&lt;string&gt;**](string.md)| Optional filter by MediaType. Allows multiple, comma delimited. | [optional] 
 **genres** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimited. | [optional] 
 **genreIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimited. | [optional] 
 **officialRatings** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimited. | [optional] 
 **tags** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimited. | [optional] 
 **years** | [**List&lt;int&gt;**](int.md)| Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimited. | [optional] 
 **enableUserData** | **bool?**| Optional, include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional, the max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **person** | **string**| Optional. If specified, results will be filtered to include only those containing the specified person. | [optional] 
 **personIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered to include only those containing the specified person ids. | [optional] 
 **personTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited. | [optional] 
 **studios** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimited. | [optional] 
 **studioIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimited. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| User id. | [optional] 
 **nameStartsWithOrGreater** | **string**| Optional filter by items whose name is sorted equally or greater than a given input string. | [optional] 
 **nameStartsWith** | **string**| Optional filter by items whose name is sorted equally than a given input string. | [optional] 
 **nameLessThan** | **string**| Optional filter by items whose name is equally or lesser than a given input string. | [optional] 
 **enableImages** | **bool?**| Optional, include image information in output. | [optional] [default to true]
 **enableTotalRecordCount** | **bool?**| Total record count. | [optional] [default to true]

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
| **200** | Artists returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

