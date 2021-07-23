# Jellyfin.Api.Api.DlnaServerApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConnectionManager**](DlnaServerApi.md#getconnectionmanager) | **GET** /Dlna/{serverId}/ConnectionManager | Gets Dlna media receiver registrar xml.
[**GetConnectionManager2**](DlnaServerApi.md#getconnectionmanager2) | **GET** /Dlna/{serverId}/ConnectionManager/ConnectionManager | Gets Dlna media receiver registrar xml.
[**GetConnectionManager3**](DlnaServerApi.md#getconnectionmanager3) | **GET** /Dlna/{serverId}/ConnectionManager/ConnectionManager.xml | Gets Dlna media receiver registrar xml.
[**GetContentDirectory**](DlnaServerApi.md#getcontentdirectory) | **GET** /Dlna/{serverId}/ContentDirectory | Gets Dlna content directory xml.
[**GetContentDirectory2**](DlnaServerApi.md#getcontentdirectory2) | **GET** /Dlna/{serverId}/ContentDirectory/ContentDirectory | Gets Dlna content directory xml.
[**GetContentDirectory3**](DlnaServerApi.md#getcontentdirectory3) | **GET** /Dlna/{serverId}/ContentDirectory/ContentDirectory.xml | Gets Dlna content directory xml.
[**GetDescriptionXml**](DlnaServerApi.md#getdescriptionxml) | **GET** /Dlna/{serverId}/description | Get Description Xml.
[**GetDescriptionXml2**](DlnaServerApi.md#getdescriptionxml2) | **GET** /Dlna/{serverId}/description.xml | Get Description Xml.
[**GetIcon**](DlnaServerApi.md#geticon) | **GET** /Dlna/icons/{fileName} | Gets a server icon.
[**GetIconId**](DlnaServerApi.md#geticonid) | **GET** /Dlna/{serverId}/icons/{fileName} | Gets a server icon.
[**GetMediaReceiverRegistrar**](DlnaServerApi.md#getmediareceiverregistrar) | **GET** /Dlna/{serverId}/MediaReceiverRegistrar | Gets Dlna media receiver registrar xml.
[**GetMediaReceiverRegistrar2**](DlnaServerApi.md#getmediareceiverregistrar2) | **GET** /Dlna/{serverId}/MediaReceiverRegistrar/MediaReceiverRegistrar | Gets Dlna media receiver registrar xml.
[**GetMediaReceiverRegistrar3**](DlnaServerApi.md#getmediareceiverregistrar3) | **GET** /Dlna/{serverId}/MediaReceiverRegistrar/MediaReceiverRegistrar.xml | Gets Dlna media receiver registrar xml.
[**ProcessConnectionManagerControlRequest**](DlnaServerApi.md#processconnectionmanagercontrolrequest) | **POST** /Dlna/{serverId}/ConnectionManager/Control | Process a connection manager control request.
[**ProcessContentDirectoryControlRequest**](DlnaServerApi.md#processcontentdirectorycontrolrequest) | **POST** /Dlna/{serverId}/ContentDirectory/Control | Process a content directory control request.
[**ProcessMediaReceiverRegistrarControlRequest**](DlnaServerApi.md#processmediareceiverregistrarcontrolrequest) | **POST** /Dlna/{serverId}/MediaReceiverRegistrar/Control | Process a media receiver registrar control request.



## GetConnectionManager

> System.IO.Stream GetConnectionManager (string serverId)

Gets Dlna media receiver registrar xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetConnectionManagerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna media receiver registrar xml.
                System.IO.Stream result = apiInstance.GetConnectionManager(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetConnectionManager: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna media receiver registrar xml returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConnectionManager2

> System.IO.Stream GetConnectionManager2 (string serverId)

Gets Dlna media receiver registrar xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetConnectionManager2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna media receiver registrar xml.
                System.IO.Stream result = apiInstance.GetConnectionManager2(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetConnectionManager2: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna media receiver registrar xml returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConnectionManager3

> System.IO.Stream GetConnectionManager3 (string serverId)

Gets Dlna media receiver registrar xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetConnectionManager3Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna media receiver registrar xml.
                System.IO.Stream result = apiInstance.GetConnectionManager3(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetConnectionManager3: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna media receiver registrar xml returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetContentDirectory

> System.IO.Stream GetContentDirectory (string serverId)

Gets Dlna content directory xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetContentDirectoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna content directory xml.
                System.IO.Stream result = apiInstance.GetContentDirectory(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetContentDirectory: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna content directory returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetContentDirectory2

> System.IO.Stream GetContentDirectory2 (string serverId)

Gets Dlna content directory xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetContentDirectory2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna content directory xml.
                System.IO.Stream result = apiInstance.GetContentDirectory2(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetContentDirectory2: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna content directory returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetContentDirectory3

> System.IO.Stream GetContentDirectory3 (string serverId)

Gets Dlna content directory xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetContentDirectory3Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna content directory xml.
                System.IO.Stream result = apiInstance.GetContentDirectory3(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetContentDirectory3: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna content directory returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDescriptionXml

> System.IO.Stream GetDescriptionXml (string serverId)

Get Description Xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetDescriptionXmlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Get Description Xml.
                System.IO.Stream result = apiInstance.GetDescriptionXml(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetDescriptionXml: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Description xml returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDescriptionXml2

> System.IO.Stream GetDescriptionXml2 (string serverId)

Get Description Xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetDescriptionXml2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Get Description Xml.
                System.IO.Stream result = apiInstance.GetDescriptionXml2(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetDescriptionXml2: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Description xml returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetIcon

> System.IO.Stream GetIcon (string fileName)

Gets a server icon.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetIconExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var fileName = fileName_example;  // string | The icon filename.

            try
            {
                // Gets a server icon.
                System.IO.Stream result = apiInstance.GetIcon(fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetIcon: " + e.Message );
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
 **fileName** | **string**| The icon filename. | 

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
| **200** | Request processed. |  -  |
| **404** | Not Found. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetIconId

> System.IO.Stream GetIconId (string serverId, string fileName)

Gets a server icon.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetIconIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.
            var fileName = fileName_example;  // string | The icon filename.

            try
            {
                // Gets a server icon.
                System.IO.Stream result = apiInstance.GetIconId(serverId, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetIconId: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 
 **fileName** | **string**| The icon filename. | 

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
| **200** | Request processed. |  -  |
| **404** | Not Found. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMediaReceiverRegistrar

> System.IO.Stream GetMediaReceiverRegistrar (string serverId)

Gets Dlna media receiver registrar xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetMediaReceiverRegistrarExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna media receiver registrar xml.
                System.IO.Stream result = apiInstance.GetMediaReceiverRegistrar(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetMediaReceiverRegistrar: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna media receiver registrar xml returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMediaReceiverRegistrar2

> System.IO.Stream GetMediaReceiverRegistrar2 (string serverId)

Gets Dlna media receiver registrar xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetMediaReceiverRegistrar2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna media receiver registrar xml.
                System.IO.Stream result = apiInstance.GetMediaReceiverRegistrar2(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetMediaReceiverRegistrar2: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna media receiver registrar xml returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMediaReceiverRegistrar3

> System.IO.Stream GetMediaReceiverRegistrar3 (string serverId)

Gets Dlna media receiver registrar xml.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class GetMediaReceiverRegistrar3Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Gets Dlna media receiver registrar xml.
                System.IO.Stream result = apiInstance.GetMediaReceiverRegistrar3(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.GetMediaReceiverRegistrar3: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dlna media receiver registrar xml returned. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ProcessConnectionManagerControlRequest

> System.IO.Stream ProcessConnectionManagerControlRequest (string serverId)

Process a connection manager control request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ProcessConnectionManagerControlRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Process a connection manager control request.
                System.IO.Stream result = apiInstance.ProcessConnectionManagerControlRequest(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.ProcessConnectionManagerControlRequest: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request processed. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ProcessContentDirectoryControlRequest

> System.IO.Stream ProcessContentDirectoryControlRequest (string serverId)

Process a content directory control request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ProcessContentDirectoryControlRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Process a content directory control request.
                System.IO.Stream result = apiInstance.ProcessContentDirectoryControlRequest(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.ProcessContentDirectoryControlRequest: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request processed. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ProcessMediaReceiverRegistrarControlRequest

> System.IO.Stream ProcessMediaReceiverRegistrarControlRequest (string serverId)

Process a media receiver registrar control request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Jellyfin.Api.Api;
using Jellyfin.Api.Client;
using Jellyfin.Api.Model;

namespace Example
{
    public class ProcessMediaReceiverRegistrarControlRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DlnaServerApi(Configuration.Default);
            var serverId = serverId_example;  // string | Server UUID.

            try
            {
                // Process a media receiver registrar control request.
                System.IO.Stream result = apiInstance.ProcessMediaReceiverRegistrarControlRequest(serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DlnaServerApi.ProcessMediaReceiverRegistrarControlRequest: " + e.Message );
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
 **serverId** | **string**| Server UUID. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request processed. |  -  |
| **503** | DLNA is disabled. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

