# Jellyfin.Api.Api.InstantMixApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInstantMixFromAlbum**](InstantMixApi.md#getinstantmixfromalbum) | **GET** /Albums/{id}/InstantMix | Creates an instant playlist based on a given album.
[**GetInstantMixFromArtists**](InstantMixApi.md#getinstantmixfromartists) | **GET** /Artists/{id}/InstantMix | Creates an instant playlist based on a given artist.
[**GetInstantMixFromArtists2**](InstantMixApi.md#getinstantmixfromartists2) | **GET** /Artists/InstantMix | Creates an instant playlist based on a given artist.
[**GetInstantMixFromItem**](InstantMixApi.md#getinstantmixfromitem) | **GET** /Items/{id}/InstantMix | Creates an instant playlist based on a given item.
[**GetInstantMixFromMusicGenreById**](InstantMixApi.md#getinstantmixfrommusicgenrebyid) | **GET** /MusicGenres/{id}/InstantMix | Creates an instant playlist based on a given genre.
[**GetInstantMixFromMusicGenreById2**](InstantMixApi.md#getinstantmixfrommusicgenrebyid2) | **GET** /MusicGenres/InstantMix | Creates an instant playlist based on a given genre.
[**GetInstantMixFromMusicGenreByName**](InstantMixApi.md#getinstantmixfrommusicgenrebyname) | **GET** /MusicGenres/{name}/InstantMix | Creates an instant playlist based on a given genre.
[**GetInstantMixFromPlaylist**](InstantMixApi.md#getinstantmixfromplaylist) | **GET** /Playlists/{id}/InstantMix | Creates an instant playlist based on a given playlist.
[**GetInstantMixFromSong**](InstantMixApi.md#getinstantmixfromsong) | **GET** /Songs/{id}/InstantMix | Creates an instant playlist based on a given song.



## GetInstantMixFromAlbum

> BaseItemDtoQueryResult GetInstantMixFromAlbum (Guid id, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given album.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromAlbumExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var id = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given album.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromAlbum(id, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromAlbum: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstantMixFromArtists

> BaseItemDtoQueryResult GetInstantMixFromArtists (Guid id, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given artist.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromArtistsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var id = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given artist.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromArtists(id, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromArtists: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstantMixFromArtists2

> BaseItemDtoQueryResult GetInstantMixFromArtists2 (Guid id, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given artist.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromArtists2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var id = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given artist.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromArtists2(id, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromArtists2: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstantMixFromItem

> BaseItemDtoQueryResult GetInstantMixFromItem (Guid id, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var id = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given item.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromItem(id, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromItem: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstantMixFromMusicGenreById

> BaseItemDtoQueryResult GetInstantMixFromMusicGenreById (Guid id, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given genre.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromMusicGenreByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var id = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given genre.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromMusicGenreById(id, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromMusicGenreById: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstantMixFromMusicGenreById2

> BaseItemDtoQueryResult GetInstantMixFromMusicGenreById2 (Guid id, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given genre.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromMusicGenreById2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var id = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given genre.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromMusicGenreById2(id, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromMusicGenreById2: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstantMixFromMusicGenreByName

> BaseItemDtoQueryResult GetInstantMixFromMusicGenreByName (string name, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given genre.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromMusicGenreByNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var name = name_example;  // string | The genre name.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given genre.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromMusicGenreByName(name, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromMusicGenreByName: " + e.Message );
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
 **name** | **string**| The genre name. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstantMixFromPlaylist

> BaseItemDtoQueryResult GetInstantMixFromPlaylist (Guid id, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given playlist.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromPlaylistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var id = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given playlist.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromPlaylist(id, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromPlaylist: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstantMixFromSong

> BaseItemDtoQueryResult GetInstantMixFromSong (Guid id, Guid? userId = null, int? limit = null, List<ItemFields> fields = null, bool? enableImages = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null)

Creates an instant playlist based on a given song.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetInstantMixFromSongExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new InstantMixApi(Configuration.Default);
            var id = new Guid(); // Guid | The item id.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var enableImages = true;  // bool? | Optional. Include image information in output. (optional) 
            var enableUserData = true;  // bool? | Optional. Include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. The max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 

            try
            {
                // Creates an instant playlist based on a given song.
                BaseItemDtoQueryResult result = apiInstance.GetInstantMixFromSong(id, userId, limit, fields, enableImages, enableUserData, imageTypeLimit, enableImageTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstantMixApi.GetInstantMixFromSong: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| The item id. | 
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **enableImages** | **bool?**| Optional. Include image information in output. | [optional] 
 **enableUserData** | **bool?**| Optional. Include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional. The max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 

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
| **200** | Instant playlist returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

