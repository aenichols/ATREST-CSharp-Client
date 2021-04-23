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
    ///  Class for testing ConfigurationItemWebhookUdfFieldsChildApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConfigurationItemWebhookUdfFieldsChildApiTests
    {
        private ConfigurationItemWebhookUdfFieldsChildApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConfigurationItemWebhookUdfFieldsChildApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConfigurationItemWebhookUdfFieldsChildApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConfigurationItemWebhookUdfFieldsChildApi
            //Assert.IsInstanceOfType(typeof(ConfigurationItemWebhookUdfFieldsChildApi), instance, "instance is a ConfigurationItemWebhookUdfFieldsChildApi");
        }


        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildCreateEntity
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildCreateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //ConfigurationItemWebhookUdfFieldModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildDeleteEntity
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildDeleteEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildPatchEntity
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildPatchEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //ConfigurationItemWebhookUdfFieldModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildQuery
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField> (response, "response is QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField");
        }

        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildQueryEntityInformation
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildQueryItem
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField> (response, "response is ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField");
        }

        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemWebhookUdfFieldsChildUpdateEntity
        /// </summary>
        [Test]
        public void ConfigurationItemWebhookUdfFieldsChildUpdateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //ConfigurationItemWebhookUdfFieldModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemWebhookUdfFieldsChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

    }

}
