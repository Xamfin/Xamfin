
# Jellyfin.Api.Model.SessionInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlayState** | [**PlayerStateInfo**](PlayerStateInfo.md) |  | [optional] 
**AdditionalUsers** | [**List&lt;SessionUserInfo&gt;**](SessionUserInfo.md) |  | [optional] 
**Capabilities** | [**ClientCapabilities**](ClientCapabilities.md) |  | [optional] 
**RemoteEndPoint** | **string** | Gets or sets the remote end point. | [optional] 
**PlayableMediaTypes** | **List&lt;string&gt;** | Gets or sets the playable media types. | [optional] [readonly] 
**Id** | **string** | Gets or sets the id. | [optional] 
**UserId** | **Guid** | Gets or sets the user id. | [optional] 
**UserName** | **string** | Gets or sets the username. | [optional] 
**_Client** | **string** | Gets or sets the type of the client. | [optional] 
**LastActivityDate** | **DateTime** | Gets or sets the last activity date. | [optional] 
**LastPlaybackCheckIn** | **DateTime** | Gets or sets the last playback check in. | [optional] 
**DeviceName** | **string** | Gets or sets the name of the device. | [optional] 
**DeviceType** | **string** | Gets or sets the type of the device. | [optional] 
**NowPlayingItem** | [**BaseItemDto**](BaseItemDto.md) | Gets or sets the now playing item. | [optional] 
**FullNowPlayingItem** | [**BaseItem**](BaseItem.md) | Class BaseItem. | [optional] 
**NowViewingItem** | [**BaseItemDto**](BaseItemDto.md) | This is strictly used as a data transfer object from the api layer.  This holds information about a BaseItem in a format that is convenient for the client. | [optional] 
**DeviceId** | **string** | Gets or sets the device id. | [optional] 
**ApplicationVersion** | **string** | Gets or sets the application version. | [optional] 
**TranscodingInfo** | [**TranscodingInfo**](TranscodingInfo.md) |  | [optional] 
**IsActive** | **bool** | Gets a value indicating whether this instance is active. | [optional] [readonly] 
**SupportsMediaControl** | **bool** |  | [optional] [readonly] 
**SupportsRemoteControl** | **bool** |  | [optional] [readonly] 
**NowPlayingQueue** | [**List&lt;QueueItem&gt;**](QueueItem.md) |  | [optional] 
**HasCustomDeviceName** | **bool** |  | [optional] 
**PlaylistItemId** | **string** |  | [optional] 
**ServerId** | **string** |  | [optional] 
**UserPrimaryImageTag** | **string** |  | [optional] 
**SupportedCommands** | [**List&lt;GeneralCommandType&gt;**](GeneralCommandType.md) | Gets or sets the supported commands. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

