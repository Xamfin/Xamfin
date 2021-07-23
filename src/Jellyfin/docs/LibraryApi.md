# Jellyfin.Api.Api.LibraryApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteItem**](LibraryApi.md#deleteitem) | **DELETE** /Items/{itemId} | Deletes an item from the library and filesystem.
[**DeleteItems**](LibraryApi.md#deleteitems) | **DELETE** /Items | Deletes items from the library and filesystem.
[**GetAncestors**](LibraryApi.md#getancestors) | **GET** /Items/{itemId}/Ancestors | Gets all parents of an item.
[**GetCriticReviews**](LibraryApi.md#getcriticreviews) | **GET** /Items/{itemId}/CriticReviews | Gets critic review for an item.
[**GetDownload**](LibraryApi.md#getdownload) | **GET** /Items/{itemId}/Download | Downloads item media.
[**GetFile**](LibraryApi.md#getfile) | **GET** /Items/{itemId}/File | Get the original file of an item.
[**GetItemCounts**](LibraryApi.md#getitemcounts) | **GET** /Items/Counts | Get item counts.
[**GetLibraryOptionsInfo**](LibraryApi.md#getlibraryoptionsinfo) | **GET** /Libraries/AvailableOptions | Gets the library options info.
[**GetMediaFolders**](LibraryApi.md#getmediafolders) | **GET** /Library/MediaFolders | Gets all user media folders.
[**GetPhysicalPaths**](LibraryApi.md#getphysicalpaths) | **GET** /Library/PhysicalPaths | Gets a list of physical paths from virtual folders.
[**GetSimilarAlbums**](LibraryApi.md#getsimilaralbums) | **GET** /Albums/{itemId}/Similar | Gets similar items.
[**GetSimilarArtists**](LibraryApi.md#getsimilarartists) | **GET** /Artists/{itemId}/Similar | Gets similar items.
[**GetSimilarItems**](LibraryApi.md#getsimilaritems) | **GET** /Items/{itemId}/Similar | Gets similar items.
[**GetSimilarMovies**](LibraryApi.md#getsimilarmovies) | **GET** /Movies/{itemId}/Similar | Gets similar items.
[**GetSimilarShows**](LibraryApi.md#getsimilarshows) | **GET** /Shows/{itemId}/Similar | Gets similar items.
[**GetSimilarTrailers**](LibraryApi.md#getsimilartrailers) | **GET** /Trailers/{itemId}/Similar | Gets similar items.
[**GetThemeMedia**](LibraryApi.md#getthememedia) | **GET** /Items/{itemId}/ThemeMedia | Get theme songs and videos for an item.
[**GetThemeSongs**](LibraryApi.md#getthemesongs) | **GET** /Items/{itemId}/ThemeSongs | Get theme songs for an item.
[**GetThemeVideos**](LibraryApi.md#getthemevideos) | **GET** /Items/{itemId}/ThemeVideos | Get theme videos for an item.
[**PostAddedMovies**](LibraryApi.md#postaddedmovies) | **POST** /Library/Movies/Added | Reports that new movies have been added by an external source.
[**PostAddedSeries**](LibraryApi.md#postaddedseries) | **POST** /Library/Series/Added | Reports that new episodes of a series have been added by an external source.
[**PostUpdatedMedia**](LibraryApi.md#postupdatedmedia) | **POST** /Library/Media/Updated | Reports that new movies have been added by an external source.
[**PostUpdatedMovies**](LibraryApi.md#postupdatedmovies) | **POST** /Library/Movies/Updated | Reports that new movies have been added by an external source.
[**PostUpdatedSeries**](LibraryApi.md#postupdatedseries) | **POST** /Library/Series/Updated | Reports that new episodes of a series have been added by an external source.
[**RefreshLibrary**](LibraryApi.md#refreshlibrary) | **POST** /Library/Refresh | Starts a library scan.



## DeleteItem

> void DeleteItem (Guid itemId)

Deletes an item from the library and filesystem.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.

            try
            {
                // Deletes an item from the library and filesystem.
                apiInstance.DeleteItem(itemId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.DeleteItem: " + e.Message );
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
| **204** | Item deleted. |  -  |
| **401** | Unauthorized access. |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteItems

> void DeleteItems (List<Guid> ids = null)

Deletes items from the library and filesystem.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var ids = new List<Guid>(); // List<Guid> | The item ids. (optional) 

            try
            {
                // Deletes items from the library and filesystem.
                apiInstance.DeleteItems(ids);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.DeleteItems: " + e.Message );
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
 **ids** | [**List&lt;Guid&gt;**](Guid.md)| The item ids. | [optional] 

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
| **204** | Items deleted. |  -  |
| **401** | Unauthorized access. |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAncestors

> List&lt;BaseItemDto&gt; GetAncestors (Guid itemId, Guid? userId = null)

Gets all parents of an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetAncestorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 

            try
            {
                // Gets all parents of an item.
                List<BaseItemDto> result = apiInstance.GetAncestors(itemId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetAncestors: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 

### Return type

[**List&lt;BaseItemDto&gt;**](BaseItemDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item parents returned. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCriticReviews

> BaseItemDtoQueryResult GetCriticReviews (string itemId)

Gets critic review for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetCriticReviewsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = itemId_example;  // string | 

            try
            {
                // Gets critic review for an item.
                BaseItemDtoQueryResult result = apiInstance.GetCriticReviews(itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetCriticReviews: " + e.Message );
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
 **itemId** | **string**|  | 

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
| **200** | Critic reviews returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDownload

> System.IO.Stream GetDownload (Guid itemId)

Downloads item media.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetDownloadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.

            try
            {
                // Downloads item media.
                System.IO.Stream result = apiInstance.GetDownload(itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetDownload: " + e.Message );
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

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: video/_*, audio/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Media downloaded. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFile

> System.IO.Stream GetFile (Guid itemId)

Get the original file of an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.

            try
            {
                // Get the original file of an item.
                System.IO.Stream result = apiInstance.GetFile(itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetFile: " + e.Message );
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

### Return type

**System.IO.Stream**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: video/_*, audio/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File stream returned. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetItemCounts

> ItemCounts GetItemCounts (Guid? userId = null, bool? isFavorite = null)

Get item counts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetItemCountsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var userId = new Guid?(); // Guid? | Optional. Get counts from a specific user's library. (optional) 
            var isFavorite = true;  // bool? | Optional. Get counts of favorite items. (optional) 

            try
            {
                // Get item counts.
                ItemCounts result = apiInstance.GetItemCounts(userId, isFavorite);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetItemCounts: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Get counts from a specific user&#39;s library. | [optional] 
 **isFavorite** | **bool?**| Optional. Get counts of favorite items. | [optional] 

### Return type

[**ItemCounts**](ItemCounts.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item counts returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLibraryOptionsInfo

> LibraryOptionsResultDto GetLibraryOptionsInfo (string libraryContentType = null, bool? isNewLibrary = null)

Gets the library options info.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLibraryOptionsInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var libraryContentType = libraryContentType_example;  // string | Library content type. (optional) 
            var isNewLibrary = true;  // bool? | Whether this is a new library. (optional)  (default to false)

            try
            {
                // Gets the library options info.
                LibraryOptionsResultDto result = apiInstance.GetLibraryOptionsInfo(libraryContentType, isNewLibrary);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetLibraryOptionsInfo: " + e.Message );
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
 **libraryContentType** | **string**| Library content type. | [optional] 
 **isNewLibrary** | **bool?**| Whether this is a new library. | [optional] [default to false]

### Return type

[**LibraryOptionsResultDto**](LibraryOptionsResultDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Library options info returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMediaFolders

> BaseItemDtoQueryResult GetMediaFolders (bool? isHidden = null)

Gets all user media folders.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetMediaFoldersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var isHidden = true;  // bool? | Optional. Filter by folders that are marked hidden, or not. (optional) 

            try
            {
                // Gets all user media folders.
                BaseItemDtoQueryResult result = apiInstance.GetMediaFolders(isHidden);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetMediaFolders: " + e.Message );
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
 **isHidden** | **bool?**| Optional. Filter by folders that are marked hidden, or not. | [optional] 

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
| **200** | Media folders returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPhysicalPaths

> List&lt;string&gt; GetPhysicalPaths ()

Gets a list of physical paths from virtual folders.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPhysicalPathsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);

            try
            {
                // Gets a list of physical paths from virtual folders.
                List<string> result = apiInstance.GetPhysicalPaths();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetPhysicalPaths: " + e.Message );
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

**List<string>**

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Physical paths returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimilarAlbums

> BaseItemDtoQueryResult GetSimilarAlbums (Guid itemId, List<Guid> excludeArtistIds = null, Guid? userId = null, int? limit = null, List<ItemFields> fields = null)

Gets similar items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSimilarAlbumsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var excludeArtistIds = new List<Guid>(); // List<Guid> | Exclude artist ids. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. (optional) 

            try
            {
                // Gets similar items.
                BaseItemDtoQueryResult result = apiInstance.GetSimilarAlbums(itemId, excludeArtistIds, userId, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetSimilarAlbums: " + e.Message );
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
 **excludeArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Exclude artist ids. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. | [optional] 

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
| **200** | Similar items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimilarArtists

> BaseItemDtoQueryResult GetSimilarArtists (Guid itemId, List<Guid> excludeArtistIds = null, Guid? userId = null, int? limit = null, List<ItemFields> fields = null)

Gets similar items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSimilarArtistsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var excludeArtistIds = new List<Guid>(); // List<Guid> | Exclude artist ids. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. (optional) 

            try
            {
                // Gets similar items.
                BaseItemDtoQueryResult result = apiInstance.GetSimilarArtists(itemId, excludeArtistIds, userId, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetSimilarArtists: " + e.Message );
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
 **excludeArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Exclude artist ids. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. | [optional] 

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
| **200** | Similar items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimilarItems

> BaseItemDtoQueryResult GetSimilarItems (Guid itemId, List<Guid> excludeArtistIds = null, Guid? userId = null, int? limit = null, List<ItemFields> fields = null)

Gets similar items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSimilarItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var excludeArtistIds = new List<Guid>(); // List<Guid> | Exclude artist ids. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. (optional) 

            try
            {
                // Gets similar items.
                BaseItemDtoQueryResult result = apiInstance.GetSimilarItems(itemId, excludeArtistIds, userId, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetSimilarItems: " + e.Message );
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
 **excludeArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Exclude artist ids. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. | [optional] 

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
| **200** | Similar items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimilarMovies

> BaseItemDtoQueryResult GetSimilarMovies (Guid itemId, List<Guid> excludeArtistIds = null, Guid? userId = null, int? limit = null, List<ItemFields> fields = null)

Gets similar items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSimilarMoviesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var excludeArtistIds = new List<Guid>(); // List<Guid> | Exclude artist ids. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. (optional) 

            try
            {
                // Gets similar items.
                BaseItemDtoQueryResult result = apiInstance.GetSimilarMovies(itemId, excludeArtistIds, userId, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetSimilarMovies: " + e.Message );
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
 **excludeArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Exclude artist ids. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. | [optional] 

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
| **200** | Similar items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimilarShows

> BaseItemDtoQueryResult GetSimilarShows (Guid itemId, List<Guid> excludeArtistIds = null, Guid? userId = null, int? limit = null, List<ItemFields> fields = null)

Gets similar items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSimilarShowsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var excludeArtistIds = new List<Guid>(); // List<Guid> | Exclude artist ids. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. (optional) 

            try
            {
                // Gets similar items.
                BaseItemDtoQueryResult result = apiInstance.GetSimilarShows(itemId, excludeArtistIds, userId, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetSimilarShows: " + e.Message );
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
 **excludeArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Exclude artist ids. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. | [optional] 

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
| **200** | Similar items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSimilarTrailers

> BaseItemDtoQueryResult GetSimilarTrailers (Guid itemId, List<Guid> excludeArtistIds = null, Guid? userId = null, int? limit = null, List<ItemFields> fields = null)

Gets similar items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSimilarTrailersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var excludeArtistIds = new List<Guid>(); // List<Guid> | Exclude artist ids. (optional) 
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. (optional) 

            try
            {
                // Gets similar items.
                BaseItemDtoQueryResult result = apiInstance.GetSimilarTrailers(itemId, excludeArtistIds, userId, limit, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetSimilarTrailers: " + e.Message );
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
 **excludeArtistIds** | [**List&lt;Guid&gt;**](Guid.md)| Exclude artist ids. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls. | [optional] 

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
| **200** | Similar items returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetThemeMedia

> AllThemeMediaResult GetThemeMedia (Guid itemId, Guid? userId = null, bool? inheritFromParent = null)

Get theme songs and videos for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetThemeMediaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var inheritFromParent = true;  // bool? | Optional. Determines whether or not parent items should be searched for theme media. (optional)  (default to false)

            try
            {
                // Get theme songs and videos for an item.
                AllThemeMediaResult result = apiInstance.GetThemeMedia(itemId, userId, inheritFromParent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetThemeMedia: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **inheritFromParent** | **bool?**| Optional. Determines whether or not parent items should be searched for theme media. | [optional] [default to false]

### Return type

[**AllThemeMediaResult**](AllThemeMediaResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Theme songs and videos returned. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetThemeSongs

> ThemeMediaResult GetThemeSongs (Guid itemId, Guid? userId = null, bool? inheritFromParent = null)

Get theme songs for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetThemeSongsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var inheritFromParent = true;  // bool? | Optional. Determines whether or not parent items should be searched for theme media. (optional)  (default to false)

            try
            {
                // Get theme songs for an item.
                ThemeMediaResult result = apiInstance.GetThemeSongs(itemId, userId, inheritFromParent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetThemeSongs: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **inheritFromParent** | **bool?**| Optional. Determines whether or not parent items should be searched for theme media. | [optional] [default to false]

### Return type

[**ThemeMediaResult**](ThemeMediaResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Theme songs returned. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetThemeVideos

> ThemeMediaResult GetThemeVideos (Guid itemId, Guid? userId = null, bool? inheritFromParent = null)

Get theme videos for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetThemeVideosExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var itemId = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var inheritFromParent = true;  // bool? | Optional. Determines whether or not parent items should be searched for theme media. (optional)  (default to false)

            try
            {
                // Get theme videos for an item.
                ThemeMediaResult result = apiInstance.GetThemeVideos(itemId, userId, inheritFromParent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.GetThemeVideos: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **inheritFromParent** | **bool?**| Optional. Determines whether or not parent items should be searched for theme media. | [optional] [default to false]

### Return type

[**ThemeMediaResult**](ThemeMediaResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Theme videos returned. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostAddedMovies

> void PostAddedMovies (string tmdbId = null, string imdbId = null)

Reports that new movies have been added by an external source.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostAddedMoviesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var tmdbId = tmdbId_example;  // string | The tmdbId. (optional) 
            var imdbId = imdbId_example;  // string | The imdbId. (optional) 

            try
            {
                // Reports that new movies have been added by an external source.
                apiInstance.PostAddedMovies(tmdbId, imdbId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.PostAddedMovies: " + e.Message );
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
 **tmdbId** | **string**| The tmdbId. | [optional] 
 **imdbId** | **string**| The imdbId. | [optional] 

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
| **204** | Report success. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostAddedSeries

> void PostAddedSeries (string tvdbId = null)

Reports that new episodes of a series have been added by an external source.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostAddedSeriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var tvdbId = tvdbId_example;  // string | The tvdbId. (optional) 

            try
            {
                // Reports that new episodes of a series have been added by an external source.
                apiInstance.PostAddedSeries(tvdbId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.PostAddedSeries: " + e.Message );
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
 **tvdbId** | **string**| The tvdbId. | [optional] 

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
| **204** | Report success. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostUpdatedMedia

> void PostUpdatedMedia (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Reports that new movies have been added by an external source.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostUpdatedMediaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | The update paths.

            try
            {
                // Reports that new movies have been added by an external source.
                apiInstance.PostUpdatedMedia(UNKNOWN_BASE_TYPE);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.PostUpdatedMedia: " + e.Message );
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| The update paths. | 

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
| **204** | Report success. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostUpdatedMovies

> void PostUpdatedMovies (string tmdbId = null, string imdbId = null)

Reports that new movies have been added by an external source.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostUpdatedMoviesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var tmdbId = tmdbId_example;  // string | The tmdbId. (optional) 
            var imdbId = imdbId_example;  // string | The imdbId. (optional) 

            try
            {
                // Reports that new movies have been added by an external source.
                apiInstance.PostUpdatedMovies(tmdbId, imdbId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.PostUpdatedMovies: " + e.Message );
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
 **tmdbId** | **string**| The tmdbId. | [optional] 
 **imdbId** | **string**| The imdbId. | [optional] 

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
| **204** | Report success. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostUpdatedSeries

> void PostUpdatedSeries (string tvdbId = null)

Reports that new episodes of a series have been added by an external source.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostUpdatedSeriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);
            var tvdbId = tvdbId_example;  // string | The tvdbId. (optional) 

            try
            {
                // Reports that new episodes of a series have been added by an external source.
                apiInstance.PostUpdatedSeries(tvdbId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.PostUpdatedSeries: " + e.Message );
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
 **tvdbId** | **string**| The tvdbId. | [optional] 

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
| **204** | Report success. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RefreshLibrary

> void RefreshLibrary ()

Starts a library scan.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class RefreshLibraryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new LibraryApi(Configuration.Default);

            try
            {
                // Starts a library scan.
                apiInstance.RefreshLibrary();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LibraryApi.RefreshLibrary: " + e.Message );
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
| **204** | Library scan started. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

