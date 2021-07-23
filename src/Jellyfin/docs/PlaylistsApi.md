# Jellyfin.Api.Api.PlaylistsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddToPlaylist**](PlaylistsApi.md#addtoplaylist) | **POST** /Playlists/{playlistId}/Items | Adds items to a playlist.
[**CreatePlaylist**](PlaylistsApi.md#createplaylist) | **POST** /Playlists | Creates a new playlist.
[**GetPlaylistItems**](PlaylistsApi.md#getplaylistitems) | **GET** /Playlists/{playlistId}/Items | Gets the original items of a playlist.
[**MoveItem**](PlaylistsApi.md#moveitem) | **POST** /Playlists/{playlistId}/Items/{itemId}/Move/{newIndex} | Moves a playlist item.
[**RemoveFromPlaylist**](PlaylistsApi.md#removefromplaylist) | **DELETE** /Playlists/{playlistId}/Items | Removes items from a playlist.



## AddToPlaylist

> void AddToPlaylist (Guid playlistId, List<Guid> ids = null, Guid? userId = null)

Adds items to a playlist.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class AddToPlaylistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaylistsApi(Configuration.Default);
            var playlistId = new Guid(); // Guid | The playlist id.
            var ids = new List<Guid>(); // List<Guid> | Item id, comma delimited. (optional) 
            var userId = new Guid?(); // Guid? | The userId. (optional) 

            try
            {
                // Adds items to a playlist.
                apiInstance.AddToPlaylist(playlistId, ids, userId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaylistsApi.AddToPlaylist: " + e.Message );
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
 **playlistId** | [**Guid**](Guid.md)| The playlist id. | 
 **ids** | [**List&lt;Guid&gt;**](Guid.md)| Item id, comma delimited. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| The userId. | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Items added to playlist. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreatePlaylist

> PlaylistCreationResult CreatePlaylist (string name = null, List<Guid> ids = null, Guid? userId = null, string mediaType = null, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Creates a new playlist.

For backwards compatibility parameters can be sent via Query or Body, with Query having higher precedence.  Query parameters are obsolete.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class CreatePlaylistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaylistsApi(Configuration.Default);
            var name = name_example;  // string | The playlist name. (optional) 
            var ids = new List<Guid>(); // List<Guid> | The item ids. (optional) 
            var userId = new Guid?(); // Guid? | The user id. (optional) 
            var mediaType = mediaType_example;  // string | The media type. (optional) 
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The create playlist payload. (optional) 

            try
            {
                // Creates a new playlist.
                PlaylistCreationResult result = apiInstance.CreatePlaylist(name, ids, userId, mediaType, UNKNOWN_BASE_TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaylistsApi.CreatePlaylist: " + e.Message );
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
 **name** | **string**| The playlist name. | [optional] 
 **ids** | [**List&lt;Guid&gt;**](Guid.md)| The item ids. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| The user id. | [optional] 
 **mediaType** | **string**| The media type. | [optional] 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The create playlist payload. | [optional] 

### Return type

[**PlaylistCreationResult**](PlaylistCreationResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlaylistItems

> BaseItemDtoQueryResult GetPlaylistItems (Guid playlistId, Guid userId, int? startIndex = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Gets the original items of a playlist.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPlaylistItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaylistsApi(Configuration.Default);
            var playlistId = new Guid(); // Guid | The playlist id.
            var userId = new Guid(); // Guid | User id.
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Gets the original items of a playlist.
                BaseItemDtoQueryResult result = apiInstance.GetPlaylistItems(playlistId, userId, startIndex, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaylistsApi.GetPlaylistItems: " + e.Message );
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
 **playlistId** | [**Guid**](Guid.md)| The playlist id. | 
 **userId** | [**Guid**](Guid.md)| User id. | 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Original playlist returned. |  -  |
| **404** | Playlist not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MoveItem

> void MoveItem (string playlistId, string itemId, int newIndex)

Moves a playlist item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class MoveItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaylistsApi(Configuration.Default);
            var playlistId = playlistId_example;  // string | The playlist id.
            var itemId = itemId_example;  // string | The item id.
            var newIndex = 56;  // int | The new index.

            try
            {
                // Moves a playlist item.
                apiInstance.MoveItem(playlistId, itemId, newIndex);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaylistsApi.MoveItem: " + e.Message );
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
 **playlistId** | **string**| The playlist id. | 
 **itemId** | **string**| The item id. | 
 **newIndex** | **int**| The new index. | 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Item moved to new index. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveFromPlaylist

> void RemoveFromPlaylist (string playlistId, List<string> entryIds = null)

Removes items from a playlist.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class RemoveFromPlaylistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaylistsApi(Configuration.Default);
            var playlistId = playlistId_example;  // string | The playlist id.
            var entryIds = new List<string>(); // List<string> | The item ids, comma delimited. (optional) 

            try
            {
                // Removes items from a playlist.
                apiInstance.RemoveFromPlaylist(playlistId, entryIds);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaylistsApi.RemoveFromPlaylist: " + e.Message );
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
 **playlistId** | **string**| The playlist id. | 
 **entryIds** | [**List&lt;string&gt;**](string.md)| The item ids, comma delimited. | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Items removed. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

