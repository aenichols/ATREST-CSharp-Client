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
    ///  Class for testing ContractServiceBundleUnitsChildApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContractServiceBundleUnitsChildApiTests
    {
        private ContractServiceBundleUnitsChildApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContractServiceBundleUnitsChildApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContractServiceBundleUnitsChildApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContractServiceBundleUnitsChildApi
            //Assert.IsInstanceOfType(typeof(ContractServiceBundleUnitsChildApi), instance, "instance is a ContractServiceBundleUnitsChildApi");
        }


        /// <summary>
        /// Test ContractServiceBundleUnitsChildQuery
        /// </summary>
        [Test]
        public void ContractServiceBundleUnitsChildQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleUnitsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultContractServiceBundleUnitModelContractServiceBundleUnit> (response, "response is QueryActionResultContractServiceBundleUnitModelContractServiceBundleUnit");
        }

        /// <summary>
        /// Test ContractServiceBundleUnitsChildQueryEntityInformation
        /// </summary>
        [Test]
        public void ContractServiceBundleUnitsChildQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleUnitsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ContractServiceBundleUnitsChildQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ContractServiceBundleUnitsChildQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleUnitsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ContractServiceBundleUnitsChildQueryItem
        /// </summary>
        [Test]
        public void ContractServiceBundleUnitsChildQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleUnitsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelContractServiceBundleUnitModelContractServiceBundleUnit> (response, "response is ItemQueryResultModelContractServiceBundleUnitModelContractServiceBundleUnit");
        }

        /// <summary>
        /// Test ContractServiceBundleUnitsChildQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void ContractServiceBundleUnitsChildQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleUnitsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

    }

}