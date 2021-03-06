/*
 * Datto|Autotask PSA Rest API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing TicketChargeModel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TicketChargeModelTests
    {
        // TODO uncomment below to declare an instance variable for TicketChargeModel
        //private TicketChargeModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TicketChargeModel
            //instance = new TicketChargeModel();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TicketChargeModel
        /// </summary>
        [Test]
        public void TicketChargeModelInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TicketChargeModel
            //Assert.IsInstanceOfType<TicketChargeModel> (instance, "variable 'instance' is a TicketChargeModel");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'BillableAmount'
        /// </summary>
        [Test]
        public void BillableAmountTest()
        {
            // TODO unit test for the property 'BillableAmount'
        }
        /// <summary>
        /// Test the property 'BillingCodeID'
        /// </summary>
        [Test]
        public void BillingCodeIDTest()
        {
            // TODO unit test for the property 'BillingCodeID'
        }
        /// <summary>
        /// Test the property 'ChargeType'
        /// </summary>
        [Test]
        public void ChargeTypeTest()
        {
            // TODO unit test for the property 'ChargeType'
        }
        /// <summary>
        /// Test the property 'ContractServiceBundleID'
        /// </summary>
        [Test]
        public void ContractServiceBundleIDTest()
        {
            // TODO unit test for the property 'ContractServiceBundleID'
        }
        /// <summary>
        /// Test the property 'ContractServiceID'
        /// </summary>
        [Test]
        public void ContractServiceIDTest()
        {
            // TODO unit test for the property 'ContractServiceID'
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO unit test for the property 'CreateDate'
        }
        /// <summary>
        /// Test the property 'CreatorResourceID'
        /// </summary>
        [Test]
        public void CreatorResourceIDTest()
        {
            // TODO unit test for the property 'CreatorResourceID'
        }
        /// <summary>
        /// Test the property 'DatePurchased'
        /// </summary>
        [Test]
        public void DatePurchasedTest()
        {
            // TODO unit test for the property 'DatePurchased'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'ExtendedCost'
        /// </summary>
        [Test]
        public void ExtendedCostTest()
        {
            // TODO unit test for the property 'ExtendedCost'
        }
        /// <summary>
        /// Test the property 'InternalCurrencyBillableAmount'
        /// </summary>
        [Test]
        public void InternalCurrencyBillableAmountTest()
        {
            // TODO unit test for the property 'InternalCurrencyBillableAmount'
        }
        /// <summary>
        /// Test the property 'InternalCurrencyUnitPrice'
        /// </summary>
        [Test]
        public void InternalCurrencyUnitPriceTest()
        {
            // TODO unit test for the property 'InternalCurrencyUnitPrice'
        }
        /// <summary>
        /// Test the property 'InternalPurchaseOrderNumber'
        /// </summary>
        [Test]
        public void InternalPurchaseOrderNumberTest()
        {
            // TODO unit test for the property 'InternalPurchaseOrderNumber'
        }
        /// <summary>
        /// Test the property 'IsBillableToCompany'
        /// </summary>
        [Test]
        public void IsBillableToCompanyTest()
        {
            // TODO unit test for the property 'IsBillableToCompany'
        }
        /// <summary>
        /// Test the property 'IsBilled'
        /// </summary>
        [Test]
        public void IsBilledTest()
        {
            // TODO unit test for the property 'IsBilled'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
        }
        /// <summary>
        /// Test the property 'OrganizationalLevelAssociationID'
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationIDTest()
        {
            // TODO unit test for the property 'OrganizationalLevelAssociationID'
        }
        /// <summary>
        /// Test the property 'ProductID'
        /// </summary>
        [Test]
        public void ProductIDTest()
        {
            // TODO unit test for the property 'ProductID'
        }
        /// <summary>
        /// Test the property 'PurchaseOrderNumber'
        /// </summary>
        [Test]
        public void PurchaseOrderNumberTest()
        {
            // TODO unit test for the property 'PurchaseOrderNumber'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'StatusLastModifiedBy'
        /// </summary>
        [Test]
        public void StatusLastModifiedByTest()
        {
            // TODO unit test for the property 'StatusLastModifiedBy'
        }
        /// <summary>
        /// Test the property 'StatusLastModifiedDate'
        /// </summary>
        [Test]
        public void StatusLastModifiedDateTest()
        {
            // TODO unit test for the property 'StatusLastModifiedDate'
        }
        /// <summary>
        /// Test the property 'TicketID'
        /// </summary>
        [Test]
        public void TicketIDTest()
        {
            // TODO unit test for the property 'TicketID'
        }
        /// <summary>
        /// Test the property 'UnitCost'
        /// </summary>
        [Test]
        public void UnitCostTest()
        {
            // TODO unit test for the property 'UnitCost'
        }
        /// <summary>
        /// Test the property 'UnitPrice'
        /// </summary>
        [Test]
        public void UnitPriceTest()
        {
            // TODO unit test for the property 'UnitPrice'
        }
        /// <summary>
        /// Test the property 'UnitQuantity'
        /// </summary>
        [Test]
        public void UnitQuantityTest()
        {
            // TODO unit test for the property 'UnitQuantity'
        }
        /// <summary>
        /// Test the property 'SoapParentPropertyId'
        /// </summary>
        [Test]
        public void SoapParentPropertyIdTest()
        {
            // TODO unit test for the property 'SoapParentPropertyId'
        }
        /// <summary>
        /// Test the property 'UserDefinedFields'
        /// </summary>
        [Test]
        public void UserDefinedFieldsTest()
        {
            // TODO unit test for the property 'UserDefinedFields'
        }

    }

}
