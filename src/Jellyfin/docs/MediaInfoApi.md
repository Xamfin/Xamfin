# Jellyfin.Api.Api.MediaInfoApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloseLiveStream**](MediaInfoApi.md#closelivestream) | **POST** /LiveStreams/Close | Closes a media source.
[**GetBitrateTestBytes**](MediaInfoApi.md#getbitratetestbytes) | **GET** /Playback/BitrateTest | Tests the network with a request with the size of the bitrate.
[**GetPlaybackInfo**](MediaInfoApi.md#getplaybackinfo) | **GET** /Items/{itemId}/PlaybackInfo | Gets live playback media info for an item.
[**GetPostedPlaybackInfo**](MediaInfoApi.md#getpostedplaybackinfo) | **POST** /Items/{itemId}/PlaybackInfo | Gets live playback media info for an item.
[**OpenLiveStream**](MediaInfoApi.md#openlivestream) | **POST** /LiveStreams/Open | Opens a media source.



## CloseLiveStream

> void CloseLiveStream (string liveStreamId)

Closes a media source.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class CloseLiveStreamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new MediaInfoApi(Configuration.Default);
            var liveStreamId = liveStreamId_example;  // string | The livestream id.

            try
            {
                // Closes a media source.
                apiInstance.CloseLiveStream(liveStreamId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaInfoApi.CloseLiveStream: " + e.Message );
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
 **liveStreamId** | **string**| The livestream id. | 

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
| **204** | Livestream closed. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetBitrateTestBytes

> System.IO.Stream GetBitrateTestBytes (int? size = null)

Tests the network with a request with the size of the bitrate.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetBitrateTestBytesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new MediaInfoApi(Configuration.Default);
            var size = 56;  // int? | The bitrate. Defaults to 102400. (optional)  (default to 102400)

            try
            {
                // Tests the network with a request with the size of the bitrate.
                System.IO.Stream result = apiInstance.GetBitrateTestBytes(size);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaInfoApi.GetBitrateTestBytes: " + e.Message );
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
 **size** | **int?**| The bitrate. Defaults to 102400. | [optional] [default to 102400]

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octet-stream, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Test buffer returned. |  -  |
| **400** | Size has to be a numer between 0 and 10,000,000. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlaybackInfo

> PlaybackInfoResponse GetPlaybackInfo (Guid itemId, Guid userId)

Gets live playback media info for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPlaybackInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new MediaInfoApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var userId = new Guid(); // Guid | The user id.

            try
            {
                // Gets live playback media info for an item.
                PlaybackInfoResponse result = apiInstance.GetPlaybackInfo(itemId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaInfoApi.GetPlaybackInfo: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid**](Guid.md)| The user id. | 

### Return type

[**PlaybackInfoResponse**](PlaybackInfoResponse.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Playback info returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPostedPlaybackInfo

> PlaybackInfoResponse GetPostedPlaybackInfo (Guid itemId, Guid? userId = null, int? maxStreamingBitrate = null, long? startTimeTicks = null, int? audioStreamIndex = null, int? subtitleStreamIndex = null, int? maxAudioChannels = null, string mediaSourceId = null, string liveStreamId = null, bool? autoOpenLiveStream = null, bool? enableDirectPlay = null, bool? enableDirectStream = null, bool? enableTranscoding = null, bool? allowVideoStreamCopy = null, bool? allowAudioStreamCopy = null, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Gets live playback media info for an item.

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
    public class GetPostedPlaybackInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new MediaInfoApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | The user id. (optional) 
            var maxStreamingBitrate = 56;  // int? | The maximum streaming bitrate. (optional) 
            var startTimeTicks = 789;  // long? | The start time in ticks. (optional) 
            var audioStreamIndex = 56;  // int? | The audio stream index. (optional) 
            var subtitleStreamIndex = 56;  // int? | The subtitle stream index. (optional) 
            var maxAudioChannels = 56;  // int? | The maximum number of audio channels. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media source id. (optional) 
            var liveStreamId = liveStreamId_example;  // string | The livestream id. (optional) 
            var autoOpenLiveStream = true;  // bool? | Whether to auto open the livestream. (optional) 
            var enableDirectPlay = true;  // bool? | Whether to enable direct play. Default: true. (optional) 
            var enableDirectStream = true;  // bool? | Whether to enable direct stream. Default: true. (optional) 
            var enableTranscoding = true;  // bool? | Whether to enable transcoding. Default: true. (optional) 
            var allowVideoStreamCopy = true;  // bool? | Whether to allow to copy the video stream. Default: true. (optional) 
            var allowAudioStreamCopy = true;  // bool? | Whether to allow to copy the audio stream. Default: true. (optional) 
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The playback info. (optional) 

            try
            {
                // Gets live playback media info for an item.
                PlaybackInfoResponse result = apiInstance.GetPostedPlaybackInfo(itemId, userId, maxStreamingBitrate, startTimeTicks, audioStreamIndex, subtitleStreamIndex, maxAudioChannels, mediaSourceId, liveStreamId, autoOpenLiveStream, enableDirectPlay, enableDirectStream, enableTranscoding, allowVideoStreamCopy, allowAudioStreamCopy, UNKNOWN_BASE_TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaInfoApi.GetPostedPlaybackInfo: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| The user id. | [optional] 
 **maxStreamingBitrate** | **int?**| The maximum streaming bitrate. | [optional] 
 **startTimeTicks** | **long?**| The start time in ticks. | [optional] 
 **audioStreamIndex** | **int?**| The audio stream index. | [optional] 
 **subtitleStreamIndex** | **int?**| The subtitle stream index. | [optional] 
 **maxAudioChannels** | **int?**| The maximum number of audio channels. | [optional] 
 **mediaSourceId** | **string**| The media source id. | [optional] 
 **liveStreamId** | **string**| The livestream id. | [optional] 
 **autoOpenLiveStream** | **bool?**| Whether to auto open the livestream. | [optional] 
 **enableDirectPlay** | **bool?**| Whether to enable direct play. Default: true. | [optional] 
 **enableDirectStream** | **bool?**| Whether to enable direct stream. Default: true. | [optional] 
 **enableTranscoding** | **bool?**| Whether to enable transcoding. Default: true. | [optional] 
 **allowVideoStreamCopy** | **bool?**| Whether to allow to copy the video stream. Default: true. | [optional] 
 **allowAudioStreamCopy** | **bool?**| Whether to allow to copy the audio stream. Default: true. | [optional] 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The playback info. | [optional] 

### Return type

[**PlaybackInfoResponse**](PlaybackInfoResponse.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Playback info returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OpenLiveStream

> LiveStreamResponse OpenLiveStream (string openToken = null, Guid? userId = null, string playSessionId = null, int? maxStreamingBitrate = null, long? startTimeTicks = null, int? audioStreamIndex = null, int? subtitleStreamIndex = null, int? maxAudioChannels = null, Guid? itemId = null, bool? enableDirectPlay = null, bool? enableDirectStream = null, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Opens a media source.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class OpenLiveStreamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new MediaInfoApi(Configuration.Default);
            var openToken = openToken_example;  // string | The open token. (optional) 
            var userId = new Guid?(); // Guid? | The user id. (optional) 
            var playSessionId = playSessionId_example;  // string | The play session id. (optional) 
            var maxStreamingBitrate = 56;  // int? | The maximum streaming bitrate. (optional) 
            var startTimeTicks = 789;  // long? | The start time in ticks. (optional) 
            var audioStreamIndex = 56;  // int? | The audio stream index. (optional) 
            var subtitleStreamIndex = 56;  // int? | The subtitle stream index. (optional) 
            var maxAudioChannels = 56;  // int? | The maximum number of audio channels. (optional) 
            var itemId = new Guid?(); // Guid? | The item id. (optional) 
            var enableDirectPlay = true;  // bool? | Whether to enable direct play. Default: true. (optional) 
            var enableDirectStream = true;  // bool? | Whether to enable direct stream. Default: true. (optional) 
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The open live stream dto. (optional) 

            try
            {
                // Opens a media source.
                LiveStreamResponse result = apiInstance.OpenLiveStream(openToken, userId, playSessionId, maxStreamingBitrate, startTimeTicks, audioStreamIndex, subtitleStreamIndex, maxAudioChannels, itemId, enableDirectPlay, enableDirectStream, UNKNOWN_BASE_TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaInfoApi.OpenLiveStream: " + e.Message );
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
 **openToken** | **string**| The open token. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| The user id. | [optional] 
 **playSessionId** | **string**| The play session id. | [optional] 
 **maxStreamingBitrate** | **int?**| The maximum streaming bitrate. | [optional] 
 **startTimeTicks** | **long?**| The start time in ticks. | [optional] 
 **audioStreamIndex** | **int?**| The audio stream index. | [optional] 
 **subtitleStreamIndex** | **int?**| The subtitle stream index. | [optional] 
 **maxAudioChannels** | **int?**| The maximum number of audio channels. | [optional] 
 **itemId** | [**Guid?**](Guid?.md)| The item id. | [optional] 
 **enableDirectPlay** | **bool?**| Whether to enable direct play. Default: true. | [optional] 
 **enableDirectStream** | **bool?**| Whether to enable direct stream. Default: true. | [optional] 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The open live stream dto. | [optional] 

### Return type

[**LiveStreamResponse**](LiveStreamResponse.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Media source opened. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

