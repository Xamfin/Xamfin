# Jellyfin.Api.Api.PlaystateApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MarkPlayedItem**](PlaystateApi.md#markplayeditem) | **POST** /Users/{userId}/PlayedItems/{itemId} | Marks an item as played for user.
[**MarkUnplayedItem**](PlaystateApi.md#markunplayeditem) | **DELETE** /Users/{userId}/PlayedItems/{itemId} | Marks an item as unplayed for user.
[**OnPlaybackProgress**](PlaystateApi.md#onplaybackprogress) | **POST** /Users/{userId}/PlayingItems/{itemId}/Progress | Reports a user&#39;s playback progress.
[**OnPlaybackStart**](PlaystateApi.md#onplaybackstart) | **POST** /Users/{userId}/PlayingItems/{itemId} | Reports that a user has begun playing an item.
[**OnPlaybackStopped**](PlaystateApi.md#onplaybackstopped) | **DELETE** /Users/{userId}/PlayingItems/{itemId} | Reports that a user has stopped playing an item.
[**PingPlaybackSession**](PlaystateApi.md#pingplaybacksession) | **POST** /Sessions/Playing/Ping | Pings a playback session.
[**ReportPlaybackProgress**](PlaystateApi.md#reportplaybackprogress) | **POST** /Sessions/Playing/Progress | Reports playback progress within a session.
[**ReportPlaybackStart**](PlaystateApi.md#reportplaybackstart) | **POST** /Sessions/Playing | Reports playback has started within a session.
[**ReportPlaybackStopped**](PlaystateApi.md#reportplaybackstopped) | **POST** /Sessions/Playing/Stopped | Reports playback has stopped within a session.



## MarkPlayedItem

> UserItemDataDto MarkPlayedItem (Guid userId, Guid itemId, DateTime? datePlayed = null)

Marks an item as played for user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class MarkPlayedItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.
            var datePlayed = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The date the item was played. (optional) 

            try
            {
                // Marks an item as played for user.
                UserItemDataDto result = apiInstance.MarkPlayedItem(userId, itemId, datePlayed);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.MarkPlayedItem: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **datePlayed** | **DateTime?**| Optional. The date the item was played. | [optional] 

### Return type

[**UserItemDataDto**](UserItemDataDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item marked as played. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MarkUnplayedItem

> UserItemDataDto MarkUnplayedItem (Guid userId, Guid itemId)

Marks an item as unplayed for user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class MarkUnplayedItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Marks an item as unplayed for user.
                UserItemDataDto result = apiInstance.MarkUnplayedItem(userId, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.MarkUnplayedItem: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 

### Return type

[**UserItemDataDto**](UserItemDataDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item marked as unplayed. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OnPlaybackProgress

> void OnPlaybackProgress (Guid userId, Guid itemId, string mediaSourceId = null, long? positionTicks = null, int? audioStreamIndex = null, int? subtitleStreamIndex = null, int? volumeLevel = null, PlayMethod? playMethod = null, string liveStreamId = null, string playSessionId = null, RepeatMode? repeatMode = null, bool? isPaused = null, bool? isMuted = null)

Reports a user's playback progress.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class OnPlaybackProgressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.
            var mediaSourceId = mediaSourceId_example;  // string | The id of the MediaSource. (optional) 
            var positionTicks = 789;  // long? | Optional. The current position, in ticks. 1 tick = 10000 ms. (optional) 
            var audioStreamIndex = 56;  // int? | The audio stream index. (optional) 
            var subtitleStreamIndex = 56;  // int? | The subtitle stream index. (optional) 
            var volumeLevel = 56;  // int? | Scale of 0-100. (optional) 
            var playMethod = ;  // PlayMethod? | The play method. (optional) 
            var liveStreamId = liveStreamId_example;  // string | The live stream id. (optional) 
            var playSessionId = playSessionId_example;  // string | The play session id. (optional) 
            var repeatMode = ;  // RepeatMode? | The repeat mode. (optional) 
            var isPaused = true;  // bool? | Indicates if the player is paused. (optional)  (default to false)
            var isMuted = true;  // bool? | Indicates if the player is muted. (optional)  (default to false)

            try
            {
                // Reports a user's playback progress.
                apiInstance.OnPlaybackProgress(userId, itemId, mediaSourceId, positionTicks, audioStreamIndex, subtitleStreamIndex, volumeLevel, playMethod, liveStreamId, playSessionId, repeatMode, isPaused, isMuted);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.OnPlaybackProgress: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **mediaSourceId** | **string**| The id of the MediaSource. | [optional] 
 **positionTicks** | **long?**| Optional. The current position, in ticks. 1 tick &#x3D; 10000 ms. | [optional] 
 **audioStreamIndex** | **int?**| The audio stream index. | [optional] 
 **subtitleStreamIndex** | **int?**| The subtitle stream index. | [optional] 
 **volumeLevel** | **int?**| Scale of 0-100. | [optional] 
 **playMethod** | **PlayMethod?**| The play method. | [optional] 
 **liveStreamId** | **string**| The live stream id. | [optional] 
 **playSessionId** | **string**| The play session id. | [optional] 
 **repeatMode** | **RepeatMode?**| The repeat mode. | [optional] 
 **isPaused** | **bool?**| Indicates if the player is paused. | [optional] [default to false]
 **isMuted** | **bool?**| Indicates if the player is muted. | [optional] [default to false]

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
| **204** | Play progress recorded. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OnPlaybackStart

> void OnPlaybackStart (Guid userId, Guid itemId, string mediaSourceId = null, int? audioStreamIndex = null, int? subtitleStreamIndex = null, PlayMethod? playMethod = null, string liveStreamId = null, string playSessionId = null, bool? canSeek = null)

Reports that a user has begun playing an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class OnPlaybackStartExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.
            var mediaSourceId = mediaSourceId_example;  // string | The id of the MediaSource. (optional) 
            var audioStreamIndex = 56;  // int? | The audio stream index. (optional) 
            var subtitleStreamIndex = 56;  // int? | The subtitle stream index. (optional) 
            var playMethod = ;  // PlayMethod? | The play method. (optional) 
            var liveStreamId = liveStreamId_example;  // string | The live stream id. (optional) 
            var playSessionId = playSessionId_example;  // string | The play session id. (optional) 
            var canSeek = true;  // bool? | Indicates if the client can seek. (optional)  (default to false)

            try
            {
                // Reports that a user has begun playing an item.
                apiInstance.OnPlaybackStart(userId, itemId, mediaSourceId, audioStreamIndex, subtitleStreamIndex, playMethod, liveStreamId, playSessionId, canSeek);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.OnPlaybackStart: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **mediaSourceId** | **string**| The id of the MediaSource. | [optional] 
 **audioStreamIndex** | **int?**| The audio stream index. | [optional] 
 **subtitleStreamIndex** | **int?**| The subtitle stream index. | [optional] 
 **playMethod** | **PlayMethod?**| The play method. | [optional] 
 **liveStreamId** | **string**| The live stream id. | [optional] 
 **playSessionId** | **string**| The play session id. | [optional] 
 **canSeek** | **bool?**| Indicates if the client can seek. | [optional] [default to false]

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
| **204** | Play start recorded. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OnPlaybackStopped

> void OnPlaybackStopped (Guid userId, Guid itemId, string mediaSourceId = null, string nextMediaType = null, long? positionTicks = null, string liveStreamId = null, string playSessionId = null)

Reports that a user has stopped playing an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class OnPlaybackStoppedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.
            var mediaSourceId = mediaSourceId_example;  // string | The id of the MediaSource. (optional) 
            var nextMediaType = nextMediaType_example;  // string | The next media type that will play. (optional) 
            var positionTicks = 789;  // long? | Optional. The position, in ticks, where playback stopped. 1 tick = 10000 ms. (optional) 
            var liveStreamId = liveStreamId_example;  // string | The live stream id. (optional) 
            var playSessionId = playSessionId_example;  // string | The play session id. (optional) 

            try
            {
                // Reports that a user has stopped playing an item.
                apiInstance.OnPlaybackStopped(userId, itemId, mediaSourceId, nextMediaType, positionTicks, liveStreamId, playSessionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.OnPlaybackStopped: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **mediaSourceId** | **string**| The id of the MediaSource. | [optional] 
 **nextMediaType** | **string**| The next media type that will play. | [optional] 
 **positionTicks** | **long?**| Optional. The position, in ticks, where playback stopped. 1 tick &#x3D; 10000 ms. | [optional] 
 **liveStreamId** | **string**| The live stream id. | [optional] 
 **playSessionId** | **string**| The play session id. | [optional] 

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
| **204** | Playback stop recorded. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PingPlaybackSession

> void PingPlaybackSession (string playSessionId)

Pings a playback session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PingPlaybackSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var playSessionId = playSessionId_example;  // string | Playback session id.

            try
            {
                // Pings a playback session.
                apiInstance.PingPlaybackSession(playSessionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.PingPlaybackSession: " + e.Message );
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
 **playSessionId** | **string**| Playback session id. | 

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
| **204** | Playback session pinged. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReportPlaybackProgress

> void ReportPlaybackProgress (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Reports playback progress within a session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ReportPlaybackProgressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The playback progress info. (optional) 

            try
            {
                // Reports playback progress within a session.
                apiInstance.ReportPlaybackProgress(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.ReportPlaybackProgress: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The playback progress info. | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Playback progress recorded. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReportPlaybackStart

> void ReportPlaybackStart (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Reports playback has started within a session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ReportPlaybackStartExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The playback start info. (optional) 

            try
            {
                // Reports playback has started within a session.
                apiInstance.ReportPlaybackStart(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.ReportPlaybackStart: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The playback start info. | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Playback start recorded. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReportPlaybackStopped

> void ReportPlaybackStopped (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Reports playback has stopped within a session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ReportPlaybackStoppedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PlaystateApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The playback stop info. (optional) 

            try
            {
                // Reports playback has stopped within a session.
                apiInstance.ReportPlaybackStopped(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlaystateApi.ReportPlaybackStopped: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The playback stop info. | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Playback stop recorded. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

