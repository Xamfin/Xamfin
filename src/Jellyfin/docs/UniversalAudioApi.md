# Jellyfin.Api.Api.UniversalAudioApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUniversalAudioStream**](UniversalAudioApi.md#getuniversalaudiostream) | **GET** /Audio/{itemId}/universal | Gets an audio stream.
[**HeadUniversalAudioStream**](UniversalAudioApi.md#headuniversalaudiostream) | **HEAD** /Audio/{itemId}/universal | Gets an audio stream.



## GetUniversalAudioStream

> System.IO.Stream GetUniversalAudioStream (Guid itemId, List<string> container = null, string mediaSourceId = null, string deviceId = null, Guid? userId = null, string audioCodec = null, int? maxAudioChannels = null, int? transcodingAudioChannels = null, int? maxStreamingBitrate = null, int? audioBitRate = null, long? startTimeTicks = null, string transcodingContainer = null, string transcodingProtocol = null, int? maxAudioSampleRate = null, int? maxAudioBitDepth = null, bool? enableRemoteMedia = null, bool? breakOnNonKeyFrames = null, bool? enableRedirection = null)

Gets an audio stream.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetUniversalAudioStreamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UniversalAudioApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var container = new List<string>(); // List<string> | Optional. The audio container. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media version id, if playing an alternate version. (optional) 
            var deviceId = deviceId_example;  // string | The device id of the client requesting. Used to stop encoding processes when needed. (optional) 
            var userId = new Guid?(); // Guid? | Optional. The user id. (optional) 
            var audioCodec = audioCodec_example;  // string | Optional. The audio codec to transcode to. (optional) 
            var maxAudioChannels = 56;  // int? | Optional. The maximum number of audio channels. (optional) 
            var transcodingAudioChannels = 56;  // int? | Optional. The number of how many audio channels to transcode to. (optional) 
            var maxStreamingBitrate = 56;  // int? | Optional. The maximum streaming bitrate. (optional) 
            var audioBitRate = 56;  // int? | Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. (optional) 
            var startTimeTicks = 789;  // long? | Optional. Specify a starting offset, in ticks. 1 tick = 10000 ms. (optional) 
            var transcodingContainer = transcodingContainer_example;  // string | Optional. The container to transcode to. (optional) 
            var transcodingProtocol = transcodingProtocol_example;  // string | Optional. The transcoding protocol. (optional) 
            var maxAudioSampleRate = 56;  // int? | Optional. The maximum audio sample rate. (optional) 
            var maxAudioBitDepth = 56;  // int? | Optional. The maximum audio bit depth. (optional) 
            var enableRemoteMedia = true;  // bool? | Optional. Whether to enable remote media. (optional) 
            var breakOnNonKeyFrames = true;  // bool? | Optional. Whether to break on non key frames. (optional)  (default to false)
            var enableRedirection = true;  // bool? | Whether to enable redirection. Defaults to true. (optional)  (default to true)

            try
            {
                // Gets an audio stream.
                System.IO.Stream result = apiInstance.GetUniversalAudioStream(itemId, container, mediaSourceId, deviceId, userId, audioCodec, maxAudioChannels, transcodingAudioChannels, maxStreamingBitrate, audioBitRate, startTimeTicks, transcodingContainer, transcodingProtocol, maxAudioSampleRate, maxAudioBitDepth, enableRemoteMedia, breakOnNonKeyFrames, enableRedirection);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UniversalAudioApi.GetUniversalAudioStream: " + e.Message );
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
 **container** | [**List&lt;string&gt;**](string.md)| Optional. The audio container. | [optional] 
 **mediaSourceId** | **string**| The media version id, if playing an alternate version. | [optional] 
 **deviceId** | **string**| The device id of the client requesting. Used to stop encoding processes when needed. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. The user id. | [optional] 
 **audioCodec** | **string**| Optional. The audio codec to transcode to. | [optional] 
 **maxAudioChannels** | **int?**| Optional. The maximum number of audio channels. | [optional] 
 **transcodingAudioChannels** | **int?**| Optional. The number of how many audio channels to transcode to. | [optional] 
 **maxStreamingBitrate** | **int?**| Optional. The maximum streaming bitrate. | [optional] 
 **audioBitRate** | **int?**| Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. | [optional] 
 **startTimeTicks** | **long?**| Optional. Specify a starting offset, in ticks. 1 tick &#x3D; 10000 ms. | [optional] 
 **transcodingContainer** | **string**| Optional. The container to transcode to. | [optional] 
 **transcodingProtocol** | **string**| Optional. The transcoding protocol. | [optional] 
 **maxAudioSampleRate** | **int?**| Optional. The maximum audio sample rate. | [optional] 
 **maxAudioBitDepth** | **int?**| Optional. The maximum audio bit depth. | [optional] 
 **enableRemoteMedia** | **bool?**| Optional. Whether to enable remote media. | [optional] 
 **breakOnNonKeyFrames** | **bool?**| Optional. Whether to break on non key frames. | [optional] [default to false]
 **enableRedirection** | **bool?**| Whether to enable redirection. Defaults to true. | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: audio/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audio stream returned. |  -  |
| **302** | Redirected to remote audio stream. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadUniversalAudioStream

> System.IO.Stream HeadUniversalAudioStream (Guid itemId, List<string> container = null, string mediaSourceId = null, string deviceId = null, Guid? userId = null, string audioCodec = null, int? maxAudioChannels = null, int? transcodingAudioChannels = null, int? maxStreamingBitrate = null, int? audioBitRate = null, long? startTimeTicks = null, string transcodingContainer = null, string transcodingProtocol = null, int? maxAudioSampleRate = null, int? maxAudioBitDepth = null, bool? enableRemoteMedia = null, bool? breakOnNonKeyFrames = null, bool? enableRedirection = null)

Gets an audio stream.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadUniversalAudioStreamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UniversalAudioApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var container = new List<string>(); // List<string> | Optional. The audio container. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media version id, if playing an alternate version. (optional) 
            var deviceId = deviceId_example;  // string | The device id of the client requesting. Used to stop encoding processes when needed. (optional) 
            var userId = new Guid?(); // Guid? | Optional. The user id. (optional) 
            var audioCodec = audioCodec_example;  // string | Optional. The audio codec to transcode to. (optional) 
            var maxAudioChannels = 56;  // int? | Optional. The maximum number of audio channels. (optional) 
            var transcodingAudioChannels = 56;  // int? | Optional. The number of how many audio channels to transcode to. (optional) 
            var maxStreamingBitrate = 56;  // int? | Optional. The maximum streaming bitrate. (optional) 
            var audioBitRate = 56;  // int? | Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. (optional) 
            var startTimeTicks = 789;  // long? | Optional. Specify a starting offset, in ticks. 1 tick = 10000 ms. (optional) 
            var transcodingContainer = transcodingContainer_example;  // string | Optional. The container to transcode to. (optional) 
            var transcodingProtocol = transcodingProtocol_example;  // string | Optional. The transcoding protocol. (optional) 
            var maxAudioSampleRate = 56;  // int? | Optional. The maximum audio sample rate. (optional) 
            var maxAudioBitDepth = 56;  // int? | Optional. The maximum audio bit depth. (optional) 
            var enableRemoteMedia = true;  // bool? | Optional. Whether to enable remote media. (optional) 
            var breakOnNonKeyFrames = true;  // bool? | Optional. Whether to break on non key frames. (optional)  (default to false)
            var enableRedirection = true;  // bool? | Whether to enable redirection. Defaults to true. (optional)  (default to true)

            try
            {
                // Gets an audio stream.
                System.IO.Stream result = apiInstance.HeadUniversalAudioStream(itemId, container, mediaSourceId, deviceId, userId, audioCodec, maxAudioChannels, transcodingAudioChannels, maxStreamingBitrate, audioBitRate, startTimeTicks, transcodingContainer, transcodingProtocol, maxAudioSampleRate, maxAudioBitDepth, enableRemoteMedia, breakOnNonKeyFrames, enableRedirection);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UniversalAudioApi.HeadUniversalAudioStream: " + e.Message );
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
 **container** | [**List&lt;string&gt;**](string.md)| Optional. The audio container. | [optional] 
 **mediaSourceId** | **string**| The media version id, if playing an alternate version. | [optional] 
 **deviceId** | **string**| The device id of the client requesting. Used to stop encoding processes when needed. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. The user id. | [optional] 
 **audioCodec** | **string**| Optional. The audio codec to transcode to. | [optional] 
 **maxAudioChannels** | **int?**| Optional. The maximum number of audio channels. | [optional] 
 **transcodingAudioChannels** | **int?**| Optional. The number of how many audio channels to transcode to. | [optional] 
 **maxStreamingBitrate** | **int?**| Optional. The maximum streaming bitrate. | [optional] 
 **audioBitRate** | **int?**| Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. | [optional] 
 **startTimeTicks** | **long?**| Optional. Specify a starting offset, in ticks. 1 tick &#x3D; 10000 ms. | [optional] 
 **transcodingContainer** | **string**| Optional. The container to transcode to. | [optional] 
 **transcodingProtocol** | **string**| Optional. The transcoding protocol. | [optional] 
 **maxAudioSampleRate** | **int?**| Optional. The maximum audio sample rate. | [optional] 
 **maxAudioBitDepth** | **int?**| Optional. The maximum audio bit depth. | [optional] 
 **enableRemoteMedia** | **bool?**| Optional. Whether to enable remote media. | [optional] 
 **breakOnNonKeyFrames** | **bool?**| Optional. Whether to break on non key frames. | [optional] [default to false]
 **enableRedirection** | **bool?**| Whether to enable redirection. Defaults to true. | [optional] [default to true]

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: audio/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audio stream returned. |  -  |
| **302** | Redirected to remote audio stream. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

