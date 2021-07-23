# Jellyfin.Api.Api.VideoAttachmentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAttachment**](VideoAttachmentsApi.md#getattachment) | **GET** /Videos/{videoId}/{mediaSourceId}/Attachments/{index} | Get video attachment.



## GetAttachment

> System.IO.Stream GetAttachment (Guid videoId, string mediaSourceId, int index)

Get video attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new VideoAttachmentsApi(Configuration.Default);
            var videoId = new Guid(); // Guid | Video ID.
            var mediaSourceId = mediaSourceId_example;  // string | Media Source ID.
            var index = 56;  // int | Attachment Index.

            try
            {
                // Get video attachment.
                System.IO.Stream result = apiInstance.GetAttachment(videoId, mediaSourceId, index);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VideoAttachmentsApi.GetAttachment: " + e.Message );
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
 **videoId** | [**Guid**](Guid.md)| Video ID. | 
 **mediaSourceId** | **string**| Media Source ID. | 
 **index** | **int**| Attachment Index. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octet-stream, application/json, application/json; profile=CamelCase, application/json; profile=PascalCase


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Attachment retrieved. |  -  |
| **404** | Video or attachment not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

