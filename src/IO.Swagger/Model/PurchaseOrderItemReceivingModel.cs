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
    /// PurchaseOrderItemReceivingModel
    /// </summary>
    [DataContract]
    public partial class PurchaseOrderItemReceivingModel :  IEquatable<PurchaseOrderItemReceivingModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderItemReceivingModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="purchaseOrderItemID">purchaseOrderItemID.</param>
        /// <param name="quantityBackOrdered">quantityBackOrdered.</param>
        /// <param name="quantityNowReceiving">quantityNowReceiving.</param>
        /// <param name="quantityPreviouslyReceived">quantityPreviouslyReceived.</param>
        /// <param name="receiveDate">receiveDate.</param>
        /// <param name="receivedByResourceID">receivedByResourceID.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public PurchaseOrderItemReceivingModel(long? id = default(long?), long? purchaseOrderItemID = default(long?), int? quantityBackOrdered = default(int?), int? quantityNowReceiving = default(int?), int? quantityPreviouslyReceived = default(int?), DateTime? receiveDate = default(DateTime?), int? receivedByResourceID = default(int?), string serialNumber = default(string), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.PurchaseOrderItemID = purchaseOrderItemID;
            this.QuantityBackOrdered = quantityBackOrdered;
            this.QuantityNowReceiving = quantityNowReceiving;
            this.QuantityPreviouslyReceived = quantityPreviouslyReceived;
            this.ReceiveDate = receiveDate;
            this.ReceivedByResourceID = receivedByResourceID;
            this.SerialNumber = serialNumber;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderItemID
        /// </summary>
        [DataMember(Name="purchaseOrderItemID", EmitDefaultValue=false)]
        public long? PurchaseOrderItemID { get; set; }

        /// <summary>
        /// Gets or Sets QuantityBackOrdered
        /// </summary>
        [DataMember(Name="quantityBackOrdered", EmitDefaultValue=false)]
        public int? QuantityBackOrdered { get; set; }

        /// <summary>
        /// Gets or Sets QuantityNowReceiving
        /// </summary>
        [DataMember(Name="quantityNowReceiving", EmitDefaultValue=false)]
        public int? QuantityNowReceiving { get; set; }

        /// <summary>
        /// Gets or Sets QuantityPreviouslyReceived
        /// </summary>
        [DataMember(Name="quantityPreviouslyReceived", EmitDefaultValue=false)]
        public int? QuantityPreviouslyReceived { get; set; }

        /// <summary>
        /// Gets or Sets ReceiveDate
        /// </summary>
        [DataMember(Name="receiveDate", EmitDefaultValue=false)]
        public DateTime? ReceiveDate { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedByResourceID
        /// </summary>
        [DataMember(Name="receivedByResourceID", EmitDefaultValue=false)]
        public int? ReceivedByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncPurchaseOrderReceiveInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class PurchaseOrderItemReceivingModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PurchaseOrderItemID: ").Append(PurchaseOrderItemID).Append("\n");
            sb.Append("  QuantityBackOrdered: ").Append(QuantityBackOrdered).Append("\n");
            sb.Append("  QuantityNowReceiving: ").Append(QuantityNowReceiving).Append("\n");
            sb.Append("  QuantityPreviouslyReceived: ").Append(QuantityPreviouslyReceived).Append("\n");
            sb.Append("  ReceiveDate: ").Append(ReceiveDate).Append("\n");
            sb.Append("  ReceivedByResourceID: ").Append(ReceivedByResourceID).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
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
            return this.Equals(input as PurchaseOrderItemReceivingModel);
        }

        /// <summary>
        /// Returns true if PurchaseOrderItemReceivingModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrderItemReceivingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrderItemReceivingModel input)
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
                    this.PurchaseOrderItemID == input.PurchaseOrderItemID ||
                    (this.PurchaseOrderItemID != null &&
                    this.PurchaseOrderItemID.Equals(input.PurchaseOrderItemID))
                ) && 
                (
                    this.QuantityBackOrdered == input.QuantityBackOrdered ||
                    (this.QuantityBackOrdered != null &&
                    this.QuantityBackOrdered.Equals(input.QuantityBackOrdered))
                ) && 
                (
                    this.QuantityNowReceiving == input.QuantityNowReceiving ||
                    (this.QuantityNowReceiving != null &&
                    this.QuantityNowReceiving.Equals(input.QuantityNowReceiving))
                ) && 
                (
                    this.QuantityPreviouslyReceived == input.QuantityPreviouslyReceived ||
                    (this.QuantityPreviouslyReceived != null &&
                    this.QuantityPreviouslyReceived.Equals(input.QuantityPreviouslyReceived))
                ) && 
                (
                    this.ReceiveDate == input.ReceiveDate ||
                    (this.ReceiveDate != null &&
                    this.ReceiveDate.Equals(input.ReceiveDate))
                ) && 
                (
                    this.ReceivedByResourceID == input.ReceivedByResourceID ||
                    (this.ReceivedByResourceID != null &&
                    this.ReceivedByResourceID.Equals(input.ReceivedByResourceID))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
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
                if (this.PurchaseOrderItemID != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderItemID.GetHashCode();
                if (this.QuantityBackOrdered != null)
                    hashCode = hashCode * 59 + this.QuantityBackOrdered.GetHashCode();
                if (this.QuantityNowReceiving != null)
                    hashCode = hashCode * 59 + this.QuantityNowReceiving.GetHashCode();
                if (this.QuantityPreviouslyReceived != null)
                    hashCode = hashCode * 59 + this.QuantityPreviouslyReceived.GetHashCode();
                if (this.ReceiveDate != null)
                    hashCode = hashCode * 59 + this.ReceiveDate.GetHashCode();
                if (this.ReceivedByResourceID != null)
                    hashCode = hashCode * 59 + this.ReceivedByResourceID.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
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
