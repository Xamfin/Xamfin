# Jellyfin.Api.Api.DisplayPreferencesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDisplayPreferences**](DisplayPreferencesApi.md#getdisplaypreferences) | **GET** /DisplayPreferences/{displayPreferencesId} | Get Display Preferences.
[**UpdateDisplayPreferences**](DisplayPreferencesApi.md#updatedisplaypreferences) | **POST** /DisplayPreferences/{displayPreferencesId} | Update Display Preferences.



## GetDisplayPreferences

> DisplayPreferencesDto GetDisplayPreferences (string displayPreferencesId, Guid userId, string _client)

Get Display Preferences.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetDisplayPreferencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new DisplayPreferencesApi(Configuration.Default);
            var displayPreferencesId = displayPreferencesId_example;  // string | Display preferences id.
            var userId = new Guid(); // Guid | User id.
            var _client = _client_example;  // string | Client.

            try
            {
                // Get Display Preferences.
                DisplayPreferencesDto result = apiInstance.GetDisplayPreferences(displayPreferencesId, userId, _client);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DisplayPreferencesApi.GetDisplayPreferences: " + e.Message );
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
 **displayPreferencesId** | **string**| Display preferences id. | 
 **userId** | [**Guid**](Guid.md)| User id. | 
 **_client** | **string**| Client. | 

### Return type

[**DisplayPreferencesDto**](DisplayPreferencesDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Display preferences retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateDisplayPreferences

> void UpdateDisplayPreferences (string displayPreferencesId, Guid userId, string _client, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Update Display Preferences.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdateDisplayPreferencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new DisplayPreferencesApi(Configuration.Default);
            var displayPreferencesId = displayPreferencesId_example;  // string | Display preferences id.
            var userId = new Guid(); // Guid | User Id.
            var _client = _client_example;  // string | Client.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | New Display Preferences object.

            try
            {
                // Update Display Preferences.
                apiInstance.UpdateDisplayPreferences(displayPreferencesId, userId, _client, UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DisplayPreferencesApi.UpdateDisplayPreferences: " + e.Message );
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
 **displayPreferencesId** | **string**| Display preferences id. | 
 **userId** | [**Guid**](Guid.md)| User Id. | 
 **_client** | **string**| Client. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| New Display Preferences object. | 

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
| **204** | Display preferences updated. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

