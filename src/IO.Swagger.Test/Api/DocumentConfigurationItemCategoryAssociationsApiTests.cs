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
    ///  Class for testing DocumentConfigurationItemCategoryAssociationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DocumentConfigurationItemCategoryAssociationsApiTests
    {
        private DocumentConfigurationItemCategoryAssociationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentConfigurationItemCategoryAssociationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentConfigurationItemCategoryAssociationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DocumentConfigurationItemCategoryAssociationsApi
            //Assert.IsInstanceOfType(typeof(DocumentConfigurationItemCategoryAssociationsApi), instance, "instance is a DocumentConfigurationItemCategoryAssociationsApi");
        }


        /// <summary>
        /// Test DocumentConfigurationItemCategoryAssociationsQuery
        /// </summary>
        [Test]
        public void DocumentConfigurationItemCategoryAssociationsQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemCategoryAssociationsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation> (response, "response is QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation");
        }

        /// <summary>
        /// Test DocumentConfigurationItemCategoryAssociationsQueryCount
        /// </summary>
        [Test]
        public void DocumentConfigurationItemCategoryAssociationsQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemCategoryAssociationsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemCategoryAssociationsQueryEntityInformation
        /// </summary>
        [Test]
        public void DocumentConfigurationItemCategoryAssociationsQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemCategoryAssociationsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitions
        /// </summary>
        [Test]
        public void DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemCategoryAssociationsQueryItem
        /// </summary>
        [Test]
        public void DocumentConfigurationItemCategoryAssociationsQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemCategoryAssociationsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation> (response, "response is ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation");
        }

        /// <summary>
        /// Test DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemCategoryAssociationsUrlParameterQuery
        /// </summary>
        [Test]
        public void DocumentConfigurationItemCategoryAssociationsUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemCategoryAssociationsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation> (response, "response is QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation");
        }

        /// <summary>
        /// Test DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCount
        /// </summary>
        [Test]
        public void DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}
