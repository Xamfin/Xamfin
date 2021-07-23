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
    ///  Class for testing LibraryOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LibraryOptionsTests
    {
        // TODO uncomment below to declare an instance variable for LibraryOptions
        //private LibraryOptions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LibraryOptions
            //instance = new LibraryOptions();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LibraryOptions
        /// </summary>
        [Test]
        public void LibraryOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" LibraryOptions
            //Assert.IsInstanceOf(typeof(LibraryOptions), instance);
        }


        /// <summary>
        /// Test the property 'EnablePhotos'
        /// </summary>
        [Test]
        public void EnablePhotosTest()
        {
            // TODO unit test for the property 'EnablePhotos'
        }
        /// <summary>
        /// Test the property 'EnableRealtimeMonitor'
        /// </summary>
        [Test]
        public void EnableRealtimeMonitorTest()
        {
            // TODO unit test for the property 'EnableRealtimeMonitor'
        }
        /// <summary>
        /// Test the property 'EnableChapterImageExtraction'
        /// </summary>
        [Test]
        public void EnableChapterImageExtractionTest()
        {
            // TODO unit test for the property 'EnableChapterImageExtraction'
        }
        /// <summary>
        /// Test the property 'ExtractChapterImagesDuringLibraryScan'
        /// </summary>
        [Test]
        public void ExtractChapterImagesDuringLibraryScanTest()
        {
            // TODO unit test for the property 'ExtractChapterImagesDuringLibraryScan'
        }
        /// <summary>
        /// Test the property 'PathInfos'
        /// </summary>
        [Test]
        public void PathInfosTest()
        {
            // TODO unit test for the property 'PathInfos'
        }
        /// <summary>
        /// Test the property 'SaveLocalMetadata'
        /// </summary>
        [Test]
        public void SaveLocalMetadataTest()
        {
            // TODO unit test for the property 'SaveLocalMetadata'
        }
        /// <summary>
        /// Test the property 'EnableInternetProviders'
        /// </summary>
        [Test]
        public void EnableInternetProvidersTest()
        {
            // TODO unit test for the property 'EnableInternetProviders'
        }
        /// <summary>
        /// Test the property 'EnableAutomaticSeriesGrouping'
        /// </summary>
        [Test]
        public void EnableAutomaticSeriesGroupingTest()
        {
            // TODO unit test for the property 'EnableAutomaticSeriesGrouping'
        }
        /// <summary>
        /// Test the property 'EnableEmbeddedTitles'
        /// </summary>
        [Test]
        public void EnableEmbeddedTitlesTest()
        {
            // TODO unit test for the property 'EnableEmbeddedTitles'
        }
        /// <summary>
        /// Test the property 'EnableEmbeddedEpisodeInfos'
        /// </summary>
        [Test]
        public void EnableEmbeddedEpisodeInfosTest()
        {
            // TODO unit test for the property 'EnableEmbeddedEpisodeInfos'
        }
        /// <summary>
        /// Test the property 'AutomaticRefreshIntervalDays'
        /// </summary>
        [Test]
        public void AutomaticRefreshIntervalDaysTest()
        {
            // TODO unit test for the property 'AutomaticRefreshIntervalDays'
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
        /// Test the property 'SeasonZeroDisplayName'
        /// </summary>
        [Test]
        public void SeasonZeroDisplayNameTest()
        {
            // TODO unit test for the property 'SeasonZeroDisplayName'
        }
        /// <summary>
        /// Test the property 'MetadataSavers'
        /// </summary>
        [Test]
        public void MetadataSaversTest()
        {
            // TODO unit test for the property 'MetadataSavers'
        }
        /// <summary>
        /// Test the property 'DisabledLocalMetadataReaders'
        /// </summary>
        [Test]
        public void DisabledLocalMetadataReadersTest()
        {
            // TODO unit test for the property 'DisabledLocalMetadataReaders'
        }
        /// <summary>
        /// Test the property 'LocalMetadataReaderOrder'
        /// </summary>
        [Test]
        public void LocalMetadataReaderOrderTest()
        {
            // TODO unit test for the property 'LocalMetadataReaderOrder'
        }
        /// <summary>
        /// Test the property 'DisabledSubtitleFetchers'
        /// </summary>
        [Test]
        public void DisabledSubtitleFetchersTest()
        {
            // TODO unit test for the property 'DisabledSubtitleFetchers'
        }
        /// <summary>
        /// Test the property 'SubtitleFetcherOrder'
        /// </summary>
        [Test]
        public void SubtitleFetcherOrderTest()
        {
            // TODO unit test for the property 'SubtitleFetcherOrder'
        }
        /// <summary>
        /// Test the property 'SkipSubtitlesIfEmbeddedSubtitlesPresent'
        /// </summary>
        [Test]
        public void SkipSubtitlesIfEmbeddedSubtitlesPresentTest()
        {
            // TODO unit test for the property 'SkipSubtitlesIfEmbeddedSubtitlesPresent'
        }
        /// <summary>
        /// Test the property 'SkipSubtitlesIfAudioTrackMatches'
        /// </summary>
        [Test]
        public void SkipSubtitlesIfAudioTrackMatchesTest()
        {
            // TODO unit test for the property 'SkipSubtitlesIfAudioTrackMatches'
        }
        /// <summary>
        /// Test the property 'SubtitleDownloadLanguages'
        /// </summary>
        [Test]
        public void SubtitleDownloadLanguagesTest()
        {
            // TODO unit test for the property 'SubtitleDownloadLanguages'
        }
        /// <summary>
        /// Test the property 'RequirePerfectSubtitleMatch'
        /// </summary>
        [Test]
        public void RequirePerfectSubtitleMatchTest()
        {
            // TODO unit test for the property 'RequirePerfectSubtitleMatch'
        }
        /// <summary>
        /// Test the property 'SaveSubtitlesWithMedia'
        /// </summary>
        [Test]
        public void SaveSubtitlesWithMediaTest()
        {
            // TODO unit test for the property 'SaveSubtitlesWithMedia'
        }
        /// <summary>
        /// Test the property 'TypeOptions'
        /// </summary>
        [Test]
        public void TypeOptionsTest()
        {
            // TODO unit test for the property 'TypeOptions'
        }

    }

}