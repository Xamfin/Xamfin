/*
 * Jellyfin API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 10.7.6
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Jellyfin.Api.Api;
using Jellyfin.Api.Model;
using Jellyfin.Api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Jellyfin.Api.Test
{
    /// <summary>
    ///  Class for testing ServerConfiguration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ServerConfigurationTests
    {
        // TODO uncomment below to declare an instance variable for ServerConfiguration
        //private ServerConfiguration instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ServerConfiguration
            //instance = new ServerConfiguration();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServerConfiguration
        /// </summary>
        [Test]
        public void ServerConfigurationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" ServerConfiguration
            //Assert.IsInstanceOf(typeof(ServerConfiguration), instance);
        }


        /// <summary>
        /// Test the property 'LogFileRetentionDays'
        /// </summary>
        [Test]
        public void LogFileRetentionDaysTest()
        {
            // TODO unit test for the property 'LogFileRetentionDays'
        }
        /// <summary>
        /// Test the property 'IsStartupWizardCompleted'
        /// </summary>
        [Test]
        public void IsStartupWizardCompletedTest()
        {
            // TODO unit test for the property 'IsStartupWizardCompleted'
        }
        /// <summary>
        /// Test the property 'CachePath'
        /// </summary>
        [Test]
        public void CachePathTest()
        {
            // TODO unit test for the property 'CachePath'
        }
        /// <summary>
        /// Test the property 'PreviousVersion'
        /// </summary>
        [Test]
        public void PreviousVersionTest()
        {
            // TODO unit test for the property 'PreviousVersion'
        }
        /// <summary>
        /// Test the property 'PreviousVersionStr'
        /// </summary>
        [Test]
        public void PreviousVersionStrTest()
        {
            // TODO unit test for the property 'PreviousVersionStr'
        }
        /// <summary>
        /// Test the property 'EnableUPnP'
        /// </summary>
        [Test]
        public void EnableUPnPTest()
        {
            // TODO unit test for the property 'EnableUPnP'
        }
        /// <summary>
        /// Test the property 'EnableMetrics'
        /// </summary>
        [Test]
        public void EnableMetricsTest()
        {
            // TODO unit test for the property 'EnableMetrics'
        }
        /// <summary>
        /// Test the property 'PublicPort'
        /// </summary>
        [Test]
        public void PublicPortTest()
        {
            // TODO unit test for the property 'PublicPort'
        }
        /// <summary>
        /// Test the property 'UPnPCreateHttpPortMap'
        /// </summary>
        [Test]
        public void UPnPCreateHttpPortMapTest()
        {
            // TODO unit test for the property 'UPnPCreateHttpPortMap'
        }
        /// <summary>
        /// Test the property 'UDPPortRange'
        /// </summary>
        [Test]
        public void UDPPortRangeTest()
        {
            // TODO unit test for the property 'UDPPortRange'
        }
        /// <summary>
        /// Test the property 'EnableIPV6'
        /// </summary>
        [Test]
        public void EnableIPV6Test()
        {
            // TODO unit test for the property 'EnableIPV6'
        }
        /// <summary>
        /// Test the property 'EnableIPV4'
        /// </summary>
        [Test]
        public void EnableIPV4Test()
        {
            // TODO unit test for the property 'EnableIPV4'
        }
        /// <summary>
        /// Test the property 'EnableSSDPTracing'
        /// </summary>
        [Test]
        public void EnableSSDPTracingTest()
        {
            // TODO unit test for the property 'EnableSSDPTracing'
        }
        /// <summary>
        /// Test the property 'SSDPTracingFilter'
        /// </summary>
        [Test]
        public void SSDPTracingFilterTest()
        {
            // TODO unit test for the property 'SSDPTracingFilter'
        }
        /// <summary>
        /// Test the property 'UDPSendCount'
        /// </summary>
        [Test]
        public void UDPSendCountTest()
        {
            // TODO unit test for the property 'UDPSendCount'
        }
        /// <summary>
        /// Test the property 'UDPSendDelay'
        /// </summary>
        [Test]
        public void UDPSendDelayTest()
        {
            // TODO unit test for the property 'UDPSendDelay'
        }
        /// <summary>
        /// Test the property 'IgnoreVirtualInterfaces'
        /// </summary>
        [Test]
        public void IgnoreVirtualInterfacesTest()
        {
            // TODO unit test for the property 'IgnoreVirtualInterfaces'
        }
        /// <summary>
        /// Test the property 'VirtualInterfaceNames'
        /// </summary>
        [Test]
        public void VirtualInterfaceNamesTest()
        {
            // TODO unit test for the property 'VirtualInterfaceNames'
        }
        /// <summary>
        /// Test the property 'GatewayMonitorPeriod'
        /// </summary>
        [Test]
        public void GatewayMonitorPeriodTest()
        {
            // TODO unit test for the property 'GatewayMonitorPeriod'
        }
        /// <summary>
        /// Test the property 'EnableMultiSocketBinding'
        /// </summary>
        [Test]
        public void EnableMultiSocketBindingTest()
        {
            // TODO unit test for the property 'EnableMultiSocketBinding'
        }
        /// <summary>
        /// Test the property 'TrustAllIP6Interfaces'
        /// </summary>
        [Test]
        public void TrustAllIP6InterfacesTest()
        {
            // TODO unit test for the property 'TrustAllIP6Interfaces'
        }
        /// <summary>
        /// Test the property 'HDHomerunPortRange'
        /// </summary>
        [Test]
        public void HDHomerunPortRangeTest()
        {
            // TODO unit test for the property 'HDHomerunPortRange'
        }
        /// <summary>
        /// Test the property 'PublishedServerUriBySubnet'
        /// </summary>
        [Test]
        public void PublishedServerUriBySubnetTest()
        {
            // TODO unit test for the property 'PublishedServerUriBySubnet'
        }
        /// <summary>
        /// Test the property 'AutoDiscoveryTracing'
        /// </summary>
        [Test]
        public void AutoDiscoveryTracingTest()
        {
            // TODO unit test for the property 'AutoDiscoveryTracing'
        }
        /// <summary>
        /// Test the property 'AutoDiscovery'
        /// </summary>
        [Test]
        public void AutoDiscoveryTest()
        {
            // TODO unit test for the property 'AutoDiscovery'
        }
        /// <summary>
        /// Test the property 'PublicHttpsPort'
        /// </summary>
        [Test]
        public void PublicHttpsPortTest()
        {
            // TODO unit test for the property 'PublicHttpsPort'
        }
        /// <summary>
        /// Test the property 'HttpServerPortNumber'
        /// </summary>
        [Test]
        public void HttpServerPortNumberTest()
        {
            // TODO unit test for the property 'HttpServerPortNumber'
        }
        /// <summary>
        /// Test the property 'HttpsPortNumber'
        /// </summary>
        [Test]
        public void HttpsPortNumberTest()
        {
            // TODO unit test for the property 'HttpsPortNumber'
        }
        /// <summary>
        /// Test the property 'EnableHttps'
        /// </summary>
        [Test]
        public void EnableHttpsTest()
        {
            // TODO unit test for the property 'EnableHttps'
        }
        /// <summary>
        /// Test the property 'EnableNormalizedItemByNameIds'
        /// </summary>
        [Test]
        public void EnableNormalizedItemByNameIdsTest()
        {
            // TODO unit test for the property 'EnableNormalizedItemByNameIds'
        }
        /// <summary>
        /// Test the property 'CertificatePath'
        /// </summary>
        [Test]
        public void CertificatePathTest()
        {
            // TODO unit test for the property 'CertificatePath'
        }
        /// <summary>
        /// Test the property 'CertificatePassword'
        /// </summary>
        [Test]
        public void CertificatePasswordTest()
        {
            // TODO unit test for the property 'CertificatePassword'
        }
        /// <summary>
        /// Test the property 'IsPortAuthorized'
        /// </summary>
        [Test]
        public void IsPortAuthorizedTest()
        {
            // TODO unit test for the property 'IsPortAuthorized'
        }
        /// <summary>
        /// Test the property 'QuickConnectAvailable'
        /// </summary>
        [Test]
        public void QuickConnectAvailableTest()
        {
            // TODO unit test for the property 'QuickConnectAvailable'
        }
        /// <summary>
        /// Test the property 'EnableRemoteAccess'
        /// </summary>
        [Test]
        public void EnableRemoteAccessTest()
        {
            // TODO unit test for the property 'EnableRemoteAccess'
        }
        /// <summary>
        /// Test the property 'EnableCaseSensitiveItemIds'
        /// </summary>
        [Test]
        public void EnableCaseSensitiveItemIdsTest()
        {
            // TODO unit test for the property 'EnableCaseSensitiveItemIds'
        }
        /// <summary>
        /// Test the property 'DisableLiveTvChannelUserDataName'
        /// </summary>
        [Test]
        public void DisableLiveTvChannelUserDataNameTest()
        {
            // TODO unit test for the property 'DisableLiveTvChannelUserDataName'
        }
        /// <summary>
        /// Test the property 'MetadataPath'
        /// </summary>
        [Test]
        public void MetadataPathTest()
        {
            // TODO unit test for the property 'MetadataPath'
        }
        /// <summary>
        /// Test the property 'MetadataNetworkPath'
        /// </summary>
        [Test]
        public void MetadataNetworkPathTest()
        {
            // TODO unit test for the property 'MetadataNetworkPath'
        }
        /// <summary>
        /// Test the property 'PreferredMetadataLanguage'
        /// </summary>
        [Test]
        public void PreferredMetadataLanguageTest()
        {
            // TODO unit test for the property 'PreferredMetadataLanguage'
        }
        /// <summary>
        /// Test the property 'MetadataCountryCode'
        /// </summary>
        [Test]
        public void MetadataCountryCodeTest()
        {
            // TODO unit test for the property 'MetadataCountryCode'
        }
        /// <summary>
        /// Test the property 'SortReplaceCharacters'
        /// </summary>
        [Test]
        public void SortReplaceCharactersTest()
        {
            // TODO unit test for the property 'SortReplaceCharacters'
        }
        /// <summary>
        /// Test the property 'SortRemoveCharacters'
        /// </summary>
        [Test]
        public void SortRemoveCharactersTest()
        {
            // TODO unit test for the property 'SortRemoveCharacters'
        }
        /// <summary>
        /// Test the property 'SortRemoveWords'
        /// </summary>
        [Test]
        public void SortRemoveWordsTest()
        {
            // TODO unit test for the property 'SortRemoveWords'
        }
        /// <summary>
        /// Test the property 'MinResumePct'
        /// </summary>
        [Test]
        public void MinResumePctTest()
        {
            // TODO unit test for the property 'MinResumePct'
        }
        /// <summary>
        /// Test the property 'MaxResumePct'
        /// </summary>
        [Test]
        public void MaxResumePctTest()
        {
            // TODO unit test for the property 'MaxResumePct'
        }
        /// <summary>
        /// Test the property 'MinResumeDurationSeconds'
        /// </summary>
        [Test]
        public void MinResumeDurationSecondsTest()
        {
            // TODO unit test for the property 'MinResumeDurationSeconds'
        }
        /// <summary>
        /// Test the property 'MinAudiobookResume'
        /// </summary>
        [Test]
        public void MinAudiobookResumeTest()
        {
            // TODO unit test for the property 'MinAudiobookResume'
        }
        /// <summary>
        /// Test the property 'MaxAudiobookResume'
        /// </summary>
        [Test]
        public void MaxAudiobookResumeTest()
        {
            // TODO unit test for the property 'MaxAudiobookResume'
        }
        /// <summary>
        /// Test the property 'LibraryMonitorDelay'
        /// </summary>
        [Test]
        public void LibraryMonitorDelayTest()
        {
            // TODO unit test for the property 'LibraryMonitorDelay'
        }
        /// <summary>
        /// Test the property 'EnableDashboardResponseCaching'
        /// </summary>
        [Test]
        public void EnableDashboardResponseCachingTest()
        {
            // TODO unit test for the property 'EnableDashboardResponseCaching'
        }
        /// <summary>
        /// Test the property 'ImageSavingConvention'
        /// </summary>
        [Test]
        public void ImageSavingConventionTest()
        {
            // TODO unit test for the property 'ImageSavingConvention'
        }
        /// <summary>
        /// Test the property 'MetadataOptions'
        /// </summary>
        [Test]
        public void MetadataOptionsTest()
        {
            // TODO unit test for the property 'MetadataOptions'
        }
        /// <summary>
        /// Test the property 'SkipDeserializationForBasicTypes'
        /// </summary>
        [Test]
        public void SkipDeserializationForBasicTypesTest()
        {
            // TODO unit test for the property 'SkipDeserializationForBasicTypes'
        }
        /// <summary>
        /// Test the property 'ServerName'
        /// </summary>
        [Test]
        public void ServerNameTest()
        {
            // TODO unit test for the property 'ServerName'
        }
        /// <summary>
        /// Test the property 'BaseUrl'
        /// </summary>
        [Test]
        public void BaseUrlTest()
        {
            // TODO unit test for the property 'BaseUrl'
        }
        /// <summary>
        /// Test the property 'UICulture'
        /// </summary>
        [Test]
        public void UICultureTest()
        {
            // TODO unit test for the property 'UICulture'
        }
        /// <summary>
        /// Test the property 'SaveMetadataHidden'
        /// </summary>
        [Test]
        public void SaveMetadataHiddenTest()
        {
            // TODO unit test for the property 'SaveMetadataHidden'
        }
        /// <summary>
        /// Test the property 'ContentTypes'
        /// </summary>
        [Test]
        public void ContentTypesTest()
        {
            // TODO unit test for the property 'ContentTypes'
        }
        /// <summary>
        /// Test the property 'RemoteClientBitrateLimit'
        /// </summary>
        [Test]
        public void RemoteClientBitrateLimitTest()
        {
            // TODO unit test for the property 'RemoteClientBitrateLimit'
        }
        /// <summary>
        /// Test the property 'EnableFolderView'
        /// </summary>
        [Test]
        public void EnableFolderViewTest()
        {
            // TODO unit test for the property 'EnableFolderView'
        }
        /// <summary>
        /// Test the property 'EnableGroupingIntoCollections'
        /// </summary>
        [Test]
        public void EnableGroupingIntoCollectionsTest()
        {
            // TODO unit test for the property 'EnableGroupingIntoCollections'
        }
        /// <summary>
        /// Test the property 'DisplaySpecialsWithinSeasons'
        /// </summary>
        [Test]
        public void DisplaySpecialsWithinSeasonsTest()
        {
            // TODO unit test for the property 'DisplaySpecialsWithinSeasons'
        }
        /// <summary>
        /// Test the property 'LocalNetworkSubnets'
        /// </summary>
        [Test]
        public void LocalNetworkSubnetsTest()
        {
            // TODO unit test for the property 'LocalNetworkSubnets'
        }
        /// <summary>
        /// Test the property 'LocalNetworkAddresses'
        /// </summary>
        [Test]
        public void LocalNetworkAddressesTest()
        {
            // TODO unit test for the property 'LocalNetworkAddresses'
        }
        /// <summary>
        /// Test the property 'CodecsUsed'
        /// </summary>
        [Test]
        public void CodecsUsedTest()
        {
            // TODO unit test for the property 'CodecsUsed'
        }
        /// <summary>
        /// Test the property 'PluginRepositories'
        /// </summary>
        [Test]
        public void PluginRepositoriesTest()
        {
            // TODO unit test for the property 'PluginRepositories'
        }
        /// <summary>
        /// Test the property 'EnableExternalContentInSuggestions'
        /// </summary>
        [Test]
        public void EnableExternalContentInSuggestionsTest()
        {
            // TODO unit test for the property 'EnableExternalContentInSuggestions'
        }
        /// <summary>
        /// Test the property 'RequireHttps'
        /// </summary>
        [Test]
        public void RequireHttpsTest()
        {
            // TODO unit test for the property 'RequireHttps'
        }
        /// <summary>
        /// Test the property 'EnableNewOmdbSupport'
        /// </summary>
        [Test]
        public void EnableNewOmdbSupportTest()
        {
            // TODO unit test for the property 'EnableNewOmdbSupport'
        }
        /// <summary>
        /// Test the property 'RemoteIPFilter'
        /// </summary>
        [Test]
        public void RemoteIPFilterTest()
        {
            // TODO unit test for the property 'RemoteIPFilter'
        }
        /// <summary>
        /// Test the property 'IsRemoteIPFilterBlacklist'
        /// </summary>
        [Test]
        public void IsRemoteIPFilterBlacklistTest()
        {
            // TODO unit test for the property 'IsRemoteIPFilterBlacklist'
        }
        /// <summary>
        /// Test the property 'ImageExtractionTimeoutMs'
        /// </summary>
        [Test]
        public void ImageExtractionTimeoutMsTest()
        {
            // TODO unit test for the property 'ImageExtractionTimeoutMs'
        }
        /// <summary>
        /// Test the property 'PathSubstitutions'
        /// </summary>
        [Test]
        public void PathSubstitutionsTest()
        {
            // TODO unit test for the property 'PathSubstitutions'
        }
        /// <summary>
        /// Test the property 'UninstalledPlugins'
        /// </summary>
        [Test]
        public void UninstalledPluginsTest()
        {
            // TODO unit test for the property 'UninstalledPlugins'
        }
        /// <summary>
        /// Test the property 'EnableSlowResponseWarning'
        /// </summary>
        [Test]
        public void EnableSlowResponseWarningTest()
        {
            // TODO unit test for the property 'EnableSlowResponseWarning'
        }
        /// <summary>
        /// Test the property 'SlowResponseThresholdMs'
        /// </summary>
        [Test]
        public void SlowResponseThresholdMsTest()
        {
            // TODO unit test for the property 'SlowResponseThresholdMs'
        }
        /// <summary>
        /// Test the property 'CorsHosts'
        /// </summary>
        [Test]
        public void CorsHostsTest()
        {
            // TODO unit test for the property 'CorsHosts'
        }
        /// <summary>
        /// Test the property 'KnownProxies'
        /// </summary>
        [Test]
        public void KnownProxiesTest()
        {
            // TODO unit test for the property 'KnownProxies'
        }
        /// <summary>
        /// Test the property 'ActivityLogRetentionDays'
        /// </summary>
        [Test]
        public void ActivityLogRetentionDaysTest()
        {
            // TODO unit test for the property 'ActivityLogRetentionDays'
        }
        /// <summary>
        /// Test the property 'LibraryScanFanoutConcurrency'
        /// </summary>
        [Test]
        public void LibraryScanFanoutConcurrencyTest()
        {
            // TODO unit test for the property 'LibraryScanFanoutConcurrency'
        }
        /// <summary>
        /// Test the property 'LibraryMetadataRefreshConcurrency'
        /// </summary>
        [Test]
        public void LibraryMetadataRefreshConcurrencyTest()
        {
            // TODO unit test for the property 'LibraryMetadataRefreshConcurrency'
        }
        /// <summary>
        /// Test the property 'RemoveOldPlugins'
        /// </summary>
        [Test]
        public void RemoveOldPluginsTest()
        {
            // TODO unit test for the property 'RemoveOldPlugins'
        }

    }

}
