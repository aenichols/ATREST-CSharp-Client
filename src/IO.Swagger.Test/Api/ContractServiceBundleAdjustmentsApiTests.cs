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
    ///  Class for testing ContractServiceBundleAdjustmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContractServiceBundleAdjustmentsApiTests
    {
        private ContractServiceBundleAdjustmentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContractServiceBundleAdjustmentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContractServiceBundleAdjustmentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContractServiceBundleAdjustmentsApi
            //Assert.IsInstanceOfType(typeof(ContractServiceBundleAdjustmentsApi), instance, "instance is a ContractServiceBundleAdjustmentsApi");
        }


        /// <summary>
        /// Test ContractServiceBundleAdjustmentsCreateEntity
        /// </summary>
        [Test]
        public void ContractServiceBundleAdjustmentsCreateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ContractServiceBundleAdjustmentModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleAdjustmentsCreateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ContractServiceBundleAdjustmentsQueryEntityInformation
        /// </summary>
        [Test]
        public void ContractServiceBundleAdjustmentsQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleAdjustmentsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ContractServiceBundleAdjustmentsQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ContractServiceBundleAdjustmentsQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleAdjustmentsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

    }

}
