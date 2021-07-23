# Jellyfin.Api.Api.FilterApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetQueryFilters**](FilterApi.md#getqueryfilters) | **GET** /Items/Filters2 | Gets query filters.
[**GetQueryFiltersLegacy**](FilterApi.md#getqueryfilterslegacy) | **GET** /Items/Filters | Gets legacy query filters.



## GetQueryFilters

> QueryFilters GetQueryFilters (Guid? userId = null, Guid? parentId = null, List<string> includeItemTypes = null, bool? isAiring = null, bool? isMovie = null, bool? isSports = null, bool? isKids = null, bool? isNews = null, bool? isSeries = null, bool? recursive = null)

Gets query filters.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetQueryFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new FilterApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | Optional. User id. (optional) 
            var parentId = new Guid?(); // Guid? | Optional. Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. (optional) 
            var isAiring = true;  // bool? | Optional. Is item airing. (optional) 
            var isMovie = true;  // bool? | Optional. Is item movie. (optional) 
            var isSports = true;  // bool? | Optional. Is item sports. (optional) 
            var isKids = true;  // bool? | Optional. Is item kids. (optional) 
            var isNews = true;  // bool? | Optional. Is item news. (optional) 
            var isSeries = true;  // bool? | Optional. Is item series. (optional) 
            var recursive = true;  // bool? | Optional. Search recursive. (optional) 

            try
            {
                // Gets query filters.
                QueryFilters result = apiInstance.GetQueryFilters(userId, parentId, includeItemTypes, isAiring, isMovie, isSports, isKids, isNews, isSeries, recursive);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilterApi.GetQueryFilters: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. User id. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Optional. Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. | [optional] 
 **isAiring** | **bool?**| Optional. Is item airing. | [optional] 
 **isMovie** | **bool?**| Optional. Is item movie. | [optional] 
 **isSports** | **bool?**| Optional. Is item sports. | [optional] 
 **isKids** | **bool?**| Optional. Is item kids. | [optional] 
 **isNews** | **bool?**| Optional. Is item news. | [optional] 
 **isSeries** | **bool?**| Optional. Is item series. | [optional] 
 **recursive** | **bool?**| Optional. Search recursive. | [optional] 

### Return type

[**QueryFilters**](QueryFilters.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Filters retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetQueryFiltersLegacy

> QueryFiltersLegacy GetQueryFiltersLegacy (Guid? userId = null, Guid? parentId = null, List<string> includeItemTypes = null, List<string> mediaTypes = null)

Gets legacy query filters.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetQueryFiltersLegacyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new FilterApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | Optional. User id. (optional) 
            var parentId = new Guid?(); // Guid? | Optional. Parent id. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. (optional) 
            var mediaTypes = new List<string>(); // List<string> | Optional. Filter by MediaType. Allows multiple, comma delimited. (optional) 

            try
            {
                // Gets legacy query filters.
                QueryFiltersLegacy result = apiInstance.GetQueryFiltersLegacy(userId, parentId, includeItemTypes, mediaTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilterApi.GetQueryFiltersLegacy: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. User id. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Optional. Parent id. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. | [optional] 
 **mediaTypes** | [**List&lt;string&gt;**](string.md)| Optional. Filter by MediaType. Allows multiple, comma delimited. | [optional] 

### Return type

[**QueryFiltersLegacy**](QueryFiltersLegacy.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Legacy filters retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

