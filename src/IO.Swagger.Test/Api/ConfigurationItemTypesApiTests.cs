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
    ///  Class for testing ConfigurationItemTypesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConfigurationItemTypesApiTests
    {
        private ConfigurationItemTypesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConfigurationItemTypesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConfigurationItemTypesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConfigurationItemTypesApi
            //Assert.IsInstanceOfType(typeof(ConfigurationItemTypesApi), instance, "instance is a ConfigurationItemTypesApi");
        }


        /// <summary>
        /// Test ConfigurationItemTypesCreateEntity
        /// </summary>
        [Test]
        public void ConfigurationItemTypesCreateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConfigurationItemTypeModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesCreateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemTypesDeleteEntity
        /// </summary>
        [Test]
        public void ConfigurationItemTypesDeleteEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesDeleteEntity(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemTypesPatchEntity
        /// </summary>
        [Test]
        public void ConfigurationItemTypesPatchEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConfigurationItemTypeModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesPatchEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemTypesQuery
        /// </summary>
        [Test]
        public void ConfigurationItemTypesQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultConfigurationItemTypeModelInstalledProductType> (response, "response is QueryActionResultConfigurationItemTypeModelInstalledProductType");
        }

        /// <summary>
        /// Test ConfigurationItemTypesQueryCount
        /// </summary>
        [Test]
        public void ConfigurationItemTypesQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemTypesQueryEntityInformation
        /// </summary>
        [Test]
        public void ConfigurationItemTypesQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemTypesQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ConfigurationItemTypesQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemTypesQueryItem
        /// </summary>
        [Test]
        public void ConfigurationItemTypesQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelConfigurationItemTypeModelInstalledProductType> (response, "response is ItemQueryResultModelConfigurationItemTypeModelInstalledProductType");
        }

        /// <summary>
        /// Test ConfigurationItemTypesQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void ConfigurationItemTypesQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemTypesUpdateEntity
        /// </summary>
        [Test]
        public void ConfigurationItemTypesUpdateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConfigurationItemTypeModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesUpdateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ConfigurationItemTypesUrlParameterQuery
        /// </summary>
        [Test]
        public void ConfigurationItemTypesUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultConfigurationItemTypeModelInstalledProductType> (response, "response is QueryActionResultConfigurationItemTypeModelInstalledProductType");
        }

        /// <summary>
        /// Test ConfigurationItemTypesUrlParameterQueryCount
        /// </summary>
        [Test]
        public void ConfigurationItemTypesUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ConfigurationItemTypesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}
