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
    /// ContractServiceAdjustmentModel
    /// </summary>
    [DataContract]
    public partial class ContractServiceAdjustmentModel :  IEquatable<ContractServiceAdjustmentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractServiceAdjustmentModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="adjustedUnitCost">adjustedUnitCost.</param>
        /// <param name="adjustedUnitPrice">adjustedUnitPrice.</param>
        /// <param name="allowRepeatService">allowRepeatService.</param>
        /// <param name="contractID">contractID.</param>
        /// <param name="contractServiceID">contractServiceID.</param>
        /// <param name="effectiveDate">effectiveDate.</param>
        /// <param name="quoteItemID">quoteItemID.</param>
        /// <param name="serviceID">serviceID.</param>
        /// <param name="unitChange">unitChange.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ContractServiceAdjustmentModel(long? id = default(long?), double? adjustedUnitCost = default(double?), double? adjustedUnitPrice = default(double?), bool? allowRepeatService = default(bool?), int? contractID = default(int?), int? contractServiceID = default(int?), DateTime? effectiveDate = default(DateTime?), int? quoteItemID = default(int?), int? serviceID = default(int?), int? unitChange = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.AdjustedUnitCost = adjustedUnitCost;
            this.AdjustedUnitPrice = adjustedUnitPrice;
            this.AllowRepeatService = allowRepeatService;
            this.ContractID = contractID;
            this.ContractServiceID = contractServiceID;
            this.EffectiveDate = effectiveDate;
            this.QuoteItemID = quoteItemID;
            this.ServiceID = serviceID;
            this.UnitChange = unitChange;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedUnitCost
        /// </summary>
        [DataMember(Name="adjustedUnitCost", EmitDefaultValue=false)]
        public double? AdjustedUnitCost { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedUnitPrice
        /// </summary>
        [DataMember(Name="adjustedUnitPrice", EmitDefaultValue=false)]
        public double? AdjustedUnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets AllowRepeatService
        /// </summary>
        [DataMember(Name="allowRepeatService", EmitDefaultValue=false)]
        public bool? AllowRepeatService { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="contractID", EmitDefaultValue=false)]
        public int? ContractID { get; set; }

        /// <summary>
        /// Gets or Sets ContractServiceID
        /// </summary>
        [DataMember(Name="contractServiceID", EmitDefaultValue=false)]
        public int? ContractServiceID { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets QuoteItemID
        /// </summary>
        [DataMember(Name="quoteItemID", EmitDefaultValue=false)]
        public int? QuoteItemID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceID
        /// </summary>
        [DataMember(Name="serviceID", EmitDefaultValue=false)]
        public int? ServiceID { get; set; }

        /// <summary>
        /// Gets or Sets UnitChange
        /// </summary>
        [DataMember(Name="unitChange", EmitDefaultValue=false)]
        public int? UnitChange { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncContractServiceAdjustmentInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ContractServiceAdjustmentModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AdjustedUnitCost: ").Append(AdjustedUnitCost).Append("\n");
            sb.Append("  AdjustedUnitPrice: ").Append(AdjustedUnitPrice).Append("\n");
            sb.Append("  AllowRepeatService: ").Append(AllowRepeatService).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  ContractServiceID: ").Append(ContractServiceID).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  QuoteItemID: ").Append(QuoteItemID).Append("\n");
            sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
            sb.Append("  UnitChange: ").Append(UnitChange).Append("\n");
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
            return this.Equals(input as ContractServiceAdjustmentModel);
        }

        /// <summary>
        /// Returns true if ContractServiceAdjustmentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractServiceAdjustmentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractServiceAdjustmentModel input)
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
                    this.AdjustedUnitCost == input.AdjustedUnitCost ||
                    (this.AdjustedUnitCost != null &&
                    this.AdjustedUnitCost.Equals(input.AdjustedUnitCost))
                ) && 
                (
                    this.AdjustedUnitPrice == input.AdjustedUnitPrice ||
                    (this.AdjustedUnitPrice != null &&
                    this.AdjustedUnitPrice.Equals(input.AdjustedUnitPrice))
                ) && 
                (
                    this.AllowRepeatService == input.AllowRepeatService ||
                    (this.AllowRepeatService != null &&
                    this.AllowRepeatService.Equals(input.AllowRepeatService))
                ) && 
                (
                    this.ContractID == input.ContractID ||
                    (this.ContractID != null &&
                    this.ContractID.Equals(input.ContractID))
                ) && 
                (
                    this.ContractServiceID == input.ContractServiceID ||
                    (this.ContractServiceID != null &&
                    this.ContractServiceID.Equals(input.ContractServiceID))
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.QuoteItemID == input.QuoteItemID ||
                    (this.QuoteItemID != null &&
                    this.QuoteItemID.Equals(input.QuoteItemID))
                ) && 
                (
                    this.ServiceID == input.ServiceID ||
                    (this.ServiceID != null &&
                    this.ServiceID.Equals(input.ServiceID))
                ) && 
                (
                    this.UnitChange == input.UnitChange ||
                    (this.UnitChange != null &&
                    this.UnitChange.Equals(input.UnitChange))
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
                if (this.AdjustedUnitCost != null)
                    hashCode = hashCode * 59 + this.AdjustedUnitCost.GetHashCode();
                if (this.AdjustedUnitPrice != null)
                    hashCode = hashCode * 59 + this.AdjustedUnitPrice.GetHashCode();
                if (this.AllowRepeatService != null)
                    hashCode = hashCode * 59 + this.AllowRepeatService.GetHashCode();
                if (this.ContractID != null)
                    hashCode = hashCode * 59 + this.ContractID.GetHashCode();
                if (this.ContractServiceID != null)
                    hashCode = hashCode * 59 + this.ContractServiceID.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.QuoteItemID != null)
                    hashCode = hashCode * 59 + this.QuoteItemID.GetHashCode();
                if (this.ServiceID != null)
                    hashCode = hashCode * 59 + this.ServiceID.GetHashCode();
                if (this.UnitChange != null)
                    hashCode = hashCode * 59 + this.UnitChange.GetHashCode();
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
