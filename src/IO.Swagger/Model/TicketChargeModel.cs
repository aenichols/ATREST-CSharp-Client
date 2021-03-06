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
    /// TicketChargeModel
    /// </summary>
    [DataContract]
    public partial class TicketChargeModel :  IEquatable<TicketChargeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketChargeModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="billableAmount">billableAmount.</param>
        /// <param name="billingCodeID">billingCodeID.</param>
        /// <param name="chargeType">chargeType.</param>
        /// <param name="contractServiceBundleID">contractServiceBundleID.</param>
        /// <param name="contractServiceID">contractServiceID.</param>
        /// <param name="createDate">createDate.</param>
        /// <param name="creatorResourceID">creatorResourceID.</param>
        /// <param name="datePurchased">datePurchased.</param>
        /// <param name="description">description.</param>
        /// <param name="extendedCost">extendedCost.</param>
        /// <param name="internalCurrencyBillableAmount">internalCurrencyBillableAmount.</param>
        /// <param name="internalCurrencyUnitPrice">internalCurrencyUnitPrice.</param>
        /// <param name="internalPurchaseOrderNumber">internalPurchaseOrderNumber.</param>
        /// <param name="isBillableToCompany">isBillableToCompany.</param>
        /// <param name="isBilled">isBilled.</param>
        /// <param name="name">name.</param>
        /// <param name="notes">notes.</param>
        /// <param name="organizationalLevelAssociationID">organizationalLevelAssociationID.</param>
        /// <param name="productID">productID.</param>
        /// <param name="purchaseOrderNumber">purchaseOrderNumber.</param>
        /// <param name="status">status.</param>
        /// <param name="statusLastModifiedBy">statusLastModifiedBy.</param>
        /// <param name="statusLastModifiedDate">statusLastModifiedDate.</param>
        /// <param name="ticketID">ticketID.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="unitQuantity">unitQuantity.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public TicketChargeModel(long? id = default(long?), double? billableAmount = default(double?), long? billingCodeID = default(long?), int? chargeType = default(int?), long? contractServiceBundleID = default(long?), long? contractServiceID = default(long?), DateTime? createDate = default(DateTime?), long? creatorResourceID = default(long?), DateTime? datePurchased = default(DateTime?), string description = default(string), double? extendedCost = default(double?), double? internalCurrencyBillableAmount = default(double?), double? internalCurrencyUnitPrice = default(double?), string internalPurchaseOrderNumber = default(string), bool? isBillableToCompany = default(bool?), bool? isBilled = default(bool?), string name = default(string), string notes = default(string), int? organizationalLevelAssociationID = default(int?), long? productID = default(long?), string purchaseOrderNumber = default(string), long? status = default(long?), long? statusLastModifiedBy = default(long?), DateTime? statusLastModifiedDate = default(DateTime?), long? ticketID = default(long?), double? unitCost = default(double?), double? unitPrice = default(double?), double? unitQuantity = default(double?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.BillableAmount = billableAmount;
            this.BillingCodeID = billingCodeID;
            this.ChargeType = chargeType;
            this.ContractServiceBundleID = contractServiceBundleID;
            this.ContractServiceID = contractServiceID;
            this.CreateDate = createDate;
            this.CreatorResourceID = creatorResourceID;
            this.DatePurchased = datePurchased;
            this.Description = description;
            this.ExtendedCost = extendedCost;
            this.InternalCurrencyBillableAmount = internalCurrencyBillableAmount;
            this.InternalCurrencyUnitPrice = internalCurrencyUnitPrice;
            this.InternalPurchaseOrderNumber = internalPurchaseOrderNumber;
            this.IsBillableToCompany = isBillableToCompany;
            this.IsBilled = isBilled;
            this.Name = name;
            this.Notes = notes;
            this.OrganizationalLevelAssociationID = organizationalLevelAssociationID;
            this.ProductID = productID;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.Status = status;
            this.StatusLastModifiedBy = statusLastModifiedBy;
            this.StatusLastModifiedDate = statusLastModifiedDate;
            this.TicketID = ticketID;
            this.UnitCost = unitCost;
            this.UnitPrice = unitPrice;
            this.UnitQuantity = unitQuantity;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets BillableAmount
        /// </summary>
        [DataMember(Name="billableAmount", EmitDefaultValue=false)]
        public double? BillableAmount { get; set; }

        /// <summary>
        /// Gets or Sets BillingCodeID
        /// </summary>
        [DataMember(Name="billingCodeID", EmitDefaultValue=false)]
        public long? BillingCodeID { get; set; }

        /// <summary>
        /// Gets or Sets ChargeType
        /// </summary>
        [DataMember(Name="chargeType", EmitDefaultValue=false)]
        public int? ChargeType { get; set; }

        /// <summary>
        /// Gets or Sets ContractServiceBundleID
        /// </summary>
        [DataMember(Name="contractServiceBundleID", EmitDefaultValue=false)]
        public long? ContractServiceBundleID { get; set; }

        /// <summary>
        /// Gets or Sets ContractServiceID
        /// </summary>
        [DataMember(Name="contractServiceID", EmitDefaultValue=false)]
        public long? ContractServiceID { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatorResourceID
        /// </summary>
        [DataMember(Name="creatorResourceID", EmitDefaultValue=false)]
        public long? CreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets DatePurchased
        /// </summary>
        [DataMember(Name="datePurchased", EmitDefaultValue=false)]
        public DateTime? DatePurchased { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedCost
        /// </summary>
        [DataMember(Name="extendedCost", EmitDefaultValue=false)]
        public double? ExtendedCost { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyBillableAmount
        /// </summary>
        [DataMember(Name="internalCurrencyBillableAmount", EmitDefaultValue=false)]
        public double? InternalCurrencyBillableAmount { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyUnitPrice
        /// </summary>
        [DataMember(Name="internalCurrencyUnitPrice", EmitDefaultValue=false)]
        public double? InternalCurrencyUnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets InternalPurchaseOrderNumber
        /// </summary>
        [DataMember(Name="internalPurchaseOrderNumber", EmitDefaultValue=false)]
        public string InternalPurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsBillableToCompany
        /// </summary>
        [DataMember(Name="isBillableToCompany", EmitDefaultValue=false)]
        public bool? IsBillableToCompany { get; set; }

        /// <summary>
        /// Gets or Sets IsBilled
        /// </summary>
        [DataMember(Name="isBilled", EmitDefaultValue=false)]
        public bool? IsBilled { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationalLevelAssociationID
        /// </summary>
        [DataMember(Name="organizationalLevelAssociationID", EmitDefaultValue=false)]
        public int? OrganizationalLevelAssociationID { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="productID", EmitDefaultValue=false)]
        public long? ProductID { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderNumber
        /// </summary>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusLastModifiedBy
        /// </summary>
        [DataMember(Name="statusLastModifiedBy", EmitDefaultValue=false)]
        public long? StatusLastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets StatusLastModifiedDate
        /// </summary>
        [DataMember(Name="statusLastModifiedDate", EmitDefaultValue=false)]
        public DateTime? StatusLastModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets TicketID
        /// </summary>
        [DataMember(Name="ticketID", EmitDefaultValue=false)]
        public long? TicketID { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="unitCost", EmitDefaultValue=false)]
        public double? UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets UnitQuantity
        /// </summary>
        [DataMember(Name="unitQuantity", EmitDefaultValue=false)]
        public double? UnitQuantity { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncTicketCostInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class TicketChargeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BillableAmount: ").Append(BillableAmount).Append("\n");
            sb.Append("  BillingCodeID: ").Append(BillingCodeID).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  ContractServiceBundleID: ").Append(ContractServiceBundleID).Append("\n");
            sb.Append("  ContractServiceID: ").Append(ContractServiceID).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CreatorResourceID: ").Append(CreatorResourceID).Append("\n");
            sb.Append("  DatePurchased: ").Append(DatePurchased).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  InternalCurrencyBillableAmount: ").Append(InternalCurrencyBillableAmount).Append("\n");
            sb.Append("  InternalCurrencyUnitPrice: ").Append(InternalCurrencyUnitPrice).Append("\n");
            sb.Append("  InternalPurchaseOrderNumber: ").Append(InternalPurchaseOrderNumber).Append("\n");
            sb.Append("  IsBillableToCompany: ").Append(IsBillableToCompany).Append("\n");
            sb.Append("  IsBilled: ").Append(IsBilled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  OrganizationalLevelAssociationID: ").Append(OrganizationalLevelAssociationID).Append("\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusLastModifiedBy: ").Append(StatusLastModifiedBy).Append("\n");
            sb.Append("  StatusLastModifiedDate: ").Append(StatusLastModifiedDate).Append("\n");
            sb.Append("  TicketID: ").Append(TicketID).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UnitQuantity: ").Append(UnitQuantity).Append("\n");
            sb.Append("  SoapParentPropertyId: ").Append(SoapParentPropertyId).Append("\n");
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
            return this.Equals(input as TicketChargeModel);
        }

        /// <summary>
        /// Returns true if TicketChargeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TicketChargeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketChargeModel input)
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
                    this.BillableAmount == input.BillableAmount ||
                    (this.BillableAmount != null &&
                    this.BillableAmount.Equals(input.BillableAmount))
                ) && 
                (
                    this.BillingCodeID == input.BillingCodeID ||
                    (this.BillingCodeID != null &&
                    this.BillingCodeID.Equals(input.BillingCodeID))
                ) && 
                (
                    this.ChargeType == input.ChargeType ||
                    (this.ChargeType != null &&
                    this.ChargeType.Equals(input.ChargeType))
                ) && 
                (
                    this.ContractServiceBundleID == input.ContractServiceBundleID ||
                    (this.ContractServiceBundleID != null &&
                    this.ContractServiceBundleID.Equals(input.ContractServiceBundleID))
                ) && 
                (
                    this.ContractServiceID == input.ContractServiceID ||
                    (this.ContractServiceID != null &&
                    this.ContractServiceID.Equals(input.ContractServiceID))
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.CreatorResourceID == input.CreatorResourceID ||
                    (this.CreatorResourceID != null &&
                    this.CreatorResourceID.Equals(input.CreatorResourceID))
                ) && 
                (
                    this.DatePurchased == input.DatePurchased ||
                    (this.DatePurchased != null &&
                    this.DatePurchased.Equals(input.DatePurchased))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExtendedCost == input.ExtendedCost ||
                    (this.ExtendedCost != null &&
                    this.ExtendedCost.Equals(input.ExtendedCost))
                ) && 
                (
                    this.InternalCurrencyBillableAmount == input.InternalCurrencyBillableAmount ||
                    (this.InternalCurrencyBillableAmount != null &&
                    this.InternalCurrencyBillableAmount.Equals(input.InternalCurrencyBillableAmount))
                ) && 
                (
                    this.InternalCurrencyUnitPrice == input.InternalCurrencyUnitPrice ||
                    (this.InternalCurrencyUnitPrice != null &&
                    this.InternalCurrencyUnitPrice.Equals(input.InternalCurrencyUnitPrice))
                ) && 
                (
                    this.InternalPurchaseOrderNumber == input.InternalPurchaseOrderNumber ||
                    (this.InternalPurchaseOrderNumber != null &&
                    this.InternalPurchaseOrderNumber.Equals(input.InternalPurchaseOrderNumber))
                ) && 
                (
                    this.IsBillableToCompany == input.IsBillableToCompany ||
                    (this.IsBillableToCompany != null &&
                    this.IsBillableToCompany.Equals(input.IsBillableToCompany))
                ) && 
                (
                    this.IsBilled == input.IsBilled ||
                    (this.IsBilled != null &&
                    this.IsBilled.Equals(input.IsBilled))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.OrganizationalLevelAssociationID == input.OrganizationalLevelAssociationID ||
                    (this.OrganizationalLevelAssociationID != null &&
                    this.OrganizationalLevelAssociationID.Equals(input.OrganizationalLevelAssociationID))
                ) && 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusLastModifiedBy == input.StatusLastModifiedBy ||
                    (this.StatusLastModifiedBy != null &&
                    this.StatusLastModifiedBy.Equals(input.StatusLastModifiedBy))
                ) && 
                (
                    this.StatusLastModifiedDate == input.StatusLastModifiedDate ||
                    (this.StatusLastModifiedDate != null &&
                    this.StatusLastModifiedDate.Equals(input.StatusLastModifiedDate))
                ) && 
                (
                    this.TicketID == input.TicketID ||
                    (this.TicketID != null &&
                    this.TicketID.Equals(input.TicketID))
                ) && 
                (
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.UnitQuantity == input.UnitQuantity ||
                    (this.UnitQuantity != null &&
                    this.UnitQuantity.Equals(input.UnitQuantity))
                ) && 
                (
                    this.SoapParentPropertyId == input.SoapParentPropertyId ||
                    (this.SoapParentPropertyId != null &&
                    this.SoapParentPropertyId.Equals(input.SoapParentPropertyId))
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
                if (this.BillableAmount != null)
                    hashCode = hashCode * 59 + this.BillableAmount.GetHashCode();
                if (this.BillingCodeID != null)
                    hashCode = hashCode * 59 + this.BillingCodeID.GetHashCode();
                if (this.ChargeType != null)
                    hashCode = hashCode * 59 + this.ChargeType.GetHashCode();
                if (this.ContractServiceBundleID != null)
                    hashCode = hashCode * 59 + this.ContractServiceBundleID.GetHashCode();
                if (this.ContractServiceID != null)
                    hashCode = hashCode * 59 + this.ContractServiceID.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.CreatorResourceID != null)
                    hashCode = hashCode * 59 + this.CreatorResourceID.GetHashCode();
                if (this.DatePurchased != null)
                    hashCode = hashCode * 59 + this.DatePurchased.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtendedCost != null)
                    hashCode = hashCode * 59 + this.ExtendedCost.GetHashCode();
                if (this.InternalCurrencyBillableAmount != null)
                    hashCode = hashCode * 59 + this.InternalCurrencyBillableAmount.GetHashCode();
                if (this.InternalCurrencyUnitPrice != null)
                    hashCode = hashCode * 59 + this.InternalCurrencyUnitPrice.GetHashCode();
                if (this.InternalPurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.InternalPurchaseOrderNumber.GetHashCode();
                if (this.IsBillableToCompany != null)
                    hashCode = hashCode * 59 + this.IsBillableToCompany.GetHashCode();
                if (this.IsBilled != null)
                    hashCode = hashCode * 59 + this.IsBilled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.OrganizationalLevelAssociationID != null)
                    hashCode = hashCode * 59 + this.OrganizationalLevelAssociationID.GetHashCode();
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusLastModifiedBy != null)
                    hashCode = hashCode * 59 + this.StatusLastModifiedBy.GetHashCode();
                if (this.StatusLastModifiedDate != null)
                    hashCode = hashCode * 59 + this.StatusLastModifiedDate.GetHashCode();
                if (this.TicketID != null)
                    hashCode = hashCode * 59 + this.TicketID.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.UnitQuantity != null)
                    hashCode = hashCode * 59 + this.UnitQuantity.GetHashCode();
                if (this.SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + this.SoapParentPropertyId.GetHashCode();
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
