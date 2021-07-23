
# Jellyfin.Api.Model.UserPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsAdministrator** | **bool** | Gets or sets a value indicating whether this instance is administrator. | [optional] 
**IsHidden** | **bool** | Gets or sets a value indicating whether this instance is hidden. | [optional] 
**IsDisabled** | **bool** | Gets or sets a value indicating whether this instance is disabled. | [optional] 
**MaxParentalRating** | **int?** | Gets or sets the max parental rating. | [optional] 
**BlockedTags** | **List&lt;string&gt;** |  | [optional] 
**EnableUserPreferenceAccess** | **bool** |  | [optional] 
**AccessSchedules** | [**List&lt;AccessSchedule&gt;**](AccessSchedule.md) |  | [optional] 
**BlockUnratedItems** | [**List&lt;UnratedItem&gt;**](UnratedItem.md) |  | [optional] 
**EnableRemoteControlOfOtherUsers** | **bool** |  | [optional] 
**EnableSharedDeviceControl** | **bool** |  | [optional] 
**EnableRemoteAccess** | **bool** |  | [optional] 
**EnableLiveTvManagement** | **bool** |  | [optional] 
**EnableLiveTvAccess** | **bool** |  | [optional] 
**EnableMediaPlayback** | **bool** |  | [optional] 
**EnableAudioPlaybackTranscoding** | **bool** |  | [optional] 
**EnableVideoPlaybackTranscoding** | **bool** |  | [optional] 
**EnablePlaybackRemuxing** | **bool** |  | [optional] 
**ForceRemoteSourceTranscoding** | **bool** |  | [optional] 
**EnableContentDeletion** | **bool** |  | [optional] 
**EnableContentDeletionFromFolders** | **List&lt;string&gt;** |  | [optional] 
**EnableContentDownloading** | **bool** |  | [optional] 
**EnableSyncTranscoding** | **bool** | Gets or sets a value indicating whether [enable synchronize]. | [optional] 
**EnableMediaConversion** | **bool** |  | [optional] 
**EnabledDevices** | **List&lt;string&gt;** |  | [optional] 
**EnableAllDevices** | **bool** |  | [optional] 
**EnabledChannels** | **List&lt;Guid&gt;** |  | [optional] 
**EnableAllChannels** | **bool** |  | [optional] 
**EnabledFolders** | **List&lt;Guid&gt;** |  | [optional] 
**EnableAllFolders** | **bool** |  | [optional] 
**InvalidLoginAttemptCount** | **int** |  | [optional] 
**LoginAttemptsBeforeLockout** | **int** |  | [optional] 
**MaxActiveSessions** | **int** |  | [optional] 
**EnablePublicSharing** | **bool** |  | [optional] 
**BlockedMediaFolders** | **List&lt;Guid&gt;** |  | [optional] 
**BlockedChannels** | **List&lt;Guid&gt;** |  | [optional] 
**RemoteClientBitrateLimit** | **int** |  | [optional] 
**AuthenticationProviderId** | **string** |  | [optional] 
**PasswordResetProviderId** | **string** |  | [optional] 
**SyncPlayAccess** | **SyncPlayUserAccessType** | Enum SyncPlayUserAccessType. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

