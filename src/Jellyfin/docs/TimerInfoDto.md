
# Jellyfin.Api.Model.TimerInfoDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the recording. | [optional] 
**Type** | **string** |  | [optional] 
**ServerId** | **string** | Gets or sets the server identifier. | [optional] 
**ExternalId** | **string** | Gets or sets the external identifier. | [optional] 
**ChannelId** | **Guid** | ChannelId of the recording. | [optional] 
**ExternalChannelId** | **string** | Gets or sets the external channel identifier. | [optional] 
**ChannelName** | **string** | ChannelName of the recording. | [optional] 
**ChannelPrimaryImageTag** | **string** |  | [optional] 
**ProgramId** | **string** | Gets or sets the program identifier. | [optional] 
**ExternalProgramId** | **string** | Gets or sets the external program identifier. | [optional] 
**Name** | **string** | Name of the recording. | [optional] 
**Overview** | **string** | Description of the recording. | [optional] 
**StartDate** | **DateTime** | The start date of the recording, in UTC. | [optional] 
**EndDate** | **DateTime** | The end date of the recording, in UTC. | [optional] 
**ServiceName** | **string** | Gets or sets the name of the service. | [optional] 
**Priority** | **int** | Gets or sets the priority. | [optional] 
**PrePaddingSeconds** | **int** | Gets or sets the pre padding seconds. | [optional] 
**PostPaddingSeconds** | **int** | Gets or sets the post padding seconds. | [optional] 
**IsPrePaddingRequired** | **bool** | Gets or sets a value indicating whether this instance is pre padding required. | [optional] 
**ParentBackdropItemId** | **string** | If the item does not have any backdrops, this will hold the Id of the Parent that has one. | [optional] 
**ParentBackdropImageTags** | **List&lt;string&gt;** | Gets or sets the parent backdrop image tags. | [optional] 
**IsPostPaddingRequired** | **bool** | Gets or sets a value indicating whether this instance is post padding required. | [optional] 
**KeepUntil** | **KeepUntil** |  | [optional] 
**Status** | **RecordingStatus** | Gets or sets the status. | [optional] 
**SeriesTimerId** | **string** | Gets or sets the series timer identifier. | [optional] 
**ExternalSeriesTimerId** | **string** | Gets or sets the external series timer identifier. | [optional] 
**RunTimeTicks** | **long?** | Gets or sets the run time ticks. | [optional] 
**ProgramInfo** | [**BaseItemDto**](BaseItemDto.md) | Gets or sets the program information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

