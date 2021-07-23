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
    ///  Class for testing SessionInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SessionInfoTests
    {
        // TODO uncomment below to declare an instance variable for SessionInfo
        //private SessionInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SessionInfo
            //instance = new SessionInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SessionInfo
        /// </summary>
        [Test]
        public void SessionInfoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" SessionInfo
            //Assert.IsInstanceOf(typeof(SessionInfo), instance);
        }


        /// <summary>
        /// Test the property 'PlayState'
        /// </summary>
        [Test]
        public void PlayStateTest()
        {
            // TODO unit test for the property 'PlayState'
        }
        /// <summary>
        /// Test the property 'AdditionalUsers'
        /// </summary>
        [Test]
        public void AdditionalUsersTest()
        {
            // TODO unit test for the property 'AdditionalUsers'
        }
        /// <summary>
        /// Test the property 'Capabilities'
        /// </summary>
        [Test]
        public void CapabilitiesTest()
        {
            // TODO unit test for the property 'Capabilities'
        }
        /// <summary>
        /// Test the property 'RemoteEndPoint'
        /// </summary>
        [Test]
        public void RemoteEndPointTest()
        {
            // TODO unit test for the property 'RemoteEndPoint'
        }
        /// <summary>
        /// Test the property 'PlayableMediaTypes'
        /// </summary>
        [Test]
        public void PlayableMediaTypesTest()
        {
            // TODO unit test for the property 'PlayableMediaTypes'
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
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Test]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }
        /// <summary>
        /// Test the property '_Client'
        /// </summary>
        [Test]
        public void _ClientTest()
        {
            // TODO unit test for the property '_Client'
        }
        /// <summary>
        /// Test the property 'LastActivityDate'
        /// </summary>
        [Test]
        public void LastActivityDateTest()
        {
            // TODO unit test for the property 'LastActivityDate'
        }
        /// <summary>
        /// Test the property 'LastPlaybackCheckIn'
        /// </summary>
        [Test]
        public void LastPlaybackCheckInTest()
        {
            // TODO unit test for the property 'LastPlaybackCheckIn'
        }
        /// <summary>
        /// Test the property 'DeviceName'
        /// </summary>
        [Test]
        public void DeviceNameTest()
        {
            // TODO unit test for the property 'DeviceName'
        }
        /// <summary>
        /// Test the property 'DeviceType'
        /// </summary>
        [Test]
        public void DeviceTypeTest()
        {
            // TODO unit test for the property 'DeviceType'
        }
        /// <summary>
        /// Test the property 'NowPlayingItem'
        /// </summary>
        [Test]
        public void NowPlayingItemTest()
        {
            // TODO unit test for the property 'NowPlayingItem'
        }
        /// <summary>
        /// Test the property 'FullNowPlayingItem'
        /// </summary>
        [Test]
        public void FullNowPlayingItemTest()
        {
            // TODO unit test for the property 'FullNowPlayingItem'
        }
        /// <summary>
        /// Test the property 'NowViewingItem'
        /// </summary>
        [Test]
        public void NowViewingItemTest()
        {
            // TODO unit test for the property 'NowViewingItem'
        }
        /// <summary>
        /// Test the property 'DeviceId'
        /// </summary>
        [Test]
        public void DeviceIdTest()
        {
            // TODO unit test for the property 'DeviceId'
        }
        /// <summary>
        /// Test the property 'ApplicationVersion'
        /// </summary>
        [Test]
        public void ApplicationVersionTest()
        {
            // TODO unit test for the property 'ApplicationVersion'
        }
        /// <summary>
        /// Test the property 'TranscodingInfo'
        /// </summary>
        [Test]
        public void TranscodingInfoTest()
        {
            // TODO unit test for the property 'TranscodingInfo'
        }
        /// <summary>
        /// Test the property 'IsActive'
        /// </summary>
        [Test]
        public void IsActiveTest()
        {
            // TODO unit test for the property 'IsActive'
        }
        /// <summary>
        /// Test the property 'SupportsMediaControl'
        /// </summary>
        [Test]
        public void SupportsMediaControlTest()
        {
            // TODO unit test for the property 'SupportsMediaControl'
        }
        /// <summary>
        /// Test the property 'SupportsRemoteControl'
        /// </summary>
        [Test]
        public void SupportsRemoteControlTest()
        {
            // TODO unit test for the property 'SupportsRemoteControl'
        }
        /// <summary>
        /// Test the property 'NowPlayingQueue'
        /// </summary>
        [Test]
        public void NowPlayingQueueTest()
        {
            // TODO unit test for the property 'NowPlayingQueue'
        }
        /// <summary>
        /// Test the property 'HasCustomDeviceName'
        /// </summary>
        [Test]
        public void HasCustomDeviceNameTest()
        {
            // TODO unit test for the property 'HasCustomDeviceName'
        }
        /// <summary>
        /// Test the property 'PlaylistItemId'
        /// </summary>
        [Test]
        public void PlaylistItemIdTest()
        {
            // TODO unit test for the property 'PlaylistItemId'
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
        /// Test the property 'UserPrimaryImageTag'
        /// </summary>
        [Test]
        public void UserPrimaryImageTagTest()
        {
            // TODO unit test for the property 'UserPrimaryImageTag'
        }
        /// <summary>
        /// Test the property 'SupportedCommands'
        /// </summary>
        [Test]
        public void SupportedCommandsTest()
        {
            // TODO unit test for the property 'SupportedCommands'
        }

    }

}