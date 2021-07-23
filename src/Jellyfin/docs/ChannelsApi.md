# Jellyfin.Api.Api.ChannelsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllChannelFeatures**](ChannelsApi.md#getallchannelfeatures) | **GET** /Channels/Features | Get all channel features.
[**GetChannelFeatures**](ChannelsApi.md#getchannelfeatures) | **GET** /Channels/{channelId}/Features | Get channel features.
[**GetChannelItems**](ChannelsApi.md#getchannelitems) | **GET** /Channels/{channelId}/Items | Get channel items.
[**GetChannels**](ChannelsApi.md#getchannels) | **GET** /Channels | Gets available channels.
[**GetLatestChannelItems**](ChannelsApi.md#getlatestchannelitems) | **GET** /Channels/Items/Latest | Gets latest channel items.



## GetAllChannelFeatures

> List&lt;ChannelFeatures&gt; GetAllChannelFeatures ()

Get all channel features.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetAllChannelFeaturesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);

            try
            {
                // Get all channel features.
                List<ChannelFeatures> result = apiInstance.GetAllChannelFeatures();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetAllChannelFeatures: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;ChannelFeatures&gt;**](ChannelFeatures.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All channel features returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetChannelFeatures

> ChannelFeatures GetChannelFeatures (Guid channelId)

Get channel features.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetChannelFeaturesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = new Guid(); // Guid | Channel id.

            try
            {
                // Get channel features.
                ChannelFeatures result = apiInstance.GetChannelFeatures(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetChannelFeatures: " + e.Message );
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
 **channelId** | [**Guid**](Guid.md)| Channel id. | 

### Return type

[**ChannelFeatures**](ChannelFeatures.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel features returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetChannelItems

> BaseItemDtoQueryResult GetChannelItems (Guid channelId, Guid? folderId = null, Guid? userId = null, int? startIndex = null, int? limit = null, List<SortOrder> sortOrder = null, List<ItemFilter> filters = null, List<string> sortBy = null, List<ItemFields> fields = null)

Get channel items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetChannelItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = new Guid(); // Guid | Channel Id.
            var folderId = new Guid?(); // Guid? | Optional. Folder Id. (optional) 
            var userId = new Guid?(); // Guid? | Optional. User Id. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var sortOrder = new List<SortOrder>(); // List<SortOrder> | Optional. Sort Order - Ascending,Descending. (optional) 
            var filters = new List<ItemFilter>(); // List<ItemFilter> | Optional. Specify additional filters to apply. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 

            try
            {
                // Get channel items.
                BaseItemDtoQueryResult result = apiInstance.GetChannelItems(channelId, folderId, userId, startIndex, limit, sortOrder, filters, sortBy, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetChannelItems: " + e.Message );
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
 **channelId** | [**Guid**](Guid.md)| Channel Id. | 
 **folderId** | [**Guid?**](Guid?.md)| Optional. Folder Id. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. User Id. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **sortOrder** | [**List&lt;SortOrder&gt;**](SortOrder.md)| Optional. Sort Order - Ascending,Descending. | [optional] 
 **filters** | [**List&lt;ItemFilter&gt;**](ItemFilter.md)| Optional. Specify additional filters to apply. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 

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
| **200** | Channel items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetChannels

> BaseItemDtoQueryResult GetChannels (Guid? userId = null, int? startIndex = null, int? limit = null, bool? supportsLatestItems = null, bool? supportsMediaDeletion = null, bool? isFavorite = null)

Gets available channels.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | User Id to filter by. Use System.Guid.Empty to not filter by user. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var supportsLatestItems = true;  // bool? | Optional. Filter by channels that support getting latest items. (optional) 
            var supportsMediaDeletion = true;  // bool? | Optional. Filter by channels that support media deletion. (optional) 
            var isFavorite = true;  // bool? | Optional. Filter by channels that are favorite. (optional) 

            try
            {
                // Gets available channels.
                BaseItemDtoQueryResult result = apiInstance.GetChannels(userId, startIndex, limit, supportsLatestItems, supportsMediaDeletion, isFavorite);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetChannels: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| User Id to filter by. Use System.Guid.Empty to not filter by user. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **supportsLatestItems** | **bool?**| Optional. Filter by channels that support getting latest items. | [optional] 
 **supportsMediaDeletion** | **bool?**| Optional. Filter by channels that support media deletion. | [optional] 
 **isFavorite** | **bool?**| Optional. Filter by channels that are favorite. | [optional] 

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
| **200** | Channels returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLatestChannelItems

> BaseItemDtoQueryResult GetLatestChannelItems (Guid? userId = null, int? startIndex = null, int? limit = null, List<ItemFilter> filters = null, List<ItemFields> fields = null, List<Guid> channelIds = null)

Gets latest channel items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLatestChannelItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | Optional. User Id. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var filters = new List<ItemFilter>(); // List<ItemFilter> | Optional. Specify additional filters to apply. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var channelIds = new List<Guid>(); // List<Guid> | Optional. Specify one or more channel id's, comma delimited. (optional) 

            try
            {
                // Gets latest channel items.
                BaseItemDtoQueryResult result = apiInstance.GetLatestChannelItems(userId, startIndex, limit, filters, fields, channelIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetLatestChannelItems: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. User Id. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **filters** | [**List&lt;ItemFilter&gt;**](ItemFilter.md)| Optional. Specify additional filters to apply. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **channelIds** | [**List&lt;Guid&gt;**](Guid.md)| Optional. Specify one or more channel id&#39;s, comma delimited. | [optional] 

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
| **200** | Latest channel items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

