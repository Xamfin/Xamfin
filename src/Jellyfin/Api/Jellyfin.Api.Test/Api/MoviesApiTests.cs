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
    ///  Class for testing MoviesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MoviesApiTests
    {
        private MoviesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MoviesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MoviesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' MoviesApi
            //Assert.IsInstanceOf(typeof(MoviesApi), instance);
        }

        
        /// <summary>
        /// Test GetMovieRecommendations
        /// </summary>
        [Test]
        public void GetMovieRecommendationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //Guid? parentId = null;
            //List<ItemFields> fields = null;
            //int? categoryLimit = null;
            //int? itemLimit = null;
            //var response = instance.GetMovieRecommendations(userId, parentId, fields, categoryLimit, itemLimit);
            //Assert.IsInstanceOf(typeof(List<RecommendationDto>), response, "response is List<RecommendationDto>");
        }
        
    }

}
