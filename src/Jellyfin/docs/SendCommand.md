
# Jellyfin.Api.Model.SendCommand

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **Guid** | Gets the group identifier. | [optional] [readonly] 
**PlaylistItemId** | **Guid** | Gets the playlist identifier of the playing item. | [optional] [readonly] 
**When** | **DateTime** | Gets or sets the UTC time when to execute the command. | [optional] 
**PositionTicks** | **long?** | Gets the position ticks. | [optional] [readonly] 
**Command** | **SendCommandType** | Gets the command. | [optional] [readonly] 
**EmittedAt** | **DateTime** | Gets the UTC time when this command has been emitted. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

