
# Jellyfin.Api.Model.MediaSourceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Protocol** | **MediaProtocol** |  | [optional] 
**Id** | **string** |  | [optional] 
**Path** | **string** |  | [optional] 
**EncoderPath** | **string** |  | [optional] 
**EncoderProtocol** | **MediaProtocol** |  | [optional] 
**Type** | **MediaSourceType** |  | [optional] 
**Container** | **string** |  | [optional] 
**Size** | **long?** |  | [optional] 
**Name** | **string** |  | [optional] 
**IsRemote** | **bool** | Differentiate internet url vs local network. | [optional] 
**ETag** | **string** |  | [optional] 
**RunTimeTicks** | **long?** |  | [optional] 
**ReadAtNativeFramerate** | **bool** |  | [optional] 
**IgnoreDts** | **bool** |  | [optional] 
**IgnoreIndex** | **bool** |  | [optional] 
**GenPtsInput** | **bool** |  | [optional] 
**SupportsTranscoding** | **bool** |  | [optional] 
**SupportsDirectStream** | **bool** |  | [optional] 
**SupportsDirectPlay** | **bool** |  | [optional] 
**IsInfiniteStream** | **bool** |  | [optional] 
**RequiresOpening** | **bool** |  | [optional] 
**OpenToken** | **string** |  | [optional] 
**RequiresClosing** | **bool** |  | [optional] 
**LiveStreamId** | **string** |  | [optional] 
**BufferMs** | **int?** |  | [optional] 
**RequiresLooping** | **bool** |  | [optional] 
**SupportsProbing** | **bool** |  | [optional] 
**VideoType** | **VideoType** |  | [optional] 
**IsoType** | **IsoType** |  | [optional] 
**Video3DFormat** | **Video3DFormat** |  | [optional] 
**MediaStreams** | [**List&lt;MediaStream&gt;**](MediaStream.md) |  | [optional] 
**MediaAttachments** | [**List&lt;MediaAttachment&gt;**](MediaAttachment.md) |  | [optional] 
**Formats** | **List&lt;string&gt;** |  | [optional] 
**Bitrate** | **int?** |  | [optional] 
**Timestamp** | **TransportStreamTimestamp** |  | [optional] 
**RequiredHttpHeaders** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**TranscodingUrl** | **string** |  | [optional] 
**TranscodingSubProtocol** | **string** |  | [optional] 
**TranscodingContainer** | **string** |  | [optional] 
**AnalyzeDurationMs** | **int?** |  | [optional] 
**DefaultAudioStreamIndex** | **int?** |  | [optional] 
**DefaultSubtitleStreamIndex** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

