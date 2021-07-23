
# Jellyfin.Api.Model.SystemInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalAddress** | **string** | Gets or sets the local address. | [optional] 
**ServerName** | **string** | Gets or sets the name of the server. | [optional] 
**Version** | **string** | Gets or sets the server version. | [optional] 
**ProductName** | **string** | Gets or sets the product name. This is the AssemblyProduct name. | [optional] 
**OperatingSystem** | **string** | Gets or sets the operating system. | [optional] 
**Id** | **string** | Gets or sets the id. | [optional] 
**StartupWizardCompleted** | **bool?** | Gets or sets a value indicating whether the startup wizard is completed. | [optional] 
**OperatingSystemDisplayName** | **string** | Gets or sets the display name of the operating system. | [optional] 
**PackageName** | **string** | Get or sets the package name. | [optional] 
**HasPendingRestart** | **bool** | Gets or sets a value indicating whether this instance has pending restart. | [optional] 
**IsShuttingDown** | **bool** |  | [optional] 
**SupportsLibraryMonitor** | **bool** | Gets or sets a value indicating whether [supports library monitor]. | [optional] 
**WebSocketPortNumber** | **int** | Gets or sets the web socket port number. | [optional] 
**CompletedInstallations** | [**List&lt;InstallationInfo&gt;**](InstallationInfo.md) | Gets or sets the completed installations. | [optional] 
**CanSelfRestart** | **bool** | Gets or sets a value indicating whether this instance can self restart. | [optional] 
**CanLaunchWebBrowser** | **bool** |  | [optional] 
**ProgramDataPath** | **string** | Gets or sets the program data path. | [optional] 
**WebPath** | **string** | Gets or sets the web UI resources path. | [optional] 
**ItemsByNamePath** | **string** | Gets or sets the items by name path. | [optional] 
**CachePath** | **string** | Gets or sets the cache path. | [optional] 
**LogPath** | **string** | Gets or sets the log path. | [optional] 
**InternalMetadataPath** | **string** | Gets or sets the internal metadata path. | [optional] 
**TranscodingTempPath** | **string** | Gets or sets the transcode path. | [optional] 
**HasUpdateAvailable** | **bool** | Gets or sets a value indicating whether this instance has update available. | [optional] 
**EncoderLocation** | **FFmpegLocation** | Enum describing the location of the FFmpeg tool. | [optional] 
**SystemArchitecture** | **Architecture** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

