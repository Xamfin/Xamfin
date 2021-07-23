# Jellyfin.Api.Api.AudioApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAudioStream**](AudioApi.md#getaudiostream) | **GET** /Audio/{itemId}/stream | Gets an audio stream.
[**GetAudioStreamByContainer**](AudioApi.md#getaudiostreambycontainer) | **GET** /Audio/{itemId}/stream.{container} | Gets an audio stream.
[**HeadAudioStream**](AudioApi.md#headaudiostream) | **HEAD** /Audio/{itemId}/stream | Gets an audio stream.
[**HeadAudioStreamByContainer**](AudioApi.md#headaudiostreambycontainer) | **HEAD** /Audio/{itemId}/stream.{container} | Gets an audio stream.



## GetAudioStream

> System.IO.Stream GetAudioStream (Guid itemId, string container = null, bool? _static = null, string _params = null, string tag = null, string deviceProfileId = null, string playSessionId = null, string segmentContainer = null, int? segmentLength = null, int? minSegments = null, string mediaSourceId = null, string deviceId = null, string audioCodec = null, bool? enableAutoStreamCopy = null, bool? allowVideoStreamCopy = null, bool? allowAudioStreamCopy = null, bool? breakOnNonKeyFrames = null, int? audioSampleRate = null, int? maxAudioBitDepth = null, int? audioBitRate = null, int? audioChannels = null, int? maxAudioChannels = null, string profile = null, string level = null, float? framerate = null, float? maxFramerate = null, bool? copyTimestamps = null, long? startTimeTicks = null, int? width = null, int? height = null, int? videoBitRate = null, int? subtitleStreamIndex = null, SubtitleDeliveryMethod? subtitleMethod = null, int? maxRefFrames = null, int? maxVideoBitDepth = null, bool? requireAvc = null, bool? deInterlace = null, bool? requireNonAnamorphic = null, int? transcodingMaxAudioChannels = null, int? cpuCoreLimit = null, string liveStreamId = null, bool? enableMpegtsM2TsMode = null, string videoCodec = null, string subtitleCodec = null, string transcodeReasons = null, int? audioStreamIndex = null, int? videoStreamIndex = null, EncodingContext? context = null, Dictionary<string, string> streamOptions = null)

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
    public class GetAudioStreamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AudioApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var container = container_example;  // string | The audio container. (optional) 
            var _static = true;  // bool? | Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false. (optional) 
            var _params = _params_example;  // string | The streaming parameters. (optional) 
            var tag = tag_example;  // string | The tag. (optional) 
            var deviceProfileId = deviceProfileId_example;  // string | Optional. The dlna device profile id to utilize. (optional) 
            var playSessionId = playSessionId_example;  // string | The play session id. (optional) 
            var segmentContainer = segmentContainer_example;  // string | The segment container. (optional) 
            var segmentLength = 56;  // int? | The segment length. (optional) 
            var minSegments = 56;  // int? | The minimum number of segments. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media version id, if playing an alternate version. (optional) 
            var deviceId = deviceId_example;  // string | The device id of the client requesting. Used to stop encoding processes when needed. (optional) 
            var audioCodec = audioCodec_example;  // string | Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url's extension. Options: aac, mp3, vorbis, wma. (optional) 
            var enableAutoStreamCopy = true;  // bool? | Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true. (optional) 
            var allowVideoStreamCopy = true;  // bool? | Whether or not to allow copying of the video stream url. (optional) 
            var allowAudioStreamCopy = true;  // bool? | Whether or not to allow copying of the audio stream url. (optional) 
            var breakOnNonKeyFrames = true;  // bool? | Optional. Whether to break on non key frames. (optional) 
            var audioSampleRate = 56;  // int? | Optional. Specify a specific audio sample rate, e.g. 44100. (optional) 
            var maxAudioBitDepth = 56;  // int? | Optional. The maximum audio bit depth. (optional) 
            var audioBitRate = 56;  // int? | Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. (optional) 
            var audioChannels = 56;  // int? | Optional. Specify a specific number of audio channels to encode to, e.g. 2. (optional) 
            var maxAudioChannels = 56;  // int? | Optional. Specify a maximum number of audio channels to encode to, e.g. 2. (optional) 
            var profile = profile_example;  // string | Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high. (optional) 
            var level = level_example;  // string | Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1. (optional) 
            var framerate = 3.4F;  // float? | Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. (optional) 
            var maxFramerate = 3.4F;  // float? | Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. (optional) 
            var copyTimestamps = true;  // bool? | Whether or not to copy timestamps when transcoding with an offset. Defaults to false. (optional) 
            var startTimeTicks = 789;  // long? | Optional. Specify a starting offset, in ticks. 1 tick = 10000 ms. (optional) 
            var width = 56;  // int? | Optional. The fixed horizontal resolution of the encoded video. (optional) 
            var height = 56;  // int? | Optional. The fixed vertical resolution of the encoded video. (optional) 
            var videoBitRate = 56;  // int? | Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults. (optional) 
            var subtitleStreamIndex = 56;  // int? | Optional. The index of the subtitle stream to use. If omitted no subtitles will be used. (optional) 
            var subtitleMethod = ;  // SubtitleDeliveryMethod? | Optional. Specify the subtitle delivery method. (optional) 
            var maxRefFrames = 56;  // int? | Optional. (optional) 
            var maxVideoBitDepth = 56;  // int? | Optional. The maximum video bit depth. (optional) 
            var requireAvc = true;  // bool? | Optional. Whether to require avc. (optional) 
            var deInterlace = true;  // bool? | Optional. Whether to deinterlace the video. (optional) 
            var requireNonAnamorphic = true;  // bool? | Optional. Whether to require a non anamorphic stream. (optional) 
            var transcodingMaxAudioChannels = 56;  // int? | Optional. The maximum number of audio channels to transcode. (optional) 
            var cpuCoreLimit = 56;  // int? | Optional. The limit of how many cpu cores to use. (optional) 
            var liveStreamId = liveStreamId_example;  // string | The live stream id. (optional) 
            var enableMpegtsM2TsMode = true;  // bool? | Optional. Whether to enable the MpegtsM2Ts mode. (optional) 
            var videoCodec = videoCodec_example;  // string | Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url's extension. Options: h265, h264, mpeg4, theora, vpx, wmv. (optional) 
            var subtitleCodec = subtitleCodec_example;  // string | Optional. Specify a subtitle codec to encode to. (optional) 
            var transcodeReasons = transcodeReasons_example;  // string | Optional. The transcoding reason. (optional) 
            var audioStreamIndex = 56;  // int? | Optional. The index of the audio stream to use. If omitted the first audio stream will be used. (optional) 
            var videoStreamIndex = 56;  // int? | Optional. The index of the video stream to use. If omitted the first video stream will be used. (optional) 
            var context = ;  // EncodingContext? | Optional. The MediaBrowser.Model.Dlna.EncodingContext. (optional) 
            var streamOptions = new Dictionary<string, string>(); // Dictionary<string, string> | Optional. The streaming options. (optional) 

            try
            {
                // Gets an audio stream.
                System.IO.Stream result = apiInstance.GetAudioStream(itemId, container, _static, _params, tag, deviceProfileId, playSessionId, segmentContainer, segmentLength, minSegments, mediaSourceId, deviceId, audioCodec, enableAutoStreamCopy, allowVideoStreamCopy, allowAudioStreamCopy, breakOnNonKeyFrames, audioSampleRate, maxAudioBitDepth, audioBitRate, audioChannels, maxAudioChannels, profile, level, framerate, maxFramerate, copyTimestamps, startTimeTicks, width, height, videoBitRate, subtitleStreamIndex, subtitleMethod, maxRefFrames, maxVideoBitDepth, requireAvc, deInterlace, requireNonAnamorphic, transcodingMaxAudioChannels, cpuCoreLimit, liveStreamId, enableMpegtsM2TsMode, videoCodec, subtitleCodec, transcodeReasons, audioStreamIndex, videoStreamIndex, context, streamOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AudioApi.GetAudioStream: " + e.Message );
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
 **container** | **string**| The audio container. | [optional] 
 **_static** | **bool?**| Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false. | [optional] 
 **_params** | **string**| The streaming parameters. | [optional] 
 **tag** | **string**| The tag. | [optional] 
 **deviceProfileId** | **string**| Optional. The dlna device profile id to utilize. | [optional] 
 **playSessionId** | **string**| The play session id. | [optional] 
 **segmentContainer** | **string**| The segment container. | [optional] 
 **segmentLength** | **int?**| The segment length. | [optional] 
 **minSegments** | **int?**| The minimum number of segments. | [optional] 
 **mediaSourceId** | **string**| The media version id, if playing an alternate version. | [optional] 
 **deviceId** | **string**| The device id of the client requesting. Used to stop encoding processes when needed. | [optional] 
 **audioCodec** | **string**| Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url&#39;s extension. Options: aac, mp3, vorbis, wma. | [optional] 
 **enableAutoStreamCopy** | **bool?**| Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true. | [optional] 
 **allowVideoStreamCopy** | **bool?**| Whether or not to allow copying of the video stream url. | [optional] 
 **allowAudioStreamCopy** | **bool?**| Whether or not to allow copying of the audio stream url. | [optional] 
 **breakOnNonKeyFrames** | **bool?**| Optional. Whether to break on non key frames. | [optional] 
 **audioSampleRate** | **int?**| Optional. Specify a specific audio sample rate, e.g. 44100. | [optional] 
 **maxAudioBitDepth** | **int?**| Optional. The maximum audio bit depth. | [optional] 
 **audioBitRate** | **int?**| Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. | [optional] 
 **audioChannels** | **int?**| Optional. Specify a specific number of audio channels to encode to, e.g. 2. | [optional] 
 **maxAudioChannels** | **int?**| Optional. Specify a maximum number of audio channels to encode to, e.g. 2. | [optional] 
 **profile** | **string**| Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high. | [optional] 
 **level** | **string**| Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1. | [optional] 
 **framerate** | **float?**| Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. | [optional] 
 **maxFramerate** | **float?**| Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. | [optional] 
 **copyTimestamps** | **bool?**| Whether or not to copy timestamps when transcoding with an offset. Defaults to false. | [optional] 
 **startTimeTicks** | **long?**| Optional. Specify a starting offset, in ticks. 1 tick &#x3D; 10000 ms. | [optional] 
 **width** | **int?**| Optional. The fixed horizontal resolution of the encoded video. | [optional] 
 **height** | **int?**| Optional. The fixed vertical resolution of the encoded video. | [optional] 
 **videoBitRate** | **int?**| Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults. | [optional] 
 **subtitleStreamIndex** | **int?**| Optional. The index of the subtitle stream to use. If omitted no subtitles will be used. | [optional] 
 **subtitleMethod** | **SubtitleDeliveryMethod?**| Optional. Specify the subtitle delivery method. | [optional] 
 **maxRefFrames** | **int?**| Optional. | [optional] 
 **maxVideoBitDepth** | **int?**| Optional. The maximum video bit depth. | [optional] 
 **requireAvc** | **bool?**| Optional. Whether to require avc. | [optional] 
 **deInterlace** | **bool?**| Optional. Whether to deinterlace the video. | [optional] 
 **requireNonAnamorphic** | **bool?**| Optional. Whether to require a non anamorphic stream. | [optional] 
 **transcodingMaxAudioChannels** | **int?**| Optional. The maximum number of audio channels to transcode. | [optional] 
 **cpuCoreLimit** | **int?**| Optional. The limit of how many cpu cores to use. | [optional] 
 **liveStreamId** | **string**| The live stream id. | [optional] 
 **enableMpegtsM2TsMode** | **bool?**| Optional. Whether to enable the MpegtsM2Ts mode. | [optional] 
 **videoCodec** | **string**| Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url&#39;s extension. Options: h265, h264, mpeg4, theora, vpx, wmv. | [optional] 
 **subtitleCodec** | **string**| Optional. Specify a subtitle codec to encode to. | [optional] 
 **transcodeReasons** | **string**| Optional. The transcoding reason. | [optional] 
 **audioStreamIndex** | **int?**| Optional. The index of the audio stream to use. If omitted the first audio stream will be used. | [optional] 
 **videoStreamIndex** | **int?**| Optional. The index of the video stream to use. If omitted the first video stream will be used. | [optional] 
 **context** | **EncodingContext?**| Optional. The MediaBrowser.Model.Dlna.EncodingContext. | [optional] 
 **streamOptions** | [**Dictionary&lt;string, string&gt;**](string.md)| Optional. The streaming options. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: audio/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audio stream returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAudioStreamByContainer

> System.IO.Stream GetAudioStreamByContainer (Guid itemId, string container, bool? _static = null, string _params = null, string tag = null, string deviceProfileId = null, string playSessionId = null, string segmentContainer = null, int? segmentLength = null, int? minSegments = null, string mediaSourceId = null, string deviceId = null, string audioCodec = null, bool? enableAutoStreamCopy = null, bool? allowVideoStreamCopy = null, bool? allowAudioStreamCopy = null, bool? breakOnNonKeyFrames = null, int? audioSampleRate = null, int? maxAudioBitDepth = null, int? audioBitRate = null, int? audioChannels = null, int? maxAudioChannels = null, string profile = null, string level = null, float? framerate = null, float? maxFramerate = null, bool? copyTimestamps = null, long? startTimeTicks = null, int? width = null, int? height = null, int? videoBitRate = null, int? subtitleStreamIndex = null, SubtitleDeliveryMethod? subtitleMethod = null, int? maxRefFrames = null, int? maxVideoBitDepth = null, bool? requireAvc = null, bool? deInterlace = null, bool? requireNonAnamorphic = null, int? transcodingMaxAudioChannels = null, int? cpuCoreLimit = null, string liveStreamId = null, bool? enableMpegtsM2TsMode = null, string videoCodec = null, string subtitleCodec = null, string transcodeReasons = null, int? audioStreamIndex = null, int? videoStreamIndex = null, EncodingContext? context = null, Dictionary<string, string> streamOptions = null)

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
    public class GetAudioStreamByContainerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AudioApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var container = container_example;  // string | The audio container.
            var _static = true;  // bool? | Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false. (optional) 
            var _params = _params_example;  // string | The streaming parameters. (optional) 
            var tag = tag_example;  // string | The tag. (optional) 
            var deviceProfileId = deviceProfileId_example;  // string | Optional. The dlna device profile id to utilize. (optional) 
            var playSessionId = playSessionId_example;  // string | The play session id. (optional) 
            var segmentContainer = segmentContainer_example;  // string | The segment container. (optional) 
            var segmentLength = 56;  // int? | The segment lenght. (optional) 
            var minSegments = 56;  // int? | The minimum number of segments. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media version id, if playing an alternate version. (optional) 
            var deviceId = deviceId_example;  // string | The device id of the client requesting. Used to stop encoding processes when needed. (optional) 
            var audioCodec = audioCodec_example;  // string | Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url's extension. Options: aac, mp3, vorbis, wma. (optional) 
            var enableAutoStreamCopy = true;  // bool? | Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true. (optional) 
            var allowVideoStreamCopy = true;  // bool? | Whether or not to allow copying of the video stream url. (optional) 
            var allowAudioStreamCopy = true;  // bool? | Whether or not to allow copying of the audio stream url. (optional) 
            var breakOnNonKeyFrames = true;  // bool? | Optional. Whether to break on non key frames. (optional) 
            var audioSampleRate = 56;  // int? | Optional. Specify a specific audio sample rate, e.g. 44100. (optional) 
            var maxAudioBitDepth = 56;  // int? | Optional. The maximum audio bit depth. (optional) 
            var audioBitRate = 56;  // int? | Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. (optional) 
            var audioChannels = 56;  // int? | Optional. Specify a specific number of audio channels to encode to, e.g. 2. (optional) 
            var maxAudioChannels = 56;  // int? | Optional. Specify a maximum number of audio channels to encode to, e.g. 2. (optional) 
            var profile = profile_example;  // string | Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high. (optional) 
            var level = level_example;  // string | Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1. (optional) 
            var framerate = 3.4F;  // float? | Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. (optional) 
            var maxFramerate = 3.4F;  // float? | Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. (optional) 
            var copyTimestamps = true;  // bool? | Whether or not to copy timestamps when transcoding with an offset. Defaults to false. (optional) 
            var startTimeTicks = 789;  // long? | Optional. Specify a starting offset, in ticks. 1 tick = 10000 ms. (optional) 
            var width = 56;  // int? | Optional. The fixed horizontal resolution of the encoded video. (optional) 
            var height = 56;  // int? | Optional. The fixed vertical resolution of the encoded video. (optional) 
            var videoBitRate = 56;  // int? | Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults. (optional) 
            var subtitleStreamIndex = 56;  // int? | Optional. The index of the subtitle stream to use. If omitted no subtitles will be used. (optional) 
            var subtitleMethod = ;  // SubtitleDeliveryMethod? | Optional. Specify the subtitle delivery method. (optional) 
            var maxRefFrames = 56;  // int? | Optional. (optional) 
            var maxVideoBitDepth = 56;  // int? | Optional. The maximum video bit depth. (optional) 
            var requireAvc = true;  // bool? | Optional. Whether to require avc. (optional) 
            var deInterlace = true;  // bool? | Optional. Whether to deinterlace the video. (optional) 
            var requireNonAnamorphic = true;  // bool? | Optional. Whether to require a non anamporphic stream. (optional) 
            var transcodingMaxAudioChannels = 56;  // int? | Optional. The maximum number of audio channels to transcode. (optional) 
            var cpuCoreLimit = 56;  // int? | Optional. The limit of how many cpu cores to use. (optional) 
            var liveStreamId = liveStreamId_example;  // string | The live stream id. (optional) 
            var enableMpegtsM2TsMode = true;  // bool? | Optional. Whether to enable the MpegtsM2Ts mode. (optional) 
            var videoCodec = videoCodec_example;  // string | Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url's extension. Options: h265, h264, mpeg4, theora, vpx, wmv. (optional) 
            var subtitleCodec = subtitleCodec_example;  // string | Optional. Specify a subtitle codec to encode to. (optional) 
            var transcodeReasons = transcodeReasons_example;  // string | Optional. The transcoding reason. (optional) 
            var audioStreamIndex = 56;  // int? | Optional. The index of the audio stream to use. If omitted the first audio stream will be used. (optional) 
            var videoStreamIndex = 56;  // int? | Optional. The index of the video stream to use. If omitted the first video stream will be used. (optional) 
            var context = ;  // EncodingContext? | Optional. The MediaBrowser.Model.Dlna.EncodingContext. (optional) 
            var streamOptions = new Dictionary<string, string>(); // Dictionary<string, string> | Optional. The streaming options. (optional) 

            try
            {
                // Gets an audio stream.
                System.IO.Stream result = apiInstance.GetAudioStreamByContainer(itemId, container, _static, _params, tag, deviceProfileId, playSessionId, segmentContainer, segmentLength, minSegments, mediaSourceId, deviceId, audioCodec, enableAutoStreamCopy, allowVideoStreamCopy, allowAudioStreamCopy, breakOnNonKeyFrames, audioSampleRate, maxAudioBitDepth, audioBitRate, audioChannels, maxAudioChannels, profile, level, framerate, maxFramerate, copyTimestamps, startTimeTicks, width, height, videoBitRate, subtitleStreamIndex, subtitleMethod, maxRefFrames, maxVideoBitDepth, requireAvc, deInterlace, requireNonAnamorphic, transcodingMaxAudioChannels, cpuCoreLimit, liveStreamId, enableMpegtsM2TsMode, videoCodec, subtitleCodec, transcodeReasons, audioStreamIndex, videoStreamIndex, context, streamOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AudioApi.GetAudioStreamByContainer: " + e.Message );
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
 **container** | **string**| The audio container. | 
 **_static** | **bool?**| Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false. | [optional] 
 **_params** | **string**| The streaming parameters. | [optional] 
 **tag** | **string**| The tag. | [optional] 
 **deviceProfileId** | **string**| Optional. The dlna device profile id to utilize. | [optional] 
 **playSessionId** | **string**| The play session id. | [optional] 
 **segmentContainer** | **string**| The segment container. | [optional] 
 **segmentLength** | **int?**| The segment lenght. | [optional] 
 **minSegments** | **int?**| The minimum number of segments. | [optional] 
 **mediaSourceId** | **string**| The media version id, if playing an alternate version. | [optional] 
 **deviceId** | **string**| The device id of the client requesting. Used to stop encoding processes when needed. | [optional] 
 **audioCodec** | **string**| Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url&#39;s extension. Options: aac, mp3, vorbis, wma. | [optional] 
 **enableAutoStreamCopy** | **bool?**| Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true. | [optional] 
 **allowVideoStreamCopy** | **bool?**| Whether or not to allow copying of the video stream url. | [optional] 
 **allowAudioStreamCopy** | **bool?**| Whether or not to allow copying of the audio stream url. | [optional] 
 **breakOnNonKeyFrames** | **bool?**| Optional. Whether to break on non key frames. | [optional] 
 **audioSampleRate** | **int?**| Optional. Specify a specific audio sample rate, e.g. 44100. | [optional] 
 **maxAudioBitDepth** | **int?**| Optional. The maximum audio bit depth. | [optional] 
 **audioBitRate** | **int?**| Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. | [optional] 
 **audioChannels** | **int?**| Optional. Specify a specific number of audio channels to encode to, e.g. 2. | [optional] 
 **maxAudioChannels** | **int?**| Optional. Specify a maximum number of audio channels to encode to, e.g. 2. | [optional] 
 **profile** | **string**| Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high. | [optional] 
 **level** | **string**| Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1. | [optional] 
 **framerate** | **float?**| Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. | [optional] 
 **maxFramerate** | **float?**| Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. | [optional] 
 **copyTimestamps** | **bool?**| Whether or not to copy timestamps when transcoding with an offset. Defaults to false. | [optional] 
 **startTimeTicks** | **long?**| Optional. Specify a starting offset, in ticks. 1 tick &#x3D; 10000 ms. | [optional] 
 **width** | **int?**| Optional. The fixed horizontal resolution of the encoded video. | [optional] 
 **height** | **int?**| Optional. The fixed vertical resolution of the encoded video. | [optional] 
 **videoBitRate** | **int?**| Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults. | [optional] 
 **subtitleStreamIndex** | **int?**| Optional. The index of the subtitle stream to use. If omitted no subtitles will be used. | [optional] 
 **subtitleMethod** | **SubtitleDeliveryMethod?**| Optional. Specify the subtitle delivery method. | [optional] 
 **maxRefFrames** | **int?**| Optional. | [optional] 
 **maxVideoBitDepth** | **int?**| Optional. The maximum video bit depth. | [optional] 
 **requireAvc** | **bool?**| Optional. Whether to require avc. | [optional] 
 **deInterlace** | **bool?**| Optional. Whether to deinterlace the video. | [optional] 
 **requireNonAnamorphic** | **bool?**| Optional. Whether to require a non anamporphic stream. | [optional] 
 **transcodingMaxAudioChannels** | **int?**| Optional. The maximum number of audio channels to transcode. | [optional] 
 **cpuCoreLimit** | **int?**| Optional. The limit of how many cpu cores to use. | [optional] 
 **liveStreamId** | **string**| The live stream id. | [optional] 
 **enableMpegtsM2TsMode** | **bool?**| Optional. Whether to enable the MpegtsM2Ts mode. | [optional] 
 **videoCodec** | **string**| Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url&#39;s extension. Options: h265, h264, mpeg4, theora, vpx, wmv. | [optional] 
 **subtitleCodec** | **string**| Optional. Specify a subtitle codec to encode to. | [optional] 
 **transcodeReasons** | **string**| Optional. The transcoding reason. | [optional] 
 **audioStreamIndex** | **int?**| Optional. The index of the audio stream to use. If omitted the first audio stream will be used. | [optional] 
 **videoStreamIndex** | **int?**| Optional. The index of the video stream to use. If omitted the first video stream will be used. | [optional] 
 **context** | **EncodingContext?**| Optional. The MediaBrowser.Model.Dlna.EncodingContext. | [optional] 
 **streamOptions** | [**Dictionary&lt;string, string&gt;**](string.md)| Optional. The streaming options. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: audio/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audio stream returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadAudioStream

> System.IO.Stream HeadAudioStream (Guid itemId, string container = null, bool? _static = null, string _params = null, string tag = null, string deviceProfileId = null, string playSessionId = null, string segmentContainer = null, int? segmentLength = null, int? minSegments = null, string mediaSourceId = null, string deviceId = null, string audioCodec = null, bool? enableAutoStreamCopy = null, bool? allowVideoStreamCopy = null, bool? allowAudioStreamCopy = null, bool? breakOnNonKeyFrames = null, int? audioSampleRate = null, int? maxAudioBitDepth = null, int? audioBitRate = null, int? audioChannels = null, int? maxAudioChannels = null, string profile = null, string level = null, float? framerate = null, float? maxFramerate = null, bool? copyTimestamps = null, long? startTimeTicks = null, int? width = null, int? height = null, int? videoBitRate = null, int? subtitleStreamIndex = null, SubtitleDeliveryMethod? subtitleMethod = null, int? maxRefFrames = null, int? maxVideoBitDepth = null, bool? requireAvc = null, bool? deInterlace = null, bool? requireNonAnamorphic = null, int? transcodingMaxAudioChannels = null, int? cpuCoreLimit = null, string liveStreamId = null, bool? enableMpegtsM2TsMode = null, string videoCodec = null, string subtitleCodec = null, string transcodeReasons = null, int? audioStreamIndex = null, int? videoStreamIndex = null, EncodingContext? context = null, Dictionary<string, string> streamOptions = null)

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
    public class HeadAudioStreamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AudioApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var container = container_example;  // string | The audio container. (optional) 
            var _static = true;  // bool? | Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false. (optional) 
            var _params = _params_example;  // string | The streaming parameters. (optional) 
            var tag = tag_example;  // string | The tag. (optional) 
            var deviceProfileId = deviceProfileId_example;  // string | Optional. The dlna device profile id to utilize. (optional) 
            var playSessionId = playSessionId_example;  // string | The play session id. (optional) 
            var segmentContainer = segmentContainer_example;  // string | The segment container. (optional) 
            var segmentLength = 56;  // int? | The segment length. (optional) 
            var minSegments = 56;  // int? | The minimum number of segments. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media version id, if playing an alternate version. (optional) 
            var deviceId = deviceId_example;  // string | The device id of the client requesting. Used to stop encoding processes when needed. (optional) 
            var audioCodec = audioCodec_example;  // string | Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url's extension. Options: aac, mp3, vorbis, wma. (optional) 
            var enableAutoStreamCopy = true;  // bool? | Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true. (optional) 
            var allowVideoStreamCopy = true;  // bool? | Whether or not to allow copying of the video stream url. (optional) 
            var allowAudioStreamCopy = true;  // bool? | Whether or not to allow copying of the audio stream url. (optional) 
            var breakOnNonKeyFrames = true;  // bool? | Optional. Whether to break on non key frames. (optional) 
            var audioSampleRate = 56;  // int? | Optional. Specify a specific audio sample rate, e.g. 44100. (optional) 
            var maxAudioBitDepth = 56;  // int? | Optional. The maximum audio bit depth. (optional) 
            var audioBitRate = 56;  // int? | Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. (optional) 
            var audioChannels = 56;  // int? | Optional. Specify a specific number of audio channels to encode to, e.g. 2. (optional) 
            var maxAudioChannels = 56;  // int? | Optional. Specify a maximum number of audio channels to encode to, e.g. 2. (optional) 
            var profile = profile_example;  // string | Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high. (optional) 
            var level = level_example;  // string | Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1. (optional) 
            var framerate = 3.4F;  // float? | Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. (optional) 
            var maxFramerate = 3.4F;  // float? | Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. (optional) 
            var copyTimestamps = true;  // bool? | Whether or not to copy timestamps when transcoding with an offset. Defaults to false. (optional) 
            var startTimeTicks = 789;  // long? | Optional. Specify a starting offset, in ticks. 1 tick = 10000 ms. (optional) 
            var width = 56;  // int? | Optional. The fixed horizontal resolution of the encoded video. (optional) 
            var height = 56;  // int? | Optional. The fixed vertical resolution of the encoded video. (optional) 
            var videoBitRate = 56;  // int? | Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults. (optional) 
            var subtitleStreamIndex = 56;  // int? | Optional. The index of the subtitle stream to use. If omitted no subtitles will be used. (optional) 
            var subtitleMethod = ;  // SubtitleDeliveryMethod? | Optional. Specify the subtitle delivery method. (optional) 
            var maxRefFrames = 56;  // int? | Optional. (optional) 
            var maxVideoBitDepth = 56;  // int? | Optional. The maximum video bit depth. (optional) 
            var requireAvc = true;  // bool? | Optional. Whether to require avc. (optional) 
            var deInterlace = true;  // bool? | Optional. Whether to deinterlace the video. (optional) 
            var requireNonAnamorphic = true;  // bool? | Optional. Whether to require a non anamorphic stream. (optional) 
            var transcodingMaxAudioChannels = 56;  // int? | Optional. The maximum number of audio channels to transcode. (optional) 
            var cpuCoreLimit = 56;  // int? | Optional. The limit of how many cpu cores to use. (optional) 
            var liveStreamId = liveStreamId_example;  // string | The live stream id. (optional) 
            var enableMpegtsM2TsMode = true;  // bool? | Optional. Whether to enable the MpegtsM2Ts mode. (optional) 
            var videoCodec = videoCodec_example;  // string | Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url's extension. Options: h265, h264, mpeg4, theora, vpx, wmv. (optional) 
            var subtitleCodec = subtitleCodec_example;  // string | Optional. Specify a subtitle codec to encode to. (optional) 
            var transcodeReasons = transcodeReasons_example;  // string | Optional. The transcoding reason. (optional) 
            var audioStreamIndex = 56;  // int? | Optional. The index of the audio stream to use. If omitted the first audio stream will be used. (optional) 
            var videoStreamIndex = 56;  // int? | Optional. The index of the video stream to use. If omitted the first video stream will be used. (optional) 
            var context = ;  // EncodingContext? | Optional. The MediaBrowser.Model.Dlna.EncodingContext. (optional) 
            var streamOptions = new Dictionary<string, string>(); // Dictionary<string, string> | Optional. The streaming options. (optional) 

            try
            {
                // Gets an audio stream.
                System.IO.Stream result = apiInstance.HeadAudioStream(itemId, container, _static, _params, tag, deviceProfileId, playSessionId, segmentContainer, segmentLength, minSegments, mediaSourceId, deviceId, audioCodec, enableAutoStreamCopy, allowVideoStreamCopy, allowAudioStreamCopy, breakOnNonKeyFrames, audioSampleRate, maxAudioBitDepth, audioBitRate, audioChannels, maxAudioChannels, profile, level, framerate, maxFramerate, copyTimestamps, startTimeTicks, width, height, videoBitRate, subtitleStreamIndex, subtitleMethod, maxRefFrames, maxVideoBitDepth, requireAvc, deInterlace, requireNonAnamorphic, transcodingMaxAudioChannels, cpuCoreLimit, liveStreamId, enableMpegtsM2TsMode, videoCodec, subtitleCodec, transcodeReasons, audioStreamIndex, videoStreamIndex, context, streamOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AudioApi.HeadAudioStream: " + e.Message );
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
 **container** | **string**| The audio container. | [optional] 
 **_static** | **bool?**| Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false. | [optional] 
 **_params** | **string**| The streaming parameters. | [optional] 
 **tag** | **string**| The tag. | [optional] 
 **deviceProfileId** | **string**| Optional. The dlna device profile id to utilize. | [optional] 
 **playSessionId** | **string**| The play session id. | [optional] 
 **segmentContainer** | **string**| The segment container. | [optional] 
 **segmentLength** | **int?**| The segment length. | [optional] 
 **minSegments** | **int?**| The minimum number of segments. | [optional] 
 **mediaSourceId** | **string**| The media version id, if playing an alternate version. | [optional] 
 **deviceId** | **string**| The device id of the client requesting. Used to stop encoding processes when needed. | [optional] 
 **audioCodec** | **string**| Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url&#39;s extension. Options: aac, mp3, vorbis, wma. | [optional] 
 **enableAutoStreamCopy** | **bool?**| Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true. | [optional] 
 **allowVideoStreamCopy** | **bool?**| Whether or not to allow copying of the video stream url. | [optional] 
 **allowAudioStreamCopy** | **bool?**| Whether or not to allow copying of the audio stream url. | [optional] 
 **breakOnNonKeyFrames** | **bool?**| Optional. Whether to break on non key frames. | [optional] 
 **audioSampleRate** | **int?**| Optional. Specify a specific audio sample rate, e.g. 44100. | [optional] 
 **maxAudioBitDepth** | **int?**| Optional. The maximum audio bit depth. | [optional] 
 **audioBitRate** | **int?**| Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. | [optional] 
 **audioChannels** | **int?**| Optional. Specify a specific number of audio channels to encode to, e.g. 2. | [optional] 
 **maxAudioChannels** | **int?**| Optional. Specify a maximum number of audio channels to encode to, e.g. 2. | [optional] 
 **profile** | **string**| Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high. | [optional] 
 **level** | **string**| Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1. | [optional] 
 **framerate** | **float?**| Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. | [optional] 
 **maxFramerate** | **float?**| Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. | [optional] 
 **copyTimestamps** | **bool?**| Whether or not to copy timestamps when transcoding with an offset. Defaults to false. | [optional] 
 **startTimeTicks** | **long?**| Optional. Specify a starting offset, in ticks. 1 tick &#x3D; 10000 ms. | [optional] 
 **width** | **int?**| Optional. The fixed horizontal resolution of the encoded video. | [optional] 
 **height** | **int?**| Optional. The fixed vertical resolution of the encoded video. | [optional] 
 **videoBitRate** | **int?**| Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults. | [optional] 
 **subtitleStreamIndex** | **int?**| Optional. The index of the subtitle stream to use. If omitted no subtitles will be used. | [optional] 
 **subtitleMethod** | **SubtitleDeliveryMethod?**| Optional. Specify the subtitle delivery method. | [optional] 
 **maxRefFrames** | **int?**| Optional. | [optional] 
 **maxVideoBitDepth** | **int?**| Optional. The maximum video bit depth. | [optional] 
 **requireAvc** | **bool?**| Optional. Whether to require avc. | [optional] 
 **deInterlace** | **bool?**| Optional. Whether to deinterlace the video. | [optional] 
 **requireNonAnamorphic** | **bool?**| Optional. Whether to require a non anamorphic stream. | [optional] 
 **transcodingMaxAudioChannels** | **int?**| Optional. The maximum number of audio channels to transcode. | [optional] 
 **cpuCoreLimit** | **int?**| Optional. The limit of how many cpu cores to use. | [optional] 
 **liveStreamId** | **string**| The live stream id. | [optional] 
 **enableMpegtsM2TsMode** | **bool?**| Optional. Whether to enable the MpegtsM2Ts mode. | [optional] 
 **videoCodec** | **string**| Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url&#39;s extension. Options: h265, h264, mpeg4, theora, vpx, wmv. | [optional] 
 **subtitleCodec** | **string**| Optional. Specify a subtitle codec to encode to. | [optional] 
 **transcodeReasons** | **string**| Optional. The transcoding reason. | [optional] 
 **audioStreamIndex** | **int?**| Optional. The index of the audio stream to use. If omitted the first audio stream will be used. | [optional] 
 **videoStreamIndex** | **int?**| Optional. The index of the video stream to use. If omitted the first video stream will be used. | [optional] 
 **context** | **EncodingContext?**| Optional. The MediaBrowser.Model.Dlna.EncodingContext. | [optional] 
 **streamOptions** | [**Dictionary&lt;string, string&gt;**](string.md)| Optional. The streaming options. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: audio/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audio stream returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadAudioStreamByContainer

> System.IO.Stream HeadAudioStreamByContainer (Guid itemId, string container, bool? _static = null, string _params = null, string tag = null, string deviceProfileId = null, string playSessionId = null, string segmentContainer = null, int? segmentLength = null, int? minSegments = null, string mediaSourceId = null, string deviceId = null, string audioCodec = null, bool? enableAutoStreamCopy = null, bool? allowVideoStreamCopy = null, bool? allowAudioStreamCopy = null, bool? breakOnNonKeyFrames = null, int? audioSampleRate = null, int? maxAudioBitDepth = null, int? audioBitRate = null, int? audioChannels = null, int? maxAudioChannels = null, string profile = null, string level = null, float? framerate = null, float? maxFramerate = null, bool? copyTimestamps = null, long? startTimeTicks = null, int? width = null, int? height = null, int? videoBitRate = null, int? subtitleStreamIndex = null, SubtitleDeliveryMethod? subtitleMethod = null, int? maxRefFrames = null, int? maxVideoBitDepth = null, bool? requireAvc = null, bool? deInterlace = null, bool? requireNonAnamorphic = null, int? transcodingMaxAudioChannels = null, int? cpuCoreLimit = null, string liveStreamId = null, bool? enableMpegtsM2TsMode = null, string videoCodec = null, string subtitleCodec = null, string transcodeReasons = null, int? audioStreamIndex = null, int? videoStreamIndex = null, EncodingContext? context = null, Dictionary<string, string> streamOptions = null)

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
    public class HeadAudioStreamByContainerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AudioApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var container = container_example;  // string | The audio container.
            var _static = true;  // bool? | Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false. (optional) 
            var _params = _params_example;  // string | The streaming parameters. (optional) 
            var tag = tag_example;  // string | The tag. (optional) 
            var deviceProfileId = deviceProfileId_example;  // string | Optional. The dlna device profile id to utilize. (optional) 
            var playSessionId = playSessionId_example;  // string | The play session id. (optional) 
            var segmentContainer = segmentContainer_example;  // string | The segment container. (optional) 
            var segmentLength = 56;  // int? | The segment lenght. (optional) 
            var minSegments = 56;  // int? | The minimum number of segments. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media version id, if playing an alternate version. (optional) 
            var deviceId = deviceId_example;  // string | The device id of the client requesting. Used to stop encoding processes when needed. (optional) 
            var audioCodec = audioCodec_example;  // string | Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url's extension. Options: aac, mp3, vorbis, wma. (optional) 
            var enableAutoStreamCopy = true;  // bool? | Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true. (optional) 
            var allowVideoStreamCopy = true;  // bool? | Whether or not to allow copying of the video stream url. (optional) 
            var allowAudioStreamCopy = true;  // bool? | Whether or not to allow copying of the audio stream url. (optional) 
            var breakOnNonKeyFrames = true;  // bool? | Optional. Whether to break on non key frames. (optional) 
            var audioSampleRate = 56;  // int? | Optional. Specify a specific audio sample rate, e.g. 44100. (optional) 
            var maxAudioBitDepth = 56;  // int? | Optional. The maximum audio bit depth. (optional) 
            var audioBitRate = 56;  // int? | Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. (optional) 
            var audioChannels = 56;  // int? | Optional. Specify a specific number of audio channels to encode to, e.g. 2. (optional) 
            var maxAudioChannels = 56;  // int? | Optional. Specify a maximum number of audio channels to encode to, e.g. 2. (optional) 
            var profile = profile_example;  // string | Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high. (optional) 
            var level = level_example;  // string | Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1. (optional) 
            var framerate = 3.4F;  // float? | Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. (optional) 
            var maxFramerate = 3.4F;  // float? | Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. (optional) 
            var copyTimestamps = true;  // bool? | Whether or not to copy timestamps when transcoding with an offset. Defaults to false. (optional) 
            var startTimeTicks = 789;  // long? | Optional. Specify a starting offset, in ticks. 1 tick = 10000 ms. (optional) 
            var width = 56;  // int? | Optional. The fixed horizontal resolution of the encoded video. (optional) 
            var height = 56;  // int? | Optional. The fixed vertical resolution of the encoded video. (optional) 
            var videoBitRate = 56;  // int? | Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults. (optional) 
            var subtitleStreamIndex = 56;  // int? | Optional. The index of the subtitle stream to use. If omitted no subtitles will be used. (optional) 
            var subtitleMethod = ;  // SubtitleDeliveryMethod? | Optional. Specify the subtitle delivery method. (optional) 
            var maxRefFrames = 56;  // int? | Optional. (optional) 
            var maxVideoBitDepth = 56;  // int? | Optional. The maximum video bit depth. (optional) 
            var requireAvc = true;  // bool? | Optional. Whether to require avc. (optional) 
            var deInterlace = true;  // bool? | Optional. Whether to deinterlace the video. (optional) 
            var requireNonAnamorphic = true;  // bool? | Optional. Whether to require a non anamporphic stream. (optional) 
            var transcodingMaxAudioChannels = 56;  // int? | Optional. The maximum number of audio channels to transcode. (optional) 
            var cpuCoreLimit = 56;  // int? | Optional. The limit of how many cpu cores to use. (optional) 
            var liveStreamId = liveStreamId_example;  // string | The live stream id. (optional) 
            var enableMpegtsM2TsMode = true;  // bool? | Optional. Whether to enable the MpegtsM2Ts mode. (optional) 
            var videoCodec = videoCodec_example;  // string | Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url's extension. Options: h265, h264, mpeg4, theora, vpx, wmv. (optional) 
            var subtitleCodec = subtitleCodec_example;  // string | Optional. Specify a subtitle codec to encode to. (optional) 
            var transcodeReasons = transcodeReasons_example;  // string | Optional. The transcoding reason. (optional) 
            var audioStreamIndex = 56;  // int? | Optional. The index of the audio stream to use. If omitted the first audio stream will be used. (optional) 
            var videoStreamIndex = 56;  // int? | Optional. The index of the video stream to use. If omitted the first video stream will be used. (optional) 
            var context = ;  // EncodingContext? | Optional. The MediaBrowser.Model.Dlna.EncodingContext. (optional) 
            var streamOptions = new Dictionary<string, string>(); // Dictionary<string, string> | Optional. The streaming options. (optional) 

            try
            {
                // Gets an audio stream.
                System.IO.Stream result = apiInstance.HeadAudioStreamByContainer(itemId, container, _static, _params, tag, deviceProfileId, playSessionId, segmentContainer, segmentLength, minSegments, mediaSourceId, deviceId, audioCodec, enableAutoStreamCopy, allowVideoStreamCopy, allowAudioStreamCopy, breakOnNonKeyFrames, audioSampleRate, maxAudioBitDepth, audioBitRate, audioChannels, maxAudioChannels, profile, level, framerate, maxFramerate, copyTimestamps, startTimeTicks, width, height, videoBitRate, subtitleStreamIndex, subtitleMethod, maxRefFrames, maxVideoBitDepth, requireAvc, deInterlace, requireNonAnamorphic, transcodingMaxAudioChannels, cpuCoreLimit, liveStreamId, enableMpegtsM2TsMode, videoCodec, subtitleCodec, transcodeReasons, audioStreamIndex, videoStreamIndex, context, streamOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AudioApi.HeadAudioStreamByContainer: " + e.Message );
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
 **container** | **string**| The audio container. | 
 **_static** | **bool?**| Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false. | [optional] 
 **_params** | **string**| The streaming parameters. | [optional] 
 **tag** | **string**| The tag. | [optional] 
 **deviceProfileId** | **string**| Optional. The dlna device profile id to utilize. | [optional] 
 **playSessionId** | **string**| The play session id. | [optional] 
 **segmentContainer** | **string**| The segment container. | [optional] 
 **segmentLength** | **int?**| The segment lenght. | [optional] 
 **minSegments** | **int?**| The minimum number of segments. | [optional] 
 **mediaSourceId** | **string**| The media version id, if playing an alternate version. | [optional] 
 **deviceId** | **string**| The device id of the client requesting. Used to stop encoding processes when needed. | [optional] 
 **audioCodec** | **string**| Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url&#39;s extension. Options: aac, mp3, vorbis, wma. | [optional] 
 **enableAutoStreamCopy** | **bool?**| Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true. | [optional] 
 **allowVideoStreamCopy** | **bool?**| Whether or not to allow copying of the video stream url. | [optional] 
 **allowAudioStreamCopy** | **bool?**| Whether or not to allow copying of the audio stream url. | [optional] 
 **breakOnNonKeyFrames** | **bool?**| Optional. Whether to break on non key frames. | [optional] 
 **audioSampleRate** | **int?**| Optional. Specify a specific audio sample rate, e.g. 44100. | [optional] 
 **maxAudioBitDepth** | **int?**| Optional. The maximum audio bit depth. | [optional] 
 **audioBitRate** | **int?**| Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults. | [optional] 
 **audioChannels** | **int?**| Optional. Specify a specific number of audio channels to encode to, e.g. 2. | [optional] 
 **maxAudioChannels** | **int?**| Optional. Specify a maximum number of audio channels to encode to, e.g. 2. | [optional] 
 **profile** | **string**| Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high. | [optional] 
 **level** | **string**| Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1. | [optional] 
 **framerate** | **float?**| Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. | [optional] 
 **maxFramerate** | **float?**| Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements. | [optional] 
 **copyTimestamps** | **bool?**| Whether or not to copy timestamps when transcoding with an offset. Defaults to false. | [optional] 
 **startTimeTicks** | **long?**| Optional. Specify a starting offset, in ticks. 1 tick &#x3D; 10000 ms. | [optional] 
 **width** | **int?**| Optional. The fixed horizontal resolution of the encoded video. | [optional] 
 **height** | **int?**| Optional. The fixed vertical resolution of the encoded video. | [optional] 
 **videoBitRate** | **int?**| Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults. | [optional] 
 **subtitleStreamIndex** | **int?**| Optional. The index of the subtitle stream to use. If omitted no subtitles will be used. | [optional] 
 **subtitleMethod** | **SubtitleDeliveryMethod?**| Optional. Specify the subtitle delivery method. | [optional] 
 **maxRefFrames** | **int?**| Optional. | [optional] 
 **maxVideoBitDepth** | **int?**| Optional. The maximum video bit depth. | [optional] 
 **requireAvc** | **bool?**| Optional. Whether to require avc. | [optional] 
 **deInterlace** | **bool?**| Optional. Whether to deinterlace the video. | [optional] 
 **requireNonAnamorphic** | **bool?**| Optional. Whether to require a non anamporphic stream. | [optional] 
 **transcodingMaxAudioChannels** | **int?**| Optional. The maximum number of audio channels to transcode. | [optional] 
 **cpuCoreLimit** | **int?**| Optional. The limit of how many cpu cores to use. | [optional] 
 **liveStreamId** | **string**| The live stream id. | [optional] 
 **enableMpegtsM2TsMode** | **bool?**| Optional. Whether to enable the MpegtsM2Ts mode. | [optional] 
 **videoCodec** | **string**| Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url&#39;s extension. Options: h265, h264, mpeg4, theora, vpx, wmv. | [optional] 
 **subtitleCodec** | **string**| Optional. Specify a subtitle codec to encode to. | [optional] 
 **transcodeReasons** | **string**| Optional. The transcoding reason. | [optional] 
 **audioStreamIndex** | **int?**| Optional. The index of the audio stream to use. If omitted the first audio stream will be used. | [optional] 
 **videoStreamIndex** | **int?**| Optional. The index of the video stream to use. If omitted the first video stream will be used. | [optional] 
 **context** | **EncodingContext?**| Optional. The MediaBrowser.Model.Dlna.EncodingContext. | [optional] 
 **streamOptions** | [**Dictionary&lt;string, string&gt;**](string.md)| Optional. The streaming options. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: audio/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audio stream returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

