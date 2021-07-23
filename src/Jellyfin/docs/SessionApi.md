# Jellyfin.Api.Api.SessionApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserToSession**](SessionApi.md#addusertosession) | **POST** /Sessions/{sessionId}/User/{userId} | Adds an additional user to a session.
[**DisplayContent**](SessionApi.md#displaycontent) | **POST** /Sessions/{sessionId}/Viewing | Instructs a session to browse to an item or view.
[**GetAuthProviders**](SessionApi.md#getauthproviders) | **GET** /Auth/Providers | Get all auth providers.
[**GetPasswordResetProviders**](SessionApi.md#getpasswordresetproviders) | **GET** /Auth/PasswordResetProviders | Get all password reset providers.
[**GetSessions**](SessionApi.md#getsessions) | **GET** /Sessions | Gets a list of sessions.
[**Play**](SessionApi.md#play) | **POST** /Sessions/{sessionId}/Playing | Instructs a session to play an item.
[**PostCapabilities**](SessionApi.md#postcapabilities) | **POST** /Sessions/Capabilities | Updates capabilities for a device.
[**PostFullCapabilities**](SessionApi.md#postfullcapabilities) | **POST** /Sessions/Capabilities/Full | Updates capabilities for a device.
[**RemoveUserFromSession**](SessionApi.md#removeuserfromsession) | **DELETE** /Sessions/{sessionId}/User/{userId} | Removes an additional user from a session.
[**ReportSessionEnded**](SessionApi.md#reportsessionended) | **POST** /Sessions/Logout | Reports that a session has ended.
[**ReportViewing**](SessionApi.md#reportviewing) | **POST** /Sessions/Viewing | Reports that a session is viewing an item.
[**SendFullGeneralCommand**](SessionApi.md#sendfullgeneralcommand) | **POST** /Sessions/{sessionId}/Command | Issues a full general command to a client.
[**SendGeneralCommand**](SessionApi.md#sendgeneralcommand) | **POST** /Sessions/{sessionId}/Command/{command} | Issues a general command to a client.
[**SendMessageCommand**](SessionApi.md#sendmessagecommand) | **POST** /Sessions/{sessionId}/Message | Issues a command to a client to display a message to the user.
[**SendPlaystateCommand**](SessionApi.md#sendplaystatecommand) | **POST** /Sessions/{sessionId}/Playing/{command} | Issues a playstate command to a client.
[**SendSystemCommand**](SessionApi.md#sendsystemcommand) | **POST** /Sessions/{sessionId}/System/{command} | Issues a system command to a client.



## AddUserToSession

> void AddUserToSession (string sessionId, Guid userId)

Adds an additional user to a session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class AddUserToSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session id.
            var userId = new Guid(); // Guid | The user id.

            try
            {
                // Adds an additional user to a session.
                apiInstance.AddUserToSession(sessionId, userId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.AddUserToSession: " + e.Message );
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
 **sessionId** | **string**| The session id. | 
 **userId** | [**Guid**](Guid.md)| The user id. | 

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
| **204** | User added to session. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DisplayContent

> void DisplayContent (string sessionId, string itemType, string itemId, string itemName)

Instructs a session to browse to an item or view.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DisplayContentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session Id.
            var itemType = itemType_example;  // string | The type of item to browse to.
            var itemId = itemId_example;  // string | The Id of the item.
            var itemName = itemName_example;  // string | The name of the item.

            try
            {
                // Instructs a session to browse to an item or view.
                apiInstance.DisplayContent(sessionId, itemType, itemId, itemName);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.DisplayContent: " + e.Message );
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
 **sessionId** | **string**| The session Id. | 
 **itemType** | **string**| The type of item to browse to. | 
 **itemId** | **string**| The Id of the item. | 
 **itemName** | **string**| The name of the item. | 

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
| **204** | Instruction sent to session. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAuthProviders

> List&lt;NameIdPair&gt; GetAuthProviders ()

Get all auth providers.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetAuthProvidersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);

            try
            {
                // Get all auth providers.
                List<NameIdPair> result = apiInstance.GetAuthProviders();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.GetAuthProviders: " + e.Message );
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
| **200** | Auth providers retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPasswordResetProviders

> List&lt;NameIdPair&gt; GetPasswordResetProviders ()

Get all password reset providers.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPasswordResetProvidersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);

            try
            {
                // Get all password reset providers.
                List<NameIdPair> result = apiInstance.GetPasswordResetProviders();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.GetPasswordResetProviders: " + e.Message );
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
| **200** | Password reset providers retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSessions

> List&lt;SessionInfo&gt; GetSessions (Guid? controllableByUserId = null, string deviceId = null, int? activeWithinSeconds = null)

Gets a list of sessions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSessionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var controllableByUserId = new Guid?(); // Guid? | Filter by sessions that a given user is allowed to remote control. (optional) 
            var deviceId = deviceId_example;  // string | Filter by device Id. (optional) 
            var activeWithinSeconds = 56;  // int? | Optional. Filter by sessions that were active in the last n seconds. (optional) 

            try
            {
                // Gets a list of sessions.
                List<SessionInfo> result = apiInstance.GetSessions(controllableByUserId, deviceId, activeWithinSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.GetSessions: " + e.Message );
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
 **controllableByUserId** | [**Guid?**](Guid?.md)| Filter by sessions that a given user is allowed to remote control. | [optional] 
 **deviceId** | **string**| Filter by device Id. | [optional] 
 **activeWithinSeconds** | **int?**| Optional. Filter by sessions that were active in the last n seconds. | [optional] 

### Return type

[**List&lt;SessionInfo&gt;**](SessionInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of sessions returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Play

> void Play (string sessionId, PlayCommand playCommand, List<Guid> itemIds, long? startPositionTicks = null, string mediaSourceId = null, int? audioStreamIndex = null, int? subtitleStreamIndex = null, int? startIndex = null)

Instructs a session to play an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PlayExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session id.
            var playCommand = ;  // PlayCommand | The type of play command to issue (PlayNow, PlayNext, PlayLast). Clients who have not yet implemented play next and play last may play now.
            var itemIds = new List<Guid>(); // List<Guid> | The ids of the items to play, comma delimited.
            var startPositionTicks = 789;  // long? | The starting position of the first item. (optional) 
            var mediaSourceId = mediaSourceId_example;  // string | Optional. The media source id. (optional) 
            var audioStreamIndex = 56;  // int? | Optional. The index of the audio stream to play. (optional) 
            var subtitleStreamIndex = 56;  // int? | Optional. The index of the subtitle stream to play. (optional) 
            var startIndex = 56;  // int? | Optional. The start index. (optional) 

            try
            {
                // Instructs a session to play an item.
                apiInstance.Play(sessionId, playCommand, itemIds, startPositionTicks, mediaSourceId, audioStreamIndex, subtitleStreamIndex, startIndex);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.Play: " + e.Message );
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
 **sessionId** | **string**| The session id. | 
 **playCommand** | **PlayCommand**| The type of play command to issue (PlayNow, PlayNext, PlayLast). Clients who have not yet implemented play next and play last may play now. | 
 **itemIds** | [**List&lt;Guid&gt;**](Guid.md)| The ids of the items to play, comma delimited. | 
 **startPositionTicks** | **long?**| The starting position of the first item. | [optional] 
 **mediaSourceId** | **string**| Optional. The media source id. | [optional] 
 **audioStreamIndex** | **int?**| Optional. The index of the audio stream to play. | [optional] 
 **subtitleStreamIndex** | **int?**| Optional. The index of the subtitle stream to play. | [optional] 
 **startIndex** | **int?**| Optional. The start index. | [optional] 

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
| **204** | Instruction sent to session. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostCapabilities

> void PostCapabilities (string id = null, List<string> playableMediaTypes = null, List<GeneralCommandType> supportedCommands = null, bool? supportsMediaControl = null, bool? supportsSync = null, bool? supportsPersistentIdentifier = null)

Updates capabilities for a device.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostCapabilitiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var id = id_example;  // string | The session id. (optional) 
            var playableMediaTypes = new List<string>(); // List<string> | A list of playable media types, comma delimited. Audio, Video, Book, Photo. (optional) 
            var supportedCommands = new List<GeneralCommandType>(); // List<GeneralCommandType> | A list of supported remote control commands, comma delimited. (optional) 
            var supportsMediaControl = true;  // bool? | Determines whether media can be played remotely.. (optional)  (default to false)
            var supportsSync = true;  // bool? | Determines whether sync is supported. (optional)  (default to false)
            var supportsPersistentIdentifier = true;  // bool? | Determines whether the device supports a unique identifier. (optional)  (default to true)

            try
            {
                // Updates capabilities for a device.
                apiInstance.PostCapabilities(id, playableMediaTypes, supportedCommands, supportsMediaControl, supportsSync, supportsPersistentIdentifier);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.PostCapabilities: " + e.Message );
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
 **id** | **string**| The session id. | [optional] 
 **playableMediaTypes** | [**List&lt;string&gt;**](string.md)| A list of playable media types, comma delimited. Audio, Video, Book, Photo. | [optional] 
 **supportedCommands** | [**List&lt;GeneralCommandType&gt;**](GeneralCommandType.md)| A list of supported remote control commands, comma delimited. | [optional] 
 **supportsMediaControl** | **bool?**| Determines whether media can be played remotely.. | [optional] [default to false]
 **supportsSync** | **bool?**| Determines whether sync is supported. | [optional] [default to false]
 **supportsPersistentIdentifier** | **bool?**| Determines whether the device supports a unique identifier. | [optional] [default to true]

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
| **204** | Capabilities posted. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostFullCapabilities

> void PostFullCapabilities (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE, string id = null)

Updates capabilities for a device.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostFullCapabilitiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The MediaBrowser.Model.Session.ClientCapabilities.
            var id = id_example;  // string | The session id. (optional) 

            try
            {
                // Updates capabilities for a device.
                apiInstance.PostFullCapabilities(UNKNOWN_BASE_TYPE, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.PostFullCapabilities: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The MediaBrowser.Model.Session.ClientCapabilities. | 
 **id** | **string**| The session id. | [optional] 

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
| **204** | Capabilities updated. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveUserFromSession

> void RemoveUserFromSession (string sessionId, Guid userId)

Removes an additional user from a session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class RemoveUserFromSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session id.
            var userId = new Guid(); // Guid | The user id.

            try
            {
                // Removes an additional user from a session.
                apiInstance.RemoveUserFromSession(sessionId, userId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.RemoveUserFromSession: " + e.Message );
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
 **sessionId** | **string**| The session id. | 
 **userId** | [**Guid**](Guid.md)| The user id. | 

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
| **204** | User removed from session. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReportSessionEnded

> void ReportSessionEnded ()

Reports that a session has ended.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ReportSessionEndedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);

            try
            {
                // Reports that a session has ended.
                apiInstance.ReportSessionEnded();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.ReportSessionEnded: " + e.Message );
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

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Session end reported to server. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReportViewing

> void ReportViewing (string itemId, string sessionId = null)

Reports that a session is viewing an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ReportViewingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var itemId = itemId_example;  // string | The item id.
            var sessionId = sessionId_example;  // string | The session id. (optional) 

            try
            {
                // Reports that a session is viewing an item.
                apiInstance.ReportViewing(itemId, sessionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.ReportViewing: " + e.Message );
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
 **sessionId** | **string**| The session id. | [optional] 

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
| **204** | Session reported to server. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendFullGeneralCommand

> void SendFullGeneralCommand (string sessionId, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Issues a full general command to a client.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SendFullGeneralCommandExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session id.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The MediaBrowser.Model.Session.GeneralCommand.

            try
            {
                // Issues a full general command to a client.
                apiInstance.SendFullGeneralCommand(sessionId, UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.SendFullGeneralCommand: " + e.Message );
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
 **sessionId** | **string**| The session id. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The MediaBrowser.Model.Session.GeneralCommand. | 

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
| **204** | Full general command sent to session. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendGeneralCommand

> void SendGeneralCommand (string sessionId, GeneralCommandType command)

Issues a general command to a client.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SendGeneralCommandExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session id.
            var command = ;  // GeneralCommandType | The command to send.

            try
            {
                // Issues a general command to a client.
                apiInstance.SendGeneralCommand(sessionId, command);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.SendGeneralCommand: " + e.Message );
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
 **sessionId** | **string**| The session id. | 
 **command** | **GeneralCommandType**| The command to send. | 

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
| **204** | General command sent to session. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendMessageCommand

> void SendMessageCommand (string sessionId, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Issues a command to a client to display a message to the user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SendMessageCommandExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session id.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The MediaBrowser.Model.Session.MessageCommand object containing Header, Message Text, and TimeoutMs.

            try
            {
                // Issues a command to a client to display a message to the user.
                apiInstance.SendMessageCommand(sessionId, UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.SendMessageCommand: " + e.Message );
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
 **sessionId** | **string**| The session id. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The MediaBrowser.Model.Session.MessageCommand object containing Header, Message Text, and TimeoutMs. | 

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
| **204** | Message sent. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendPlaystateCommand

> void SendPlaystateCommand (string sessionId, PlaystateCommand command, long? seekPositionTicks = null, string controllingUserId = null)

Issues a playstate command to a client.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SendPlaystateCommandExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session id.
            var command = ;  // PlaystateCommand | The MediaBrowser.Model.Session.PlaystateCommand.
            var seekPositionTicks = 789;  // long? | The optional position ticks. (optional) 
            var controllingUserId = controllingUserId_example;  // string | The optional controlling user id. (optional) 

            try
            {
                // Issues a playstate command to a client.
                apiInstance.SendPlaystateCommand(sessionId, command, seekPositionTicks, controllingUserId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.SendPlaystateCommand: " + e.Message );
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
 **sessionId** | **string**| The session id. | 
 **command** | **PlaystateCommand**| The MediaBrowser.Model.Session.PlaystateCommand. | 
 **seekPositionTicks** | **long?**| The optional position ticks. | [optional] 
 **controllingUserId** | **string**| The optional controlling user id. | [optional] 

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
| **204** | Playstate command sent to session. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendSystemCommand

> void SendSystemCommand (string sessionId, GeneralCommandType command)

Issues a system command to a client.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SendSystemCommandExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new SessionApi(Configuration.Default);
            var sessionId = sessionId_example;  // string | The session id.
            var command = ;  // GeneralCommandType | The command to send.

            try
            {
                // Issues a system command to a client.
                apiInstance.SendSystemCommand(sessionId, command);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionApi.SendSystemCommand: " + e.Message );
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
 **sessionId** | **string**| The session id. | 
 **command** | **GeneralCommandType**| The command to send. | 

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
| **204** | System command sent to session. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

