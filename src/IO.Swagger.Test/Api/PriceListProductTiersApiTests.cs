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
    ///  Class for testing PriceListProductTiersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PriceListProductTiersApiTests
    {
        private PriceListProductTiersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PriceListProductTiersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PriceListProductTiersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PriceListProductTiersApi
            //Assert.IsInstanceOfType(typeof(PriceListProductTiersApi), instance, "instance is a PriceListProductTiersApi");
        }


        /// <summary>
        /// Test PriceListProductTiersPatchEntity
        /// </summary>
        [Test]
        public void PriceListProductTiersPatchEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PriceListProductTierModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersPatchEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test PriceListProductTiersQuery
        /// </summary>
        [Test]
        public void PriceListProductTiersQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultPriceListProductTierModelPriceListProductTier> (response, "response is QueryActionResultPriceListProductTierModelPriceListProductTier");
        }

        /// <summary>
        /// Test PriceListProductTiersQueryCount
        /// </summary>
        [Test]
        public void PriceListProductTiersQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test PriceListProductTiersQueryEntityInformation
        /// </summary>
        [Test]
        public void PriceListProductTiersQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test PriceListProductTiersQueryFieldDefinitions
        /// </summary>
        [Test]
        public void PriceListProductTiersQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test PriceListProductTiersQueryItem
        /// </summary>
        [Test]
        public void PriceListProductTiersQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelPriceListProductTierModelPriceListProductTier> (response, "response is ItemQueryResultModelPriceListProductTierModelPriceListProductTier");
        }

        /// <summary>
        /// Test PriceListProductTiersQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void PriceListProductTiersQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test PriceListProductTiersUpdateEntity
        /// </summary>
        [Test]
        public void PriceListProductTiersUpdateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PriceListProductTierModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersUpdateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test PriceListProductTiersUrlParameterQuery
        /// </summary>
        [Test]
        public void PriceListProductTiersUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultPriceListProductTierModelPriceListProductTier> (response, "response is QueryActionResultPriceListProductTierModelPriceListProductTier");
        }

        /// <summary>
        /// Test PriceListProductTiersUrlParameterQueryCount
        /// </summary>
        [Test]
        public void PriceListProductTiersUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.PriceListProductTiersUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}
