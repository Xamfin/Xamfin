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
    ///  Class for testing TrailersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TrailersApiTests
    {
        private TrailersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TrailersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TrailersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TrailersApi
            //Assert.IsInstanceOf(typeof(TrailersApi), instance);
        }

        
        /// <summary>
        /// Test GetTrailers
        /// </summary>
        [Test]
        public void GetTrailersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //string maxOfficialRating = null;
            //bool? hasThemeSong = null;
            //bool? hasThemeVideo = null;
            //bool? hasSubtitles = null;
            //bool? hasSpecialFeature = null;
            //bool? hasTrailer = null;
            //string adjacentTo = null;
            //int? parentIndexNumber = null;
            //bool? hasParentalRating = null;
            //bool? isHd = null;
            //bool? is4K = null;
            //List<LocationType> locationTypes = null;
            //List<LocationType> excludeLocationTypes = null;
            //bool? isMissing = null;
            //bool? isUnaired = null;
            //double? minCommunityRating = null;
            //double? minCriticRating = null;
            //DateTime? minPremiereDate = null;
            //DateTime? minDateLastSaved = null;
            //DateTime? minDateLastSavedForUser = null;
            //DateTime? maxPremiereDate = null;
            //bool? hasOverview = null;
            //bool? hasImdbId = null;
            //bool? hasTmdbId = null;
            //bool? hasTvdbId = null;
            //List<Guid> excludeItemIds = null;
            //int? startIndex = null;
            //int? limit = null;
            //bool? recursive = null;
            //string searchTerm = null;
            //List<SortOrder> sortOrder = null;
            //Guid? parentId = null;
            //List<ItemFields> fields = null;
            //List<string> excludeItemTypes = null;
            //List<ItemFilter> filters = null;
            //bool? isFavorite = null;
            //List<string> mediaTypes = null;
            //List<ImageType> imageTypes = null;
            //List<string> sortBy = null;
            //bool? isPlayed = null;
            //List<string> genres = null;
            //List<string> officialRatings = null;
            //List<string> tags = null;
            //List<int> years = null;
            //bool? enableUserData = null;
            //int? imageTypeLimit = null;
            //List<ImageType> enableImageTypes = null;
            //string person = null;
            //List<Guid> personIds = null;
            //List<string> personTypes = null;
            //List<string> studios = null;
            //List<string> artists = null;
            //List<Guid> excludeArtistIds = null;
            //List<Guid> artistIds = null;
            //List<Guid> albumArtistIds = null;
            //List<Guid> contributingArtistIds = null;
            //List<string> albums = null;
            //List<Guid> albumIds = null;
            //List<Guid> ids = null;
            //List<VideoType> videoTypes = null;
            //string minOfficialRating = null;
            //bool? isLocked = null;
            //bool? isPlaceHolder = null;
            //bool? hasOfficialRating = null;
            //bool? collapseBoxSetItems = null;
            //int? minWidth = null;
            //int? minHeight = null;
            //int? maxWidth = null;
            //int? maxHeight = null;
            //bool? is3D = null;
            //List<SeriesStatus> seriesStatus = null;
            //string nameStartsWithOrGreater = null;
            //string nameStartsWith = null;
            //string nameLessThan = null;
            //List<Guid> studioIds = null;
            //List<Guid> genreIds = null;
            //bool? enableTotalRecordCount = null;
            //bool? enableImages = null;
            //var response = instance.GetTrailers(userId, maxOfficialRating, hasThemeSong, hasThemeVideo, hasSubtitles, hasSpecialFeature, hasTrailer, adjacentTo, parentIndexNumber, hasParentalRating, isHd, is4K, locationTypes, excludeLocationTypes, isMissing, isUnaired, minCommunityRating, minCriticRating, minPremiereDate, minDateLastSaved, minDateLastSavedForUser, maxPremiereDate, hasOverview, hasImdbId, hasTmdbId, hasTvdbId, excludeItemIds, startIndex, limit, recursive, searchTerm, sortOrder, parentId, fields, excludeItemTypes, filters, isFavorite, mediaTypes, imageTypes, sortBy, isPlayed, genres, officialRatings, tags, years, enableUserData, imageTypeLimit, enableImageTypes, person, personIds, personTypes, studios, artists, excludeArtistIds, artistIds, albumArtistIds, contributingArtistIds, albums, albumIds, ids, videoTypes, minOfficialRating, isLocked, isPlaceHolder, hasOfficialRating, collapseBoxSetItems, minWidth, minHeight, maxWidth, maxHeight, is3D, seriesStatus, nameStartsWithOrGreater, nameStartsWith, nameLessThan, studioIds, genreIds, enableTotalRecordCount, enableImages);
            //Assert.IsInstanceOf(typeof(BaseItemDtoQueryResult), response, "response is BaseItemDtoQueryResult");
        }
        
    }

}
