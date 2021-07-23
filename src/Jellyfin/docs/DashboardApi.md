# Jellyfin.Api.Api.DashboardApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConfigurationPages**](DashboardApi.md#getconfigurationpages) | **GET** /web/ConfigurationPages | Gets the configuration pages.
[**GetDashboardConfigurationPage**](DashboardApi.md#getdashboardconfigurationpage) | **GET** /web/ConfigurationPage | Gets a dashboard configuration page.



## GetConfigurationPages

> List&lt;ConfigurationPageInfo&gt; GetConfigurationPages (bool? enableInMainMenu = null, ConfigurationPageType? pageType = null)

Gets the configuration pages.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetConfigurationPagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DashboardApi(Configuration.Default);
            var enableInMainMenu = true;  // bool? | Whether to enable in the main menu. (optional) 
            var pageType = ;  // ConfigurationPageType? | The Jellyfin.Api.Models.ConfigurationPageInfo. (optional) 

            try
            {
                // Gets the configuration pages.
                List<ConfigurationPageInfo> result = apiInstance.GetConfigurationPages(enableInMainMenu, pageType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DashboardApi.GetConfigurationPages: " + e.Message );
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
 **enableInMainMenu** | **bool?**| Whether to enable in the main menu. | [optional] 
 **pageType** | **ConfigurationPageType?**| The Jellyfin.Api.Models.ConfigurationPageInfo. | [optional] 

### Return type

[**List&lt;ConfigurationPageInfo&gt;**](ConfigurationPageInfo.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ConfigurationPages returned. |  -  |
| **404** | Server still loading. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDashboardConfigurationPage

> System.IO.Stream GetDashboardConfigurationPage (string name = null)

Gets a dashboard configuration page.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetDashboardConfigurationPageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DashboardApi(Configuration.Default);
            var name = name_example;  // string | The name of the page. (optional) 

            try
            {
                // Gets a dashboard configuration page.
                System.IO.Stream result = apiInstance.GetDashboardConfigurationPage(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DashboardApi.GetDashboardConfigurationPage: " + e.Message );
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
 **name** | **string**| The name of the page. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/html, application/x-javascript, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ConfigurationPage returned. |  -  |
| **404** | Plugin configuration page not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

