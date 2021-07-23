# Jellyfin.Api.Api.GenresApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGenre**](GenresApi.md#getgenre) | **GET** /Genres/{genreName} | Gets a genre, by name.
[**GetGenres**](GenresApi.md#getgenres) | **GET** /Genres | Gets all genres from a given item, folder, or the entire library.



## GetGenre

> BaseItemDto GetGenre (string genreName, Guid? userId = null)

Gets a genre, by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetGenreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new GenresApi(Configuration.Default);
            var genreName = genreName_example;  // string | The genre name.
            var userId = new Guid?(); // Guid? | The user id. (optional) 

            try
            {
                // Gets a genre, by name.
                BaseItemDto result = apiInstance.GetGenre(genreName, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GenresApi.GetGenre: " + e.Message );
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
 **genreName** | **string**| The genre name. | 
 **userId** | [**Guid?**](Guid?.md)| The user id. | [optional] 

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
| **200** | Genres returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetGenres

> BaseItemDtoQueryResult GetGenres (int? startIndex = null, int? limit = null, string searchTerm = null, Guid? parentId = null, List<ItemFields> fields = null, List<string> excludeItemTypes = null, List<string> includeItemTypes = null, bool? isFavorite = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, Guid? userId = null, string nameStartsWithOrGreater = null, string nameStartsWith = null, string nameLessThan = null, bool? enableImages = null, bool? enableTotalRecordCount = null)

Gets all genres from a given item, folder, or the entire library.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetGenresExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new GenresApi(Configuration.Default);
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var searchTerm = searchTerm_example;  // string | The search term. (optional) 
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var excludeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered out based on item type. This allows multiple, comma delimited. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered in based on item type. This allows multiple, comma delimited. (optional) 
            var isFavorite = true;  // bool? | Optional filter by items that are marked as favorite, or not. (optional) 
            var imageTypeLimit = 56;  // int? | Optional, the max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var userId = new Guid?(); // Guid? | User id. (optional) 
            var nameStartsWithOrGreater = nameStartsWithOrGreater_example;  // string | Optional filter by items whose name is sorted equally or greater than a given input string. (optional) 
            var nameStartsWith = nameStartsWith_example;  // string | Optional filter by items whose name is sorted equally than a given input string. (optional) 
            var nameLessThan = nameLessThan_example;  // string | Optional filter by items whose name is equally or lesser than a given input string. (optional) 
            var enableImages = true;  // bool? | Optional, include image information in output. (optional)  (default to true)
            var enableTotalRecordCount = true;  // bool? | Optional. Include total record count. (optional)  (default to true)

            try
            {
                // Gets all genres from a given item, folder, or the entire library.
                BaseItemDtoQueryResult result = apiInstance.GetGenres(startIndex, limit, searchTerm, parentId, fields, excludeItemTypes, includeItemTypes, isFavorite, imageTypeLimit, enableImageTypes, userId, nameStartsWithOrGreater, nameStartsWith, nameLessThan, enableImages, enableTotalRecordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GenresApi.GetGenres: " + e.Message );
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
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **searchTerm** | **string**| The search term. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **excludeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered out based on item type. This allows multiple, comma delimited. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered in based on item type. This allows multiple, comma delimited. | [optional] 
 **isFavorite** | **bool?**| Optional filter by items that are marked as favorite, or not. | [optional] 
 **imageTypeLimit** | **int?**| Optional, the max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| User id. | [optional] 
 **nameStartsWithOrGreater** | **string**| Optional filter by items whose name is sorted equally or greater than a given input string. | [optional] 
 **nameStartsWith** | **string**| Optional filter by items whose name is sorted equally than a given input string. | [optional] 
 **nameLessThan** | **string**| Optional filter by items whose name is equally or lesser than a given input string. | [optional] 
 **enableImages** | **bool?**| Optional, include image information in output. | [optional] [default to true]
 **enableTotalRecordCount** | **bool?**| Optional. Include total record count. | [optional] [default to true]

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
| **200** | Genres returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

