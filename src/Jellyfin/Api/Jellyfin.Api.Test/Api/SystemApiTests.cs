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
    ///  Class for testing SystemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SystemApiTests
    {
        private SystemApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SystemApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SystemApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' SystemApi
            //Assert.IsInstanceOf(typeof(SystemApi), instance);
        }

        
        /// <summary>
        /// Test GetEndpointInfo
        /// </summary>
        [Test]
        public void GetEndpointInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEndpointInfo();
            //Assert.IsInstanceOf(typeof(EndPointInfo), response, "response is EndPointInfo");
        }
        
        /// <summary>
        /// Test GetLogFile
        /// </summary>
        [Test]
        public void GetLogFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetLogFile(name);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetPingSystem
        /// </summary>
        [Test]
        public void GetPingSystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPingSystem();
            //Assert.IsInstanceOf(typeof(string), response, "response is string");
        }
        
        /// <summary>
        /// Test GetPublicSystemInfo
        /// </summary>
        [Test]
        public void GetPublicSystemInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPublicSystemInfo();
            //Assert.IsInstanceOf(typeof(PublicSystemInfo), response, "response is PublicSystemInfo");
        }
        
        /// <summary>
        /// Test GetServerLogs
        /// </summary>
        [Test]
        public void GetServerLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetServerLogs();
            //Assert.IsInstanceOf(typeof(List<LogFile>), response, "response is List<LogFile>");
        }
        
        /// <summary>
        /// Test GetSystemInfo
        /// </summary>
        [Test]
        public void GetSystemInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSystemInfo();
            //Assert.IsInstanceOf(typeof(SystemInfo), response, "response is SystemInfo");
        }
        
        /// <summary>
        /// Test GetWakeOnLanInfo
        /// </summary>
        [Test]
        public void GetWakeOnLanInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWakeOnLanInfo();
            //Assert.IsInstanceOf(typeof(List<WakeOnLanInfo>), response, "response is List<WakeOnLanInfo>");
        }
        
        /// <summary>
        /// Test PostPingSystem
        /// </summary>
        [Test]
        public void PostPingSystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PostPingSystem();
            //Assert.IsInstanceOf(typeof(string), response, "response is string");
        }
        
        /// <summary>
        /// Test RestartApplication
        /// </summary>
        [Test]
        public void RestartApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.RestartApplication();
            
        }
        
        /// <summary>
        /// Test ShutdownApplication
        /// </summary>
        [Test]
        public void ShutdownApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ShutdownApplication();
            
        }
        
    }

}
