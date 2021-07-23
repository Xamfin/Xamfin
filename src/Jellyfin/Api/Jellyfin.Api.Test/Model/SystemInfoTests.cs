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
    ///  Class for testing SystemInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SystemInfoTests
    {
        // TODO uncomment below to declare an instance variable for SystemInfo
        //private SystemInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SystemInfo
            //instance = new SystemInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SystemInfo
        /// </summary>
        [Test]
        public void SystemInfoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" SystemInfo
            //Assert.IsInstanceOf(typeof(SystemInfo), instance);
        }


        /// <summary>
        /// Test the property 'LocalAddress'
        /// </summary>
        [Test]
        public void LocalAddressTest()
        {
            // TODO unit test for the property 'LocalAddress'
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
        /// Test the property 'Version'
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO unit test for the property 'Version'
        }
        /// <summary>
        /// Test the property 'ProductName'
        /// </summary>
        [Test]
        public void ProductNameTest()
        {
            // TODO unit test for the property 'ProductName'
        }
        /// <summary>
        /// Test the property 'OperatingSystem'
        /// </summary>
        [Test]
        public void OperatingSystemTest()
        {
            // TODO unit test for the property 'OperatingSystem'
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
        /// Test the property 'StartupWizardCompleted'
        /// </summary>
        [Test]
        public void StartupWizardCompletedTest()
        {
            // TODO unit test for the property 'StartupWizardCompleted'
        }
        /// <summary>
        /// Test the property 'OperatingSystemDisplayName'
        /// </summary>
        [Test]
        public void OperatingSystemDisplayNameTest()
        {
            // TODO unit test for the property 'OperatingSystemDisplayName'
        }
        /// <summary>
        /// Test the property 'PackageName'
        /// </summary>
        [Test]
        public void PackageNameTest()
        {
            // TODO unit test for the property 'PackageName'
        }
        /// <summary>
        /// Test the property 'HasPendingRestart'
        /// </summary>
        [Test]
        public void HasPendingRestartTest()
        {
            // TODO unit test for the property 'HasPendingRestart'
        }
        /// <summary>
        /// Test the property 'IsShuttingDown'
        /// </summary>
        [Test]
        public void IsShuttingDownTest()
        {
            // TODO unit test for the property 'IsShuttingDown'
        }
        /// <summary>
        /// Test the property 'SupportsLibraryMonitor'
        /// </summary>
        [Test]
        public void SupportsLibraryMonitorTest()
        {
            // TODO unit test for the property 'SupportsLibraryMonitor'
        }
        /// <summary>
        /// Test the property 'WebSocketPortNumber'
        /// </summary>
        [Test]
        public void WebSocketPortNumberTest()
        {
            // TODO unit test for the property 'WebSocketPortNumber'
        }
        /// <summary>
        /// Test the property 'CompletedInstallations'
        /// </summary>
        [Test]
        public void CompletedInstallationsTest()
        {
            // TODO unit test for the property 'CompletedInstallations'
        }
        /// <summary>
        /// Test the property 'CanSelfRestart'
        /// </summary>
        [Test]
        public void CanSelfRestartTest()
        {
            // TODO unit test for the property 'CanSelfRestart'
        }
        /// <summary>
        /// Test the property 'CanLaunchWebBrowser'
        /// </summary>
        [Test]
        public void CanLaunchWebBrowserTest()
        {
            // TODO unit test for the property 'CanLaunchWebBrowser'
        }
        /// <summary>
        /// Test the property 'ProgramDataPath'
        /// </summary>
        [Test]
        public void ProgramDataPathTest()
        {
            // TODO unit test for the property 'ProgramDataPath'
        }
        /// <summary>
        /// Test the property 'WebPath'
        /// </summary>
        [Test]
        public void WebPathTest()
        {
            // TODO unit test for the property 'WebPath'
        }
        /// <summary>
        /// Test the property 'ItemsByNamePath'
        /// </summary>
        [Test]
        public void ItemsByNamePathTest()
        {
            // TODO unit test for the property 'ItemsByNamePath'
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
        /// Test the property 'LogPath'
        /// </summary>
        [Test]
        public void LogPathTest()
        {
            // TODO unit test for the property 'LogPath'
        }
        /// <summary>
        /// Test the property 'InternalMetadataPath'
        /// </summary>
        [Test]
        public void InternalMetadataPathTest()
        {
            // TODO unit test for the property 'InternalMetadataPath'
        }
        /// <summary>
        /// Test the property 'TranscodingTempPath'
        /// </summary>
        [Test]
        public void TranscodingTempPathTest()
        {
            // TODO unit test for the property 'TranscodingTempPath'
        }
        /// <summary>
        /// Test the property 'HasUpdateAvailable'
        /// </summary>
        [Test]
        public void HasUpdateAvailableTest()
        {
            // TODO unit test for the property 'HasUpdateAvailable'
        }
        /// <summary>
        /// Test the property 'EncoderLocation'
        /// </summary>
        [Test]
        public void EncoderLocationTest()
        {
            // TODO unit test for the property 'EncoderLocation'
        }
        /// <summary>
        /// Test the property 'SystemArchitecture'
        /// </summary>
        [Test]
        public void SystemArchitectureTest()
        {
            // TODO unit test for the property 'SystemArchitecture'
        }

    }

}
