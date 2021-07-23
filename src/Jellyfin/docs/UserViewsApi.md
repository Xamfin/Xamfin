# Jellyfin.Api.Api.UserViewsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGroupingOptions**](UserViewsApi.md#getgroupingoptions) | **GET** /Users/{userId}/GroupingOptions | Get user view grouping options.
[**GetUserViews**](UserViewsApi.md#getuserviews) | **GET** /Users/{userId}/Views | Get user views.



## GetGroupingOptions

> List&lt;SpecialViewOptionDto&gt; GetGroupingOptions (Guid userId)

Get user view grouping options.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetGroupingOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new UserViewsApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.

            try
            {
                // Get user view grouping options.
                List<SpecialViewOptionDto> result = apiInstance.GetGroupingOptions(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserViewsApi.GetGroupingOptions: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 

### Return type

[**List&lt;SpecialViewOptionDto&gt;**](SpecialViewOptionDto.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User view grouping options returned. |  -  |
| **404** | User not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUserViews

> BaseItemDtoQueryResult GetUserViews (Guid userId, bool? includeExternalContent = null, List<string> presetViews = null, bool? includeHidden = null)

Get user views.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetUserViewsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new UserViewsApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var includeExternalContent = true;  // bool? | Whether or not to include external views such as channels or live tv. (optional) 
            var presetViews = new List<string>(); // List<string> | Preset views. (optional) 
            var includeHidden = true;  // bool? | Whether or not to include hidden content. (optional)  (default to false)

            try
            {
                // Get user views.
                BaseItemDtoQueryResult result = apiInstance.GetUserViews(userId, includeExternalContent, presetViews, includeHidden);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserViewsApi.GetUserViews: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **includeExternalContent** | **bool?**| Whether or not to include external views such as channels or live tv. | [optional] 
 **presetViews** | [**List&lt;string&gt;**](string.md)| Preset views. | [optional] 
 **includeHidden** | **bool?**| Whether or not to include hidden content. | [optional] [default to false]

### Return type

[**BaseItemDtoQueryResult**](BaseItemDtoQueryResult.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User views returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

