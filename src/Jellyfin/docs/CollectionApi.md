# Jellyfin.Api.Api.CollectionApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddToCollection**](CollectionApi.md#addtocollection) | **POST** /Collections/{collectionId}/Items | Adds items to a collection.
[**CreateCollection**](CollectionApi.md#createcollection) | **POST** /Collections | Creates a new collection.
[**RemoveFromCollection**](CollectionApi.md#removefromcollection) | **DELETE** /Collections/{collectionId}/Items | Removes items from a collection.



## AddToCollection

> void AddToCollection (Guid collectionId, List<Guid> ids)

Adds items to a collection.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class AddToCollectionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new CollectionApi(Configuration.Default);
            var collectionId = new Guid(); // Guid | The collection id.
            var ids = new List<Guid>(); // List<Guid> | Item ids, comma delimited.

            try
            {
                // Adds items to a collection.
                apiInstance.AddToCollection(collectionId, ids);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CollectionApi.AddToCollection: " + e.Message );
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
 **collectionId** | [**Guid**](Guid.md)| The collection id. | 
 **ids** | [**List&lt;Guid&gt;**](Guid.md)| Item ids, comma delimited. | 

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
| **204** | Items added to collection. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateCollection

> CollectionCreationResult CreateCollection (string name = null, List<string> ids = null, Guid? parentId = null, bool? isLocked = null)

Creates a new collection.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new CollectionApi(Configuration.Default);
            var name = name_example;  // string | The name of the collection. (optional) 
            var ids = new List<string>(); // List<string> | Item Ids to add to the collection. (optional) 
            var parentId = new Guid?(); // Guid? | Optional. Create the collection within a specific folder. (optional) 
            var isLocked = true;  // bool? | Whether or not to lock the new collection. (optional)  (default to false)

            try
            {
                // Creates a new collection.
                CollectionCreationResult result = apiInstance.CreateCollection(name, ids, parentId, isLocked);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CollectionApi.CreateCollection: " + e.Message );
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
 **name** | **string**| The name of the collection. | [optional] 
 **ids** | [**List&lt;string&gt;**](string.md)| Item Ids to add to the collection. | [optional] 
 **parentId** | [**Guid?**](Guid?.md)| Optional. Create the collection within a specific folder. | [optional] 
 **isLocked** | **bool?**| Whether or not to lock the new collection. | [optional] [default to false]

### Return type

[**CollectionCreationResult**](CollectionCreationResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Collection created. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveFromCollection

> void RemoveFromCollection (Guid collectionId, List<Guid> ids)

Removes items from a collection.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class RemoveFromCollectionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new CollectionApi(Configuration.Default);
            var collectionId = new Guid(); // Guid | The collection id.
            var ids = new List<Guid>(); // List<Guid> | Item ids, comma delimited.

            try
            {
                // Removes items from a collection.
                apiInstance.RemoveFromCollection(collectionId, ids);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CollectionApi.RemoveFromCollection: " + e.Message );
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
 **collectionId** | [**Guid**](Guid.md)| The collection id. | 
 **ids** | [**List&lt;Guid&gt;**](Guid.md)| Item ids, comma delimited. | 

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
| **204** | Items removed from collection. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

