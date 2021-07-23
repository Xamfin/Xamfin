
# Jellyfin.Api.Model.QuickConnectResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Authenticated** | **bool** | Gets a value indicating whether this request is authorized. | [optional] [readonly] 
**Secret** | **string** | Gets or sets the secret value used to uniquely identify this request. Can be used to retrieve authentication information. | [optional] 
**Code** | **string** | Gets or sets the user facing code used so the user can quickly differentiate this request from others. | [optional] 
**Authentication** | **string** | Gets or sets the private access token. | [optional] 
**Error** | **string** | Gets or sets an error message. | [optional] 
**DateAdded** | **DateTime?** | Gets or sets the DateTime that this request was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

