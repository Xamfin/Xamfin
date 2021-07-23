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
    ///  Class for testing HlsSegmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HlsSegmentApiTests
    {
        private HlsSegmentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HlsSegmentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HlsSegmentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' HlsSegmentApi
            //Assert.IsInstanceOf(typeof(HlsSegmentApi), instance);
        }

        
        /// <summary>
        /// Test GetHlsAudioSegmentLegacyAac
        /// </summary>
        [Test]
        public void GetHlsAudioSegmentLegacyAacTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemId = null;
            //string segmentId = null;
            //var response = instance.GetHlsAudioSegmentLegacyAac(itemId, segmentId);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetHlsAudioSegmentLegacyMp3
        /// </summary>
        [Test]
        public void GetHlsAudioSegmentLegacyMp3Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemId = null;
            //string segmentId = null;
            //var response = instance.GetHlsAudioSegmentLegacyMp3(itemId, segmentId);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetHlsPlaylistLegacy
        /// </summary>
        [Test]
        public void GetHlsPlaylistLegacyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemId = null;
            //string playlistId = null;
            //var response = instance.GetHlsPlaylistLegacy(itemId, playlistId);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetHlsVideoSegmentLegacy
        /// </summary>
        [Test]
        public void GetHlsVideoSegmentLegacyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemId = null;
            //string playlistId = null;
            //string segmentId = null;
            //string segmentContainer = null;
            //var response = instance.GetHlsVideoSegmentLegacy(itemId, playlistId, segmentId, segmentContainer);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test StopEncodingProcess
        /// </summary>
        [Test]
        public void StopEncodingProcessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //string playSessionId = null;
            //instance.StopEncodingProcess(deviceId, playSessionId);
            
        }
        
    }

}
