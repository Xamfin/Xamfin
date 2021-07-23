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
    ///  Class for testing RemoteImageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RemoteImageApiTests
    {
        private RemoteImageApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RemoteImageApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RemoteImageApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' RemoteImageApi
            //Assert.IsInstanceOf(typeof(RemoteImageApi), instance);
        }

        
        /// <summary>
        /// Test DownloadRemoteImage
        /// </summary>
        [Test]
        public void DownloadRemoteImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid itemId = null;
            //ImageType type = null;
            //string imageUrl = null;
            //instance.DownloadRemoteImage(itemId, type, imageUrl);
            
        }
        
        /// <summary>
        /// Test GetRemoteImageProviders
        /// </summary>
        [Test]
        public void GetRemoteImageProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid itemId = null;
            //var response = instance.GetRemoteImageProviders(itemId);
            //Assert.IsInstanceOf(typeof(List<ImageProviderInfo>), response, "response is List<ImageProviderInfo>");
        }
        
        /// <summary>
        /// Test GetRemoteImages
        /// </summary>
        [Test]
        public void GetRemoteImagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid itemId = null;
            //ImageType? type = null;
            //int? startIndex = null;
            //int? limit = null;
            //string providerName = null;
            //bool? includeAllLanguages = null;
            //var response = instance.GetRemoteImages(itemId, type, startIndex, limit, providerName, includeAllLanguages);
            //Assert.IsInstanceOf(typeof(RemoteImageResult), response, "response is RemoteImageResult");
        }
        
    }

}