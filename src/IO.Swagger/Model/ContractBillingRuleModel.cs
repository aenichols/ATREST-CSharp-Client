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
    /// ContractBillingRuleModel
    /// </summary>
    [DataContract]
    public partial class ContractBillingRuleModel :  IEquatable<ContractBillingRuleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractBillingRuleModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contractID">contractID.</param>
        /// <param name="createChargesAsBillable">createChargesAsBillable.</param>
        /// <param name="dailyProratedCost">dailyProratedCost.</param>
        /// <param name="dailyProratedPrice">dailyProratedPrice.</param>
        /// <param name="determineUnits">determineUnits.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="executionMethod">executionMethod.</param>
        /// <param name="includeItemsInChargeDescription">includeItemsInChargeDescription.</param>
        /// <param name="invoiceDescription">invoiceDescription.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isDailyProrationEnabled">isDailyProrationEnabled.</param>
        /// <param name="maximumUnits">maximumUnits.</param>
        /// <param name="minimumUnits">minimumUnits.</param>
        /// <param name="productID">productID.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ContractBillingRuleModel(long? id = default(long?), int? contractID = default(int?), bool? createChargesAsBillable = default(bool?), double? dailyProratedCost = default(double?), double? dailyProratedPrice = default(double?), int? determineUnits = default(int?), DateTime? endDate = default(DateTime?), int? executionMethod = default(int?), bool? includeItemsInChargeDescription = default(bool?), string invoiceDescription = default(string), bool? isActive = default(bool?), bool? isDailyProrationEnabled = default(bool?), int? maximumUnits = default(int?), int? minimumUnits = default(int?), int? productID = default(int?), DateTime? startDate = default(DateTime?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.ContractID = contractID;
            this.CreateChargesAsBillable = createChargesAsBillable;
            this.DailyProratedCost = dailyProratedCost;
            this.DailyProratedPrice = dailyProratedPrice;
            this.DetermineUnits = determineUnits;
            this.EndDate = endDate;
            this.ExecutionMethod = executionMethod;
            this.IncludeItemsInChargeDescription = includeItemsInChargeDescription;
            this.InvoiceDescription = invoiceDescription;
            this.IsActive = isActive;
            this.IsDailyProrationEnabled = isDailyProrationEnabled;
            this.MaximumUnits = maximumUnits;
            this.MinimumUnits = minimumUnits;
            this.ProductID = productID;
            this.StartDate = startDate;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="contractID", EmitDefaultValue=false)]
        public int? ContractID { get; set; }

        /// <summary>
        /// Gets or Sets CreateChargesAsBillable
        /// </summary>
        [DataMember(Name="createChargesAsBillable", EmitDefaultValue=false)]
        public bool? CreateChargesAsBillable { get; set; }

        /// <summary>
        /// Gets or Sets DailyProratedCost
        /// </summary>
        [DataMember(Name="dailyProratedCost", EmitDefaultValue=false)]
        public double? DailyProratedCost { get; set; }

        /// <summary>
        /// Gets or Sets DailyProratedPrice
        /// </summary>
        [DataMember(Name="dailyProratedPrice", EmitDefaultValue=false)]
        public double? DailyProratedPrice { get; set; }

        /// <summary>
        /// Gets or Sets DetermineUnits
        /// </summary>
        [DataMember(Name="determineUnits", EmitDefaultValue=false)]
        public int? DetermineUnits { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionMethod
        /// </summary>
        [DataMember(Name="executionMethod", EmitDefaultValue=false)]
        public int? ExecutionMethod { get; set; }

        /// <summary>
        /// Gets or Sets IncludeItemsInChargeDescription
        /// </summary>
        [DataMember(Name="includeItemsInChargeDescription", EmitDefaultValue=false)]
        public bool? IncludeItemsInChargeDescription { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDescription
        /// </summary>
        [DataMember(Name="invoiceDescription", EmitDefaultValue=false)]
        public string InvoiceDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsDailyProrationEnabled
        /// </summary>
        [DataMember(Name="isDailyProrationEnabled", EmitDefaultValue=false)]
        public bool? IsDailyProrationEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MaximumUnits
        /// </summary>
        [DataMember(Name="maximumUnits", EmitDefaultValue=false)]
        public int? MaximumUnits { get; set; }

        /// <summary>
        /// Gets or Sets MinimumUnits
        /// </summary>
        [DataMember(Name="minimumUnits", EmitDefaultValue=false)]
        public int? MinimumUnits { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="productID", EmitDefaultValue=false)]
        public int? ProductID { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncContractBillingRuleInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ContractBillingRuleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  CreateChargesAsBillable: ").Append(CreateChargesAsBillable).Append("\n");
            sb.Append("  DailyProratedCost: ").Append(DailyProratedCost).Append("\n");
            sb.Append("  DailyProratedPrice: ").Append(DailyProratedPrice).Append("\n");
            sb.Append("  DetermineUnits: ").Append(DetermineUnits).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExecutionMethod: ").Append(ExecutionMethod).Append("\n");
            sb.Append("  IncludeItemsInChargeDescription: ").Append(IncludeItemsInChargeDescription).Append("\n");
            sb.Append("  InvoiceDescription: ").Append(InvoiceDescription).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDailyProrationEnabled: ").Append(IsDailyProrationEnabled).Append("\n");
            sb.Append("  MaximumUnits: ").Append(MaximumUnits).Append("\n");
            sb.Append("  MinimumUnits: ").Append(MinimumUnits).Append("\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as ContractBillingRuleModel);
        }

        /// <summary>
        /// Returns true if ContractBillingRuleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractBillingRuleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractBillingRuleModel input)
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
                    this.ContractID == input.ContractID ||
                    (this.ContractID != null &&
                    this.ContractID.Equals(input.ContractID))
                ) && 
                (
                    this.CreateChargesAsBillable == input.CreateChargesAsBillable ||
                    (this.CreateChargesAsBillable != null &&
                    this.CreateChargesAsBillable.Equals(input.CreateChargesAsBillable))
                ) && 
                (
                    this.DailyProratedCost == input.DailyProratedCost ||
                    (this.DailyProratedCost != null &&
                    this.DailyProratedCost.Equals(input.DailyProratedCost))
                ) && 
                (
                    this.DailyProratedPrice == input.DailyProratedPrice ||
                    (this.DailyProratedPrice != null &&
                    this.DailyProratedPrice.Equals(input.DailyProratedPrice))
                ) && 
                (
                    this.DetermineUnits == input.DetermineUnits ||
                    (this.DetermineUnits != null &&
                    this.DetermineUnits.Equals(input.DetermineUnits))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ExecutionMethod == input.ExecutionMethod ||
                    (this.ExecutionMethod != null &&
                    this.ExecutionMethod.Equals(input.ExecutionMethod))
                ) && 
                (
                    this.IncludeItemsInChargeDescription == input.IncludeItemsInChargeDescription ||
                    (this.IncludeItemsInChargeDescription != null &&
                    this.IncludeItemsInChargeDescription.Equals(input.IncludeItemsInChargeDescription))
                ) && 
                (
                    this.InvoiceDescription == input.InvoiceDescription ||
                    (this.InvoiceDescription != null &&
                    this.InvoiceDescription.Equals(input.InvoiceDescription))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsDailyProrationEnabled == input.IsDailyProrationEnabled ||
                    (this.IsDailyProrationEnabled != null &&
                    this.IsDailyProrationEnabled.Equals(input.IsDailyProrationEnabled))
                ) && 
                (
                    this.MaximumUnits == input.MaximumUnits ||
                    (this.MaximumUnits != null &&
                    this.MaximumUnits.Equals(input.MaximumUnits))
                ) && 
                (
                    this.MinimumUnits == input.MinimumUnits ||
                    (this.MinimumUnits != null &&
                    this.MinimumUnits.Equals(input.MinimumUnits))
                ) && 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.ContractID != null)
                    hashCode = hashCode * 59 + this.ContractID.GetHashCode();
                if (this.CreateChargesAsBillable != null)
                    hashCode = hashCode * 59 + this.CreateChargesAsBillable.GetHashCode();
                if (this.DailyProratedCost != null)
                    hashCode = hashCode * 59 + this.DailyProratedCost.GetHashCode();
                if (this.DailyProratedPrice != null)
                    hashCode = hashCode * 59 + this.DailyProratedPrice.GetHashCode();
                if (this.DetermineUnits != null)
                    hashCode = hashCode * 59 + this.DetermineUnits.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ExecutionMethod != null)
                    hashCode = hashCode * 59 + this.ExecutionMethod.GetHashCode();
                if (this.IncludeItemsInChargeDescription != null)
                    hashCode = hashCode * 59 + this.IncludeItemsInChargeDescription.GetHashCode();
                if (this.InvoiceDescription != null)
                    hashCode = hashCode * 59 + this.InvoiceDescription.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsDailyProrationEnabled != null)
                    hashCode = hashCode * 59 + this.IsDailyProrationEnabled.GetHashCode();
                if (this.MaximumUnits != null)
                    hashCode = hashCode * 59 + this.MaximumUnits.GetHashCode();
                if (this.MinimumUnits != null)
                    hashCode = hashCode * 59 + this.MinimumUnits.GetHashCode();
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
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
