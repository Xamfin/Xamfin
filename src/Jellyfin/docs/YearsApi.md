# Jellyfin.Api.Api.YearsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetYear**](YearsApi.md#getyear) | **GET** /Years/{year} | Gets a year.
[**GetYears**](YearsApi.md#getyears) | **GET** /Years | Get years.



## GetYear

> BaseItemDto GetYear (int year, Guid? userId = null)

Gets a year.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetYearExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new YearsApi(Configuration.Default);
            var year = 56;  // int | The year.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 

            try
            {
                // Gets a year.
                BaseItemDto result = apiInstance.GetYear(year, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling YearsApi.GetYear: " + e.Message );
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
 **year** | **int**| The year. | 
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
| **200** | Year returned. |  -  |
| **404** | Year not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetYears

> BaseItemDtoQueryResult GetYears (int? startIndex = null, int? limit = null, List<SortOrder> sortOrder = null, Guid? parentId = null, List<ItemFields> fields = null, List<string> excludeItemTypes = null, List<string> includeItemTypes = null, List<string> mediaTypes = null, List<string> sortBy = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, Guid? userId = null, bool? recursive = null, bool? enableImages = null)

Get years.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetYearsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new YearsApi(Configuration.Default);
            var startIndex = 56;  // int? | Skips over a given number of items within the results. Use for paging. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var sortOrder = new List<SortOrder>(); // List<SortOrder> | Sort Order - Ascending,Descending. (optional) 
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var excludeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be excluded based on item type. This allows multiple, comma delimited. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be included based on item type. This allows multiple, comma delimited. (optional) 
            var mediaTypes = new List<string>(); // List<string> | Optional. Filter by MediaType. Allows multiple, comma delimited. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var userId = new Guid?(); // Guid? | User Id. (optional) 
            var recursive = true;  // bool? | Search recursively. (optional)  (default to true)
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional)  (default to true)

            try
            {
                // Get years.
                BaseItemDtoQueryResult result = apiInstance.GetYears(startIndex, limit, sortOrder, parentId, fields, excludeItemTypes, includeItemTypes, mediaTypes, sortBy, enableUserData, imageTypeLimit, enableImageTypes, userId, recursive, enableImages);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling YearsApi.GetYears: " + e.Message );
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
 **startIndex** | **int?**| Skips over a given number of items within the results. Use for paging. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **sortOrder** | [**List&lt;SortOrder&gt;**](SortOrder.md)| Sort Order - Ascending,Descending. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **excludeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be excluded based on item type. This allows multiple, comma delimited. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be included based on item type. This allows multiple, comma delimited. | [optional] 
 **mediaTypes** | [**List&lt;string&gt;**](string.md)| Optional. Filter by MediaType. Allows multiple, comma delimited. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| User Id. | [optional] 
 **recursive** | **bool?**| Search recursively. | [optional] [default to true]
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
| **200** | Year query returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

