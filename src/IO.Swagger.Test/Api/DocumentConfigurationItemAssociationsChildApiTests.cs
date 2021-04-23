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
    ///  Class for testing DocumentConfigurationItemAssociationsChildApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DocumentConfigurationItemAssociationsChildApiTests
    {
        private DocumentConfigurationItemAssociationsChildApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentConfigurationItemAssociationsChildApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentConfigurationItemAssociationsChildApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DocumentConfigurationItemAssociationsChildApi
            //Assert.IsInstanceOfType(typeof(DocumentConfigurationItemAssociationsChildApi), instance, "instance is a DocumentConfigurationItemAssociationsChildApi");
        }


        /// <summary>
        /// Test DocumentConfigurationItemAssociationsChildCreateEntity
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsChildCreateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //DocumentConfigurationItemAssociationModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsChildDeleteEntity
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsChildDeleteEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsChildQuery
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsChildQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation> (response, "response is QueryActionResultDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsChildQueryEntityInformation
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsChildQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsChildQueryFieldDefinitions
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsChildQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsChildQueryItem
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsChildQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation> (response, "response is ItemQueryResultModelDocumentConfigurationItemAssociationModelDocumentInstalledProductAssociation");
        }

        /// <summary>
        /// Test DocumentConfigurationItemAssociationsChildQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void DocumentConfigurationItemAssociationsChildQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.DocumentConfigurationItemAssociationsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

    }

}
