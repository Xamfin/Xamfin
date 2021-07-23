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
    ///  Class for testing SeriesTimerInfoDto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SeriesTimerInfoDtoTests
    {
        // TODO uncomment below to declare an instance variable for SeriesTimerInfoDto
        //private SeriesTimerInfoDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SeriesTimerInfoDto
            //instance = new SeriesTimerInfoDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SeriesTimerInfoDto
        /// </summary>
        [Test]
        public void SeriesTimerInfoDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" SeriesTimerInfoDto
            //Assert.IsInstanceOf(typeof(SeriesTimerInfoDto), instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'ServerId'
        /// </summary>
        [Test]
        public void ServerIdTest()
        {
            // TODO unit test for the property 'ServerId'
        }
        /// <summary>
        /// Test the property 'ExternalId'
        /// </summary>
        [Test]
        public void ExternalIdTest()
        {
            // TODO unit test for the property 'ExternalId'
        }
        /// <summary>
        /// Test the property 'ChannelId'
        /// </summary>
        [Test]
        public void ChannelIdTest()
        {
            // TODO unit test for the property 'ChannelId'
        }
        /// <summary>
        /// Test the property 'ExternalChannelId'
        /// </summary>
        [Test]
        public void ExternalChannelIdTest()
        {
            // TODO unit test for the property 'ExternalChannelId'
        }
        /// <summary>
        /// Test the property 'ChannelName'
        /// </summary>
        [Test]
        public void ChannelNameTest()
        {
            // TODO unit test for the property 'ChannelName'
        }
        /// <summary>
        /// Test the property 'ChannelPrimaryImageTag'
        /// </summary>
        [Test]
        public void ChannelPrimaryImageTagTest()
        {
            // TODO unit test for the property 'ChannelPrimaryImageTag'
        }
        /// <summary>
        /// Test the property 'ProgramId'
        /// </summary>
        [Test]
        public void ProgramIdTest()
        {
            // TODO unit test for the property 'ProgramId'
        }
        /// <summary>
        /// Test the property 'ExternalProgramId'
        /// </summary>
        [Test]
        public void ExternalProgramIdTest()
        {
            // TODO unit test for the property 'ExternalProgramId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Overview'
        /// </summary>
        [Test]
        public void OverviewTest()
        {
            // TODO unit test for the property 'Overview'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'ServiceName'
        /// </summary>
        [Test]
        public void ServiceNameTest()
        {
            // TODO unit test for the property 'ServiceName'
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Test]
        public void PriorityTest()
        {
            // TODO unit test for the property 'Priority'
        }
        /// <summary>
        /// Test the property 'PrePaddingSeconds'
        /// </summary>
        [Test]
        public void PrePaddingSecondsTest()
        {
            // TODO unit test for the property 'PrePaddingSeconds'
        }
        /// <summary>
        /// Test the property 'PostPaddingSeconds'
        /// </summary>
        [Test]
        public void PostPaddingSecondsTest()
        {
            // TODO unit test for the property 'PostPaddingSeconds'
        }
        /// <summary>
        /// Test the property 'IsPrePaddingRequired'
        /// </summary>
        [Test]
        public void IsPrePaddingRequiredTest()
        {
            // TODO unit test for the property 'IsPrePaddingRequired'
        }
        /// <summary>
        /// Test the property 'ParentBackdropItemId'
        /// </summary>
        [Test]
        public void ParentBackdropItemIdTest()
        {
            // TODO unit test for the property 'ParentBackdropItemId'
        }
        /// <summary>
        /// Test the property 'ParentBackdropImageTags'
        /// </summary>
        [Test]
        public void ParentBackdropImageTagsTest()
        {
            // TODO unit test for the property 'ParentBackdropImageTags'
        }
        /// <summary>
        /// Test the property 'IsPostPaddingRequired'
        /// </summary>
        [Test]
        public void IsPostPaddingRequiredTest()
        {
            // TODO unit test for the property 'IsPostPaddingRequired'
        }
        /// <summary>
        /// Test the property 'KeepUntil'
        /// </summary>
        [Test]
        public void KeepUntilTest()
        {
            // TODO unit test for the property 'KeepUntil'
        }
        /// <summary>
        /// Test the property 'RecordAnyTime'
        /// </summary>
        [Test]
        public void RecordAnyTimeTest()
        {
            // TODO unit test for the property 'RecordAnyTime'
        }
        /// <summary>
        /// Test the property 'SkipEpisodesInLibrary'
        /// </summary>
        [Test]
        public void SkipEpisodesInLibraryTest()
        {
            // TODO unit test for the property 'SkipEpisodesInLibrary'
        }
        /// <summary>
        /// Test the property 'RecordAnyChannel'
        /// </summary>
        [Test]
        public void RecordAnyChannelTest()
        {
            // TODO unit test for the property 'RecordAnyChannel'
        }
        /// <summary>
        /// Test the property 'KeepUpTo'
        /// </summary>
        [Test]
        public void KeepUpToTest()
        {
            // TODO unit test for the property 'KeepUpTo'
        }
        /// <summary>
        /// Test the property 'RecordNewOnly'
        /// </summary>
        [Test]
        public void RecordNewOnlyTest()
        {
            // TODO unit test for the property 'RecordNewOnly'
        }
        /// <summary>
        /// Test the property 'Days'
        /// </summary>
        [Test]
        public void DaysTest()
        {
            // TODO unit test for the property 'Days'
        }
        /// <summary>
        /// Test the property 'DayPattern'
        /// </summary>
        [Test]
        public void DayPatternTest()
        {
            // TODO unit test for the property 'DayPattern'
        }
        /// <summary>
        /// Test the property 'ImageTags'
        /// </summary>
        [Test]
        public void ImageTagsTest()
        {
            // TODO unit test for the property 'ImageTags'
        }
        /// <summary>
        /// Test the property 'ParentThumbItemId'
        /// </summary>
        [Test]
        public void ParentThumbItemIdTest()
        {
            // TODO unit test for the property 'ParentThumbItemId'
        }
        /// <summary>
        /// Test the property 'ParentThumbImageTag'
        /// </summary>
        [Test]
        public void ParentThumbImageTagTest()
        {
            // TODO unit test for the property 'ParentThumbImageTag'
        }
        /// <summary>
        /// Test the property 'ParentPrimaryImageItemId'
        /// </summary>
        [Test]
        public void ParentPrimaryImageItemIdTest()
        {
            // TODO unit test for the property 'ParentPrimaryImageItemId'
        }
        /// <summary>
        /// Test the property 'ParentPrimaryImageTag'
        /// </summary>
        [Test]
        public void ParentPrimaryImageTagTest()
        {
            // TODO unit test for the property 'ParentPrimaryImageTag'
        }

    }

}
