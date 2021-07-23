# Jellyfin.Api.Api.LibraryStructureApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMediaPath**](LibraryStructureApi.md#addmediapath) | **POST** /Library/VirtualFolders/Paths | Add a media path to a library.
[**AddVirtualFolder**](LibraryStructureApi.md#addvirtualfolder) | **POST** /Library/VirtualFolders | Adds a virtual folder.
[**GetVirtualFolders**](LibraryStructureApi.md#getvirtualfolders) | **GET** /Library/VirtualFolders | Gets all virtual folders.
[**RemoveMediaPath**](LibraryStructureApi.md#removemediapath) | **DELETE** /Library/VirtualFolders/Paths | Remove a media path.
[**RemoveVirtualFolder**](LibraryStructureApi.md#removevirtualfolder) | **DELETE** /Library/VirtualFolders | Removes a virtual folder.
[**RenameVirtualFolder**](LibraryStructureApi.md#renamevirtualfolder) | **POST** /Library/VirtualFolders/Name | Renames a virtual folder.
[**UpdateLibraryOptions**](LibraryStructureApi.md#updatelibraryoptions) | **POST** /Library/VirtualFolders/LibraryOptions | Update library options.
[**UpdateMediaPath**](LibraryStructureApi.md#updatemediapath) | **POST** /Library/VirtualFolders/Paths/Update | Updates a media path.



## AddMediaPath

> void AddMediaPath (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE, bool? refreshLibrary = null)

Add a media path to a library.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class AddMediaPathExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryStructureApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The media path dto.
            var refreshLibrary = true;  // bool? | Whether to refresh the library. (optional)  (default to false)

            try
            {
                // Add a media path to a library.
                apiInstance.AddMediaPath(UNKNOWN_BASE_TYPE, refreshLibrary);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryStructureApi.AddMediaPath: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The media path dto. | 
 **refreshLibrary** | **bool?**| Whether to refresh the library. | [optional] [default to false]

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
| **204** | Media path added. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddVirtualFolder

> void AddVirtualFolder (string name = null, CollectionTypeOptions? collectionType = null, List<string> paths = null, bool? refreshLibrary = null, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Adds a virtual folder.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class AddVirtualFolderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryStructureApi(Configuration.Default);
            var name = name_example;  // string | The name of the virtual folder. (optional) 
            var collectionType = ;  // CollectionTypeOptions? | The type of the collection. (optional) 
            var paths = new List<string>(); // List<string> | The paths of the virtual folder. (optional) 
            var refreshLibrary = true;  // bool? | Whether to refresh the library. (optional)  (default to false)
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The library options. (optional) 

            try
            {
                // Adds a virtual folder.
                apiInstance.AddVirtualFolder(name, collectionType, paths, refreshLibrary, UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryStructureApi.AddVirtualFolder: " + e.Message );
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
 **name** | **string**| The name of the virtual folder. | [optional] 
 **collectionType** | **CollectionTypeOptions?**| The type of the collection. | [optional] 
 **paths** | [**List&lt;string&gt;**](string.md)| The paths of the virtual folder. | [optional] 
 **refreshLibrary** | **bool?**| Whether to refresh the library. | [optional] [default to false]
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The library options. | [optional] 

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
| **204** | Folder added. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetVirtualFolders

> List&lt;VirtualFolderInfo&gt; GetVirtualFolders ()

Gets all virtual folders.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetVirtualFoldersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryStructureApi(Configuration.Default);

            try
            {
                // Gets all virtual folders.
                List<VirtualFolderInfo> result = apiInstance.GetVirtualFolders();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryStructureApi.GetVirtualFolders: " + e.Message );
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

[**List&lt;VirtualFolderInfo&gt;**](VirtualFolderInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Virtual folders retrieved. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveMediaPath

> void RemoveMediaPath (string name = null, string path = null, bool? refreshLibrary = null)

Remove a media path.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class RemoveMediaPathExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryStructureApi(Configuration.Default);
            var name = name_example;  // string | The name of the library. (optional) 
            var path = path_example;  // string | The path to remove. (optional) 
            var refreshLibrary = true;  // bool? | Whether to refresh the library. (optional)  (default to false)

            try
            {
                // Remove a media path.
                apiInstance.RemoveMediaPath(name, path, refreshLibrary);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryStructureApi.RemoveMediaPath: " + e.Message );
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
 **name** | **string**| The name of the library. | [optional] 
 **path** | **string**| The path to remove. | [optional] 
 **refreshLibrary** | **bool?**| Whether to refresh the library. | [optional] [default to false]

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
| **204** | Media path removed. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveVirtualFolder

> void RemoveVirtualFolder (string name = null, bool? refreshLibrary = null)

Removes a virtual folder.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class RemoveVirtualFolderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryStructureApi(Configuration.Default);
            var name = name_example;  // string | The name of the folder. (optional) 
            var refreshLibrary = true;  // bool? | Whether to refresh the library. (optional)  (default to false)

            try
            {
                // Removes a virtual folder.
                apiInstance.RemoveVirtualFolder(name, refreshLibrary);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryStructureApi.RemoveVirtualFolder: " + e.Message );
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
 **name** | **string**| The name of the folder. | [optional] 
 **refreshLibrary** | **bool?**| Whether to refresh the library. | [optional] [default to false]

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
| **204** | Folder removed. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RenameVirtualFolder

> void RenameVirtualFolder (string name = null, string newName = null, bool? refreshLibrary = null)

Renames a virtual folder.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class RenameVirtualFolderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryStructureApi(Configuration.Default);
            var name = name_example;  // string | The name of the virtual folder. (optional) 
            var newName = newName_example;  // string | The new name. (optional) 
            var refreshLibrary = true;  // bool? | Whether to refresh the library. (optional)  (default to false)

            try
            {
                // Renames a virtual folder.
                apiInstance.RenameVirtualFolder(name, newName, refreshLibrary);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryStructureApi.RenameVirtualFolder: " + e.Message );
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
 **name** | **string**| The name of the virtual folder. | [optional] 
 **newName** | **string**| The new name. | [optional] 
 **refreshLibrary** | **bool?**| Whether to refresh the library. | [optional] [default to false]

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
| **204** | Folder renamed. |  -  |
| **404** | Library doesn&#39;t exist. |  -  |
| **409** | Library already exists. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateLibraryOptions

> void UpdateLibraryOptions (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null)

Update library options.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdateLibraryOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryStructureApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The library name and options. (optional) 

            try
            {
                // Update library options.
                apiInstance.UpdateLibraryOptions(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryStructureApi.UpdateLibraryOptions: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The library name and options. | [optional] 

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
| **204** | Library updated. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateMediaPath

> void UpdateMediaPath (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Updates a media path.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdateMediaPathExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryStructureApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The name of the library and path infos.

            try
            {
                // Updates a media path.
                apiInstance.UpdateMediaPath(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryStructureApi.UpdateMediaPath: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The name of the library and path infos. | 

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
| **204** | Media path updated. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

