# Jellyfin.Api.Api.PersonsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPerson**](PersonsApi.md#getperson) | **GET** /Persons/{name} | Get person by name.
[**GetPersons**](PersonsApi.md#getpersons) | **GET** /Persons | Gets all persons.



## GetPerson

> BaseItemDto GetPerson (string name, Guid? userId = null)

Get person by name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPersonExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PersonsApi(Configuration.Default);
            var name = name_example;  // string | Person name.
            var userId = new Guid?(); // Guid? | Optional. Filter by user id, and attach user data. (optional) 

            try
            {
                // Get person by name.
                BaseItemDto result = apiInstance.GetPerson(name, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PersonsApi.GetPerson: " + e.Message );
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
 **userId** | [**Guid?**](Guid?.md)| Optional. Filter by user id, and attach user data. | [optional] 

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
| **200** | Person returned. |  -  |
| **404** | Person not found. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPersons

> BaseItemDtoQueryResult GetPersons (int? limit = null, string searchTerm = null, List<ItemFields> fields = null, List<ItemFilter> filters = null, bool? isFavorite = null, bool? enableUserData = null, int? imageTypeLimit = null, List<ImageType> enableImageTypes = null, List<string> excludePersonTypes = null, List<string> personTypes = null, Guid? appearsInItemId = null, Guid? userId = null, bool? enableImages = null)

Gets all persons.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetPersonsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new PersonsApi(Configuration.Default);
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var searchTerm = searchTerm_example;  // string | The search term. (optional) 
            var fields = new List<ItemFields>(); // List<ItemFields> | Optional. Specify additional fields of information to return in the output. (optional) 
            var filters = new List<ItemFilter>(); // List<ItemFilter> | Optional. Specify additional filters to apply. (optional) 
            var isFavorite = true;  // bool? | Optional filter by items that are marked as favorite, or not. userId is required. (optional) 
            var enableUserData = true;  // bool? | Optional, include user data. (optional) 
            var imageTypeLimit = 56;  // int? | Optional, the max number of images to return, per image type. (optional) 
            var enableImageTypes = new List<ImageType>(); // List<ImageType> | Optional. The image types to include in the output. (optional) 
            var excludePersonTypes = new List<string>(); // List<string> | Optional. If specified results will be filtered to exclude those containing the specified PersonType. Allows multiple, comma-delimited. (optional) 
            var personTypes = new List<string>(); // List<string> | Optional. If specified results will be filtered to include only those containing the specified PersonType. Allows multiple, comma-delimited. (optional) 
            var appearsInItemId = new Guid?(); // Guid? | Optional. If specified, person results will be filtered on items related to said persons. (optional) 
            var userId = new Guid?(); // Guid? | User id. (optional) 
            var enableImages = true;  // bool? | Optional, include image information in output. (optional)  (default to true)

            try
            {
                // Gets all persons.
                BaseItemDtoQueryResult result = apiInstance.GetPersons(limit, searchTerm, fields, filters, isFavorite, enableUserData, imageTypeLimit, enableImageTypes, excludePersonTypes, personTypes, appearsInItemId, userId, enableImages);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PersonsApi.GetPersons: " + e.Message );
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
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **searchTerm** | **string**| The search term. | [optional] 
 **fields** | [**List&lt;ItemFields&gt;**](ItemFields.md)| Optional. Specify additional fields of information to return in the output. | [optional] 
 **filters** | [**List&lt;ItemFilter&gt;**](ItemFilter.md)| Optional. Specify additional filters to apply. | [optional] 
 **isFavorite** | **bool?**| Optional filter by items that are marked as favorite, or not. userId is required. | [optional] 
 **enableUserData** | **bool?**| Optional, include user data. | [optional] 
 **imageTypeLimit** | **int?**| Optional, the max number of images to return, per image type. | [optional] 
 **enableImageTypes** | [**List&lt;ImageType&gt;**](ImageType.md)| Optional. The image types to include in the output. | [optional] 
 **excludePersonTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified results will be filtered to exclude those containing the specified PersonType. Allows multiple, comma-delimited. | [optional] 
 **personTypes** | [**List&lt;string&gt;**](string.md)| Optional. If specified results will be filtered to include only those containing the specified PersonType. Allows multiple, comma-delimited. | [optional] 
 **appearsInItemId** | [**Guid?**](Guid?.md)| Optional. If specified, person results will be filtered on items related to said persons. | [optional] 
 **userId** | [**Guid?**](Guid?.md)| User id. | [optional] 
 **enableImages** | **bool?**| Optional, include image information in output. | [optional] [default to true]

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
| **200** | Persons returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

