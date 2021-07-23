# Jellyfin.Api.Api.RemoteImageApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadRemoteImage**](RemoteImageApi.md#downloadremoteimage) | **POST** /Items/{itemId}/RemoteImages/Download | Downloads a remote image for an item.
[**GetRemoteImageProviders**](RemoteImageApi.md#getremoteimageproviders) | **GET** /Items/{itemId}/RemoteImages/Providers | Gets available remote image providers for an item.
[**GetRemoteImages**](RemoteImageApi.md#getremoteimages) | **GET** /Items/{itemId}/RemoteImages | Gets available remote images for an item.



## DownloadRemoteImage

> void DownloadRemoteImage (Guid itemId, ImageType type, string imageUrl = null)

Downloads a remote image for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DownloadRemoteImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new RemoteImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item Id.
            var type = ;  // ImageType | The image type.
            var imageUrl = imageUrl_example;  // string | The image url. (optional) 

            try
            {
                // Downloads a remote image for an item.
                apiInstance.DownloadRemoteImage(itemId, type, imageUrl);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RemoteImageApi.DownloadRemoteImage: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item Id. | 
 **type** | **ImageType**| The image type. | 
 **imageUrl** | **string**| The image url. | [optional] 

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
| **204** | Remote image downloaded. |  -  |
| **404** | Remote image not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRemoteImageProviders

> List&lt;ImageProviderInfo&gt; GetRemoteImageProviders (Guid itemId)

Gets available remote image providers for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRemoteImageProvidersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new RemoteImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item Id.

            try
            {
                // Gets available remote image providers for an item.
                List<ImageProviderInfo> result = apiInstance.GetRemoteImageProviders(itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RemoteImageApi.GetRemoteImageProviders: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item Id. | 

### Return type

[**List&lt;ImageProviderInfo&gt;**](ImageProviderInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned remote image providers. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRemoteImages

> RemoteImageResult GetRemoteImages (Guid itemId, ImageType? type = null, int? startIndex = null, int? limit = null, string providerName = null, bool? includeAllLanguages = null)

Gets available remote images for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRemoteImagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new RemoteImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item Id.
            var type = ;  // ImageType? | The image type. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var providerName = providerName_example;  // string | Optional. The image provider to use. (optional) 
            var includeAllLanguages = true;  // bool? | Optional. Include all languages. (optional)  (default to false)

            try
            {
                // Gets available remote images for an item.
                RemoteImageResult result = apiInstance.GetRemoteImages(itemId, type, startIndex, limit, providerName, includeAllLanguages);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RemoteImageApi.GetRemoteImages: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item Id. | 
 **type** | **ImageType?**| The image type. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **providerName** | **string**| Optional. The image provider to use. | [optional] 
 **includeAllLanguages** | **bool?**| Optional. Include all languages. | [optional] [default to false]

### Return type

[**RemoteImageResult**](RemoteImageResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Remote Images returned. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

