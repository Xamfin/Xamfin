# Jellyfin.Api.Api.MoviesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMovieRecommendations**](MoviesApi.md#getmovierecommendations) | **GET** /Movies/Recommendations | Gets movie recommendations.



## GetMovieRecommendations

> List&lt;RecommendationDto&gt; GetMovieRecommendations (Guid? userId = null, Guid? parentId = null, List<ItemFields> fields = null, int? categoryLimit = null, int? itemLimit = null)

Gets movie recommendations.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetMovieRecommendationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new MoviesApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. The fields to return. (optional) 
            var categoryLimit = 56;  // int? | The max number of categories to return. (optional)  (default to 5)
            var itemLimit = 56;  // int? | The max number of items to return per category. (optional)  (default to 8)

            try
            {
                // Gets movie recommendations.
                List<RecommendationDto> result = apiInstance.GetMovieRecommendations(userId, parentId, fields, categoryLimit, itemLimit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MoviesApi.GetMovieRecommendations: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. The fields to return. | [optional] 
 **categoryLimit** | **int?**| The max number of categories to return. | [optional] [default to 5]
 **itemLimit** | **int?**| The max number of items to return per category. | [optional] [default to 8]

### Return type

[**List&lt;RecommendationDto&gt;**](RecommendationDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Movie recommendations returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

