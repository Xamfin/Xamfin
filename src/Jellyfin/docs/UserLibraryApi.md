# Jellyfin.Api.Api.UserLibraryApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUserItemRating**](UserLibraryApi.md#deleteuseritemrating) | **DELETE** /Users/{userId}/Items/{itemId}/Rating | Deletes a user&#39;s saved personal rating for an item.
[**GetIntros**](UserLibraryApi.md#getintros) | **GET** /Users/{userId}/Items/{itemId}/Intros | Gets intros to play before the main media item plays.
[**GetItem**](UserLibraryApi.md#getitem) | **GET** /Users/{userId}/Items/{itemId} | Gets an item from a user&#39;s library.
[**GetLatestMedia**](UserLibraryApi.md#getlatestmedia) | **GET** /Users/{userId}/Items/Latest | Gets latest media.
[**GetLocalTrailers**](UserLibraryApi.md#getlocaltrailers) | **GET** /Users/{userId}/Items/{itemId}/LocalTrailers | Gets local trailers for an item.
[**GetRootFolder**](UserLibraryApi.md#getrootfolder) | **GET** /Users/{userId}/Items/Root | Gets the root folder from a user&#39;s library.
[**GetSpecialFeatures**](UserLibraryApi.md#getspecialfeatures) | **GET** /Users/{userId}/Items/{itemId}/SpecialFeatures | Gets special features for an item.
[**MarkFavoriteItem**](UserLibraryApi.md#markfavoriteitem) | **POST** /Users/{userId}/FavoriteItems/{itemId} | Marks an item as a favorite.
[**UnmarkFavoriteItem**](UserLibraryApi.md#unmarkfavoriteitem) | **DELETE** /Users/{userId}/FavoriteItems/{itemId} | Unmarks item as a favorite.
[**UpdateUserItemRating**](UserLibraryApi.md#updateuseritemrating) | **POST** /Users/{userId}/Items/{itemId}/Rating | Updates a user&#39;s rating for an item.



## DeleteUserItemRating

> UserItemDataDto DeleteUserItemRating (Guid userId, Guid itemId)

Deletes a user's saved personal rating for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteUserItemRatingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Deletes a user's saved personal rating for an item.
                UserItemDataDto result = apiInstance.DeleteUserItemRating(userId, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.DeleteUserItemRating: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **itemId** | [**Guid**](Guid.md)| Item id. | 

### Return type

[**UserItemDataDto**](UserItemDataDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Personal rating removed. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetIntros

> BaseItemDtoQueryResult GetIntros (Guid userId, Guid itemId)

Gets intros to play before the main media item plays.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetIntrosExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Gets intros to play before the main media item plays.
                BaseItemDtoQueryResult result = apiInstance.GetIntros(userId, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.GetIntros: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **itemId** | [**Guid**](Guid.md)| Item id. | 

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
| **200** | Intros returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetItem

> BaseItemDto GetItem (Guid userId, Guid itemId)

Gets an item from a user's library.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Gets an item from a user's library.
                BaseItemDto result = apiInstance.GetItem(userId, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.GetItem: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **itemId** | [**Guid**](Guid.md)| Item id. | 

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
| **200** | Item returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLatestMedia

> List&lt;BaseItemDto&gt; GetLatestMedia (Guid userId, Guid? parentId = null, List<ItemFields> fields = null, List<string> includeItemTypes = null, bool? isPlayed = null, bool? enableImages = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, bool? enableUserData = null, int? limit = null, bool? groupItems = null)

Gets latest media.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLatestMediaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var parentId = new Guid?(); // Guid? | Specify this to localize the search to a specific item or folder. Omit to use the root. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var includeItemTypes = new List<string>(); // List<string> | Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. (optional) 
            var isPlayed = true;  // bool? | Filter by items that are played, or not. (optional) 
            var enableImages = true;  // bool? | Optional. include image information in output. (optional) 
            var imageTypeLimit = 56;  // int? | Optional. the max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var enableUserData = true;  // bool? | Optional. include user data. (optional) 
            var limit = 56;  // int? | Return item limit. (optional)  (default to 20)
            var groupItems = true;  // bool? | Whether or not to group items into a parent container. (optional)  (default to true)

            try
            {
                // Gets latest media.
                List<BaseItemDto> result = apiInstance.GetLatestMedia(userId, parentId, fields, includeItemTypes, isPlayed, enableImages, imageTypeLimit, enableImageTypes, enableUserData, limit, groupItems);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.GetLatestMedia: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **parentId** | [**Guid?**](Guid?.md)| Specify this to localize the search to a specific item or folder. Omit to use the root. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **includeItemTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited. | [optional] 
 **isPlayed** | **bool?**| Filter by items that are played, or not. | [optional] 
 **enableImages** | **bool?**| Optional. include image information in output. | [optional] 
 **imageTypeLimit** | **int?**| Optional. the max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **enableUserData** | **bool?**| Optional. include user data. | [optional] 
 **limit** | **int?**| Return item limit. | [optional] [default to 20]
 **groupItems** | **bool?**| Whether or not to group items into a parent container. | [optional] [default to true]

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
| **200** | Latest media returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLocalTrailers

> List&lt;BaseItemDto&gt; GetLocalTrailers (Guid userId, Guid itemId)

Gets local trailers for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLocalTrailersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Gets local trailers for an item.
                List<BaseItemDto> result = apiInstance.GetLocalTrailers(userId, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.GetLocalTrailers: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **itemId** | [**Guid**](Guid.md)| Item id. | 

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
| **200** | An Microsoft.AspNetCore.Mvc.OkResult containing the item&#39;s local trailers. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRootFolder

> BaseItemDto GetRootFolder (Guid userId)

Gets the root folder from a user's library.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetRootFolderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.

            try
            {
                // Gets the root folder from a user's library.
                BaseItemDto result = apiInstance.GetRootFolder(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.GetRootFolder: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 

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
| **200** | Root folder returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSpecialFeatures

> List&lt;BaseItemDto&gt; GetSpecialFeatures (Guid userId, Guid itemId)

Gets special features for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetSpecialFeaturesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Gets special features for an item.
                List<BaseItemDto> result = apiInstance.GetSpecialFeatures(userId, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.GetSpecialFeatures: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **itemId** | [**Guid**](Guid.md)| Item id. | 

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
| **200** | Special features returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MarkFavoriteItem

> UserItemDataDto MarkFavoriteItem (Guid userId, Guid itemId)

Marks an item as a favorite.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class MarkFavoriteItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Marks an item as a favorite.
                UserItemDataDto result = apiInstance.MarkFavoriteItem(userId, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.MarkFavoriteItem: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **itemId** | [**Guid**](Guid.md)| Item id. | 

### Return type

[**UserItemDataDto**](UserItemDataDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item marked as favorite. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnmarkFavoriteItem

> UserItemDataDto UnmarkFavoriteItem (Guid userId, Guid itemId)

Unmarks item as a favorite.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UnmarkFavoriteItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Unmarks item as a favorite.
                UserItemDataDto result = apiInstance.UnmarkFavoriteItem(userId, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.UnmarkFavoriteItem: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **itemId** | [**Guid**](Guid.md)| Item id. | 

### Return type

[**UserItemDataDto**](UserItemDataDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item unmarked as favorite. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateUserItemRating

> UserItemDataDto UpdateUserItemRating (Guid userId, Guid itemId, bool? likes = null)

Updates a user's rating for an item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdateUserItemRatingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new UserLibraryApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var itemId = new Guid(); // Guid | Item id.
            var likes = true;  // bool? | Whether this M:Jellyfin.Api.Controllers.UserLibraryController.UpdateUserItemRating(System.Guid,System.Guid,System.Nullable{System.Boolean}) is likes. (optional) 

            try
            {
                // Updates a user's rating for an item.
                UserItemDataDto result = apiInstance.UpdateUserItemRating(userId, itemId, likes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserLibraryApi.UpdateUserItemRating: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User id. | 
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **likes** | **bool?**| Whether this M:Jellyfin.Api.Controllers.UserLibraryController.UpdateUserItemRating(System.Guid,System.Guid,System.Nullable{System.Boolean}) is likes. | [optional] 

### Return type

[**UserItemDataDto**](UserItemDataDto.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item rating updated. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

