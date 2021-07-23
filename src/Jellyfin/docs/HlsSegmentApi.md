# Jellyfin.Api.Api.HlsSegmentApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHlsAudioSegmentLegacyAac**](HlsSegmentApi.md#gethlsaudiosegmentlegacyaac) | **GET** /Audio/{itemId}/hls/{segmentId}/stream.aac | Gets the specified audio segment for an audio item.
[**GetHlsAudioSegmentLegacyMp3**](HlsSegmentApi.md#gethlsaudiosegmentlegacymp3) | **GET** /Audio/{itemId}/hls/{segmentId}/stream.mp3 | Gets the specified audio segment for an audio item.
[**GetHlsPlaylistLegacy**](HlsSegmentApi.md#gethlsplaylistlegacy) | **GET** /Videos/{itemId}/hls/{playlistId}/stream.m3u8 | Gets a hls video playlist.
[**GetHlsVideoSegmentLegacy**](HlsSegmentApi.md#gethlsvideosegmentlegacy) | **GET** /Videos/{itemId}/hls/{playlistId}/{segmentId}.{segmentContainer} | Gets a hls video segment.
[**StopEncodingProcess**](HlsSegmentApi.md#stopencodingprocess) | **DELETE** /Videos/ActiveEncodings | Stops an active encoding.



## GetHlsAudioSegmentLegacyAac

> System.IO.Stream GetHlsAudioSegmentLegacyAac (string itemId, string segmentId)

Gets the specified audio segment for an audio item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetHlsAudioSegmentLegacyAacExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new HlsSegmentApi(Configuration.Default);
            var itemId = itemId_example;  // string | The item id.
            var segmentId = segmentId_example;  // string | The segment id.

            try
            {
                // Gets the specified audio segment for an audio item.
                System.IO.Stream result = apiInstance.GetHlsAudioSegmentLegacyAac(itemId, segmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HlsSegmentApi.GetHlsAudioSegmentLegacyAac: " + e.Message );
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
 **itemId** | **string**| The item id. | 
 **segmentId** | **string**| The segment id. | 

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
| **200** | Hls audio segment returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetHlsAudioSegmentLegacyMp3

> System.IO.Stream GetHlsAudioSegmentLegacyMp3 (string itemId, string segmentId)

Gets the specified audio segment for an audio item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetHlsAudioSegmentLegacyMp3Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new HlsSegmentApi(Configuration.Default);
            var itemId = itemId_example;  // string | The item id.
            var segmentId = segmentId_example;  // string | The segment id.

            try
            {
                // Gets the specified audio segment for an audio item.
                System.IO.Stream result = apiInstance.GetHlsAudioSegmentLegacyMp3(itemId, segmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HlsSegmentApi.GetHlsAudioSegmentLegacyMp3: " + e.Message );
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
 **itemId** | **string**| The item id. | 
 **segmentId** | **string**| The segment id. | 

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
| **200** | Hls audio segment returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetHlsPlaylistLegacy

> System.IO.Stream GetHlsPlaylistLegacy (string itemId, string playlistId)

Gets a hls video playlist.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetHlsPlaylistLegacyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new HlsSegmentApi(Configuration.Default);
            var itemId = itemId_example;  // string | The video id.
            var playlistId = playlistId_example;  // string | The playlist id.

            try
            {
                // Gets a hls video playlist.
                System.IO.Stream result = apiInstance.GetHlsPlaylistLegacy(itemId, playlistId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HlsSegmentApi.GetHlsPlaylistLegacy: " + e.Message );
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
 **itemId** | **string**| The video id. | 
 **playlistId** | **string**| The playlist id. | 

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/x-mpegURL


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Hls video playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetHlsVideoSegmentLegacy

> System.IO.Stream GetHlsVideoSegmentLegacy (string itemId, string playlistId, string segmentId, string segmentContainer)

Gets a hls video segment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetHlsVideoSegmentLegacyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new HlsSegmentApi(Configuration.Default);
            var itemId = itemId_example;  // string | The item id.
            var playlistId = playlistId_example;  // string | The playlist id.
            var segmentId = segmentId_example;  // string | The segment id.
            var segmentContainer = segmentContainer_example;  // string | The segment container.

            try
            {
                // Gets a hls video segment.
                System.IO.Stream result = apiInstance.GetHlsVideoSegmentLegacy(itemId, playlistId, segmentId, segmentContainer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HlsSegmentApi.GetHlsVideoSegmentLegacy: " + e.Message );
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
 **itemId** | **string**| The item id. | 
 **playlistId** | **string**| The playlist id. | 
 **segmentId** | **string**| The segment id. | 
 **segmentContainer** | **string**| The segment container. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: video/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Hls video segment returned. |  -  |
| **404** | Hls segment not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## StopEncodingProcess

> void StopEncodingProcess (string deviceId, string playSessionId)

Stops an active encoding.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class StopEncodingProcessExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new HlsSegmentApi(Configuration.Default);
            var deviceId = deviceId_example;  // string | The device id of the client requesting. Used to stop encoding processes when needed.
            var playSessionId = playSessionId_example;  // string | The play session id.

            try
            {
                // Stops an active encoding.
                apiInstance.StopEncodingProcess(deviceId, playSessionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HlsSegmentApi.StopEncodingProcess: " + e.Message );
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
 **deviceId** | **string**| The device id of the client requesting. Used to stop encoding processes when needed. | 
 **playSessionId** | **string**| The play session id. | 

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
| **204** | Encoding stopped successfully. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

