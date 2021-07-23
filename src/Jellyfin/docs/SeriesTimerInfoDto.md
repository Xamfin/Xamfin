
# Jellyfin.Api.Model.SeriesTimerInfoDto

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
**RecordAnyTime** | **bool** | Gets or sets a value indicating whether [record any time]. | [optional] 
**SkipEpisodesInLibrary** | **bool** |  | [optional] 
**RecordAnyChannel** | **bool** | Gets or sets a value indicating whether [record any channel]. | [optional] 
**KeepUpTo** | **int** |  | [optional] 
**RecordNewOnly** | **bool** | Gets or sets a value indicating whether [record new only]. | [optional] 
**Days** | [**List&lt;DayOfWeek&gt;**](DayOfWeek.md) | Gets or sets the days. | [optional] 
**DayPattern** | **DayPattern** | Gets or sets the day pattern. | [optional] 
**ImageTags** | **Dictionary&lt;string, string&gt;** | Gets or sets the image tags. | [optional] 
**ParentThumbItemId** | **string** | Gets or sets the parent thumb item id. | [optional] 
**ParentThumbImageTag** | **string** | Gets or sets the parent thumb image tag. | [optional] 
**ParentPrimaryImageItemId** | **string** | Gets or sets the parent primary image item identifier. | [optional] 
**ParentPrimaryImageTag** | **string** | Gets or sets the parent primary image tag. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

