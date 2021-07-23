
# Jellyfin.Api.Model.UserDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the name. | [optional] 
**ServerId** | **string** | Gets or sets the server identifier. | [optional] 
**ServerName** | **string** | Gets or sets the name of the server.  This is not used by the server and is for client-side usage only. | [optional] 
**Id** | **Guid** | Gets or sets the id. | [optional] 
**PrimaryImageTag** | **string** | Gets or sets the primary image tag. | [optional] 
**HasPassword** | **bool** | Gets or sets a value indicating whether this instance has password. | [optional] 
**HasConfiguredPassword** | **bool** | Gets or sets a value indicating whether this instance has configured password. | [optional] 
**HasConfiguredEasyPassword** | **bool** | Gets or sets a value indicating whether this instance has configured easy password. | [optional] 
**EnableAutoLogin** | **bool?** | Gets or sets whether async login is enabled or not. | [optional] 
**LastLoginDate** | **DateTime?** | Gets or sets the last login date. | [optional] 
**LastActivityDate** | **DateTime?** | Gets or sets the last activity date. | [optional] 
**Configuration** | [**UserConfiguration**](UserConfiguration.md) | Gets or sets the configuration. | [optional] 
**Policy** | [**UserPolicy**](UserPolicy.md) | Gets or sets the policy. | [optional] 
**PrimaryImageAspectRatio** | **double?** | Gets or sets the primary image aspect ratio. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

