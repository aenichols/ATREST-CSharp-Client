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
    ///  Class for testing DocumentConfigurationItemAssociationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DocumentConfigurationItemAssociationsApiTests
    {
        private DocumentConfigurationItemAssociationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentConfigurationItemAssociationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentConfigurationItemAssociationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DocumentConfigurationItemAssociationsApi
            //Assert.IsInstanceOfType(typeof(DocumentConfigurationItemAssociationsApi), instance, "instance is a DocumentConfigurationItemAssociationsApi");
        }


        /// <summary>
        /// Test DocumentConfigurationItemAssociationsQuery
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation> (response, "response is QueryActionResultDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsQueryCount
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsQueryEntityInformation
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsQueryFieldDefinitions
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsQueryItem
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation> (response, "response is ItemQueryResultModelDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsUrlParameterQuery
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation> (response, "response is QueryActionResultDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsUrlParameterQueryCount
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}