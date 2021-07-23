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
    ///  Class for testing UserPolicy
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserPolicyTests
    {
        // TODO uncomment below to declare an instance variable for UserPolicy
        //private UserPolicy instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UserPolicy
            //instance = new UserPolicy();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserPolicy
        /// </summary>
        [Test]
        public void UserPolicyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" UserPolicy
            //Assert.IsInstanceOf(typeof(UserPolicy), instance);
        }


        /// <summary>
        /// Test the property 'IsAdministrator'
        /// </summary>
        [Test]
        public void IsAdministratorTest()
        {
            // TODO unit test for the property 'IsAdministrator'
        }
        /// <summary>
        /// Test the property 'IsHidden'
        /// </summary>
        [Test]
        public void IsHiddenTest()
        {
            // TODO unit test for the property 'IsHidden'
        }
        /// <summary>
        /// Test the property 'IsDisabled'
        /// </summary>
        [Test]
        public void IsDisabledTest()
        {
            // TODO unit test for the property 'IsDisabled'
        }
        /// <summary>
        /// Test the property 'MaxParentalRating'
        /// </summary>
        [Test]
        public void MaxParentalRatingTest()
        {
            // TODO unit test for the property 'MaxParentalRating'
        }
        /// <summary>
        /// Test the property 'BlockedTags'
        /// </summary>
        [Test]
        public void BlockedTagsTest()
        {
            // TODO unit test for the property 'BlockedTags'
        }
        /// <summary>
        /// Test the property 'EnableUserPreferenceAccess'
        /// </summary>
        [Test]
        public void EnableUserPreferenceAccessTest()
        {
            // TODO unit test for the property 'EnableUserPreferenceAccess'
        }
        /// <summary>
        /// Test the property 'AccessSchedules'
        /// </summary>
        [Test]
        public void AccessSchedulesTest()
        {
            // TODO unit test for the property 'AccessSchedules'
        }
        /// <summary>
        /// Test the property 'BlockUnratedItems'
        /// </summary>
        [Test]
        public void BlockUnratedItemsTest()
        {
            // TODO unit test for the property 'BlockUnratedItems'
        }
        /// <summary>
        /// Test the property 'EnableRemoteControlOfOtherUsers'
        /// </summary>
        [Test]
        public void EnableRemoteControlOfOtherUsersTest()
        {
            // TODO unit test for the property 'EnableRemoteControlOfOtherUsers'
        }
        /// <summary>
        /// Test the property 'EnableSharedDeviceControl'
        /// </summary>
        [Test]
        public void EnableSharedDeviceControlTest()
        {
            // TODO unit test for the property 'EnableSharedDeviceControl'
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
        /// Test the property 'EnableLiveTvManagement'
        /// </summary>
        [Test]
        public void EnableLiveTvManagementTest()
        {
            // TODO unit test for the property 'EnableLiveTvManagement'
        }
        /// <summary>
        /// Test the property 'EnableLiveTvAccess'
        /// </summary>
        [Test]
        public void EnableLiveTvAccessTest()
        {
            // TODO unit test for the property 'EnableLiveTvAccess'
        }
        /// <summary>
        /// Test the property 'EnableMediaPlayback'
        /// </summary>
        [Test]
        public void EnableMediaPlaybackTest()
        {
            // TODO unit test for the property 'EnableMediaPlayback'
        }
        /// <summary>
        /// Test the property 'EnableAudioPlaybackTranscoding'
        /// </summary>
        [Test]
        public void EnableAudioPlaybackTranscodingTest()
        {
            // TODO unit test for the property 'EnableAudioPlaybackTranscoding'
        }
        /// <summary>
        /// Test the property 'EnableVideoPlaybackTranscoding'
        /// </summary>
        [Test]
        public void EnableVideoPlaybackTranscodingTest()
        {
            // TODO unit test for the property 'EnableVideoPlaybackTranscoding'
        }
        /// <summary>
        /// Test the property 'EnablePlaybackRemuxing'
        /// </summary>
        [Test]
        public void EnablePlaybackRemuxingTest()
        {
            // TODO unit test for the property 'EnablePlaybackRemuxing'
        }
        /// <summary>
        /// Test the property 'ForceRemoteSourceTranscoding'
        /// </summary>
        [Test]
        public void ForceRemoteSourceTranscodingTest()
        {
            // TODO unit test for the property 'ForceRemoteSourceTranscoding'
        }
        /// <summary>
        /// Test the property 'EnableContentDeletion'
        /// </summary>
        [Test]
        public void EnableContentDeletionTest()
        {
            // TODO unit test for the property 'EnableContentDeletion'
        }
        /// <summary>
        /// Test the property 'EnableContentDeletionFromFolders'
        /// </summary>
        [Test]
        public void EnableContentDeletionFromFoldersTest()
        {
            // TODO unit test for the property 'EnableContentDeletionFromFolders'
        }
        /// <summary>
        /// Test the property 'EnableContentDownloading'
        /// </summary>
        [Test]
        public void EnableContentDownloadingTest()
        {
            // TODO unit test for the property 'EnableContentDownloading'
        }
        /// <summary>
        /// Test the property 'EnableSyncTranscoding'
        /// </summary>
        [Test]
        public void EnableSyncTranscodingTest()
        {
            // TODO unit test for the property 'EnableSyncTranscoding'
        }
        /// <summary>
        /// Test the property 'EnableMediaConversion'
        /// </summary>
        [Test]
        public void EnableMediaConversionTest()
        {
            // TODO unit test for the property 'EnableMediaConversion'
        }
        /// <summary>
        /// Test the property 'EnabledDevices'
        /// </summary>
        [Test]
        public void EnabledDevicesTest()
        {
            // TODO unit test for the property 'EnabledDevices'
        }
        /// <summary>
        /// Test the property 'EnableAllDevices'
        /// </summary>
        [Test]
        public void EnableAllDevicesTest()
        {
            // TODO unit test for the property 'EnableAllDevices'
        }
        /// <summary>
        /// Test the property 'EnabledChannels'
        /// </summary>
        [Test]
        public void EnabledChannelsTest()
        {
            // TODO unit test for the property 'EnabledChannels'
        }
        /// <summary>
        /// Test the property 'EnableAllChannels'
        /// </summary>
        [Test]
        public void EnableAllChannelsTest()
        {
            // TODO unit test for the property 'EnableAllChannels'
        }
        /// <summary>
        /// Test the property 'EnabledFolders'
        /// </summary>
        [Test]
        public void EnabledFoldersTest()
        {
            // TODO unit test for the property 'EnabledFolders'
        }
        /// <summary>
        /// Test the property 'EnableAllFolders'
        /// </summary>
        [Test]
        public void EnableAllFoldersTest()
        {
            // TODO unit test for the property 'EnableAllFolders'
        }
        /// <summary>
        /// Test the property 'InvalidLoginAttemptCount'
        /// </summary>
        [Test]
        public void InvalidLoginAttemptCountTest()
        {
            // TODO unit test for the property 'InvalidLoginAttemptCount'
        }
        /// <summary>
        /// Test the property 'LoginAttemptsBeforeLockout'
        /// </summary>
        [Test]
        public void LoginAttemptsBeforeLockoutTest()
        {
            // TODO unit test for the property 'LoginAttemptsBeforeLockout'
        }
        /// <summary>
        /// Test the property 'MaxActiveSessions'
        /// </summary>
        [Test]
        public void MaxActiveSessionsTest()
        {
            // TODO unit test for the property 'MaxActiveSessions'
        }
        /// <summary>
        /// Test the property 'EnablePublicSharing'
        /// </summary>
        [Test]
        public void EnablePublicSharingTest()
        {
            // TODO unit test for the property 'EnablePublicSharing'
        }
        /// <summary>
        /// Test the property 'BlockedMediaFolders'
        /// </summary>
        [Test]
        public void BlockedMediaFoldersTest()
        {
            // TODO unit test for the property 'BlockedMediaFolders'
        }
        /// <summary>
        /// Test the property 'BlockedChannels'
        /// </summary>
        [Test]
        public void BlockedChannelsTest()
        {
            // TODO unit test for the property 'BlockedChannels'
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
        /// Test the property 'AuthenticationProviderId'
        /// </summary>
        [Test]
        public void AuthenticationProviderIdTest()
        {
            // TODO unit test for the property 'AuthenticationProviderId'
        }
        /// <summary>
        /// Test the property 'PasswordResetProviderId'
        /// </summary>
        [Test]
        public void PasswordResetProviderIdTest()
        {
            // TODO unit test for the property 'PasswordResetProviderId'
        }
        /// <summary>
        /// Test the property 'SyncPlayAccess'
        /// </summary>
        [Test]
        public void SyncPlayAccessTest()
        {
            // TODO unit test for the property 'SyncPlayAccess'
        }

    }

}
