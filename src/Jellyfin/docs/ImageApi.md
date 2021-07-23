# Jellyfin.Api.Api.ImageApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteItemImage**](ImageApi.md#deleteitemimage) | **DELETE** /Items/{itemId}/Images/{imageType} | Delete an item&#39;s image.
[**DeleteItemImageByIndex**](ImageApi.md#deleteitemimagebyindex) | **DELETE** /Items/{itemId}/Images/{imageType}/{imageIndex} | Delete an item&#39;s image.
[**DeleteUserImage**](ImageApi.md#deleteuserimage) | **DELETE** /Users/{userId}/Images/{imageType} | Delete the user&#39;s image.
[**DeleteUserImageByIndex**](ImageApi.md#deleteuserimagebyindex) | **DELETE** /Users/{userId}/Images/{imageType}/{index} | Delete the user&#39;s image.
[**GetArtistImage**](ImageApi.md#getartistimage) | **GET** /Artists/{name}/Images/{imageType}/{imageIndex} | Get artist image by name.
[**GetGenreImage**](ImageApi.md#getgenreimage) | **GET** /Genres/{name}/Images/{imageType} | Get genre image by name.
[**GetGenreImageByIndex**](ImageApi.md#getgenreimagebyindex) | **GET** /Genres/{name}/Images/{imageType}/{imageIndex} | Get genre image by name.
[**GetItemImage**](ImageApi.md#getitemimage) | **GET** /Items/{itemId}/Images/{imageType} | Gets the item&#39;s image.
[**GetItemImage2**](ImageApi.md#getitemimage2) | **GET** /Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}/{format}/{maxWidth}/{maxHeight}/{percentPlayed}/{unplayedCount} | Gets the item&#39;s image.
[**GetItemImageByIndex**](ImageApi.md#getitemimagebyindex) | **GET** /Items/{itemId}/Images/{imageType}/{imageIndex} | Gets the item&#39;s image.
[**GetItemImageInfos**](ImageApi.md#getitemimageinfos) | **GET** /Items/{itemId}/Images | Get item image infos.
[**GetMusicGenreImage**](ImageApi.md#getmusicgenreimage) | **GET** /MusicGenres/{name}/Images/{imageType} | Get music genre image by name.
[**GetMusicGenreImageByIndex**](ImageApi.md#getmusicgenreimagebyindex) | **GET** /MusicGenres/{name}/Images/{imageType}/{imageIndex} | Get music genre image by name.
[**GetPersonImage**](ImageApi.md#getpersonimage) | **GET** /Persons/{name}/Images/{imageType} | Get person image by name.
[**GetPersonImageByIndex**](ImageApi.md#getpersonimagebyindex) | **GET** /Persons/{name}/Images/{imageType}/{imageIndex} | Get person image by name.
[**GetStudioImage**](ImageApi.md#getstudioimage) | **GET** /Studios/{name}/Images/{imageType} | Get studio image by name.
[**GetStudioImageByIndex**](ImageApi.md#getstudioimagebyindex) | **GET** /Studios/{name}/Images/{imageType}/{imageIndex} | Get studio image by name.
[**GetUserImage**](ImageApi.md#getuserimage) | **GET** /Users/{userId}/Images/{imageType} | Get user profile image.
[**GetUserImageByIndex**](ImageApi.md#getuserimagebyindex) | **GET** /Users/{userId}/Images/{imageType}/{imageIndex} | Get user profile image.
[**HeadArtistImage**](ImageApi.md#headartistimage) | **HEAD** /Artists/{name}/Images/{imageType}/{imageIndex} | Get artist image by name.
[**HeadGenreImage**](ImageApi.md#headgenreimage) | **HEAD** /Genres/{name}/Images/{imageType} | Get genre image by name.
[**HeadGenreImageByIndex**](ImageApi.md#headgenreimagebyindex) | **HEAD** /Genres/{name}/Images/{imageType}/{imageIndex} | Get genre image by name.
[**HeadItemImage**](ImageApi.md#headitemimage) | **HEAD** /Items/{itemId}/Images/{imageType} | Gets the item&#39;s image.
[**HeadItemImage2**](ImageApi.md#headitemimage2) | **HEAD** /Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}/{format}/{maxWidth}/{maxHeight}/{percentPlayed}/{unplayedCount} | Gets the item&#39;s image.
[**HeadItemImageByIndex**](ImageApi.md#headitemimagebyindex) | **HEAD** /Items/{itemId}/Images/{imageType}/{imageIndex} | Gets the item&#39;s image.
[**HeadMusicGenreImage**](ImageApi.md#headmusicgenreimage) | **HEAD** /MusicGenres/{name}/Images/{imageType} | Get music genre image by name.
[**HeadMusicGenreImageByIndex**](ImageApi.md#headmusicgenreimagebyindex) | **HEAD** /MusicGenres/{name}/Images/{imageType}/{imageIndex} | Get music genre image by name.
[**HeadPersonImage**](ImageApi.md#headpersonimage) | **HEAD** /Persons/{name}/Images/{imageType} | Get person image by name.
[**HeadPersonImageByIndex**](ImageApi.md#headpersonimagebyindex) | **HEAD** /Persons/{name}/Images/{imageType}/{imageIndex} | Get person image by name.
[**HeadStudioImage**](ImageApi.md#headstudioimage) | **HEAD** /Studios/{name}/Images/{imageType} | Get studio image by name.
[**HeadStudioImageByIndex**](ImageApi.md#headstudioimagebyindex) | **HEAD** /Studios/{name}/Images/{imageType}/{imageIndex} | Get studio image by name.
[**HeadUserImage**](ImageApi.md#headuserimage) | **HEAD** /Users/{userId}/Images/{imageType} | Get user profile image.
[**HeadUserImageByIndex**](ImageApi.md#headuserimagebyindex) | **HEAD** /Users/{userId}/Images/{imageType}/{imageIndex} | Get user profile image.
[**PostUserImage**](ImageApi.md#postuserimage) | **POST** /Users/{userId}/Images/{imageType} | Sets the user image.
[**PostUserImageByIndex**](ImageApi.md#postuserimagebyindex) | **POST** /Users/{userId}/Images/{imageType}/{index} | Sets the user image.
[**SetItemImage**](ImageApi.md#setitemimage) | **POST** /Items/{itemId}/Images/{imageType} | Set item image.
[**SetItemImageByIndex**](ImageApi.md#setitemimagebyindex) | **POST** /Items/{itemId}/Images/{imageType}/{imageIndex} | Set item image.
[**UpdateItemImageIndex**](ImageApi.md#updateitemimageindex) | **POST** /Items/{itemId}/Images/{imageType}/{imageIndex}/Index | Updates the index for an item image.



## DeleteItemImage

> void DeleteItemImage (Guid itemId, ImageType imageType, int? imageIndex = null)

Delete an item's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteItemImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int? | The image index. (optional) 

            try
            {
                // Delete an item's image.
                apiInstance.DeleteItemImage(itemId, imageType, imageIndex);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.DeleteItemImage: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int?**| The image index. | [optional] 

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
| **204** | Image deleted. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteItemImageByIndex

> void DeleteItemImageByIndex (Guid itemId, ImageType imageType, int imageIndex)

Delete an item's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteItemImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | The image index.

            try
            {
                // Delete an item's image.
                apiInstance.DeleteItemImageByIndex(itemId, imageType, imageIndex);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.DeleteItemImageByIndex: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| The image index. | 

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
| **204** | Image deleted. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteUserImage

> void DeleteUserImage (Guid userId, ImageType imageType, int? index = null)

Delete the user's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteUserImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var userId = new Guid(); // Guid | User Id.
            var imageType = ;  // ImageType | (Unused) Image type.
            var index = 56;  // int? | (Unused) Image index. (optional) 

            try
            {
                // Delete the user's image.
                apiInstance.DeleteUserImage(userId, imageType, index);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.DeleteUserImage: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User Id. | 
 **imageType** | **ImageType**| (Unused) Image type. | 
 **index** | **int?**| (Unused) Image index. | [optional] 

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
| **204** | Image deleted. |  -  |
| **403** | User does not have permission to delete the image. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteUserImageByIndex

> void DeleteUserImageByIndex (Guid userId, ImageType imageType, int index)

Delete the user's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class DeleteUserImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var userId = new Guid(); // Guid | User Id.
            var imageType = ;  // ImageType | (Unused) Image type.
            var index = 56;  // int | (Unused) Image index.

            try
            {
                // Delete the user's image.
                apiInstance.DeleteUserImageByIndex(userId, imageType, index);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.DeleteUserImageByIndex: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User Id. | 
 **imageType** | **ImageType**| (Unused) Image type. | 
 **index** | **int**| (Unused) Image index. | 

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
| **204** | Image deleted. |  -  |
| **403** | User does not have permission to delete the image. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArtistImage

> System.IO.Stream GetArtistImage (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get artist image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetArtistImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Artist name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get artist image by name.
                System.IO.Stream result = apiInstance.GetArtistImage(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetArtistImage: " + e.Message );
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
 **name** | **string**| Artist name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetGenreImage

> System.IO.Stream GetGenreImage (string name, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get genre image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetGenreImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Genre name.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get genre image by name.
                System.IO.Stream result = apiInstance.GetGenreImage(name, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetGenreImage: " + e.Message );
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
 **name** | **string**| Genre name. | 
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetGenreImageByIndex

> System.IO.Stream GetGenreImageByIndex (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get genre image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetGenreImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Genre name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get genre image by name.
                System.IO.Stream result = apiInstance.GetGenreImageByIndex(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetGenreImageByIndex: " + e.Message );
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
 **name** | **string**| Genre name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetItemImage

> System.IO.Stream GetItemImage (Guid itemId, ImageType imageType, int? maxWidth = null, int? maxHeight = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, string tag = null, bool? cropWhitespace = null, ImageFormat? format = null, bool? addPlayedIndicator = null, double? percentPlayed = null, int? unplayedCount = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Gets the item's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetItemImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var format = ;  // ImageFormat? | Optional. The MediaBrowser.Model.Drawing.ImageFormat of the returned image. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Gets the item's image.
                System.IO.Stream result = apiInstance.GetItemImage(itemId, imageType, maxWidth, maxHeight, width, height, quality, fillWidth, fillHeight, tag, cropWhitespace, format, addPlayedIndicator, percentPlayed, unplayedCount, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetItemImage: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **format** | **ImageFormat?**| Optional. The MediaBrowser.Model.Drawing.ImageFormat of the returned image. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetItemImage2

> System.IO.Stream GetItemImage2 (Guid itemId, ImageType imageType, int maxWidth, int maxHeight, string tag, ImageFormat format, double percentPlayed, int unplayedCount, int imageIndex, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Gets the item's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetItemImage2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var maxWidth = 56;  // int | The maximum image width to return.
            var maxHeight = 56;  // int | The maximum image height to return.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers.
            var format = ;  // ImageFormat | Determines the output format of the image - original,gif,jpg,png.
            var percentPlayed = 1.2D;  // double | Optional. Percent to render for the percent played overlay.
            var unplayedCount = 56;  // int | Optional. Unplayed count overlay to render.
            var imageIndex = 56;  // int | Image index.
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Gets the item's image.
                System.IO.Stream result = apiInstance.GetItemImage2(itemId, imageType, maxWidth, maxHeight, tag, format, percentPlayed, unplayedCount, imageIndex, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetItemImage2: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **maxWidth** | **int**| The maximum image width to return. | 
 **maxHeight** | **int**| The maximum image height to return. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | 
 **format** | **ImageFormat**| Determines the output format of the image - original,gif,jpg,png. | 
 **percentPlayed** | **double**| Optional. Percent to render for the percent played overlay. | 
 **unplayedCount** | **int**| Optional. Unplayed count overlay to render. | 
 **imageIndex** | **int**| Image index. | 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetItemImageByIndex

> System.IO.Stream GetItemImageByIndex (Guid itemId, ImageType imageType, int imageIndex, int? maxWidth = null, int? maxHeight = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, string tag = null, bool? cropWhitespace = null, ImageFormat? format = null, bool? addPlayedIndicator = null, double? percentPlayed = null, int? unplayedCount = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Gets the item's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetItemImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var format = ;  // ImageFormat? | Optional. The MediaBrowser.Model.Drawing.ImageFormat of the returned image. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Gets the item's image.
                System.IO.Stream result = apiInstance.GetItemImageByIndex(itemId, imageType, imageIndex, maxWidth, maxHeight, width, height, quality, fillWidth, fillHeight, tag, cropWhitespace, format, addPlayedIndicator, percentPlayed, unplayedCount, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetItemImageByIndex: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **format** | **ImageFormat?**| Optional. The MediaBrowser.Model.Drawing.ImageFormat of the returned image. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetItemImageInfos

> List&lt;ImageInfo&gt; GetItemImageInfos (Guid itemId)

Get item image infos.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetItemImageInfosExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.

            try
            {
                // Get item image infos.
                List<ImageInfo> result = apiInstance.GetItemImageInfos(itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetItemImageInfos: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 

### Return type

[**List&lt;ImageInfo&gt;**](ImageInfo.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item images returned. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMusicGenreImage

> System.IO.Stream GetMusicGenreImage (string name, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get music genre image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetMusicGenreImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Music genre name.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get music genre image by name.
                System.IO.Stream result = apiInstance.GetMusicGenreImage(name, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetMusicGenreImage: " + e.Message );
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
 **name** | **string**| Music genre name. | 
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMusicGenreImageByIndex

> System.IO.Stream GetMusicGenreImageByIndex (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get music genre image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetMusicGenreImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Music genre name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get music genre image by name.
                System.IO.Stream result = apiInstance.GetMusicGenreImageByIndex(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetMusicGenreImageByIndex: " + e.Message );
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
 **name** | **string**| Music genre name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPersonImage

> System.IO.Stream GetPersonImage (string name, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get person image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPersonImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Person name.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get person image by name.
                System.IO.Stream result = apiInstance.GetPersonImage(name, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetPersonImage: " + e.Message );
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
 **name** | **string**| Person name. | 
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPersonImageByIndex

> System.IO.Stream GetPersonImageByIndex (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get person image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPersonImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Person name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get person image by name.
                System.IO.Stream result = apiInstance.GetPersonImageByIndex(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetPersonImageByIndex: " + e.Message );
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
 **name** | **string**| Person name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetStudioImage

> System.IO.Stream GetStudioImage (string name, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get studio image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetStudioImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Studio name.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get studio image by name.
                System.IO.Stream result = apiInstance.GetStudioImage(name, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetStudioImage: " + e.Message );
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
 **name** | **string**| Studio name. | 
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetStudioImageByIndex

> System.IO.Stream GetStudioImageByIndex (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get studio image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetStudioImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Studio name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get studio image by name.
                System.IO.Stream result = apiInstance.GetStudioImageByIndex(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetStudioImageByIndex: " + e.Message );
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
 **name** | **string**| Studio name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUserImage

> System.IO.Stream GetUserImage (Guid userId, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get user profile image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetUserImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get user profile image.
                System.IO.Stream result = apiInstance.GetUserImage(userId, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetUserImage: " + e.Message );
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
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUserImageByIndex

> System.IO.Stream GetUserImageByIndex (Guid userId, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get user profile image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetUserImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get user profile image.
                System.IO.Stream result = apiInstance.GetUserImageByIndex(userId, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetUserImageByIndex: " + e.Message );
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
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadArtistImage

> System.IO.Stream HeadArtistImage (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get artist image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadArtistImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Artist name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get artist image by name.
                System.IO.Stream result = apiInstance.HeadArtistImage(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadArtistImage: " + e.Message );
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
 **name** | **string**| Artist name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadGenreImage

> System.IO.Stream HeadGenreImage (string name, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get genre image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadGenreImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Genre name.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get genre image by name.
                System.IO.Stream result = apiInstance.HeadGenreImage(name, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadGenreImage: " + e.Message );
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
 **name** | **string**| Genre name. | 
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadGenreImageByIndex

> System.IO.Stream HeadGenreImageByIndex (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get genre image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadGenreImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Genre name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get genre image by name.
                System.IO.Stream result = apiInstance.HeadGenreImageByIndex(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadGenreImageByIndex: " + e.Message );
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
 **name** | **string**| Genre name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadItemImage

> System.IO.Stream HeadItemImage (Guid itemId, ImageType imageType, int? maxWidth = null, int? maxHeight = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, string tag = null, bool? cropWhitespace = null, ImageFormat? format = null, bool? addPlayedIndicator = null, double? percentPlayed = null, int? unplayedCount = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Gets the item's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadItemImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var format = ;  // ImageFormat? | Optional. The MediaBrowser.Model.Drawing.ImageFormat of the returned image. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Gets the item's image.
                System.IO.Stream result = apiInstance.HeadItemImage(itemId, imageType, maxWidth, maxHeight, width, height, quality, fillWidth, fillHeight, tag, cropWhitespace, format, addPlayedIndicator, percentPlayed, unplayedCount, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadItemImage: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **format** | **ImageFormat?**| Optional. The MediaBrowser.Model.Drawing.ImageFormat of the returned image. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadItemImage2

> System.IO.Stream HeadItemImage2 (Guid itemId, ImageType imageType, int maxWidth, int maxHeight, string tag, ImageFormat format, double percentPlayed, int unplayedCount, int imageIndex, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Gets the item's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadItemImage2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var maxWidth = 56;  // int | The maximum image width to return.
            var maxHeight = 56;  // int | The maximum image height to return.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers.
            var format = ;  // ImageFormat | Determines the output format of the image - original,gif,jpg,png.
            var percentPlayed = 1.2D;  // double | Optional. Percent to render for the percent played overlay.
            var unplayedCount = 56;  // int | Optional. Unplayed count overlay to render.
            var imageIndex = 56;  // int | Image index.
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Gets the item's image.
                System.IO.Stream result = apiInstance.HeadItemImage2(itemId, imageType, maxWidth, maxHeight, tag, format, percentPlayed, unplayedCount, imageIndex, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadItemImage2: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **maxWidth** | **int**| The maximum image width to return. | 
 **maxHeight** | **int**| The maximum image height to return. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | 
 **format** | **ImageFormat**| Determines the output format of the image - original,gif,jpg,png. | 
 **percentPlayed** | **double**| Optional. Percent to render for the percent played overlay. | 
 **unplayedCount** | **int**| Optional. Unplayed count overlay to render. | 
 **imageIndex** | **int**| Image index. | 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadItemImageByIndex

> System.IO.Stream HeadItemImageByIndex (Guid itemId, ImageType imageType, int imageIndex, int? maxWidth = null, int? maxHeight = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, string tag = null, bool? cropWhitespace = null, ImageFormat? format = null, bool? addPlayedIndicator = null, double? percentPlayed = null, int? unplayedCount = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Gets the item's image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadItemImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var format = ;  // ImageFormat? | Optional. The MediaBrowser.Model.Drawing.ImageFormat of the returned image. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Gets the item's image.
                System.IO.Stream result = apiInstance.HeadItemImageByIndex(itemId, imageType, imageIndex, maxWidth, maxHeight, width, height, quality, fillWidth, fillHeight, tag, cropWhitespace, format, addPlayedIndicator, percentPlayed, unplayedCount, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadItemImageByIndex: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **format** | **ImageFormat?**| Optional. The MediaBrowser.Model.Drawing.ImageFormat of the returned image. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadMusicGenreImage

> System.IO.Stream HeadMusicGenreImage (string name, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get music genre image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadMusicGenreImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Music genre name.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get music genre image by name.
                System.IO.Stream result = apiInstance.HeadMusicGenreImage(name, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadMusicGenreImage: " + e.Message );
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
 **name** | **string**| Music genre name. | 
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadMusicGenreImageByIndex

> System.IO.Stream HeadMusicGenreImageByIndex (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get music genre image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadMusicGenreImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Music genre name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get music genre image by name.
                System.IO.Stream result = apiInstance.HeadMusicGenreImageByIndex(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadMusicGenreImageByIndex: " + e.Message );
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
 **name** | **string**| Music genre name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadPersonImage

> System.IO.Stream HeadPersonImage (string name, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get person image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadPersonImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Person name.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get person image by name.
                System.IO.Stream result = apiInstance.HeadPersonImage(name, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadPersonImage: " + e.Message );
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
 **name** | **string**| Person name. | 
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadPersonImageByIndex

> System.IO.Stream HeadPersonImageByIndex (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get person image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadPersonImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Person name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get person image by name.
                System.IO.Stream result = apiInstance.HeadPersonImageByIndex(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadPersonImageByIndex: " + e.Message );
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
 **name** | **string**| Person name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadStudioImage

> System.IO.Stream HeadStudioImage (string name, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get studio image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadStudioImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Studio name.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get studio image by name.
                System.IO.Stream result = apiInstance.HeadStudioImage(name, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadStudioImage: " + e.Message );
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
 **name** | **string**| Studio name. | 
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadStudioImageByIndex

> System.IO.Stream HeadStudioImageByIndex (string name, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get studio image by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadStudioImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var name = name_example;  // string | Studio name.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get studio image by name.
                System.IO.Stream result = apiInstance.HeadStudioImageByIndex(name, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadStudioImageByIndex: " + e.Message );
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
 **name** | **string**| Studio name. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadUserImage

> System.IO.Stream HeadUserImage (Guid userId, ImageType imageType, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null, int? imageIndex = null)

Get user profile image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadUserImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var imageType = ;  // ImageType | Image type.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 
            var imageIndex = 56;  // int? | Image index. (optional) 

            try
            {
                // Get user profile image.
                System.IO.Stream result = apiInstance.HeadUserImage(userId, imageType, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer, imageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadUserImage: " + e.Message );
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
 **imageType** | **ImageType**| Image type. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 
 **imageIndex** | **int?**| Image index. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HeadUserImageByIndex

> System.IO.Stream HeadUserImageByIndex (Guid userId, ImageType imageType, int imageIndex, string tag = null, ImageFormat? format = null, int? maxWidth = null, int? maxHeight = null, double? percentPlayed = null, int? unplayedCount = null, int? width = null, int? height = null, int? quality = null, int? fillWidth = null, int? fillHeight = null, bool? cropWhitespace = null, bool? addPlayedIndicator = null, int? blur = null, string backgroundColor = null, string foregroundLayer = null)

Get user profile image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class HeadUserImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImageApi(Configuration.Default);
            var userId = new Guid(); // Guid | User id.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Image index.
            var tag = tag_example;  // string | Optional. Supply the cache tag from the item object to receive strong caching headers. (optional) 
            var format = ;  // ImageFormat? | Determines the output format of the image - original,gif,jpg,png. (optional) 
            var maxWidth = 56;  // int? | The maximum image width to return. (optional) 
            var maxHeight = 56;  // int? | The maximum image height to return. (optional) 
            var percentPlayed = 1.2D;  // double? | Optional. Percent to render for the percent played overlay. (optional) 
            var unplayedCount = 56;  // int? | Optional. Unplayed count overlay to render. (optional) 
            var width = 56;  // int? | The fixed image width to return. (optional) 
            var height = 56;  // int? | The fixed image height to return. (optional) 
            var quality = 56;  // int? | Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. (optional) 
            var fillWidth = 56;  // int? | Width of box to fill. (optional) 
            var fillHeight = 56;  // int? | Height of box to fill. (optional) 
            var cropWhitespace = true;  // bool? | Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. (optional) 
            var addPlayedIndicator = true;  // bool? | Optional. Add a played indicator. (optional) 
            var blur = 56;  // int? | Optional. Blur image. (optional) 
            var backgroundColor = backgroundColor_example;  // string | Optional. Apply a background color for transparent images. (optional) 
            var foregroundLayer = foregroundLayer_example;  // string | Optional. Apply a foreground layer on top of the image. (optional) 

            try
            {
                // Get user profile image.
                System.IO.Stream result = apiInstance.HeadUserImageByIndex(userId, imageType, imageIndex, tag, format, maxWidth, maxHeight, percentPlayed, unplayedCount, width, height, quality, fillWidth, fillHeight, cropWhitespace, addPlayedIndicator, blur, backgroundColor, foregroundLayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.HeadUserImageByIndex: " + e.Message );
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
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Image index. | 
 **tag** | **string**| Optional. Supply the cache tag from the item object to receive strong caching headers. | [optional] 
 **format** | **ImageFormat?**| Determines the output format of the image - original,gif,jpg,png. | [optional] 
 **maxWidth** | **int?**| The maximum image width to return. | [optional] 
 **maxHeight** | **int?**| The maximum image height to return. | [optional] 
 **percentPlayed** | **double?**| Optional. Percent to render for the percent played overlay. | [optional] 
 **unplayedCount** | **int?**| Optional. Unplayed count overlay to render. | [optional] 
 **width** | **int?**| The fixed image width to return. | [optional] 
 **height** | **int?**| The fixed image height to return. | [optional] 
 **quality** | **int?**| Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases. | [optional] 
 **fillWidth** | **int?**| Width of box to fill. | [optional] 
 **fillHeight** | **int?**| Height of box to fill. | [optional] 
 **cropWhitespace** | **bool?**| Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art. | [optional] 
 **addPlayedIndicator** | **bool?**| Optional. Add a played indicator. | [optional] 
 **blur** | **int?**| Optional. Blur image. | [optional] 
 **backgroundColor** | **string**| Optional. Apply a background color for transparent images. | [optional] 
 **foregroundLayer** | **string**| Optional. Apply a foreground layer on top of the image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/_*, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image stream returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostUserImage

> void PostUserImage (Guid userId, ImageType imageType, int? index = null, System.IO.Stream body = null)

Sets the user image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostUserImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var userId = new Guid(); // Guid | User Id.
            var imageType = ;  // ImageType | (Unused) Image type.
            var index = 56;  // int? | (Unused) Image index. (optional) 
            var body = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Sets the user image.
                apiInstance.PostUserImage(userId, imageType, index, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.PostUserImage: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User Id. | 
 **imageType** | **ImageType**| (Unused) Image type. | 
 **index** | **int?**| (Unused) Image index. | [optional] 
 **body** | **System.IO.Stream**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: image/_*
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Image updated. |  -  |
| **403** | User does not have permission to delete the image. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostUserImageByIndex

> void PostUserImageByIndex (Guid userId, ImageType imageType, int index, System.IO.Stream body = null)

Sets the user image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class PostUserImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var userId = new Guid(); // Guid | User Id.
            var imageType = ;  // ImageType | (Unused) Image type.
            var index = 56;  // int | (Unused) Image index.
            var body = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Sets the user image.
                apiInstance.PostUserImageByIndex(userId, imageType, index, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.PostUserImageByIndex: " + e.Message );
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
 **userId** | [**Guid**](Guid.md)| User Id. | 
 **imageType** | **ImageType**| (Unused) Image type. | 
 **index** | **int**| (Unused) Image index. | 
 **body** | **System.IO.Stream**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: image/_*
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Image updated. |  -  |
| **403** | User does not have permission to delete the image. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetItemImage

> void SetItemImage (Guid itemId, ImageType imageType, System.IO.Stream body = null)

Set item image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SetItemImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var body = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Set item image.
                apiInstance.SetItemImage(itemId, imageType, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.SetItemImage: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **body** | **System.IO.Stream**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: image/_*
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Image saved. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetItemImageByIndex

> void SetItemImageByIndex (Guid itemId, ImageType imageType, int imageIndex, System.IO.Stream body = null)

Set item image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class SetItemImageByIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | (Unused) Image index.
            var body = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Set item image.
                apiInstance.SetItemImageByIndex(itemId, imageType, imageIndex, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.SetItemImageByIndex: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| (Unused) Image index. | 
 **body** | **System.IO.Stream**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: image/_*
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Image saved. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateItemImageIndex

> void UpdateItemImageIndex (Guid itemId, ImageType imageType, int imageIndex, int newIndex)

Updates the index for an item image.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class UpdateItemImageIndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ImageApi(Configuration.Default);
            var itemId = new Guid(); // Guid | Item id.
            var imageType = ;  // ImageType | Image type.
            var imageIndex = 56;  // int | Old image index.
            var newIndex = 56;  // int | New image index.

            try
            {
                // Updates the index for an item image.
                apiInstance.UpdateItemImageIndex(itemId, imageType, imageIndex, newIndex);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.UpdateItemImageIndex: " + e.Message );
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
 **itemId** | [**Guid**](Guid.md)| Item id. | 
 **imageType** | **ImageType**| Image type. | 
 **imageIndex** | **int**| Old image index. | 
 **newIndex** | **int**| New image index. | 

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
| **204** | Image index updated. |  -  |
| **404** | Item not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

