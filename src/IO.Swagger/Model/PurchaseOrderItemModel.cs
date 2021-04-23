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
    /// PurchaseOrderItemModel
    /// </summary>
    [DataContract]
    public partial class PurchaseOrderItemModel :  IEquatable<PurchaseOrderItemModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderItemModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="chargeID">chargeID.</param>
        /// <param name="contractID">contractID.</param>
        /// <param name="estimatedArrivalDate">estimatedArrivalDate.</param>
        /// <param name="internalCurrencyUnitCost">internalCurrencyUnitCost.</param>
        /// <param name="inventoryLocationID">inventoryLocationID.</param>
        /// <param name="memo">memo.</param>
        /// <param name="orderID">orderID.</param>
        /// <param name="productID">productID.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="salesOrderID">salesOrderID.</param>
        /// <param name="ticketID">ticketID.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public PurchaseOrderItemModel(long? id = default(long?), int? chargeID = default(int?), long? contractID = default(long?), DateTime? estimatedArrivalDate = default(DateTime?), double? internalCurrencyUnitCost = default(double?), int? inventoryLocationID = default(int?), string memo = default(string), int? orderID = default(int?), int? productID = default(int?), long? projectID = default(long?), int? quantity = default(int?), long? salesOrderID = default(long?), long? ticketID = default(long?), double? unitCost = default(double?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.ChargeID = chargeID;
            this.ContractID = contractID;
            this.EstimatedArrivalDate = estimatedArrivalDate;
            this.InternalCurrencyUnitCost = internalCurrencyUnitCost;
            this.InventoryLocationID = inventoryLocationID;
            this.Memo = memo;
            this.OrderID = orderID;
            this.ProductID = productID;
            this.ProjectID = projectID;
            this.Quantity = quantity;
            this.SalesOrderID = salesOrderID;
            this.TicketID = ticketID;
            this.UnitCost = unitCost;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ChargeID
        /// </summary>
        [DataMember(Name="chargeID", EmitDefaultValue=false)]
        public int? ChargeID { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="contractID", EmitDefaultValue=false)]
        public long? ContractID { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedArrivalDate
        /// </summary>
        [DataMember(Name="estimatedArrivalDate", EmitDefaultValue=false)]
        public DateTime? EstimatedArrivalDate { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyUnitCost
        /// </summary>
        [DataMember(Name="internalCurrencyUnitCost", EmitDefaultValue=false)]
        public double? InternalCurrencyUnitCost { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocationID
        /// </summary>
        [DataMember(Name="inventoryLocationID", EmitDefaultValue=false)]
        public int? InventoryLocationID { get; set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name="memo", EmitDefaultValue=false)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or Sets OrderID
        /// </summary>
        [DataMember(Name="orderID", EmitDefaultValue=false)]
        public int? OrderID { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="productID", EmitDefaultValue=false)]
        public int? ProductID { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="projectID", EmitDefaultValue=false)]
        public long? ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets SalesOrderID
        /// </summary>
        [DataMember(Name="salesOrderID", EmitDefaultValue=false)]
        public long? SalesOrderID { get; set; }

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
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncPurchaseOrderItemInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class PurchaseOrderItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChargeID: ").Append(ChargeID).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  EstimatedArrivalDate: ").Append(EstimatedArrivalDate).Append("\n");
            sb.Append("  InternalCurrencyUnitCost: ").Append(InternalCurrencyUnitCost).Append("\n");
            sb.Append("  InventoryLocationID: ").Append(InventoryLocationID).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  OrderID: ").Append(OrderID).Append("\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SalesOrderID: ").Append(SalesOrderID).Append("\n");
            sb.Append("  TicketID: ").Append(TicketID).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
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
            return this.Equals(input as PurchaseOrderItemModel);
        }

        /// <summary>
        /// Returns true if PurchaseOrderItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrderItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrderItemModel input)
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
                    this.ChargeID == input.ChargeID ||
                    (this.ChargeID != null &&
                    this.ChargeID.Equals(input.ChargeID))
                ) && 
                (
                    this.ContractID == input.ContractID ||
                    (this.ContractID != null &&
                    this.ContractID.Equals(input.ContractID))
                ) && 
                (
                    this.EstimatedArrivalDate == input.EstimatedArrivalDate ||
                    (this.EstimatedArrivalDate != null &&
                    this.EstimatedArrivalDate.Equals(input.EstimatedArrivalDate))
                ) && 
                (
                    this.InternalCurrencyUnitCost == input.InternalCurrencyUnitCost ||
                    (this.InternalCurrencyUnitCost != null &&
                    this.InternalCurrencyUnitCost.Equals(input.InternalCurrencyUnitCost))
                ) && 
                (
                    this.InventoryLocationID == input.InventoryLocationID ||
                    (this.InventoryLocationID != null &&
                    this.InventoryLocationID.Equals(input.InventoryLocationID))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.OrderID == input.OrderID ||
                    (this.OrderID != null &&
                    this.OrderID.Equals(input.OrderID))
                ) && 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.SalesOrderID == input.SalesOrderID ||
                    (this.SalesOrderID != null &&
                    this.SalesOrderID.Equals(input.SalesOrderID))
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
                if (this.ChargeID != null)
                    hashCode = hashCode * 59 + this.ChargeID.GetHashCode();
                if (this.ContractID != null)
                    hashCode = hashCode * 59 + this.ContractID.GetHashCode();
                if (this.EstimatedArrivalDate != null)
                    hashCode = hashCode * 59 + this.EstimatedArrivalDate.GetHashCode();
                if (this.InternalCurrencyUnitCost != null)
                    hashCode = hashCode * 59 + this.InternalCurrencyUnitCost.GetHashCode();
                if (this.InventoryLocationID != null)
                    hashCode = hashCode * 59 + this.InventoryLocationID.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.OrderID != null)
                    hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.SalesOrderID != null)
                    hashCode = hashCode * 59 + this.SalesOrderID.GetHashCode();
                if (this.TicketID != null)
                    hashCode = hashCode * 59 + this.TicketID.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
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
