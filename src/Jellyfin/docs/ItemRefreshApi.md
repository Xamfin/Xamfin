# Jellyfin.Api.Api.ItemRefreshApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Post**](ItemRefreshApi.md#post) | **POST** /Items/{itemId}/Refresh | Refreshes metadata for an item.



## Post

> void Post (Guid itemId, MetadataRefreshMode? metadataRefreshMode = null, MetadataRefreshMode? imageRefreshMode = null, bool? replaceAllMetadata = null, bool? replaceAllImages = null)

Refreshes metadata for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ItemRefreshApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var metadataRefreshMode = ;  // MetadataRefreshMode? | (Optional) Specifies the metadata refresh mode. (optional) 
            var imageRefreshMode = ;  // MetadataRefreshMode? | (Optional) Specifies the image refresh mode. (optional) 
            var replaceAllMetadata = true;  // bool? | (Optional) Determines if metadata should be replaced. Only applicable if mode is FullRefresh. (optional)  (default to false)
            var replaceAllImages = true;  // bool? | (Optional) Determines if images should be replaced. Only applicable if mode is FullRefresh. (optional)  (default to false)

            try
            {
                // Refreshes metadata for an item.
                apiInstance.Post(itemId, metadataRefreshMode, imageRefreshMode, replaceAllMetadata, replaceAllImages);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemRefreshApi.Post: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **metadataRefreshMode** | **MetadataRefreshMode?**| (Optional) Specifies the metadata refresh mode. | [optional] 
 **imageRefreshMode** | **MetadataRefreshMode?**| (Optional) Specifies the image refresh mode. | [optional] 
 **replaceAllMetadata** | **bool?**| (Optional) Determines if metadata should be replaced. Only applicable if mode is FullRefresh. | [optional] [default to false]
 **replaceAllImages** | **bool?**| (Optional) Determines if images should be replaced. Only applicable if mode is FullRefresh. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Item metadata refresh queued. |  -  |
| **404** | Item to refresh not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

