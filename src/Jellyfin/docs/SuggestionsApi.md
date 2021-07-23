# Jellyfin.Api.Api.SuggestionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSuggestions**](SuggestionsApi.md#getsuggestions) | **GET** /Users/{userId}/Suggestions | Gets suggestions.



## GetSuggestions

> BaseItemDtoQueryResult GetSuggestions (Guid userId, List<string> mediaType = null, List<string> type = null, int? startIndex = null, int? limit = null, bool? enableTotalRecordCount = null)

Gets suggestions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSuggestionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SuggestionsApi(Configuration.Default);
            var userId = new Guid(); // Guid | The user id.
            var mediaType = new List<string>(); // List<string> | The media types. (optional) 
            var type = new List<string>(); // List<string> | The type. (optional) 
            var startIndex = 56;  // int? | Optional. The start index. (optional) 
            var limit = 56;  // int? | Optional. The limit. (optional) 
            var enableTotalRecordCount = true;  // bool? | Whether to enable the total record count. (optional)  (default to false)

            try
            {
                // Gets suggestions.
                BaseItemDtoQueryResult result = apiInstance.GetSuggestions(userId, mediaType, type, startIndex, limit, enableTotalRecordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SuggestionsApi.GetSuggestions: " + e.Message );
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
 **mediaType** | [**List&lt;string&gt;**](string.md)| The media types. | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| The type. | [optional] 
 **startIndex** | **int?**| Optional. The start index. | [optional] 
 **limit** | **int?**| Optional. The limit. | [optional] 
 **enableTotalRecordCount** | **bool?**| Whether to enable the total record count. | [optional] [default to false]

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
| **200** | Suggestions returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

