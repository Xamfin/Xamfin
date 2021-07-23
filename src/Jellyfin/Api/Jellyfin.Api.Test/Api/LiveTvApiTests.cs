/*
 * Jellyfin API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 10.7.6
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Jellyfin.Api.Client;
using Jellyfin.Api.Api;
using Jellyfin.Api.Model;

namespace Jellyfin.Api.Test
{
    /// <summary>
    ///  Class for testing LiveTvApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LiveTvApiTests
    {
        private LiveTvApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LiveTvApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LiveTvApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' LiveTvApi
            //Assert.IsInstanceOf(typeof(LiveTvApi), instance);
        }

        
        /// <summary>
        /// Test AddListingProvider
        /// </summary>
        [Test]
        public void AddListingProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pw = null;
            //bool? validateListings = null;
            //bool? validateLogin = null;
            //UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
            //var response = instance.AddListingProvider(pw, validateListings, validateLogin, UNKNOWN_BASE_TYPE);
            //Assert.IsInstanceOf(typeof(ListingsProviderInfo), response, "response is ListingsProviderInfo");
        }
        
        /// <summary>
        /// Test AddTunerHost
        /// </summary>
        [Test]
        public void AddTunerHostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
            //var response = instance.AddTunerHost(UNKNOWN_BASE_TYPE);
            //Assert.IsInstanceOf(typeof(TunerHostInfo), response, "response is TunerHostInfo");
        }
        
        /// <summary>
        /// Test CancelSeriesTimer
        /// </summary>
        [Test]
        public void CancelSeriesTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timerId = null;
            //instance.CancelSeriesTimer(timerId);
            
        }
        
        /// <summary>
        /// Test CancelTimer
        /// </summary>
        [Test]
        public void CancelTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timerId = null;
            //instance.CancelTimer(timerId);
            
        }
        
        /// <summary>
        /// Test CreateSeriesTimer
        /// </summary>
        [Test]
        public void CreateSeriesTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
            //instance.CreateSeriesTimer(UNKNOWN_BASE_TYPE);
            
        }
        
        /// <summary>
        /// Test CreateTimer
        /// </summary>
        [Test]
        public void CreateTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
            //instance.CreateTimer(UNKNOWN_BASE_TYPE);
            
        }
        
        /// <summary>
        /// Test DeleteListingProvider
        /// </summary>
        [Test]
        public void DeleteListingProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteListingProvider(id);
            
        }
        
        /// <summary>
        /// Test DeleteRecording
        /// </summary>
        [Test]
        public void DeleteRecordingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid recordingId = null;
            //instance.DeleteRecording(recordingId);
            
        }
        
        /// <summary>
        /// Test DeleteTunerHost
        /// </summary>
        [Test]
        public void DeleteTunerHostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteTunerHost(id);
            
        }
        
        /// <summary>
        /// Test DiscoverTuners
        /// </summary>
        [Test]
        public void DiscoverTunersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? newDevicesOnly = null;
            //var response = instance.DiscoverTuners(newDevicesOnly);
            //Assert.IsInstanceOf(typeof(List<TunerHostInfo>), response, "response is List<TunerHostInfo>");
        }
        
        /// <summary>
        /// Test DiscvoverTuners
        /// </summary>
        [Test]
        public void DiscvoverTunersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? newDevicesOnly = null;
            //var response = instance.DiscvoverTuners(newDevicesOnly);
            //Assert.IsInstanceOf(typeof(List<TunerHostInfo>), response, "response is List<TunerHostInfo>");
        }
        
        /// <summary>
        /// Test GetChannel
        /// </summary>
        [Test]
        public void GetChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid channelId = null;
            //Guid? userId = null;
            //var response = instance.GetChannel(channelId, userId);
            //Assert.IsInstanceOf(typeof(BaseItemDto), response, "response is BaseItemDto");
        }
        
        /// <summary>
        /// Test GetChannelMappingOptions
        /// </summary>
        [Test]
        public void GetChannelMappingOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //var response = instance.GetChannelMappingOptions(providerId);
            //Assert.IsInstanceOf(typeof(ChannelMappingOptionsDto), response, "response is ChannelMappingOptionsDto");
        }
        
        /// <summary>
        /// Test GetDefaultListingProvider
        /// </summary>
        [Test]
        public void GetDefaultListingProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDefaultListingProvider();
            //Assert.IsInstanceOf(typeof(ListingsProviderInfo), response, "response is ListingsProviderInfo");
        }
        
        /// <summary>
        /// Test GetDefaultTimer
        /// </summary>
        [Test]
        public void GetDefaultTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string programId = null;
            //var response = instance.GetDefaultTimer(programId);
            //Assert.IsInstanceOf(typeof(SeriesTimerInfoDto), response, "response is SeriesTimerInfoDto");
        }
        
        /// <summary>
        /// Test GetGuideInfo
        /// </summary>
        [Test]
        public void GetGuideInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetGuideInfo();
            //Assert.IsInstanceOf(typeof(GuideInfo), response, "response is GuideInfo");
        }
        
        /// <summary>
        /// Test GetLineups
        /// </summary>
        [Test]
        public void GetLineupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string type = null;
            //string location = null;
            //string country = null;
            //var response = instance.GetLineups(id, type, location, country);
            //Assert.IsInstanceOf(typeof(List<NameIdPair>), response, "response is List<NameIdPair>");
        }
        
        /// <summary>
        /// Test GetLiveRecordingFile
        /// </summary>
        [Test]
        public void GetLiveRecordingFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string recordingId = null;
            //var response = instance.GetLiveRecordingFile(recordingId);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetLiveStreamFile
        /// </summary>
        [Test]
        public void GetLiveStreamFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string streamId = null;
            //string container = null;
            //var response = instance.GetLiveStreamFile(streamId, container);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetLiveTvChannels
        /// </summary>
        [Test]
        public void GetLiveTvChannelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChannelType? type = null;
            //Guid? userId = null;
            //int? startIndex = null;
            //bool? isMovie = null;
            //bool? isSeries = null;
            //bool? isNews = null;
            //bool? isKids = null;
            //bool? isSports = null;
            //int? limit = null;
            //bool? isFavorite = null;
            //bool? isLiked = null;
            //bool? isDisliked = null;
            //bool? enableImages = null;
            //int? imageTypeLimit = null;
            //List<ImageType> enableImageTypes = null;
            //List<ItemFields> fields = null;
            //bool? enableUserData = null;
            //List<string> sortBy = null;
            //SortOrder? sortOrder = null;
            //bool? enableFavoriteSorting = null;
            //bool? addCurrentProgram = null;
            //var response = instance.GetLiveTvChannels(type, userId, startIndex, isMovie, isSeries, isNews, isKids, isSports, limit, isFavorite, isLiked, isDisliked, enableImages, imageTypeLimit, enableImageTypes, fields, enableUserData, sortBy, sortOrder, enableFavoriteSorting, addCurrentProgram);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetLiveTvInfo
        /// </summary>
        [Test]
        public void GetLiveTvInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetLiveTvInfo();
            //Assert.IsInstanceOf(typeof(LiveTvInfo), response, "response is LiveTvInfo");
        }
        
        /// <summary>
        /// Test GetLiveTvPrograms
        /// </summary>
        [Test]
        public void GetLiveTvProgramsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid> channelIds = null;
            //Guid? userId = null;
            //DateTime? minStartDate = null;
            //bool? hasAired = null;
            //bool? isAiring = null;
            //DateTime? maxStartDate = null;
            //DateTime? minEndDate = null;
            //DateTime? maxEndDate = null;
            //bool? isMovie = null;
            //bool? isSeries = null;
            //bool? isNews = null;
            //bool? isKids = null;
            //bool? isSports = null;
            //int? startIndex = null;
            //int? limit = null;
            //List<string> sortBy = null;
            //List<SortOrder> sortOrder = null;
            //List<string> genres = null;
            //List<Guid> genreIds = null;
            //bool? enableImages = null;
            //int? imageTypeLimit = null;
            //List<ImageType> enableImageTypes = null;
            //bool? enableUserData = null;
            //string seriesTimerId = null;
            //Guid? librarySeriesId = null;
            //List<ItemFields> fields = null;
            //bool? enableTotalRecordCount = null;
            //var response = instance.GetLiveTvPrograms(channelIds, userId, minStartDate, hasAired, isAiring, maxStartDate, minEndDate, maxEndDate, isMovie, isSeries, isNews, isKids, isSports, startIndex, limit, sortBy, sortOrder, genres, genreIds, enableImages, imageTypeLimit, enableImageTypes, enableUserData, seriesTimerId, librarySeriesId, fields, enableTotalRecordCount);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetProgram
        /// </summary>
        [Test]
        public void GetProgramTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string programId = null;
            //Guid? userId = null;
            //var response = instance.GetProgram(programId, userId);
            //Assert.IsInstanceOf(typeof(BaseItemDto), response, "response is BaseItemDto");
        }
        
        /// <summary>
        /// Test GetPrograms
        /// </summary>
        [Test]
        public void GetProgramsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
            //var response = instance.GetPrograms(UNKNOWN_BASE_TYPE);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetRecommendedPrograms
        /// </summary>
        [Test]
        public void GetRecommendedProgramsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //int? limit = null;
            //bool? isAiring = null;
            //bool? hasAired = null;
            //bool? isSeries = null;
            //bool? isMovie = null;
            //bool? isNews = null;
            //bool? isKids = null;
            //bool? isSports = null;
            //bool? enableImages = null;
            //int? imageTypeLimit = null;
            //List<ImageType> enableImageTypes = null;
            //List<Guid> genreIds = null;
            //List<ItemFields> fields = null;
            //bool? enableUserData = null;
            //bool? enableTotalRecordCount = null;
            //var response = instance.GetRecommendedPrograms(userId, limit, isAiring, hasAired, isSeries, isMovie, isNews, isKids, isSports, enableImages, imageTypeLimit, enableImageTypes, genreIds, fields, enableUserData, enableTotalRecordCount);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetRecording
        /// </summary>
        [Test]
        public void GetRecordingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid recordingId = null;
            //Guid? userId = null;
            //var response = instance.GetRecording(recordingId, userId);
            //Assert.IsInstanceOf(typeof(BaseItemDto), response, "response is BaseItemDto");
        }
        
        /// <summary>
        /// Test GetRecordingFolders
        /// </summary>
        [Test]
        public void GetRecordingFoldersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //var response = instance.GetRecordingFolders(userId);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetRecordingGroup
        /// </summary>
        [Test]
        public void GetRecordingGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid groupId = null;
            //instance.GetRecordingGroup(groupId);
            
        }
        
        /// <summary>
        /// Test GetRecordingGroups
        /// </summary>
        [Test]
        public void GetRecordingGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //var response = instance.GetRecordingGroups(userId);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetRecordings
        /// </summary>
        [Test]
        public void GetRecordingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelId = null;
            //Guid? userId = null;
            //int? startIndex = null;
            //int? limit = null;
            //RecordingStatus? status = null;
            //bool? isInProgress = null;
            //string seriesTimerId = null;
            //bool? enableImages = null;
            //int? imageTypeLimit = null;
            //List<ImageType> enableImageTypes = null;
            //List<ItemFields> fields = null;
            //bool? enableUserData = null;
            //bool? isMovie = null;
            //bool? isSeries = null;
            //bool? isKids = null;
            //bool? isSports = null;
            //bool? isNews = null;
            //bool? isLibraryItem = null;
            //bool? enableTotalRecordCount = null;
            //var response = instance.GetRecordings(channelId, userId, startIndex, limit, status, isInProgress, seriesTimerId, enableImages, imageTypeLimit, enableImageTypes, fields, enableUserData, isMovie, isSeries, isKids, isSports, isNews, isLibraryItem, enableTotalRecordCount);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetRecordingsSeries
        /// </summary>
        [Test]
        public void GetRecordingsSeriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelId = null;
            //Guid? userId = null;
            //string groupId = null;
            //int? startIndex = null;
            //int? limit = null;
            //RecordingStatus? status = null;
            //bool? isInProgress = null;
            //string seriesTimerId = null;
            //bool? enableImages = null;
            //int? imageTypeLimit = null;
            //List<ImageType> enableImageTypes = null;
            //List<ItemFields> fields = null;
            //bool? enableUserData = null;
            //bool? enableTotalRecordCount = null;
            //var response = instance.GetRecordingsSeries(channelId, userId, groupId, startIndex, limit, status, isInProgress, seriesTimerId, enableImages, imageTypeLimit, enableImageTypes, fields, enableUserData, enableTotalRecordCount);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetSchedulesDirectCountries
        /// </summary>
        [Test]
        public void GetSchedulesDirectCountriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSchedulesDirectCountries();
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetSeriesTimer
        /// </summary>
        [Test]
        public void GetSeriesTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timerId = null;
            //var response = instance.GetSeriesTimer(timerId);
            //Assert.IsInstanceOf(typeof(SeriesTimerInfoDto), response, "response is SeriesTimerInfoDto");
        }
        
        /// <summary>
        /// Test GetSeriesTimers
        /// </summary>
        [Test]
        public void GetSeriesTimersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sortBy = null;
            //SortOrder? sortOrder = null;
            //var response = instance.GetSeriesTimers(sortBy, sortOrder);
            //Assert.IsInstanceOf(typeof(SeriesTimerInfoDtoQueryResult), response, "response is SeriesTimerInfoDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetTimer
        /// </summary>
        [Test]
        public void GetTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timerId = null;
            //var response = instance.GetTimer(timerId);
            //Assert.IsInstanceOf(typeof(TimerInfoDto), response, "response is TimerInfoDto");
        }
        
        /// <summary>
        /// Test GetTimers
        /// </summary>
        [Test]
        public void GetTimersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelId = null;
            //string seriesTimerId = null;
            //bool? isActive = null;
            //bool? isScheduled = null;
            //var response = instance.GetTimers(channelId, seriesTimerId, isActive, isScheduled);
            //Assert.IsInstanceOf(typeof(TimerInfoDtoQueryResult), response, "response is TimerInfoDtoQueryResult");
        }
        
        /// <summary>
        /// Test GetTunerHostTypes
        /// </summary>
        [Test]
        public void GetTunerHostTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTunerHostTypes();
            //Assert.IsInstanceOf(typeof(List<NameIdPair>), response, "response is List<NameIdPair>");
        }
        
        /// <summary>
        /// Test ResetTuner
        /// </summary>
        [Test]
        public void ResetTunerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tunerId = null;
            //instance.ResetTuner(tunerId);
            
        }
        
        /// <summary>
        /// Test SetChannelMapping
        /// </summary>
        [Test]
        public void SetChannelMappingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
            //var response = instance.SetChannelMapping(UNKNOWN_BASE_TYPE);
            //Assert.IsInstanceOf(typeof(TunerChannelMapping), response, "response is TunerChannelMapping");
        }
        
        /// <summary>
        /// Test UpdateSeriesTimer
        /// </summary>
        [Test]
        public void UpdateSeriesTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timerId = null;
            //UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
            //instance.UpdateSeriesTimer(timerId, UNKNOWN_BASE_TYPE);
            
        }
        
        /// <summary>
        /// Test UpdateTimer
        /// </summary>
        [Test]
        public void UpdateTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timerId = null;
            //UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
            //instance.UpdateTimer(timerId, UNKNOWN_BASE_TYPE);
            
        }
        
    }

}