
# Jellyfin.Api.Model.ChannelFeatures

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the name. | [optional] 
**Id** | **string** | Gets or sets the identifier. | [optional] 
**CanSearch** | **bool** | Gets or sets a value indicating whether this instance can search. | [optional] 
**MediaTypes** | [**List&lt;ChannelMediaType&gt;**](ChannelMediaType.md) | Gets or sets the media types. | [optional] 
**ContentTypes** | [**List&lt;ChannelMediaContentType&gt;**](ChannelMediaContentType.md) | Gets or sets the content types. | [optional] 
**MaxPageSize** | **int?** | Represents the maximum number of records the channel allows retrieving at a time. | [optional] 
**AutoRefreshLevels** | **int?** | Gets or sets the automatic refresh levels. | [optional] 
**DefaultSortFields** | [**List&lt;ChannelItemSortField&gt;**](ChannelItemSortField.md) | Gets or sets the default sort orders. | [optional] 
**SupportsSortOrderToggle** | **bool** | Indicates if a sort ascending/descending toggle is supported or not. | [optional] 
**SupportsLatestMedia** | **bool** | Gets or sets a value indicating whether [supports latest media]. | [optional] 
**CanFilter** | **bool** | Gets or sets a value indicating whether this instance can filter. | [optional] 
**SupportsContentDownloading** | **bool** | Gets or sets a value indicating whether [supports content downloading]. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

