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
    /// BillingCodeModel
    /// </summary>
    [DataContract]
    public partial class BillingCodeModel :  IEquatable<BillingCodeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCodeModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="afterHoursWorkType">afterHoursWorkType.</param>
        /// <param name="billingCodeType">billingCodeType.</param>
        /// <param name="department">department.</param>
        /// <param name="description">description.</param>
        /// <param name="externalNumber">externalNumber.</param>
        /// <param name="generalLedgerAccount">generalLedgerAccount.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isExcludedFromNewContracts">isExcludedFromNewContracts.</param>
        /// <param name="markupRate">markupRate.</param>
        /// <param name="name">name.</param>
        /// <param name="taxCategoryID">taxCategoryID.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="useType">useType.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public BillingCodeModel(long? id = default(long?), int? afterHoursWorkType = default(int?), int? billingCodeType = default(int?), int? department = default(int?), string description = default(string), string externalNumber = default(string), int? generalLedgerAccount = default(int?), bool? isActive = default(bool?), bool? isExcludedFromNewContracts = default(bool?), double? markupRate = default(double?), string name = default(string), int? taxCategoryID = default(int?), double? unitCost = default(double?), double? unitPrice = default(double?), int? useType = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.AfterHoursWorkType = afterHoursWorkType;
            this.BillingCodeType = billingCodeType;
            this.Department = department;
            this.Description = description;
            this.ExternalNumber = externalNumber;
            this.GeneralLedgerAccount = generalLedgerAccount;
            this.IsActive = isActive;
            this.IsExcludedFromNewContracts = isExcludedFromNewContracts;
            this.MarkupRate = markupRate;
            this.Name = name;
            this.TaxCategoryID = taxCategoryID;
            this.UnitCost = unitCost;
            this.UnitPrice = unitPrice;
            this.UseType = useType;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets AfterHoursWorkType
        /// </summary>
        [DataMember(Name="afterHoursWorkType", EmitDefaultValue=false)]
        public int? AfterHoursWorkType { get; set; }

        /// <summary>
        /// Gets or Sets BillingCodeType
        /// </summary>
        [DataMember(Name="billingCodeType", EmitDefaultValue=false)]
        public int? BillingCodeType { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public int? Department { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExternalNumber
        /// </summary>
        [DataMember(Name="externalNumber", EmitDefaultValue=false)]
        public string ExternalNumber { get; set; }

        /// <summary>
        /// Gets or Sets GeneralLedgerAccount
        /// </summary>
        [DataMember(Name="generalLedgerAccount", EmitDefaultValue=false)]
        public int? GeneralLedgerAccount { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsExcludedFromNewContracts
        /// </summary>
        [DataMember(Name="isExcludedFromNewContracts", EmitDefaultValue=false)]
        public bool? IsExcludedFromNewContracts { get; set; }

        /// <summary>
        /// Gets or Sets MarkupRate
        /// </summary>
        [DataMember(Name="markupRate", EmitDefaultValue=false)]
        public double? MarkupRate { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategoryID
        /// </summary>
        [DataMember(Name="taxCategoryID", EmitDefaultValue=false)]
        public int? TaxCategoryID { get; set; }

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
        /// Gets or Sets UseType
        /// </summary>
        [DataMember(Name="useType", EmitDefaultValue=false)]
        public int? UseType { get; set; }

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
            sb.Append("class BillingCodeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AfterHoursWorkType: ").Append(AfterHoursWorkType).Append("\n");
            sb.Append("  BillingCodeType: ").Append(BillingCodeType).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalNumber: ").Append(ExternalNumber).Append("\n");
            sb.Append("  GeneralLedgerAccount: ").Append(GeneralLedgerAccount).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsExcludedFromNewContracts: ").Append(IsExcludedFromNewContracts).Append("\n");
            sb.Append("  MarkupRate: ").Append(MarkupRate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TaxCategoryID: ").Append(TaxCategoryID).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UseType: ").Append(UseType).Append("\n");
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
            return this.Equals(input as BillingCodeModel);
        }

        /// <summary>
        /// Returns true if BillingCodeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingCodeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingCodeModel input)
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
                    this.AfterHoursWorkType == input.AfterHoursWorkType ||
                    (this.AfterHoursWorkType != null &&
                    this.AfterHoursWorkType.Equals(input.AfterHoursWorkType))
                ) && 
                (
                    this.BillingCodeType == input.BillingCodeType ||
                    (this.BillingCodeType != null &&
                    this.BillingCodeType.Equals(input.BillingCodeType))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExternalNumber == input.ExternalNumber ||
                    (this.ExternalNumber != null &&
                    this.ExternalNumber.Equals(input.ExternalNumber))
                ) && 
                (
                    this.GeneralLedgerAccount == input.GeneralLedgerAccount ||
                    (this.GeneralLedgerAccount != null &&
                    this.GeneralLedgerAccount.Equals(input.GeneralLedgerAccount))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsExcludedFromNewContracts == input.IsExcludedFromNewContracts ||
                    (this.IsExcludedFromNewContracts != null &&
                    this.IsExcludedFromNewContracts.Equals(input.IsExcludedFromNewContracts))
                ) && 
                (
                    this.MarkupRate == input.MarkupRate ||
                    (this.MarkupRate != null &&
                    this.MarkupRate.Equals(input.MarkupRate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TaxCategoryID == input.TaxCategoryID ||
                    (this.TaxCategoryID != null &&
                    this.TaxCategoryID.Equals(input.TaxCategoryID))
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
                    this.UseType == input.UseType ||
                    (this.UseType != null &&
                    this.UseType.Equals(input.UseType))
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
                if (this.AfterHoursWorkType != null)
                    hashCode = hashCode * 59 + this.AfterHoursWorkType.GetHashCode();
                if (this.BillingCodeType != null)
                    hashCode = hashCode * 59 + this.BillingCodeType.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalNumber != null)
                    hashCode = hashCode * 59 + this.ExternalNumber.GetHashCode();
                if (this.GeneralLedgerAccount != null)
                    hashCode = hashCode * 59 + this.GeneralLedgerAccount.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsExcludedFromNewContracts != null)
                    hashCode = hashCode * 59 + this.IsExcludedFromNewContracts.GetHashCode();
                if (this.MarkupRate != null)
                    hashCode = hashCode * 59 + this.MarkupRate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TaxCategoryID != null)
                    hashCode = hashCode * 59 + this.TaxCategoryID.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.UseType != null)
                    hashCode = hashCode * 59 + this.UseType.GetHashCode();
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