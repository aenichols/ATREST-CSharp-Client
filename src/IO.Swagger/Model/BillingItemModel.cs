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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// BillingItemModel
    /// </summary>
    [DataContract]
    public partial class BillingItemModel :  IEquatable<BillingItemModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingItemModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountManagerWhenApprovedID">accountManagerWhenApprovedID.</param>
        /// <param name="billingCodeID">billingCodeID.</param>
        /// <param name="billingItemType">billingItemType.</param>
        /// <param name="companyID">companyID.</param>
        /// <param name="configurationItemID">configurationItemID.</param>
        /// <param name="contractChargeID">contractChargeID.</param>
        /// <param name="contractID">contractID.</param>
        /// <param name="description">description.</param>
        /// <param name="expenseItemID">expenseItemID.</param>
        /// <param name="extendedPrice">extendedPrice.</param>
        /// <param name="internalCurrencyExtendedPrice">internalCurrencyExtendedPrice.</param>
        /// <param name="internalCurrencyRate">internalCurrencyRate.</param>
        /// <param name="internalCurrencyTaxDollars">internalCurrencyTaxDollars.</param>
        /// <param name="internalCurrencyTotalAmount">internalCurrencyTotalAmount.</param>
        /// <param name="invoiceID">invoiceID.</param>
        /// <param name="itemApproverID">itemApproverID.</param>
        /// <param name="itemDate">itemDate.</param>
        /// <param name="itemName">itemName.</param>
        /// <param name="lineItemFullDescription">lineItemFullDescription.</param>
        /// <param name="lineItemGroupDescription">lineItemGroupDescription.</param>
        /// <param name="milestoneID">milestoneID.</param>
        /// <param name="nonBillable">nonBillable.</param>
        /// <param name="organizationalLevelAssociationID">organizationalLevelAssociationID.</param>
        /// <param name="ourCost">ourCost.</param>
        /// <param name="postedDate">postedDate.</param>
        /// <param name="postedOnTime">postedOnTime.</param>
        /// <param name="projectChargeID">projectChargeID.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="purchaseOrderNumber">purchaseOrderNumber.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="rate">rate.</param>
        /// <param name="roleID">roleID.</param>
        /// <param name="serviceBundleID">serviceBundleID.</param>
        /// <param name="serviceID">serviceID.</param>
        /// <param name="sortOrderID">sortOrderID.</param>
        /// <param name="subType">subType.</param>
        /// <param name="taskID">taskID.</param>
        /// <param name="taxDollars">taxDollars.</param>
        /// <param name="ticketChargeID">ticketChargeID.</param>
        /// <param name="ticketID">ticketID.</param>
        /// <param name="timeEntryID">timeEntryID.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="vendorID">vendorID.</param>
        /// <param name="webServiceDate">webServiceDate.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public BillingItemModel(long? id = default(long?), int? accountManagerWhenApprovedID = default(int?), int? billingCodeID = default(int?), int? billingItemType = default(int?), int? companyID = default(int?), long? configurationItemID = default(long?), long? contractChargeID = default(long?), int? contractID = default(int?), string description = default(string), int? expenseItemID = default(int?), double? extendedPrice = default(double?), double? internalCurrencyExtendedPrice = default(double?), double? internalCurrencyRate = default(double?), double? internalCurrencyTaxDollars = default(double?), double? internalCurrencyTotalAmount = default(double?), int? invoiceID = default(int?), int? itemApproverID = default(int?), DateTime? itemDate = default(DateTime?), string itemName = default(string), string lineItemFullDescription = default(string), string lineItemGroupDescription = default(string), long? milestoneID = default(long?), int? nonBillable = default(int?), int? organizationalLevelAssociationID = default(int?), double? ourCost = default(double?), DateTime? postedDate = default(DateTime?), DateTime? postedOnTime = default(DateTime?), long? projectChargeID = default(long?), int? projectID = default(int?), string purchaseOrderNumber = default(string), double? quantity = default(double?), double? rate = default(double?), int? roleID = default(int?), long? serviceBundleID = default(long?), long? serviceID = default(long?), long? sortOrderID = default(long?), int? subType = default(int?), int? taskID = default(int?), double? taxDollars = default(double?), long? ticketChargeID = default(long?), int? ticketID = default(int?), int? timeEntryID = default(int?), double? totalAmount = default(double?), long? vendorID = default(long?), DateTime? webServiceDate = default(DateTime?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.AccountManagerWhenApprovedID = accountManagerWhenApprovedID;
            this.BillingCodeID = billingCodeID;
            this.BillingItemType = billingItemType;
            this.CompanyID = companyID;
            this.ConfigurationItemID = configurationItemID;
            this.ContractChargeID = contractChargeID;
            this.ContractID = contractID;
            this.Description = description;
            this.ExpenseItemID = expenseItemID;
            this.ExtendedPrice = extendedPrice;
            this.InternalCurrencyExtendedPrice = internalCurrencyExtendedPrice;
            this.InternalCurrencyRate = internalCurrencyRate;
            this.InternalCurrencyTaxDollars = internalCurrencyTaxDollars;
            this.InternalCurrencyTotalAmount = internalCurrencyTotalAmount;
            this.InvoiceID = invoiceID;
            this.ItemApproverID = itemApproverID;
            this.ItemDate = itemDate;
            this.ItemName = itemName;
            this.LineItemFullDescription = lineItemFullDescription;
            this.LineItemGroupDescription = lineItemGroupDescription;
            this.MilestoneID = milestoneID;
            this.NonBillable = nonBillable;
            this.OrganizationalLevelAssociationID = organizationalLevelAssociationID;
            this.OurCost = ourCost;
            this.PostedDate = postedDate;
            this.PostedOnTime = postedOnTime;
            this.ProjectChargeID = projectChargeID;
            this.ProjectID = projectID;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.Quantity = quantity;
            this.Rate = rate;
            this.RoleID = roleID;
            this.ServiceBundleID = serviceBundleID;
            this.ServiceID = serviceID;
            this.SortOrderID = sortOrderID;
            this.SubType = subType;
            this.TaskID = taskID;
            this.TaxDollars = taxDollars;
            this.TicketChargeID = ticketChargeID;
            this.TicketID = ticketID;
            this.TimeEntryID = timeEntryID;
            this.TotalAmount = totalAmount;
            this.VendorID = vendorID;
            this.WebServiceDate = webServiceDate;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountManagerWhenApprovedID
        /// </summary>
        [DataMember(Name="accountManagerWhenApprovedID", EmitDefaultValue=false)]
        public int? AccountManagerWhenApprovedID { get; set; }

        /// <summary>
        /// Gets or Sets BillingCodeID
        /// </summary>
        [DataMember(Name="billingCodeID", EmitDefaultValue=false)]
        public int? BillingCodeID { get; set; }

        /// <summary>
        /// Gets or Sets BillingItemType
        /// </summary>
        [DataMember(Name="billingItemType", EmitDefaultValue=false)]
        public int? BillingItemType { get; set; }

        /// <summary>
        /// Gets or Sets CompanyID
        /// </summary>
        [DataMember(Name="companyID", EmitDefaultValue=false)]
        public int? CompanyID { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationItemID
        /// </summary>
        [DataMember(Name="configurationItemID", EmitDefaultValue=false)]
        public long? ConfigurationItemID { get; set; }

        /// <summary>
        /// Gets or Sets ContractChargeID
        /// </summary>
        [DataMember(Name="contractChargeID", EmitDefaultValue=false)]
        public long? ContractChargeID { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="contractID", EmitDefaultValue=false)]
        public int? ContractID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseItemID
        /// </summary>
        [DataMember(Name="expenseItemID", EmitDefaultValue=false)]
        public int? ExpenseItemID { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedPrice
        /// </summary>
        [DataMember(Name="extendedPrice", EmitDefaultValue=false)]
        public double? ExtendedPrice { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyExtendedPrice
        /// </summary>
        [DataMember(Name="internalCurrencyExtendedPrice", EmitDefaultValue=false)]
        public double? InternalCurrencyExtendedPrice { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyRate
        /// </summary>
        [DataMember(Name="internalCurrencyRate", EmitDefaultValue=false)]
        public double? InternalCurrencyRate { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyTaxDollars
        /// </summary>
        [DataMember(Name="internalCurrencyTaxDollars", EmitDefaultValue=false)]
        public double? InternalCurrencyTaxDollars { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyTotalAmount
        /// </summary>
        [DataMember(Name="internalCurrencyTotalAmount", EmitDefaultValue=false)]
        public double? InternalCurrencyTotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceID
        /// </summary>
        [DataMember(Name="invoiceID", EmitDefaultValue=false)]
        public int? InvoiceID { get; set; }

        /// <summary>
        /// Gets or Sets ItemApproverID
        /// </summary>
        [DataMember(Name="itemApproverID", EmitDefaultValue=false)]
        public int? ItemApproverID { get; set; }

        /// <summary>
        /// Gets or Sets ItemDate
        /// </summary>
        [DataMember(Name="itemDate", EmitDefaultValue=false)]
        public DateTime? ItemDate { get; set; }

        /// <summary>
        /// Gets or Sets ItemName
        /// </summary>
        [DataMember(Name="itemName", EmitDefaultValue=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or Sets LineItemFullDescription
        /// </summary>
        [DataMember(Name="lineItemFullDescription", EmitDefaultValue=false)]
        public string LineItemFullDescription { get; set; }

        /// <summary>
        /// Gets or Sets LineItemGroupDescription
        /// </summary>
        [DataMember(Name="lineItemGroupDescription", EmitDefaultValue=false)]
        public string LineItemGroupDescription { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneID
        /// </summary>
        [DataMember(Name="milestoneID", EmitDefaultValue=false)]
        public long? MilestoneID { get; set; }

        /// <summary>
        /// Gets or Sets NonBillable
        /// </summary>
        [DataMember(Name="nonBillable", EmitDefaultValue=false)]
        public int? NonBillable { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationalLevelAssociationID
        /// </summary>
        [DataMember(Name="organizationalLevelAssociationID", EmitDefaultValue=false)]
        public int? OrganizationalLevelAssociationID { get; set; }

        /// <summary>
        /// Gets or Sets OurCost
        /// </summary>
        [DataMember(Name="ourCost", EmitDefaultValue=false)]
        public double? OurCost { get; set; }

        /// <summary>
        /// Gets or Sets PostedDate
        /// </summary>
        [DataMember(Name="postedDate", EmitDefaultValue=false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// Gets or Sets PostedOnTime
        /// </summary>
        [DataMember(Name="postedOnTime", EmitDefaultValue=false)]
        public DateTime? PostedOnTime { get; set; }

        /// <summary>
        /// Gets or Sets ProjectChargeID
        /// </summary>
        [DataMember(Name="projectChargeID", EmitDefaultValue=false)]
        public long? ProjectChargeID { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="projectID", EmitDefaultValue=false)]
        public int? ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderNumber
        /// </summary>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public double? Rate { get; set; }

        /// <summary>
        /// Gets or Sets RoleID
        /// </summary>
        [DataMember(Name="roleID", EmitDefaultValue=false)]
        public int? RoleID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceBundleID
        /// </summary>
        [DataMember(Name="serviceBundleID", EmitDefaultValue=false)]
        public long? ServiceBundleID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceID
        /// </summary>
        [DataMember(Name="serviceID", EmitDefaultValue=false)]
        public long? ServiceID { get; set; }

        /// <summary>
        /// Gets or Sets SortOrderID
        /// </summary>
        [DataMember(Name="sortOrderID", EmitDefaultValue=false)]
        public long? SortOrderID { get; set; }

        /// <summary>
        /// Gets or Sets SubType
        /// </summary>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public int? SubType { get; set; }

        /// <summary>
        /// Gets or Sets TaskID
        /// </summary>
        [DataMember(Name="taskID", EmitDefaultValue=false)]
        public int? TaskID { get; set; }

        /// <summary>
        /// Gets or Sets TaxDollars
        /// </summary>
        [DataMember(Name="taxDollars", EmitDefaultValue=false)]
        public double? TaxDollars { get; set; }

        /// <summary>
        /// Gets or Sets TicketChargeID
        /// </summary>
        [DataMember(Name="ticketChargeID", EmitDefaultValue=false)]
        public long? TicketChargeID { get; set; }

        /// <summary>
        /// Gets or Sets TicketID
        /// </summary>
        [DataMember(Name="ticketID", EmitDefaultValue=false)]
        public int? TicketID { get; set; }

        /// <summary>
        /// Gets or Sets TimeEntryID
        /// </summary>
        [DataMember(Name="timeEntryID", EmitDefaultValue=false)]
        public int? TimeEntryID { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public double? TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets VendorID
        /// </summary>
        [DataMember(Name="vendorID", EmitDefaultValue=false)]
        public long? VendorID { get; set; }

        /// <summary>
        /// Gets or Sets WebServiceDate
        /// </summary>
        [DataMember(Name="webServiceDate", EmitDefaultValue=false)]
        public DateTime? WebServiceDate { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedFields
        /// </summary>
        [DataMember(Name="userDefinedFields", EmitDefaultValue=false)]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountManagerWhenApprovedID: ").Append(AccountManagerWhenApprovedID).Append("\n");
            sb.Append("  BillingCodeID: ").Append(BillingCodeID).Append("\n");
            sb.Append("  BillingItemType: ").Append(BillingItemType).Append("\n");
            sb.Append("  CompanyID: ").Append(CompanyID).Append("\n");
            sb.Append("  ConfigurationItemID: ").Append(ConfigurationItemID).Append("\n");
            sb.Append("  ContractChargeID: ").Append(ContractChargeID).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpenseItemID: ").Append(ExpenseItemID).Append("\n");
            sb.Append("  ExtendedPrice: ").Append(ExtendedPrice).Append("\n");
            sb.Append("  InternalCurrencyExtendedPrice: ").Append(InternalCurrencyExtendedPrice).Append("\n");
            sb.Append("  InternalCurrencyRate: ").Append(InternalCurrencyRate).Append("\n");
            sb.Append("  InternalCurrencyTaxDollars: ").Append(InternalCurrencyTaxDollars).Append("\n");
            sb.Append("  InternalCurrencyTotalAmount: ").Append(InternalCurrencyTotalAmount).Append("\n");
            sb.Append("  InvoiceID: ").Append(InvoiceID).Append("\n");
            sb.Append("  ItemApproverID: ").Append(ItemApproverID).Append("\n");
            sb.Append("  ItemDate: ").Append(ItemDate).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  LineItemFullDescription: ").Append(LineItemFullDescription).Append("\n");
            sb.Append("  LineItemGroupDescription: ").Append(LineItemGroupDescription).Append("\n");
            sb.Append("  MilestoneID: ").Append(MilestoneID).Append("\n");
            sb.Append("  NonBillable: ").Append(NonBillable).Append("\n");
            sb.Append("  OrganizationalLevelAssociationID: ").Append(OrganizationalLevelAssociationID).Append("\n");
            sb.Append("  OurCost: ").Append(OurCost).Append("\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  PostedOnTime: ").Append(PostedOnTime).Append("\n");
            sb.Append("  ProjectChargeID: ").Append(ProjectChargeID).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  RoleID: ").Append(RoleID).Append("\n");
            sb.Append("  ServiceBundleID: ").Append(ServiceBundleID).Append("\n");
            sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
            sb.Append("  SortOrderID: ").Append(SortOrderID).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  TaskID: ").Append(TaskID).Append("\n");
            sb.Append("  TaxDollars: ").Append(TaxDollars).Append("\n");
            sb.Append("  TicketChargeID: ").Append(TicketChargeID).Append("\n");
            sb.Append("  TicketID: ").Append(TicketID).Append("\n");
            sb.Append("  TimeEntryID: ").Append(TimeEntryID).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  VendorID: ").Append(VendorID).Append("\n");
            sb.Append("  WebServiceDate: ").Append(WebServiceDate).Append("\n");
            sb.Append("  UserDefinedFields: ").Append(UserDefinedFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillingItemModel);
        }

        /// <summary>
        /// Returns true if BillingItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingItemModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AccountManagerWhenApprovedID == input.AccountManagerWhenApprovedID ||
                    (this.AccountManagerWhenApprovedID != null &&
                    this.AccountManagerWhenApprovedID.Equals(input.AccountManagerWhenApprovedID))
                ) && 
                (
                    this.BillingCodeID == input.BillingCodeID ||
                    (this.BillingCodeID != null &&
                    this.BillingCodeID.Equals(input.BillingCodeID))
                ) && 
                (
                    this.BillingItemType == input.BillingItemType ||
                    (this.BillingItemType != null &&
                    this.BillingItemType.Equals(input.BillingItemType))
                ) && 
                (
                    this.CompanyID == input.CompanyID ||
                    (this.CompanyID != null &&
                    this.CompanyID.Equals(input.CompanyID))
                ) && 
                (
                    this.ConfigurationItemID == input.ConfigurationItemID ||
                    (this.ConfigurationItemID != null &&
                    this.ConfigurationItemID.Equals(input.ConfigurationItemID))
                ) && 
                (
                    this.ContractChargeID == input.ContractChargeID ||
                    (this.ContractChargeID != null &&
                    this.ContractChargeID.Equals(input.ContractChargeID))
                ) && 
                (
                    this.ContractID == input.ContractID ||
                    (this.ContractID != null &&
                    this.ContractID.Equals(input.ContractID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExpenseItemID == input.ExpenseItemID ||
                    (this.ExpenseItemID != null &&
                    this.ExpenseItemID.Equals(input.ExpenseItemID))
                ) && 
                (
                    this.ExtendedPrice == input.ExtendedPrice ||
                    (this.ExtendedPrice != null &&
                    this.ExtendedPrice.Equals(input.ExtendedPrice))
                ) && 
                (
                    this.InternalCurrencyExtendedPrice == input.InternalCurrencyExtendedPrice ||
                    (this.InternalCurrencyExtendedPrice != null &&
                    this.InternalCurrencyExtendedPrice.Equals(input.InternalCurrencyExtendedPrice))
                ) && 
                (
                    this.InternalCurrencyRate == input.InternalCurrencyRate ||
                    (this.InternalCurrencyRate != null &&
                    this.InternalCurrencyRate.Equals(input.InternalCurrencyRate))
                ) && 
                (
                    this.InternalCurrencyTaxDollars == input.InternalCurrencyTaxDollars ||
                    (this.InternalCurrencyTaxDollars != null &&
                    this.InternalCurrencyTaxDollars.Equals(input.InternalCurrencyTaxDollars))
                ) && 
                (
                    this.InternalCurrencyTotalAmount == input.InternalCurrencyTotalAmount ||
                    (this.InternalCurrencyTotalAmount != null &&
                    this.InternalCurrencyTotalAmount.Equals(input.InternalCurrencyTotalAmount))
                ) && 
                (
                    this.InvoiceID == input.InvoiceID ||
                    (this.InvoiceID != null &&
                    this.InvoiceID.Equals(input.InvoiceID))
                ) && 
                (
                    this.ItemApproverID == input.ItemApproverID ||
                    (this.ItemApproverID != null &&
                    this.ItemApproverID.Equals(input.ItemApproverID))
                ) && 
                (
                    this.ItemDate == input.ItemDate ||
                    (this.ItemDate != null &&
                    this.ItemDate.Equals(input.ItemDate))
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.LineItemFullDescription == input.LineItemFullDescription ||
                    (this.LineItemFullDescription != null &&
                    this.LineItemFullDescription.Equals(input.LineItemFullDescription))
                ) && 
                (
                    this.LineItemGroupDescription == input.LineItemGroupDescription ||
                    (this.LineItemGroupDescription != null &&
                    this.LineItemGroupDescription.Equals(input.LineItemGroupDescription))
                ) && 
                (
                    this.MilestoneID == input.MilestoneID ||
                    (this.MilestoneID != null &&
                    this.MilestoneID.Equals(input.MilestoneID))
                ) && 
                (
                    this.NonBillable == input.NonBillable ||
                    (this.NonBillable != null &&
                    this.NonBillable.Equals(input.NonBillable))
                ) && 
                (
                    this.OrganizationalLevelAssociationID == input.OrganizationalLevelAssociationID ||
                    (this.OrganizationalLevelAssociationID != null &&
                    this.OrganizationalLevelAssociationID.Equals(input.OrganizationalLevelAssociationID))
                ) && 
                (
                    this.OurCost == input.OurCost ||
                    (this.OurCost != null &&
                    this.OurCost.Equals(input.OurCost))
                ) && 
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) && 
                (
                    this.PostedOnTime == input.PostedOnTime ||
                    (this.PostedOnTime != null &&
                    this.PostedOnTime.Equals(input.PostedOnTime))
                ) && 
                (
                    this.ProjectChargeID == input.ProjectChargeID ||
                    (this.ProjectChargeID != null &&
                    this.ProjectChargeID.Equals(input.ProjectChargeID))
                ) && 
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
                ) && 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.RoleID == input.RoleID ||
                    (this.RoleID != null &&
                    this.RoleID.Equals(input.RoleID))
                ) && 
                (
                    this.ServiceBundleID == input.ServiceBundleID ||
                    (this.ServiceBundleID != null &&
                    this.ServiceBundleID.Equals(input.ServiceBundleID))
                ) && 
                (
                    this.ServiceID == input.ServiceID ||
                    (this.ServiceID != null &&
                    this.ServiceID.Equals(input.ServiceID))
                ) && 
                (
                    this.SortOrderID == input.SortOrderID ||
                    (this.SortOrderID != null &&
                    this.SortOrderID.Equals(input.SortOrderID))
                ) && 
                (
                    this.SubType == input.SubType ||
                    (this.SubType != null &&
                    this.SubType.Equals(input.SubType))
                ) && 
                (
                    this.TaskID == input.TaskID ||
                    (this.TaskID != null &&
                    this.TaskID.Equals(input.TaskID))
                ) && 
                (
                    this.TaxDollars == input.TaxDollars ||
                    (this.TaxDollars != null &&
                    this.TaxDollars.Equals(input.TaxDollars))
                ) && 
                (
                    this.TicketChargeID == input.TicketChargeID ||
                    (this.TicketChargeID != null &&
                    this.TicketChargeID.Equals(input.TicketChargeID))
                ) && 
                (
                    this.TicketID == input.TicketID ||
                    (this.TicketID != null &&
                    this.TicketID.Equals(input.TicketID))
                ) && 
                (
                    this.TimeEntryID == input.TimeEntryID ||
                    (this.TimeEntryID != null &&
                    this.TimeEntryID.Equals(input.TimeEntryID))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.VendorID == input.VendorID ||
                    (this.VendorID != null &&
                    this.VendorID.Equals(input.VendorID))
                ) && 
                (
                    this.WebServiceDate == input.WebServiceDate ||
                    (this.WebServiceDate != null &&
                    this.WebServiceDate.Equals(input.WebServiceDate))
                ) && 
                (
                    this.UserDefinedFields == input.UserDefinedFields ||
                    this.UserDefinedFields != null &&
                    this.UserDefinedFields.SequenceEqual(input.UserDefinedFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccountManagerWhenApprovedID != null)
                    hashCode = hashCode * 59 + this.AccountManagerWhenApprovedID.GetHashCode();
                if (this.BillingCodeID != null)
                    hashCode = hashCode * 59 + this.BillingCodeID.GetHashCode();
                if (this.BillingItemType != null)
                    hashCode = hashCode * 59 + this.BillingItemType.GetHashCode();
                if (this.CompanyID != null)
                    hashCode = hashCode * 59 + this.CompanyID.GetHashCode();
                if (this.ConfigurationItemID != null)
                    hashCode = hashCode * 59 + this.ConfigurationItemID.GetHashCode();
                if (this.ContractChargeID != null)
                    hashCode = hashCode * 59 + this.ContractChargeID.GetHashCode();
                if (this.ContractID != null)
                    hashCode = hashCode * 59 + this.ContractID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpenseItemID != null)
                    hashCode = hashCode * 59 + this.ExpenseItemID.GetHashCode();
                if (this.ExtendedPrice != null)
                    hashCode = hashCode * 59 + this.ExtendedPrice.GetHashCode();
                if (this.InternalCurrencyExtendedPrice != null)
                    hashCode = hashCode * 59 + this.InternalCurrencyExtendedPrice.GetHashCode();
                if (this.InternalCurrencyRate != null)
                    hashCode = hashCode * 59 + this.InternalCurrencyRate.GetHashCode();
                if (this.InternalCurrencyTaxDollars != null)
                    hashCode = hashCode * 59 + this.InternalCurrencyTaxDollars.GetHashCode();
                if (this.InternalCurrencyTotalAmount != null)
                    hashCode = hashCode * 59 + this.InternalCurrencyTotalAmount.GetHashCode();
                if (this.InvoiceID != null)
                    hashCode = hashCode * 59 + this.InvoiceID.GetHashCode();
                if (this.ItemApproverID != null)
                    hashCode = hashCode * 59 + this.ItemApproverID.GetHashCode();
                if (this.ItemDate != null)
                    hashCode = hashCode * 59 + this.ItemDate.GetHashCode();
                if (this.ItemName != null)
                    hashCode = hashCode * 59 + this.ItemName.GetHashCode();
                if (this.LineItemFullDescription != null)
                    hashCode = hashCode * 59 + this.LineItemFullDescription.GetHashCode();
                if (this.LineItemGroupDescription != null)
                    hashCode = hashCode * 59 + this.LineItemGroupDescription.GetHashCode();
                if (this.MilestoneID != null)
                    hashCode = hashCode * 59 + this.MilestoneID.GetHashCode();
                if (this.NonBillable != null)
                    hashCode = hashCode * 59 + this.NonBillable.GetHashCode();
                if (this.OrganizationalLevelAssociationID != null)
                    hashCode = hashCode * 59 + this.OrganizationalLevelAssociationID.GetHashCode();
                if (this.OurCost != null)
                    hashCode = hashCode * 59 + this.OurCost.GetHashCode();
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.PostedOnTime != null)
                    hashCode = hashCode * 59 + this.PostedOnTime.GetHashCode();
                if (this.ProjectChargeID != null)
                    hashCode = hashCode * 59 + this.ProjectChargeID.GetHashCode();
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.RoleID != null)
                    hashCode = hashCode * 59 + this.RoleID.GetHashCode();
                if (this.ServiceBundleID != null)
                    hashCode = hashCode * 59 + this.ServiceBundleID.GetHashCode();
                if (this.ServiceID != null)
                    hashCode = hashCode * 59 + this.ServiceID.GetHashCode();
                if (this.SortOrderID != null)
                    hashCode = hashCode * 59 + this.SortOrderID.GetHashCode();
                if (this.SubType != null)
                    hashCode = hashCode * 59 + this.SubType.GetHashCode();
                if (this.TaskID != null)
                    hashCode = hashCode * 59 + this.TaskID.GetHashCode();
                if (this.TaxDollars != null)
                    hashCode = hashCode * 59 + this.TaxDollars.GetHashCode();
                if (this.TicketChargeID != null)
                    hashCode = hashCode * 59 + this.TicketChargeID.GetHashCode();
                if (this.TicketID != null)
                    hashCode = hashCode * 59 + this.TicketID.GetHashCode();
                if (this.TimeEntryID != null)
                    hashCode = hashCode * 59 + this.TimeEntryID.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.VendorID != null)
                    hashCode = hashCode * 59 + this.VendorID.GetHashCode();
                if (this.WebServiceDate != null)
                    hashCode = hashCode * 59 + this.WebServiceDate.GetHashCode();
                if (this.UserDefinedFields != null)
                    hashCode = hashCode * 59 + this.UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}