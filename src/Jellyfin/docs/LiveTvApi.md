# Jellyfin.Api.Api.LiveTvApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddListingProvider**](LiveTvApi.md#addlistingprovider) | **POST** /LiveTv/ListingProviders | Adds a listings provider.
[**AddTunerHost**](LiveTvApi.md#addtunerhost) | **POST** /LiveTv/TunerHosts | Adds a tuner host.
[**CancelSeriesTimer**](LiveTvApi.md#cancelseriestimer) | **DELETE** /LiveTv/SeriesTimers/{timerId} | Cancels a live tv series timer.
[**CancelTimer**](LiveTvApi.md#canceltimer) | **DELETE** /LiveTv/Timers/{timerId} | Cancels a live tv timer.
[**CreateSeriesTimer**](LiveTvApi.md#createseriestimer) | **POST** /LiveTv/SeriesTimers | Creates a live tv series timer.
[**CreateTimer**](LiveTvApi.md#createtimer) | **POST** /LiveTv/Timers | Creates a live tv timer.
[**DeleteListingProvider**](LiveTvApi.md#deletelistingprovider) | **DELETE** /LiveTv/ListingProviders | Delete listing provider.
[**DeleteRecording**](LiveTvApi.md#deleterecording) | **DELETE** /LiveTv/Recordings/{recordingId} | Deletes a live tv recording.
[**DeleteTunerHost**](LiveTvApi.md#deletetunerhost) | **DELETE** /LiveTv/TunerHosts | Deletes a tuner host.
[**DiscoverTuners**](LiveTvApi.md#discovertuners) | **GET** /LiveTv/Tuners/Discover | Discover tuners.
[**DiscvoverTuners**](LiveTvApi.md#discvovertuners) | **GET** /LiveTv/Tuners/Discvover | Discover tuners.
[**GetChannel**](LiveTvApi.md#getchannel) | **GET** /LiveTv/Channels/{channelId} | Gets a live tv channel.
[**GetChannelMappingOptions**](LiveTvApi.md#getchannelmappingoptions) | **GET** /LiveTv/ChannelMappingOptions | Get channel mapping options.
[**GetDefaultListingProvider**](LiveTvApi.md#getdefaultlistingprovider) | **GET** /LiveTv/ListingProviders/Default | Gets default listings provider info.
[**GetDefaultTimer**](LiveTvApi.md#getdefaulttimer) | **GET** /LiveTv/Timers/Defaults | Gets the default values for a new timer.
[**GetGuideInfo**](LiveTvApi.md#getguideinfo) | **GET** /LiveTv/GuideInfo | Get guid info.
[**GetLineups**](LiveTvApi.md#getlineups) | **GET** /LiveTv/ListingProviders/Lineups | Gets available lineups.
[**GetLiveRecordingFile**](LiveTvApi.md#getliverecordingfile) | **GET** /LiveTv/LiveRecordings/{recordingId}/stream | Gets a live tv recording stream.
[**GetLiveStreamFile**](LiveTvApi.md#getlivestreamfile) | **GET** /LiveTv/LiveStreamFiles/{streamId}/stream.{container} | Gets a live tv channel stream.
[**GetLiveTvChannels**](LiveTvApi.md#getlivetvchannels) | **GET** /LiveTv/Channels | Gets available live tv channels.
[**GetLiveTvInfo**](LiveTvApi.md#getlivetvinfo) | **GET** /LiveTv/Info | Gets available live tv services.
[**GetLiveTvPrograms**](LiveTvApi.md#getlivetvprograms) | **GET** /LiveTv/Programs | Gets available live tv epgs.
[**GetProgram**](LiveTvApi.md#getprogram) | **GET** /LiveTv/Programs/{programId} | Gets a live tv program.
[**GetPrograms**](LiveTvApi.md#getprograms) | **POST** /LiveTv/Programs | Gets available live tv epgs.
[**GetRecommendedPrograms**](LiveTvApi.md#getrecommendedprograms) | **GET** /LiveTv/Programs/Recommended | Gets recommended live tv epgs.
[**GetRecording**](LiveTvApi.md#getrecording) | **GET** /LiveTv/Recordings/{recordingId} | Gets a live tv recording.
[**GetRecordingFolders**](LiveTvApi.md#getrecordingfolders) | **GET** /LiveTv/Recordings/Folders | Gets recording folders.
[**GetRecordingGroup**](LiveTvApi.md#getrecordinggroup) | **GET** /LiveTv/Recordings/Groups/{groupId} | Get recording group.
[**GetRecordingGroups**](LiveTvApi.md#getrecordinggroups) | **GET** /LiveTv/Recordings/Groups | Gets live tv recording groups.
[**GetRecordings**](LiveTvApi.md#getrecordings) | **GET** /LiveTv/Recordings | Gets live tv recordings.
[**GetRecordingsSeries**](LiveTvApi.md#getrecordingsseries) | **GET** /LiveTv/Recordings/Series | Gets live tv recording series.
[**GetSchedulesDirectCountries**](LiveTvApi.md#getschedulesdirectcountries) | **GET** /LiveTv/ListingProviders/SchedulesDirect/Countries | Gets available countries.
[**GetSeriesTimer**](LiveTvApi.md#getseriestimer) | **GET** /LiveTv/SeriesTimers/{timerId} | Gets a live tv series timer.
[**GetSeriesTimers**](LiveTvApi.md#getseriestimers) | **GET** /LiveTv/SeriesTimers | Gets live tv series timers.
[**GetTimer**](LiveTvApi.md#gettimer) | **GET** /LiveTv/Timers/{timerId} | Gets a timer.
[**GetTimers**](LiveTvApi.md#gettimers) | **GET** /LiveTv/Timers | Gets the live tv timers.
[**GetTunerHostTypes**](LiveTvApi.md#gettunerhosttypes) | **GET** /LiveTv/TunerHosts/Types | Get tuner host types.
[**ResetTuner**](LiveTvApi.md#resettuner) | **POST** /LiveTv/Tuners/{tunerId}/Reset | Resets a tv tuner.
[**SetChannelMapping**](LiveTvApi.md#setchannelmapping) | **POST** /LiveTv/ChannelMappings | Set channel mappings.
[**UpdateSeriesTimer**](LiveTvApi.md#updateseriestimer) | **POST** /LiveTv/SeriesTimers/{timerId} | Updates a live tv series timer.
[**UpdateTimer**](LiveTvApi.md#updatetimer) | **POST** /LiveTv/Timers/{timerId} | Updates a live tv timer.



## AddListingProvider

> ListingsProviderInfo AddListingProvider (string pw = null, bool? validateListings = null, bool? validateLogin = null, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Adds a listings provider.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class AddListingProviderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var pw = pw_example;  // string | Password. (optional) 
            var validateListings = true;  // bool? | Validate listings. (optional)  (default to false)
            var validateLogin = true;  // bool? | Validate login. (optional)  (default to false)
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | New listings info. (optional) 

            try
            {
                // Adds a listings provider.
                ListingsProviderInfo result = apiInstance.AddListingProvider(pw, validateListings, validateLogin, UNKNOWN_BASE_TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.AddListingProvider: " + e.Message );
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
 **pw** | **string**| Password. | [optional] 
 **validateListings** | **bool?**| Validate listings. | [optional] [default to false]
 **validateLogin** | **bool?**| Validate login. | [optional] [default to false]
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| New listings info. | [optional] 

### Return type

[**ListingsProviderInfo**](ListingsProviderInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created listings provider returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddTunerHost

> TunerHostInfo AddTunerHost (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Adds a tuner host.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class AddTunerHostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | New tuner host. (optional) 

            try
            {
                // Adds a tuner host.
                TunerHostInfo result = apiInstance.AddTunerHost(UNKNOWN_BASE_TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.AddTunerHost: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| New tuner host. | [optional] 

### Return type

[**TunerHostInfo**](TunerHostInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created tuner host returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CancelSeriesTimer

> void CancelSeriesTimer (string timerId)

Cancels a live tv series timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class CancelSeriesTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var timerId = timerId_example;  // string | Timer id.

            try
            {
                // Cancels a live tv series timer.
                apiInstance.CancelSeriesTimer(timerId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.CancelSeriesTimer: " + e.Message );
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
 **timerId** | **string**| Timer id. | 

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
| **204** | Timer cancelled. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CancelTimer

> void CancelTimer (string timerId)

Cancels a live tv timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class CancelTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var timerId = timerId_example;  // string | Timer id.

            try
            {
                // Cancels a live tv timer.
                apiInstance.CancelTimer(timerId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.CancelTimer: " + e.Message );
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
 **timerId** | **string**| Timer id. | 

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
| **204** | Timer deleted. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSeriesTimer

> void CreateSeriesTimer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Creates a live tv series timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class CreateSeriesTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | New series timer info. (optional) 

            try
            {
                // Creates a live tv series timer.
                apiInstance.CreateSeriesTimer(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.CreateSeriesTimer: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| New series timer info. | [optional] 

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
| **204** | Series timer info created. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateTimer

> void CreateTimer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Creates a live tv timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class CreateTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | New timer info. (optional) 

            try
            {
                // Creates a live tv timer.
                apiInstance.CreateTimer(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.CreateTimer: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| New timer info. | [optional] 

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
| **204** | Timer created. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteListingProvider

> void DeleteListingProvider (string id = null)

Delete listing provider.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteListingProviderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var id = id_example;  // string | Listing provider id. (optional) 

            try
            {
                // Delete listing provider.
                apiInstance.DeleteListingProvider(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.DeleteListingProvider: " + e.Message );
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
 **id** | **string**| Listing provider id. | [optional] 

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
| **204** | Listing provider deleted. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteRecording

> void DeleteRecording (Guid recordingId)

Deletes a live tv recording.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteRecordingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var recordingId = new Guid(); // Guid | Recording id.

            try
            {
                // Deletes a live tv recording.
                apiInstance.DeleteRecording(recordingId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.DeleteRecording: " + e.Message );
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
 **recordingId** | [**Guid**](Guid.md)| Recording id. | 

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
| **204** | Recording deleted. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteTunerHost

> void DeleteTunerHost (string id = null)

Deletes a tuner host.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteTunerHostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var id = id_example;  // string | Tuner host id. (optional) 

            try
            {
                // Deletes a tuner host.
                apiInstance.DeleteTunerHost(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.DeleteTunerHost: " + e.Message );
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
 **id** | **string**| Tuner host id. | [optional] 

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
| **204** | Tuner host deleted. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DiscoverTuners

> List&lt;TunerHostInfo&gt; DiscoverTuners (bool? newDevicesOnly = null)

Discover tuners.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DiscoverTunersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var newDevicesOnly = true;  // bool? | Only discover new tuners. (optional)  (default to false)

            try
            {
                // Discover tuners.
                List<TunerHostInfo> result = apiInstance.DiscoverTuners(newDevicesOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.DiscoverTuners: " + e.Message );
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
 **newDevicesOnly** | **bool?**| Only discover new tuners. | [optional] [default to false]

### Return type

[**List&lt;TunerHostInfo&gt;**](TunerHostInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tuners returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DiscvoverTuners

> List&lt;TunerHostInfo&gt; DiscvoverTuners (bool? newDevicesOnly = null)

Discover tuners.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DiscvoverTunersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var newDevicesOnly = true;  // bool? | Only discover new tuners. (optional)  (default to false)

            try
            {
                // Discover tuners.
                List<TunerHostInfo> result = apiInstance.DiscvoverTuners(newDevicesOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.DiscvoverTuners: " + e.Message );
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
 **newDevicesOnly** | **bool?**| Only discover new tuners. | [optional] [default to false]

### Return type

[**List&lt;TunerHostInfo&gt;**](TunerHostInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tuners returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetChannel

> BaseItemDto GetChannel (Guid channelId, Guid? userId = null)

Gets a live tv channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var channelId = new Guid(); // Guid | Channel id.
            var userId = new Guid?(); // Guid? | Optional. Attach user data. (optional) 

            try
            {
                // Gets a live tv channel.
                BaseItemDto result = apiInstance.GetChannel(channelId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetChannel: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Attach user data. | [optional] 

### Return type

[**BaseItemDto**](BaseItemDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Live tv channel returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetChannelMappingOptions

> ChannelMappingOptionsDto GetChannelMappingOptions (string providerId = null)

Get channel mapping options.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetChannelMappingOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var providerId = providerId_example;  // string | Provider id. (optional) 

            try
            {
                // Get channel mapping options.
                ChannelMappingOptionsDto result = apiInstance.GetChannelMappingOptions(providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetChannelMappingOptions: " + e.Message );
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
 **providerId** | **string**| Provider id. | [optional] 

### Return type

[**ChannelMappingOptionsDto**](ChannelMappingOptionsDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel mapping options returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDefaultListingProvider

> ListingsProviderInfo GetDefaultListingProvider ()

Gets default listings provider info.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetDefaultListingProviderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);

            try
            {
                // Gets default listings provider info.
                ListingsProviderInfo result = apiInstance.GetDefaultListingProvider();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetDefaultListingProvider: " + e.Message );
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

[**ListingsProviderInfo**](ListingsProviderInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default listings provider info returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDefaultTimer

> SeriesTimerInfoDto GetDefaultTimer (string programId = null)

Gets the default values for a new timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetDefaultTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var programId = programId_example;  // string | Optional. To attach default values based on a program. (optional) 

            try
            {
                // Gets the default values for a new timer.
                SeriesTimerInfoDto result = apiInstance.GetDefaultTimer(programId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetDefaultTimer: " + e.Message );
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
 **programId** | **string**| Optional. To attach default values based on a program. | [optional] 

### Return type

[**SeriesTimerInfoDto**](SeriesTimerInfoDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default values returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetGuideInfo

> GuideInfo GetGuideInfo ()

Get guid info.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetGuideInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);

            try
            {
                // Get guid info.
                GuideInfo result = apiInstance.GetGuideInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetGuideInfo: " + e.Message );
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

[**GuideInfo**](GuideInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Guid info returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLineups

> List&lt;NameIdPair&gt; GetLineups (string id = null, string type = null, string location = null, string country = null)

Gets available lineups.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLineupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var id = id_example;  // string | Provider id. (optional) 
            var type = type_example;  // string | Provider type. (optional) 
            var location = location_example;  // string | Location. (optional) 
            var country = country_example;  // string | Country. (optional) 

            try
            {
                // Gets available lineups.
                List<NameIdPair> result = apiInstance.GetLineups(id, type, location, country);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetLineups: " + e.Message );
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
 **id** | **string**| Provider id. | [optional] 
 **type** | **string**| Provider type. | [optional] 
 **location** | **string**| Location. | [optional] 
 **country** | **string**| Country. | [optional] 

### Return type

[**List&lt;NameIdPair&gt;**](NameIdPair.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available lineups returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLiveRecordingFile

> System.IO.Stream GetLiveRecordingFile (string recordingId)

Gets a live tv recording stream.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLiveRecordingFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new LiveTvApi(Configuration.Default);
            var recordingId = recordingId_example;  // string | Recording id.

            try
            {
                // Gets a live tv recording stream.
                System.IO.Stream result = apiInstance.GetLiveRecordingFile(recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetLiveRecordingFile: " + e.Message );
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
 **recordingId** | **string**| Recording id. | 

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
| **200** | Recording stream returned. |  -  |
| **404** | Recording not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLiveStreamFile

> System.IO.Stream GetLiveStreamFile (string streamId, string container)

Gets a live tv channel stream.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLiveStreamFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new LiveTvApi(Configuration.Default);
            var streamId = streamId_example;  // string | Stream id.
            var container = container_example;  // string | Container type.

            try
            {
                // Gets a live tv channel stream.
                System.IO.Stream result = apiInstance.GetLiveStreamFile(streamId, container);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetLiveStreamFile: " + e.Message );
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
 **streamId** | **string**| Stream id. | 
 **container** | **string**| Container type. | 

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
| **200** | Stream returned. |  -  |
| **404** | Stream not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLiveTvChannels

> BaseItemDtoQueryResult GetLiveTvChannels (ChannelType? type = null, Guid? userId = null, int? startIndex = null, bool? isMovie = null, bool? isSeries = null, bool? isNews = null, bool? isKids = null, bool? isSports = null, int? limit = null, bool? isFavorite = null, bool? isLiked = null, bool? isDisliked = null, bool? enableImages = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, List<ItemFields> fields = null, bool? enableUserData = null, List<string> sortBy = null, SortOrder? sortOrder = null, bool? enableFavoriteSorting = null, bool? addCurrentProgram = null)

Gets available live tv channels.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLiveTvChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var type = ;  // ChannelType? | Optional. Filter by channel type. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user and attach user data. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var isMovie = true;  // bool? | Optional. Filter for movies. (optional) 
            var isSeries = true;  // bool? | Optional. Filter for series. (optional) 
            var isNews = true;  // bool? | Optional. Filter for news. (optional) 
            var isKids = true;  // bool? | Optional. Filter for kids. (optional) 
            var isSports = true;  // bool? | Optional. Filter for sports. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var isFavorite = true;  // bool? | Optional. Filter by channels that are favorites, or not. (optional) 
            var isLiked = true;  // bool? | Optional. Filter by channels that are liked, or not. (optional) 
            var isDisliked = true;  // bool? | Optional. Filter by channels that are disliked, or not. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | \"Optional. The image types to include in the output. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Key to sort by. (optional) 
            var sortOrder = ;  // SortOrder? | Optional. Sort order. (optional) 
            var enableFavoriteSorting = true;  // bool? | Optional. Incorporate favorite and like status into channel sorting. (optional)  (default to false)
            var addCurrentProgram = true;  // bool? | Optional. Adds current program info to each channel. (optional)  (default to true)

            try
            {
                // Gets available live tv channels.
                BaseItemDtoQueryResult result = apiInstance.GetLiveTvChannels(type, userId, startIndex, isMovie, isSeries, isNews, isKids, isSports, limit, isFavorite, isLiked, isDisliked, enableImages, imageTypeLimit, enableImageTypes, fields, enableUserData, sortBy, sortOrder, enableFavoriteSorting, addCurrentProgram);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetLiveTvChannels: " + e.Message );
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
 **type** | **ChannelType?**| Optional. Filter by channel type. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user and attach user data. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **isMovie** | **bool?**| Optional. Filter for movies. | [optional] 
 **isSeries** | **bool?**| Optional. Filter for series. | [optional] 
 **isNews** | **bool?**| Optional. Filter for news. | [optional] 
 **isKids** | **bool?**| Optional. Filter for kids. | [optional] 
 **isSports** | **bool?**| Optional. Filter for sports. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **isFavorite** | **bool?**| Optional. Filter by channels that are favorites, or not. | [optional] 
 **isLiked** | **bool?**| Optional. Filter by channels that are liked, or not. | [optional] 
 **isDisliked** | **bool?**| Optional. Filter by channels that are disliked, or not. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| \&quot;Optional. The image types to include in the output. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Key to sort by. | [optional] 
 **sortOrder** | **SortOrder?**| Optional. Sort order. | [optional] 
 **enableFavoriteSorting** | **bool?**| Optional. Incorporate favorite and like status into channel sorting. | [optional] [default to false]
 **addCurrentProgram** | **bool?**| Optional. Adds current program info to each channel. | [optional] [default to true]

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
| **200** | Available live tv channels returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLiveTvInfo

> LiveTvInfo GetLiveTvInfo ()

Gets available live tv services.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLiveTvInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);

            try
            {
                // Gets available live tv services.
                LiveTvInfo result = apiInstance.GetLiveTvInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetLiveTvInfo: " + e.Message );
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

[**LiveTvInfo**](LiveTvInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available live tv services returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLiveTvPrograms

> BaseItemDtoQueryResult GetLiveTvPrograms (List<Guid> channelIds = null, Guid? userId = null, DateTime? minStartDate = null, bool? hasAired = null, bool? isAiring = null, DateTime? maxStartDate = null, DateTime? minEndDate = null, DateTime? maxEndDate = null, bool? isMovie = null, bool? isSeries = null, bool? isNews = null, bool? isKids = null, bool? isSports = null, int? startIndex = null, int? limit = null, List<string> sortBy = null, List<SortOrder> sortOrder = null, List<string> genres = null, List<Guid> genreIds = null, bool? enableImages = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, bool? enableUserData = null, string seriesTimerId = null, Guid? librarySeriesId = null, List<ItemFields> fields = null, bool? enableTotalRecordCount = null)

Gets available live tv epgs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLiveTvProgramsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var channelIds = new List<Guid>(); // List<Guid> | The channels to return guide information for. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user id. (optional) 
            var minStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum premiere start date. (optional) 
            var hasAired = true;  // bool? | Optional. Filter by programs that have completed airing, or not. (optional) 
            var isAiring = true;  // bool? | Optional. Filter by programs that are currently airing, or not. (optional) 
            var maxStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The maximum premiere start date. (optional) 
            var minEndDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum premiere end date. (optional) 
            var maxEndDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The maximum premiere end date. (optional) 
            var isMovie = true;  // bool? | Optional. Filter for movies. (optional) 
            var isSeries = true;  // bool? | Optional. Filter for series. (optional) 
            var isNews = true;  // bool? | Optional. Filter for news. (optional) 
            var isKids = true;  // bool? | Optional. Filter for kids. (optional) 
            var isSports = true;  // bool? | Optional. Filter for sports. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Specify one or more sort orders, comma delimited. Options: Name, StartDate. (optional) 
            var sortOrder = new List<SortOrder>(); // List<SortOrder> | Sort Order - Ascending,Descending. (optional) 
            var genres = new List<string>(); // List<string> | The genres to return guide information for. (optional) 
            var genreIds = new List<Guid>(); // List<Guid> | The genre ids to return guide information for. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var seriesTimerId = seriesTimerId_example;  // string | Optional. Filter by series timer id. (optional) 
            var librarySeriesId = new Guid?(); // Guid? | Optional. Filter by library series id. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableTotalRecordCount = true;  // bool? | Retrieve total record count. (optional)  (default to true)

            try
            {
                // Gets available live tv epgs.
                BaseItemDtoQueryResult result = apiInstance.GetLiveTvPrograms(channelIds, userId, minStartDate, hasAired, isAiring, maxStartDate, minEndDate, maxEndDate, isMovie, isSeries, isNews, isKids, isSports, startIndex, limit, sortBy, sortOrder, genres, genreIds, enableImages, imageTypeLimit, enableImageTypes, enableUserData, seriesTimerId, librarySeriesId, fields, enableTotalRecordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetLiveTvPrograms: " + e.Message );
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
 **channelIds** | [**List&lt;Guid&gt;**](Guid.md)| The channels to return guide information for. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id. | [optional] 
 **minStartDate** | **DateTime?**| Optional. The minimum premiere start date. | [optional] 
 **hasAired** | **bool?**| Optional. Filter by programs that have completed airing, or not. | [optional] 
 **isAiring** | **bool?**| Optional. Filter by programs that are currently airing, or not. | [optional] 
 **maxStartDate** | **DateTime?**| Optional. The maximum premiere start date. | [optional] 
 **minEndDate** | **DateTime?**| Optional. The minimum premiere end date. | [optional] 
 **maxEndDate** | **DateTime?**| Optional. The maximum premiere end date. | [optional] 
 **isMovie** | **bool?**| Optional. Filter for movies. | [optional] 
 **isSeries** | **bool?**| Optional. Filter for series. | [optional] 
 **isNews** | **bool?**| Optional. Filter for news. | [optional] 
 **isKids** | **bool?**| Optional. Filter for kids. | [optional] 
 **isSports** | **bool?**| Optional. Filter for sports. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Specify one or more sort orders, comma delimited. Options: Name, StartDate. | [optional] 
 **sortOrder** | [**List&lt;SortOrder&gt;**](SortOrder.md)| Sort Order - Ascending,Descending. | [optional] 
 **genres** | [**List&lt;string&gt;**](string.md)| The genres to return guide information for. | [optional] 
 **genreIds** | [**List&lt;Guid&gt;**](Guid.md)| The genre ids to return guide information for. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **seriesTimerId** | **string**| Optional. Filter by series timer id. | [optional] 
 **librarySeriesId** | [**Guid?**](Guid?.md)| Optional. Filter by library series id. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableTotalRecordCount** | **bool?**| Retrieve total record count. | [optional] [default to true]

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
| **200** | Live tv epgs returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetProgram

> BaseItemDto GetProgram (string programId, Guid? userId = null)

Gets a live tv program.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetProgramExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var programId = programId_example;  // string | Program id.
            var userId = new Guid?(); // Guid? | Optional. Attach user data. (optional) 

            try
            {
                // Gets a live tv program.
                BaseItemDto result = apiInstance.GetProgram(programId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetProgram: " + e.Message );
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
 **programId** | **string**| Program id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Attach user data. | [optional] 

### Return type

[**BaseItemDto**](BaseItemDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPrograms

> BaseItemDtoQueryResult GetPrograms (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Gets available live tv epgs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetProgramsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | Request body. (optional) 

            try
            {
                // Gets available live tv epgs.
                BaseItemDtoQueryResult result = apiInstance.GetPrograms(UNKNOWN_BASE_TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetPrograms: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| Request body. | [optional] 

### Return type

[**BaseItemDtoQueryResult**](BaseItemDtoQueryResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Live tv epgs returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRecommendedPrograms

> BaseItemDtoQueryResult GetRecommendedPrograms (Guid? userId = null, int? limit = null, bool? isAiring = null, bool? hasAired = null, bool? isSeries = null, bool? isMovie = null, bool? isNews = null, bool? isKids = null, bool? isSports = null, bool? enableImages = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, List<Guid> genreIds = null, List<ItemFields> fields = null, bool? enableUserData = null, bool? enableTotalRecordCount = null)

Gets recommended live tv epgs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRecommendedProgramsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | Optional. filter by user id. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var isAiring = true;  // bool? | Optional. Filter by programs that are currently airing, or not. (optional) 
            var hasAired = true;  // bool? | Optional. Filter by programs that have completed airing, or not. (optional) 
            var isSeries = true;  // bool? | Optional. Filter for series. (optional) 
            var isMovie = true;  // bool? | Optional. Filter for movies. (optional) 
            var isNews = true;  // bool? | Optional. Filter for news. (optional) 
            var isKids = true;  // bool? | Optional. Filter for kids. (optional) 
            var isSports = true;  // bool? | Optional. Filter for sports. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var genreIds = new List<Guid>(); // List<Guid> | The genres to return guide information for. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. include user data. (optional) 
            var enableTotalRecordCount = true;  // bool? | Retrieve total record count. (optional)  (default to true)

            try
            {
                // Gets recommended live tv epgs.
                BaseItemDtoQueryResult result = apiInstance.GetRecommendedPrograms(userId, limit, isAiring, hasAired, isSeries, isMovie, isNews, isKids, isSports, enableImages, imageTypeLimit, enableImageTypes, genreIds, fields, enableUserData, enableTotalRecordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetRecommendedPrograms: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. filter by user id. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **isAiring** | **bool?**| Optional. Filter by programs that are currently airing, or not. | [optional] 
 **hasAired** | **bool?**| Optional. Filter by programs that have completed airing, or not. | [optional] 
 **isSeries** | **bool?**| Optional. Filter for series. | [optional] 
 **isMovie** | **bool?**| Optional. Filter for movies. | [optional] 
 **isNews** | **bool?**| Optional. Filter for news. | [optional] 
 **isKids** | **bool?**| Optional. Filter for kids. | [optional] 
 **isSports** | **bool?**| Optional. Filter for sports. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **genreIds** | [**List&lt;Guid&gt;**](Guid.md)| The genres to return guide information for. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. include user data. | [optional] 
 **enableTotalRecordCount** | **bool?**| Retrieve total record count. | [optional] [default to true]

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
| **200** | Recommended epgs returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRecording

> BaseItemDto GetRecording (Guid recordingId, Guid? userId = null)

Gets a live tv recording.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRecordingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var recordingId = new Guid(); // Guid | Recording id.
            var userId = new Guid?(); // Guid? | Optional. Attach user data. (optional) 

            try
            {
                // Gets a live tv recording.
                BaseItemDto result = apiInstance.GetRecording(recordingId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetRecording: " + e.Message );
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
 **recordingId** | [**Guid**](Guid.md)| Recording id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Attach user data. | [optional] 

### Return type

[**BaseItemDto**](BaseItemDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Recording returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRecordingFolders

> BaseItemDtoQueryResult GetRecordingFolders (Guid? userId = null)

Gets recording folders.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRecordingFoldersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | Optional. Filter by user and attach user data. (optional) 

            try
            {
                // Gets recording folders.
                BaseItemDtoQueryResult result = apiInstance.GetRecordingFolders(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetRecordingFolders: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user and attach user data. | [optional] 

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
| **200** | Recording folders returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRecordingGroup

> void GetRecordingGroup (Guid groupId)

Get recording group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRecordingGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var groupId = new Guid(); // Guid | Group id.

            try
            {
                // Get recording group.
                apiInstance.GetRecordingGroup(groupId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetRecordingGroup: " + e.Message );
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
 **groupId** | [**Guid**](Guid.md)| Group id. | 

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRecordingGroups

> BaseItemDtoQueryResult GetRecordingGroups (Guid? userId = null)

Gets live tv recording groups.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRecordingGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | Optional. Filter by user and attach user data. (optional) 

            try
            {
                // Gets live tv recording groups.
                BaseItemDtoQueryResult result = apiInstance.GetRecordingGroups(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetRecordingGroups: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user and attach user data. | [optional] 

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
| **200** | Recording groups returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRecordings

> BaseItemDtoQueryResult GetRecordings (string channelId = null, Guid? userId = null, int? startIndex = null, int? limit = null, RecordingStatus? status = null, bool? isInProgress = null, string seriesTimerId = null, bool? enableImages = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, List<ItemFields> fields = null, bool? enableUserData = null, bool? isMovie = null, bool? isSeries = null, bool? isKids = null, bool? isSports = null, bool? isNews = null, bool? isLibraryItem = null, bool? enableTotalRecordCount = null)

Gets live tv recordings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRecordingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var channelId = channelId_example;  // string | Optional. Filter by channel id. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user and attach user data. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var status = ;  // RecordingStatus? | Optional. Filter by recording status. (optional) 
            var isInProgress = true;  // bool? | Optional. Filter by recordings that are in progress, or not. (optional) 
            var seriesTimerId = seriesTimerId_example;  // string | Optional. Filter by recordings belonging to a series timer. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var isMovie = true;  // bool? | Optional. Filter for movies. (optional) 
            var isSeries = true;  // bool? | Optional. Filter for series. (optional) 
            var isKids = true;  // bool? | Optional. Filter for kids. (optional) 
            var isSports = true;  // bool? | Optional. Filter for sports. (optional) 
            var isNews = true;  // bool? | Optional. Filter for news. (optional) 
            var isLibraryItem = true;  // bool? | Optional. Filter for is library item. (optional) 
            var enableTotalRecordCount = true;  // bool? | Optional. Return total record count. (optional)  (default to true)

            try
            {
                // Gets live tv recordings.
                BaseItemDtoQueryResult result = apiInstance.GetRecordings(channelId, userId, startIndex, limit, status, isInProgress, seriesTimerId, enableImages, imageTypeLimit, enableImageTypes, fields, enableUserData, isMovie, isSeries, isKids, isSports, isNews, isLibraryItem, enableTotalRecordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetRecordings: " + e.Message );
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
 **channelId** | **string**| Optional. Filter by channel id. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user and attach user data. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **status** | **RecordingStatus?**| Optional. Filter by recording status. | [optional] 
 **isInProgress** | **bool?**| Optional. Filter by recordings that are in progress, or not. | [optional] 
 **seriesTimerId** | **string**| Optional. Filter by recordings belonging to a series timer. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **isMovie** | **bool?**| Optional. Filter for movies. | [optional] 
 **isSeries** | **bool?**| Optional. Filter for series. | [optional] 
 **isKids** | **bool?**| Optional. Filter for kids. | [optional] 
 **isSports** | **bool?**| Optional. Filter for sports. | [optional] 
 **isNews** | **bool?**| Optional. Filter for news. | [optional] 
 **isLibraryItem** | **bool?**| Optional. Filter for is library item. | [optional] 
 **enableTotalRecordCount** | **bool?**| Optional. Return total record count. | [optional] [default to true]

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
| **200** | Live tv recordings returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRecordingsSeries

> BaseItemDtoQueryResult GetRecordingsSeries (string channelId = null, Guid? userId = null, string groupId = null, int? startIndex = null, int? limit = null, RecordingStatus? status = null, bool? isInProgress = null, string seriesTimerId = null, bool? enableImages = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, List<ItemFields> fields = null, bool? enableUserData = null, bool? enableTotalRecordCount = null)

Gets live tv recording series.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRecordingsSeriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var channelId = channelId_example;  // string | Optional. Filter by channel id. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user and attach user data. (optional) 
            var groupId = groupId_example;  // string | Optional. Filter by recording group. (optional) 
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var status = ;  // RecordingStatus? | Optional. Filter by recording status. (optional) 
            var isInProgress = true;  // bool? | Optional. Filter by recordings that are in progress, or not. (optional) 
            var seriesTimerId = seriesTimerId_example;  // string | Optional. Filter by recordings belonging to a series timer. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var enableTotalRecordCount = true;  // bool? | Optional. Return total record count. (optional)  (default to true)

            try
            {
                // Gets live tv recording series.
                BaseItemDtoQueryResult result = apiInstance.GetRecordingsSeries(channelId, userId, groupId, startIndex, limit, status, isInProgress, seriesTimerId, enableImages, imageTypeLimit, enableImageTypes, fields, enableUserData, enableTotalRecordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetRecordingsSeries: " + e.Message );
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
 **channelId** | **string**| Optional. Filter by channel id. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user and attach user data. | [optional] 
 **groupId** | **string**| Optional. Filter by recording group. | [optional] 
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **status** | **RecordingStatus?**| Optional. Filter by recording status. | [optional] 
 **isInProgress** | **bool?**| Optional. Filter by recordings that are in progress, or not. | [optional] 
 **seriesTimerId** | **string**| Optional. Filter by recordings belonging to a series timer. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **enableTotalRecordCount** | **bool?**| Optional. Return total record count. | [optional] [default to true]

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
| **200** | Live tv recordings returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSchedulesDirectCountries

> System.IO.Stream GetSchedulesDirectCountries ()

Gets available countries.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSchedulesDirectCountriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);

            try
            {
                // Gets available countries.
                System.IO.Stream result = apiInstance.GetSchedulesDirectCountries();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetSchedulesDirectCountries: " + e.Message );
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

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available countries returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSeriesTimer

> SeriesTimerInfoDto GetSeriesTimer (string timerId)

Gets a live tv series timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSeriesTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var timerId = timerId_example;  // string | Timer id.

            try
            {
                // Gets a live tv series timer.
                SeriesTimerInfoDto result = apiInstance.GetSeriesTimer(timerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetSeriesTimer: " + e.Message );
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
 **timerId** | **string**| Timer id. | 

### Return type

[**SeriesTimerInfoDto**](SeriesTimerInfoDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Series timer returned. |  -  |
| **404** | Series timer not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSeriesTimers

> SeriesTimerInfoDtoQueryResult GetSeriesTimers (string sortBy = null, SortOrder? sortOrder = null)

Gets live tv series timers.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSeriesTimersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var sortBy = sortBy_example;  // string | Optional. Sort by SortName or Priority. (optional) 
            var sortOrder = ;  // SortOrder? | Optional. Sort in Ascending or Descending order. (optional) 

            try
            {
                // Gets live tv series timers.
                SeriesTimerInfoDtoQueryResult result = apiInstance.GetSeriesTimers(sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetSeriesTimers: " + e.Message );
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
 **sortBy** | **string**| Optional. Sort by SortName or Priority. | [optional] 
 **sortOrder** | **SortOrder?**| Optional. Sort in Ascending or Descending order. | [optional] 

### Return type

[**SeriesTimerInfoDtoQueryResult**](SeriesTimerInfoDtoQueryResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Timers returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTimer

> TimerInfoDto GetTimer (string timerId)

Gets a timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var timerId = timerId_example;  // string | Timer id.

            try
            {
                // Gets a timer.
                TimerInfoDto result = apiInstance.GetTimer(timerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetTimer: " + e.Message );
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
 **timerId** | **string**| Timer id. | 

### Return type

[**TimerInfoDto**](TimerInfoDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Timer returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTimers

> TimerInfoDtoQueryResult GetTimers (string channelId = null, string seriesTimerId = null, bool? isActive = null, bool? isScheduled = null)

Gets the live tv timers.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetTimersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var channelId = channelId_example;  // string | Optional. Filter by channel id. (optional) 
            var seriesTimerId = seriesTimerId_example;  // string | Optional. Filter by timers belonging to a series timer. (optional) 
            var isActive = true;  // bool? | Optional. Filter by timers that are active. (optional) 
            var isScheduled = true;  // bool? | Optional. Filter by timers that are scheduled. (optional) 

            try
            {
                // Gets the live tv timers.
                TimerInfoDtoQueryResult result = apiInstance.GetTimers(channelId, seriesTimerId, isActive, isScheduled);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetTimers: " + e.Message );
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
 **channelId** | **string**| Optional. Filter by channel id. | [optional] 
 **seriesTimerId** | **string**| Optional. Filter by timers belonging to a series timer. | [optional] 
 **isActive** | **bool?**| Optional. Filter by timers that are active. | [optional] 
 **isScheduled** | **bool?**| Optional. Filter by timers that are scheduled. | [optional] 

### Return type

[**TimerInfoDtoQueryResult**](TimerInfoDtoQueryResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
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


## GetTunerHostTypes

> List&lt;NameIdPair&gt; GetTunerHostTypes ()

Get tuner host types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetTunerHostTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);

            try
            {
                // Get tuner host types.
                List<NameIdPair> result = apiInstance.GetTunerHostTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.GetTunerHostTypes: " + e.Message );
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

[**List&lt;NameIdPair&gt;**](NameIdPair.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tuner host types returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ResetTuner

> void ResetTuner (string tunerId)

Resets a tv tuner.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ResetTunerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var tunerId = tunerId_example;  // string | Tuner id.

            try
            {
                // Resets a tv tuner.
                apiInstance.ResetTuner(tunerId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.ResetTuner: " + e.Message );
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
 **tunerId** | **string**| Tuner id. | 

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
| **204** | Tuner reset. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetChannelMapping

> TunerChannelMapping SetChannelMapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Set channel mappings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SetChannelMappingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The set channel mapping dto.

            try
            {
                // Set channel mappings.
                TunerChannelMapping result = apiInstance.SetChannelMapping(UNKNOWN_BASE_TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.SetChannelMapping: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The set channel mapping dto. | 

### Return type

[**TunerChannelMapping**](TunerChannelMapping.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created channel mapping returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSeriesTimer

> void UpdateSeriesTimer (string timerId, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Updates a live tv series timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdateSeriesTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var timerId = timerId_example;  // string | Timer id.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | New series timer info. (optional) 

            try
            {
                // Updates a live tv series timer.
                apiInstance.UpdateSeriesTimer(timerId, UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.UpdateSeriesTimer: " + e.Message );
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
 **timerId** | **string**| Timer id. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| New series timer info. | [optional] 

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
| **204** | Series timer updated. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateTimer

> void UpdateTimer (string timerId, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Updates a live tv timer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdateTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LiveTvApi(Configuration.Default);
            var timerId = timerId_example;  // string | Timer id.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | New timer info. (optional) 

            try
            {
                // Updates a live tv timer.
                apiInstance.UpdateTimer(timerId, UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LiveTvApi.UpdateTimer: " + e.Message );
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
 **timerId** | **string**| Timer id. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| New timer info. | [optional] 

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
| **204** | Timer updated. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

