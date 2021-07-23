
# Jellyfin.Api.Model.PlaybackStartInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanSeek** | **bool** | Gets or sets a value indicating whether this instance can seek. | [optional] 
**Item** | [**BaseItemDto**](BaseItemDto.md) | Gets or sets the item. | [optional] 
**ItemId** | **Guid** | Gets or sets the item identifier. | [optional] 
**SessionId** | **string** | Gets or sets the session id. | [optional] 
**MediaSourceId** | **string** | Gets or sets the media version identifier. | [optional] 
**AudioStreamIndex** | **int?** | Gets or sets the index of the audio stream. | [optional] 
**SubtitleStreamIndex** | **int?** | Gets or sets the index of the subtitle stream. | [optional] 
**IsPaused** | **bool** | Gets or sets a value indicating whether this instance is paused. | [optional] 
**IsMuted** | **bool** | Gets or sets a value indicating whether this instance is muted. | [optional] 
**PositionTicks** | **long?** | Gets or sets the position ticks. | [optional] 
**PlaybackStartTimeTicks** | **long?** |  | [optional] 
**VolumeLevel** | **int?** | Gets or sets the volume level. | [optional] 
**Brightness** | **int?** |  | [optional] 
**AspectRatio** | **string** |  | [optional] 
**PlayMethod** | **PlayMethod** | Gets or sets the play method. | [optional] 
**LiveStreamId** | **string** | Gets or sets the live stream identifier. | [optional] 
**PlaySessionId** | **string** | Gets or sets the play session identifier. | [optional] 
**RepeatMode** | **RepeatMode** | Gets or sets the repeat mode. | [optional] 
**NowPlayingQueue** | [**List&lt;QueueItem&gt;**](QueueItem.md) |  | [optional] 
**PlaylistItemId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

