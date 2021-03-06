/*
 * Datto|Autotask PSA Rest API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ChecklistLibrariesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ChecklistLibrariesApiTests
    {
        private ChecklistLibrariesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChecklistLibrariesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChecklistLibrariesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChecklistLibrariesApi
            //Assert.IsInstanceOfType(typeof(ChecklistLibrariesApi), instance, "instance is a ChecklistLibrariesApi");
        }


        /// <summary>
        /// Test ChecklistLibrariesCreateEntity
        /// </summary>
        [Test]
        public void ChecklistLibrariesCreateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChecklistLibraryModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesCreateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ChecklistLibrariesDeleteEntity
        /// </summary>
        [Test]
        public void ChecklistLibrariesDeleteEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesDeleteEntity(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ChecklistLibrariesPatchEntity
        /// </summary>
        [Test]
        public void ChecklistLibrariesPatchEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChecklistLibraryModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesPatchEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ChecklistLibrariesQuery
        /// </summary>
        [Test]
        public void ChecklistLibrariesQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultChecklistLibraryModelChecklistLibrary> (response, "response is QueryActionResultChecklistLibraryModelChecklistLibrary");
        }

        /// <summary>
        /// Test ChecklistLibrariesQueryCount
        /// </summary>
        [Test]
        public void ChecklistLibrariesQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test ChecklistLibrariesQueryEntityInformation
        /// </summary>
        [Test]
        public void ChecklistLibrariesQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ChecklistLibrariesQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ChecklistLibrariesQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ChecklistLibrariesQueryItem
        /// </summary>
        [Test]
        public void ChecklistLibrariesQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelChecklistLibraryModelChecklistLibrary> (response, "response is ItemQueryResultModelChecklistLibraryModelChecklistLibrary");
        }

        /// <summary>
        /// Test ChecklistLibrariesQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void ChecklistLibrariesQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test ChecklistLibrariesUpdateEntity
        /// </summary>
        [Test]
        public void ChecklistLibrariesUpdateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChecklistLibraryModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesUpdateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ChecklistLibrariesUrlParameterQuery
        /// </summary>
        [Test]
        public void ChecklistLibrariesUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultChecklistLibraryModelChecklistLibrary> (response, "response is QueryActionResultChecklistLibraryModelChecklistLibrary");
        }

        /// <summary>
        /// Test ChecklistLibrariesUrlParameterQueryCount
        /// </summary>
        [Test]
        public void ChecklistLibrariesUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ChecklistLibrariesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}
