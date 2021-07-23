# Jellyfin.Api.Api.SubtitleApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSubtitle**](SubtitleApi.md#deletesubtitle) | **DELETE** /Videos/{itemId}/Subtitles/{index} | Deletes an external subtitle file.
[**DownloadRemoteSubtitles**](SubtitleApi.md#downloadremotesubtitles) | **POST** /Items/{itemId}/RemoteSearch/Subtitles/{subtitleId} | Downloads a remote subtitle.
[**GetFallbackFont**](SubtitleApi.md#getfallbackfont) | **GET** /FallbackFont/Fonts/{name} | Gets a fallback font file.
[**GetFallbackFontList**](SubtitleApi.md#getfallbackfontlist) | **GET** /FallbackFont/Fonts | Gets a list of available fallback font files.
[**GetRemoteSubtitles**](SubtitleApi.md#getremotesubtitles) | **GET** /Providers/Subtitles/Subtitles/{id} | Gets the remote subtitles.
[**GetSubtitle**](SubtitleApi.md#getsubtitle) | **GET** /Videos/{routeItemId}/{routeMediaSourceId}/Subtitles/{routeIndex}/Stream.{routeFormat} | Gets subtitles in a specified format.
[**GetSubtitlePlaylist**](SubtitleApi.md#getsubtitleplaylist) | **GET** /Videos/{itemId}/{mediaSourceId}/Subtitles/{index}/subtitles.m3u8 | Gets an HLS subtitle playlist.
[**GetSubtitleWithTicks**](SubtitleApi.md#getsubtitlewithticks) | **GET** /Videos/{routeItemId}/{routeMediaSourceId}/Subtitles/{routeIndex}/{routeStartPositionTicks}/Stream.{routeFormat} | Gets subtitles in a specified format.
[**SearchRemoteSubtitles**](SubtitleApi.md#searchremotesubtitles) | **GET** /Items/{itemId}/RemoteSearch/Subtitles/{language} | Search remote subtitles.
[**UploadSubtitle**](SubtitleApi.md#uploadsubtitle) | **POST** /Videos/{itemId}/Subtitles | Upload an external subtitle file.



## DeleteSubtitle

> void DeleteSubtitle (Guid itemId, int index)

Deletes an external subtitle file.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteSubtitleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SubtitleApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var index = 56;  // int | The index of the subtitle file.

            try
            {
                // Deletes an external subtitle file.
                apiInstance.DeleteSubtitle(itemId, index);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.DeleteSubtitle: " + e.Message );
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
 **index** | **int**| The index of the subtitle file. | 

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
| **204** | Subtitle deleted. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DownloadRemoteSubtitles

> void DownloadRemoteSubtitles (Guid itemId, string subtitleId)

Downloads a remote subtitle.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DownloadRemoteSubtitlesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SubtitleApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var subtitleId = subtitleId_example;  // string | The subtitle id.

            try
            {
                // Downloads a remote subtitle.
                apiInstance.DownloadRemoteSubtitles(itemId, subtitleId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.DownloadRemoteSubtitles: " + e.Message );
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
 **subtitleId** | **string**| The subtitle id. | 

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
| **204** | Subtitle downloaded. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFallbackFont

> System.IO.Stream GetFallbackFont (string name)

Gets a fallback font file.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetFallbackFontExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SubtitleApi(Configuration.Default);
            var name = name_example;  // string | The name of the fallback font file to get.

            try
            {
                // Gets a fallback font file.
                System.IO.Stream result = apiInstance.GetFallbackFont(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.GetFallbackFont: " + e.Message );
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
 **name** | **string**| The name of the fallback font file to get. | 

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: font/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fallback font file retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFallbackFontList

> List&lt;FontFile&gt; GetFallbackFontList ()

Gets a list of available fallback font files.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetFallbackFontListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SubtitleApi(Configuration.Default);

            try
            {
                // Gets a list of available fallback font files.
                List<FontFile> result = apiInstance.GetFallbackFontList();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.GetFallbackFontList: " + e.Message );
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

[**List&lt;FontFile&gt;**](FontFile.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Information retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRemoteSubtitles

> System.IO.Stream GetRemoteSubtitles (string id)

Gets the remote subtitles.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRemoteSubtitlesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SubtitleApi(Configuration.Default);
            var id = id_example;  // string | The item id.

            try
            {
                // Gets the remote subtitles.
                System.IO.Stream result = apiInstance.GetRemoteSubtitles(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.GetRemoteSubtitles: " + e.Message );
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
 **id** | **string**| The item id. | 

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSubtitle

> System.IO.Stream GetSubtitle (Guid routeItemId, string routeMediaSourceId, int routeIndex, string routeFormat, Guid? itemId = null, string mediaSourceId = null, int? index = null, string format = null, long? endPositionTicks = null, bool? copyTimestamps = null, bool? addVttTimeMap = null, long? startPositionTicks = null)

Gets subtitles in a specified format.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSubtitleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new SubtitleApi(Configuration.Default);
            var routeItemId = new Guid(); // Guid | The (route) item id.
            var routeMediaSourceId = routeMediaSourceId_example;  // string | The (route) media source id.
            var routeIndex = 56;  // int | The (route) subtitle stream index.
            var routeFormat = routeFormat_example;  // string | The (route) format of the returned subtitle.
            var itemId = new Guid?(); // Guid? | The item id. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media source id. (optional) 
            var index = 56;  // int? | The subtitle stream index. (optional) 
            var format = format_example;  // string | The format of the returned subtitle. (optional) 
            var endPositionTicks = 789;  // long? | Optional. The end position of the subtitle in ticks. (optional) 
            var copyTimestamps = true;  // bool? | Optional. Whether to copy the timestamps. (optional)  (default to false)
            var addVttTimeMap = true;  // bool? | Optional. Whether to add a VTT time map. (optional)  (default to false)
            var startPositionTicks = 789;  // long? | The start position of the subtitle in ticks. (optional)  (default to 0)

            try
            {
                // Gets subtitles in a specified format.
                System.IO.Stream result = apiInstance.GetSubtitle(routeItemId, routeMediaSourceId, routeIndex, routeFormat, itemId, mediaSourceId, index, format, endPositionTicks, copyTimestamps, addVttTimeMap, startPositionTicks);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.GetSubtitle: " + e.Message );
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
 **routeItemId** | [**Guid**](Guid.md)| The (route) item id. | 
 **routeMediaSourceId** | **string**| The (route) media source id. | 
 **routeIndex** | **int**| The (route) subtitle stream index. | 
 **routeFormat** | **string**| The (route) format of the returned subtitle. | 
 **itemId** | [**Guid?**](Guid?.md)| The item id. | [optional] 
 **mediaSourceId** | **string**| The media source id. | [optional] 
 **index** | **int?**| The subtitle stream index. | [optional] 
 **format** | **string**| The format of the returned subtitle. | [optional] 
 **endPositionTicks** | **long?**| Optional. The end position of the subtitle in ticks. | [optional] 
 **copyTimestamps** | **bool?**| Optional. Whether to copy the timestamps. | [optional] [default to false]
 **addVttTimeMap** | **bool?**| Optional. Whether to add a VTT time map. | [optional] [default to false]
 **startPositionTicks** | **long?**| The start position of the subtitle in ticks. | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSubtitlePlaylist

> System.IO.Stream GetSubtitlePlaylist (Guid itemId, int index, string mediaSourceId, int segmentLength)

Gets an HLS subtitle playlist.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSubtitlePlaylistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SubtitleApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var index = 56;  // int | The subtitle stream index.
            var mediaSourceId = mediaSourceId_example;  // string | The media source id.
            var segmentLength = 56;  // int | The subtitle segment length.

            try
            {
                // Gets an HLS subtitle playlist.
                System.IO.Stream result = apiInstance.GetSubtitlePlaylist(itemId, index, mediaSourceId, segmentLength);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.GetSubtitlePlaylist: " + e.Message );
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
 **index** | **int**| The subtitle stream index. | 
 **mediaSourceId** | **string**| The media source id. | 
 **segmentLength** | **int**| The subtitle segment length. | 

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
| **200** | Subtitle playlist retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSubtitleWithTicks

> System.IO.Stream GetSubtitleWithTicks (Guid routeItemId, string routeMediaSourceId, int routeIndex, long routeStartPositionTicks, string routeFormat, Guid? itemId = null, string mediaSourceId = null, int? index = null, long? startPositionTicks = null, string format = null, long? endPositionTicks = null, bool? copyTimestamps = null, bool? addVttTimeMap = null)

Gets subtitles in a specified format.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSubtitleWithTicksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new SubtitleApi(Configuration.Default);
            var routeItemId = new Guid(); // Guid | The (route) item id.
            var routeMediaSourceId = routeMediaSourceId_example;  // string | The (route) media source id.
            var routeIndex = 56;  // int | The (route) subtitle stream index.
            var routeStartPositionTicks = 789;  // long | The (route) start position of the subtitle in ticks.
            var routeFormat = routeFormat_example;  // string | The (route) format of the returned subtitle.
            var itemId = new Guid?(); // Guid? | The item id. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | The media source id. (optional) 
            var index = 56;  // int? | The subtitle stream index. (optional) 
            var startPositionTicks = 789;  // long? | The start position of the subtitle in ticks. (optional) 
            var format = format_example;  // string | The format of the returned subtitle. (optional) 
            var endPositionTicks = 789;  // long? | Optional. The end position of the subtitle in ticks. (optional) 
            var copyTimestamps = true;  // bool? | Optional. Whether to copy the timestamps. (optional)  (default to false)
            var addVttTimeMap = true;  // bool? | Optional. Whether to add a VTT time map. (optional)  (default to false)

            try
            {
                // Gets subtitles in a specified format.
                System.IO.Stream result = apiInstance.GetSubtitleWithTicks(routeItemId, routeMediaSourceId, routeIndex, routeStartPositionTicks, routeFormat, itemId, mediaSourceId, index, startPositionTicks, format, endPositionTicks, copyTimestamps, addVttTimeMap);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.GetSubtitleWithTicks: " + e.Message );
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
 **routeItemId** | [**Guid**](Guid.md)| The (route) item id. | 
 **routeMediaSourceId** | **string**| The (route) media source id. | 
 **routeIndex** | **int**| The (route) subtitle stream index. | 
 **routeStartPositionTicks** | **long**| The (route) start position of the subtitle in ticks. | 
 **routeFormat** | **string**| The (route) format of the returned subtitle. | 
 **itemId** | [**Guid?**](Guid?.md)| The item id. | [optional] 
 **mediaSourceId** | **string**| The media source id. | [optional] 
 **index** | **int?**| The subtitle stream index. | [optional] 
 **startPositionTicks** | **long?**| The start position of the subtitle in ticks. | [optional] 
 **format** | **string**| The format of the returned subtitle. | [optional] 
 **endPositionTicks** | **long?**| Optional. The end position of the subtitle in ticks. | [optional] 
 **copyTimestamps** | **bool?**| Optional. Whether to copy the timestamps. | [optional] [default to false]
 **addVttTimeMap** | **bool?**| Optional. Whether to add a VTT time map. | [optional] [default to false]

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File returned. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchRemoteSubtitles

> List&lt;RemoteSubtitleInfo&gt; SearchRemoteSubtitles (Guid itemId, string language, bool? isPerfectMatch = null)

Search remote subtitles.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SearchRemoteSubtitlesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SubtitleApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var language = language_example;  // string | The language of the subtitles.
            var isPerfectMatch = true;  // bool? | Optional. Only show subtitles which are a perfect match. (optional) 

            try
            {
                // Search remote subtitles.
                List<RemoteSubtitleInfo> result = apiInstance.SearchRemoteSubtitles(itemId, language, isPerfectMatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.SearchRemoteSubtitles: " + e.Message );
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
 **language** | **string**| The language of the subtitles. | 
 **isPerfectMatch** | **bool?**| Optional. Only show subtitles which are a perfect match. | [optional] 

### Return type

[**List&lt;RemoteSubtitleInfo&gt;**](RemoteSubtitleInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subtitles retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UploadSubtitle

> void UploadSubtitle (Guid itemId, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Upload an external subtitle file.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UploadSubtitleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SubtitleApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item the subtitle belongs to.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The request body.

            try
            {
                // Upload an external subtitle file.
                apiInstance.UploadSubtitle(itemId, UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitleApi.UploadSubtitle: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| The item the subtitle belongs to. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The request body. | 

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
| **204** | Subtitle uploaded. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

