# Jellyfin.Api.Api.SearchApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](SearchApi.md#get) | **GET** /Search/Hints | Gets the search hint result.



## Get

> SearchHintResult Get (string searchTerm, int? startIndex = null, int? limit = null, Guid? userId = null, List<string> includeItemTypes = null, List<string> excludeItemTypes = null, List<string> mediaTypes = null, Guid? parentId = null, bool? isMovie = null, bool? isSeries = null, bool? isNews = null, bool? isKids = null, bool? isSports = null, bool? includePeople = null, bool? includeMedia = null, bool? includeGenres = null, bool? includeStudios = null, bool? includeArtists = null)

Gets the search hint result.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SearchApi(Configuration.Default);
            var searchTerm = searchTerm_example;  // string | The search term to filter on.
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Supply a user id to search within a user's library or omit to search all. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | If specified, only results with the specified item types are returned. This allows multiple, comma delimeted. (optional) 
            var excludeItemTypes = new List<string>(); // List<string> | If specified, results with these item types are filtered out. This allows multiple, comma delimeted. (optional) 
            var mediaTypes = new List<string>(); // List<string> | If specified, only results with the specified media types are returned. This allows multiple, comma delimeted. (optional) 
            var parentId = new Guid?(); // Guid? | If specified, only children of the parent are returned. (optional) 
            var isMovie = true;  // bool? | Optional filter for movies. (optional) 
            var isSeries = true;  // bool? | Optional filter for series. (optional) 
            var isNews = true;  // bool? | Optional filter for news. (optional) 
            var isKids = true;  // bool? | Optional filter for kids. (optional) 
            var isSports = true;  // bool? | Optional filter for sports. (optional) 
            var includePeople = true;  // bool? | Optional filter whether to include people. (optional)  (default to true)
            var includeMedia = true;  // bool? | Optional filter whether to include media. (optional)  (default to true)
            var includeGenres = true;  // bool? | Optional filter whether to include genres. (optional)  (default to true)
            var includeStudios = true;  // bool? | Optional filter whether to include studios. (optional)  (default to true)
            var includeArtists = true;  // bool? | Optional filter whether to include artists. (optional)  (default to true)

            try
            {
                // Gets the search hint result.
                SearchHintResult result = apiInstance.Get(searchTerm, startIndex, limit, userId, includeItemTypes, excludeItemTypes, mediaTypes, parentId, isMovie, isSeries, isNews, isKids, isSports, includePeople, includeMedia, includeGenres, includeStudios, includeArtists);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SearchApi.Get: " + e.Message );
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
 **searchTerm** | **string**| The search term to filter on. | 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Supply a user id to search within a user&#39;s library or omit to search all. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| If specified, only results with the specified item types are returned. This allows multiple, comma delimeted. | [optional] 
 **excludeItemTypes** | [**List&lt;string&gt;**](string.md)| If specified, results with these item types are filtered out. This allows multiple, comma delimeted. | [optional] 
 **mediaTypes** | [**List&lt;string&gt;**](string.md)| If specified, only results with the specified media types are returned. This allows multiple, comma delimeted. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| If specified, only children of the parent are returned. | [optional] 
 **isMovie** | **bool?**| Optional filter for movies. | [optional] 
 **isSeries** | **bool?**| Optional filter for series. | [optional] 
 **isNews** | **bool?**| Optional filter for news. | [optional] 
 **isKids** | **bool?**| Optional filter for kids. | [optional] 
 **isSports** | **bool?**| Optional filter for sports. | [optional] 
 **includePeople** | **bool?**| Optional filter whether to include people. | [optional] [default to true]
 **includeMedia** | **bool?**| Optional filter whether to include media. | [optional] [default to true]
 **includeGenres** | **bool?**| Optional filter whether to include genres. | [optional] [default to true]
 **includeStudios** | **bool?**| Optional filter whether to include studios. | [optional] [default to true]
 **includeArtists** | **bool?**| Optional filter whether to include artists. | [optional] [default to true]

### Return type

[**SearchHintResult**](SearchHintResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Search hint returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

