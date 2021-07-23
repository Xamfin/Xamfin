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
    ///  Class for testing ApiKeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApiKeyApiTests
    {
        private ApiKeyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ApiKeyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApiKeyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ApiKeyApi
            //Assert.IsInstanceOf(typeof(ApiKeyApi), instance);
        }

        
        /// <summary>
        /// Test CreateKey
        /// </summary>
        [Test]
        public void CreateKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string app = null;
            //instance.CreateKey(app);
            
        }
        
        /// <summary>
        /// Test GetKeys
        /// </summary>
        [Test]
        public void GetKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetKeys();
            //Assert.IsInstanceOf(typeof(AuthenticationInfoQueryResult), response, "response is AuthenticationInfoQueryResult");
        }
        
        /// <summary>
        /// Test RevokeKey
        /// </summary>
        [Test]
        public void RevokeKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //instance.RevokeKey(key);
            
        }
        
    }

}
