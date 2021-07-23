# Jellyfin.Api.Api.PackageApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPackageInstallation**](PackageApi.md#cancelpackageinstallation) | **DELETE** /Packages/Installing/{packageId} | Cancels a package installation.
[**GetPackageInfo**](PackageApi.md#getpackageinfo) | **GET** /Packages/{name} | Gets a package by name or assembly GUID.
[**GetPackages**](PackageApi.md#getpackages) | **GET** /Packages | Gets available packages.
[**GetRepositories**](PackageApi.md#getrepositories) | **GET** /Repositories | Gets all package repositories.
[**InstallPackage**](PackageApi.md#installpackage) | **POST** /Packages/Installed/{name} | Installs a package.
[**SetRepositories**](PackageApi.md#setrepositories) | **POST** /Repositories | Sets the enabled and existing package repositories.



## CancelPackageInstallation

> void CancelPackageInstallation (Guid packageId)

Cancels a package installation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class CancelPackageInstallationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PackageApi(Configuration.Default);
            var packageId = new Guid(); // Guid | Installation Id.

            try
            {
                // Cancels a package installation.
                apiInstance.CancelPackageInstallation(packageId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PackageApi.CancelPackageInstallation: " + e.Message );
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
 **packageId** | [**Guid**](Guid.md)| Installation Id. | 

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
| **204** | Installation cancelled. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPackageInfo

> PackageInfo GetPackageInfo (string name, Guid? assemblyGuid = null)

Gets a package by name or assembly GUID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPackageInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PackageApi(Configuration.Default);
            var name = name_example;  // string | The name of the package.
            var assemblyGuid = new Guid?(); // Guid? | The GUID of the associated assembly. (optional) 

            try
            {
                // Gets a package by name or assembly GUID.
                PackageInfo result = apiInstance.GetPackageInfo(name, assemblyGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PackageApi.GetPackageInfo: " + e.Message );
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
 **name** | **string**| The name of the package. | 
 **assemblyGuid** | [**Guid?**](Guid?.md)| The GUID of the associated assembly. | [optional] 

### Return type

[**PackageInfo**](PackageInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Package retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPackages

> List&lt;PackageInfo&gt; GetPackages ()

Gets available packages.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPackagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PackageApi(Configuration.Default);

            try
            {
                // Gets available packages.
                List<PackageInfo> result = apiInstance.GetPackages();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PackageApi.GetPackages: " + e.Message );
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

[**List&lt;PackageInfo&gt;**](PackageInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available packages returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRepositories

> List&lt;RepositoryInfo&gt; GetRepositories ()

Gets all package repositories.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRepositoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PackageApi(Configuration.Default);

            try
            {
                // Gets all package repositories.
                List<RepositoryInfo> result = apiInstance.GetRepositories();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PackageApi.GetRepositories: " + e.Message );
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

[**List&lt;RepositoryInfo&gt;**](RepositoryInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Package repositories returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InstallPackage

> void InstallPackage (string name, Guid? assemblyGuid = null, string version = null, string repositoryUrl = null)

Installs a package.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class InstallPackageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PackageApi(Configuration.Default);
            var name = name_example;  // string | Package name.
            var assemblyGuid = new Guid?(); // Guid? | GUID of the associated assembly. (optional) 
            var version = version_example;  // string | Optional version. Defaults to latest version. (optional) 
            var repositoryUrl = repositoryUrl_example;  // string | Optional. Specify the repository to install from. (optional) 

            try
            {
                // Installs a package.
                apiInstance.InstallPackage(name, assemblyGuid, version, repositoryUrl);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PackageApi.InstallPackage: " + e.Message );
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
 **name** | **string**| Package name. | 
 **assemblyGuid** | [**Guid?**](Guid?.md)| GUID of the associated assembly. | [optional] 
 **version** | **string**| Optional version. Defaults to latest version. | [optional] 
 **repositoryUrl** | **string**| Optional. Specify the repository to install from. | [optional] 

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
| **204** | Package found. |  -  |
| **404** | Package not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetRepositories

> void SetRepositories (List<RepositoryInfo> repositoryInfo)

Sets the enabled and existing package repositories.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SetRepositoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PackageApi(Configuration.Default);
            var repositoryInfo = new List<RepositoryInfo>(); // List<RepositoryInfo> | The list of package repositories.

            try
            {
                // Sets the enabled and existing package repositories.
                apiInstance.SetRepositories(repositoryInfo);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PackageApi.SetRepositories: " + e.Message );
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
 **repositoryInfo** | [**List&lt;RepositoryInfo&gt;**](RepositoryInfo.md)| The list of package repositories. | 

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
| **204** | Package repositories saved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

