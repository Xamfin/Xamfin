# Jellyfin.Api.Api.PluginsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DisablePlugin**](PluginsApi.md#disableplugin) | **POST** /Plugins/{pluginId}/{version}/Disable | Disable a plugin.
[**EnablePlugin**](PluginsApi.md#enableplugin) | **POST** /Plugins/{pluginId}/{version}/Enable | Enables a disabled plugin.
[**GetPluginConfiguration**](PluginsApi.md#getpluginconfiguration) | **GET** /Plugins/{pluginId}/Configuration | Gets plugin configuration.
[**GetPluginImage**](PluginsApi.md#getpluginimage) | **GET** /Plugins/{pluginId}/{version}/Image | Gets a plugin&#39;s image.
[**GetPluginManifest**](PluginsApi.md#getpluginmanifest) | **POST** /Plugins/{pluginId}/Manifest | Gets a plugin&#39;s manifest.
[**GetPlugins**](PluginsApi.md#getplugins) | **GET** /Plugins | Gets a list of currently installed plugins.
[**UninstallPlugin**](PluginsApi.md#uninstallplugin) | **DELETE** /Plugins/{pluginId} | Uninstalls a plugin.
[**UninstallPluginByVersion**](PluginsApi.md#uninstallpluginbyversion) | **DELETE** /Plugins/{pluginId}/{version} | Uninstalls a plugin by version.
[**UpdatePluginConfiguration**](PluginsApi.md#updatepluginconfiguration) | **POST** /Plugins/{pluginId}/Configuration | Updates plugin configuration.
[**UpdatePluginSecurityInfo**](PluginsApi.md#updatepluginsecurityinfo) | **POST** /Plugins/SecurityInfo | Updates plugin security info.



## DisablePlugin

> void DisablePlugin (Guid pluginId, Version version)

Disable a plugin.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DisablePluginExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var pluginId = new Guid(); // Guid | Plugin id.
            var version = new Version(); // Version | Plugin version.

            try
            {
                // Disable a plugin.
                apiInstance.DisablePlugin(pluginId, version);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.DisablePlugin: " + e.Message );
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
 **pluginId** | [**Guid**](Guid.md)| Plugin id. | 
 **version** | [**Version**](Version.md)| Plugin version. | 

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
| **204** | Plugin disabled. |  -  |
| **404** | Plugin not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EnablePlugin

> void EnablePlugin (Guid pluginId, Version version)

Enables a disabled plugin.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class EnablePluginExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var pluginId = new Guid(); // Guid | Plugin id.
            var version = new Version(); // Version | Plugin version.

            try
            {
                // Enables a disabled plugin.
                apiInstance.EnablePlugin(pluginId, version);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.EnablePlugin: " + e.Message );
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
 **pluginId** | [**Guid**](Guid.md)| Plugin id. | 
 **version** | [**Version**](Version.md)| Plugin version. | 

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
| **204** | Plugin enabled. |  -  |
| **404** | Plugin not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPluginConfiguration

> Object GetPluginConfiguration (Guid pluginId)

Gets plugin configuration.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPluginConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var pluginId = new Guid(); // Guid | Plugin id.

            try
            {
                // Gets plugin configuration.
                Object result = apiInstance.GetPluginConfiguration(pluginId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPluginConfiguration: " + e.Message );
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
 **pluginId** | [**Guid**](Guid.md)| Plugin id. | 

### Return type

**Object**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Plugin configuration returned. |  -  |
| **404** | Plugin not found or plugin configuration not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPluginImage

> System.IO.Stream GetPluginImage (Guid pluginId, Version version)

Gets a plugin's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPluginImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var pluginId = new Guid(); // Guid | Plugin id.
            var version = new Version(); // Version | Plugin version.

            try
            {
                // Gets a plugin's image.
                System.IO.Stream result = apiInstance.GetPluginImage(pluginId, version);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPluginImage: " + e.Message );
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
 **pluginId** | [**Guid**](Guid.md)| Plugin id. | 
 **version** | [**Version**](Version.md)| Plugin version. | 

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Plugin image returned. |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPluginManifest

> void GetPluginManifest (Guid pluginId)

Gets a plugin's manifest.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPluginManifestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var pluginId = new Guid(); // Guid | Plugin id.

            try
            {
                // Gets a plugin's manifest.
                apiInstance.GetPluginManifest(pluginId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPluginManifest: " + e.Message );
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
 **pluginId** | [**Guid**](Guid.md)| Plugin id. | 

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
| **204** | Plugin manifest returned. |  -  |
| **404** | Plugin not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlugins

> List&lt;PluginInfo&gt; GetPlugins ()

Gets a list of currently installed plugins.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPluginsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);

            try
            {
                // Gets a list of currently installed plugins.
                List<PluginInfo> result = apiInstance.GetPlugins();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPlugins: " + e.Message );
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

[**List&lt;PluginInfo&gt;**](PluginInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Installed plugins returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UninstallPlugin

> void UninstallPlugin (Guid pluginId)

Uninstalls a plugin.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UninstallPluginExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var pluginId = new Guid(); // Guid | Plugin id.

            try
            {
                // Uninstalls a plugin.
                apiInstance.UninstallPlugin(pluginId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.UninstallPlugin: " + e.Message );
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
 **pluginId** | [**Guid**](Guid.md)| Plugin id. | 

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
| **204** | Plugin uninstalled. |  -  |
| **404** | Plugin not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UninstallPluginByVersion

> void UninstallPluginByVersion (Guid pluginId, Version version)

Uninstalls a plugin by version.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UninstallPluginByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var pluginId = new Guid(); // Guid | Plugin id.
            var version = new Version(); // Version | Plugin version.

            try
            {
                // Uninstalls a plugin by version.
                apiInstance.UninstallPluginByVersion(pluginId, version);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.UninstallPluginByVersion: " + e.Message );
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
 **pluginId** | [**Guid**](Guid.md)| Plugin id. | 
 **version** | [**Version**](Version.md)| Plugin version. | 

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
| **204** | Plugin uninstalled. |  -  |
| **404** | Plugin not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePluginConfiguration

> void UpdatePluginConfiguration (Guid pluginId)

Updates plugin configuration.

Accepts plugin configuration as JSON body.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdatePluginConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var pluginId = new Guid(); // Guid | Plugin id.

            try
            {
                // Updates plugin configuration.
                apiInstance.UpdatePluginConfiguration(pluginId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.UpdatePluginConfiguration: " + e.Message );
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
 **pluginId** | [**Guid**](Guid.md)| Plugin id. | 

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
| **204** | Plugin configuration updated. |  -  |
| **404** | Plugin not found or plugin does not have configuration. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePluginSecurityInfo

> void UpdatePluginSecurityInfo (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Updates plugin security info.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdatePluginSecurityInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PluginsApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | Plugin security info.

            try
            {
                // Updates plugin security info.
                apiInstance.UpdatePluginSecurityInfo(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PluginsApi.UpdatePluginSecurityInfo: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| Plugin security info. | 

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
| **204** | Plugin security info updated. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

