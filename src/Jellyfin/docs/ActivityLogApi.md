# Jellyfin.Api.Api.ActivityLogApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLogEntries**](ActivityLogApi.md#getlogentries) | **GET** /System/ActivityLog/Entries | Gets activity log entries.



## GetLogEntries

> ActivityLogEntryQueryResult GetLogEntries (int? startIndex = null, int? limit = null, DateTime? minDate = null, bool? hasUserId = null)

Gets activity log entries.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetLogEntriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: CustomAuthentication
            Configuration.Default.AddApiKey("X-Emby-Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Emby-Authorization", "Bearer");

            var apiInstance = new ActivityLogApi(Configuration.Default);
            var startIndex = 56;  // int? | Optional. The record index to start at. All items with a lower index will be dropped from the results. (optional) 
            var limit = 56;  // int? | Optional. The maximum number of records to return. (optional) 
            var minDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional. The minimum date. Format = ISO. (optional) 
            var hasUserId = true;  // bool? | Optional. Filter log entries if it has user id, or not. (optional) 

            try
            {
                // Gets activity log entries.
                ActivityLogEntryQueryResult result = apiInstance.GetLogEntries(startIndex, limit, minDate, hasUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ActivityLogApi.GetLogEntries: " + e.Message );
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
 **startIndex** | **int?**| Optional. The record index to start at. All items with a lower index will be dropped from the results. | [optional] 
 **limit** | **int?**| Optional. The maximum number of records to return. | [optional] 
 **minDate** | **DateTime?**| Optional. The minimum date. Format &#x3D; ISO. | [optional] 
 **hasUserId** | **bool?**| Optional. Filter log entries if it has user id, or not. | [optional] 

### Return type

[**ActivityLogEntryQueryResult**](ActivityLogEntryQueryResult.md)

### Authorization

[CustomAuthentication](../README.md#CustomAuthentication)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Activity log returned. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

