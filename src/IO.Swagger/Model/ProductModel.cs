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
    /// ProductModel
    /// </summary>
    [DataContract]
    public partial class ProductModel :  IEquatable<ProductModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="billingType">billingType.</param>
        /// <param name="chargeBillingCodeID">chargeBillingCodeID.</param>
        /// <param name="defaultVendorID">defaultVendorID.</param>
        /// <param name="description">description.</param>
        /// <param name="doesNotRequireProcurement">doesNotRequireProcurement.</param>
        /// <param name="externalProductID">externalProductID.</param>
        /// <param name="impersonatorCreatorResourceID">impersonatorCreatorResourceID.</param>
        /// <param name="internalProductID">internalProductID.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isEligibleForRma">isEligibleForRma.</param>
        /// <param name="isSerialized">isSerialized.</param>
        /// <param name="link">link.</param>
        /// <param name="manufacturerName">manufacturerName.</param>
        /// <param name="manufacturerProductName">manufacturerProductName.</param>
        /// <param name="markupRate">markupRate.</param>
        /// <param name="msrp">msrp.</param>
        /// <param name="name">name.</param>
        /// <param name="periodType">periodType.</param>
        /// <param name="priceCostMethod">priceCostMethod.</param>
        /// <param name="productBillingCodeID">productBillingCodeID.</param>
        /// <param name="productCategory">productCategory.</param>
        /// <param name="sku">sku.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="vendorProductNumber">vendorProductNumber.</param>
        /// <param name="defaultInstalledProductCategoryID">defaultInstalledProductCategoryID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ProductModel(long? id = default(long?), int? billingType = default(int?), int? chargeBillingCodeID = default(int?), int? defaultVendorID = default(int?), string description = default(string), bool? doesNotRequireProcurement = default(bool?), string externalProductID = default(string), int? impersonatorCreatorResourceID = default(int?), string internalProductID = default(string), bool? isActive = default(bool?), bool? isEligibleForRma = default(bool?), bool? isSerialized = default(bool?), string link = default(string), string manufacturerName = default(string), string manufacturerProductName = default(string), double? markupRate = default(double?), double? msrp = default(double?), string name = default(string), int? periodType = default(int?), int? priceCostMethod = default(int?), int? productBillingCodeID = default(int?), int? productCategory = default(int?), string sku = default(string), double? unitCost = default(double?), double? unitPrice = default(double?), string vendorProductNumber = default(string), int? defaultInstalledProductCategoryID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.BillingType = billingType;
            this.ChargeBillingCodeID = chargeBillingCodeID;
            this.DefaultVendorID = defaultVendorID;
            this.Description = description;
            this.DoesNotRequireProcurement = doesNotRequireProcurement;
            this.ExternalProductID = externalProductID;
            this.ImpersonatorCreatorResourceID = impersonatorCreatorResourceID;
            this.InternalProductID = internalProductID;
            this.IsActive = isActive;
            this.IsEligibleForRma = isEligibleForRma;
            this.IsSerialized = isSerialized;
            this.Link = link;
            this.ManufacturerName = manufacturerName;
            this.ManufacturerProductName = manufacturerProductName;
            this.MarkupRate = markupRate;
            this.Msrp = msrp;
            this.Name = name;
            this.PeriodType = periodType;
            this.PriceCostMethod = priceCostMethod;
            this.ProductBillingCodeID = productBillingCodeID;
            this.ProductCategory = productCategory;
            this.Sku = sku;
            this.UnitCost = unitCost;
            this.UnitPrice = unitPrice;
            this.VendorProductNumber = vendorProductNumber;
            this.DefaultInstalledProductCategoryID = defaultInstalledProductCategoryID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets BillingType
        /// </summary>
        [DataMember(Name="billingType", EmitDefaultValue=false)]
        public int? BillingType { get; set; }

        /// <summary>
        /// Gets or Sets ChargeBillingCodeID
        /// </summary>
        [DataMember(Name="chargeBillingCodeID", EmitDefaultValue=false)]
        public int? ChargeBillingCodeID { get; set; }

        /// <summary>
        /// Gets or Sets DefaultVendorID
        /// </summary>
        [DataMember(Name="defaultVendorID", EmitDefaultValue=false)]
        public int? DefaultVendorID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DoesNotRequireProcurement
        /// </summary>
        [DataMember(Name="doesNotRequireProcurement", EmitDefaultValue=false)]
        public bool? DoesNotRequireProcurement { get; set; }

        /// <summary>
        /// Gets or Sets ExternalProductID
        /// </summary>
        [DataMember(Name="externalProductID", EmitDefaultValue=false)]
        public string ExternalProductID { get; set; }

        /// <summary>
        /// Gets or Sets ImpersonatorCreatorResourceID
        /// </summary>
        [DataMember(Name="impersonatorCreatorResourceID", EmitDefaultValue=false)]
        public int? ImpersonatorCreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets InternalProductID
        /// </summary>
        [DataMember(Name="internalProductID", EmitDefaultValue=false)]
        public string InternalProductID { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsEligibleForRma
        /// </summary>
        [DataMember(Name="isEligibleForRma", EmitDefaultValue=false)]
        public bool? IsEligibleForRma { get; set; }

        /// <summary>
        /// Gets or Sets IsSerialized
        /// </summary>
        [DataMember(Name="isSerialized", EmitDefaultValue=false)]
        public bool? IsSerialized { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerName
        /// </summary>
        [DataMember(Name="manufacturerName", EmitDefaultValue=false)]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerProductName
        /// </summary>
        [DataMember(Name="manufacturerProductName", EmitDefaultValue=false)]
        public string ManufacturerProductName { get; set; }

        /// <summary>
        /// Gets or Sets MarkupRate
        /// </summary>
        [DataMember(Name="markupRate", EmitDefaultValue=false)]
        public double? MarkupRate { get; set; }

        /// <summary>
        /// Gets or Sets Msrp
        /// </summary>
        [DataMember(Name="msrp", EmitDefaultValue=false)]
        public double? Msrp { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PeriodType
        /// </summary>
        [DataMember(Name="periodType", EmitDefaultValue=false)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// Gets or Sets PriceCostMethod
        /// </summary>
        [DataMember(Name="priceCostMethod", EmitDefaultValue=false)]
        public int? PriceCostMethod { get; set; }

        /// <summary>
        /// Gets or Sets ProductBillingCodeID
        /// </summary>
        [DataMember(Name="productBillingCodeID", EmitDefaultValue=false)]
        public int? ProductBillingCodeID { get; set; }

        /// <summary>
        /// Gets or Sets ProductCategory
        /// </summary>
        [DataMember(Name="productCategory", EmitDefaultValue=false)]
        public int? ProductCategory { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

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
        /// Gets or Sets VendorProductNumber
        /// </summary>
        [DataMember(Name="vendorProductNumber", EmitDefaultValue=false)]
        public string VendorProductNumber { get; set; }

        /// <summary>
        /// Gets or Sets DefaultInstalledProductCategoryID
        /// </summary>
        [DataMember(Name="defaultInstalledProductCategoryID", EmitDefaultValue=false)]
        public int? DefaultInstalledProductCategoryID { get; set; }

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
            sb.Append("class ProductModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BillingType: ").Append(BillingType).Append("\n");
            sb.Append("  ChargeBillingCodeID: ").Append(ChargeBillingCodeID).Append("\n");
            sb.Append("  DefaultVendorID: ").Append(DefaultVendorID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DoesNotRequireProcurement: ").Append(DoesNotRequireProcurement).Append("\n");
            sb.Append("  ExternalProductID: ").Append(ExternalProductID).Append("\n");
            sb.Append("  ImpersonatorCreatorResourceID: ").Append(ImpersonatorCreatorResourceID).Append("\n");
            sb.Append("  InternalProductID: ").Append(InternalProductID).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsEligibleForRma: ").Append(IsEligibleForRma).Append("\n");
            sb.Append("  IsSerialized: ").Append(IsSerialized).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  ManufacturerName: ").Append(ManufacturerName).Append("\n");
            sb.Append("  ManufacturerProductName: ").Append(ManufacturerProductName).Append("\n");
            sb.Append("  MarkupRate: ").Append(MarkupRate).Append("\n");
            sb.Append("  Msrp: ").Append(Msrp).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  PriceCostMethod: ").Append(PriceCostMethod).Append("\n");
            sb.Append("  ProductBillingCodeID: ").Append(ProductBillingCodeID).Append("\n");
            sb.Append("  ProductCategory: ").Append(ProductCategory).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  VendorProductNumber: ").Append(VendorProductNumber).Append("\n");
            sb.Append("  DefaultInstalledProductCategoryID: ").Append(DefaultInstalledProductCategoryID).Append("\n");
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
            return this.Equals(input as ProductModel);
        }

        /// <summary>
        /// Returns true if ProductModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductModel input)
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
                    this.BillingType == input.BillingType ||
                    (this.BillingType != null &&
                    this.BillingType.Equals(input.BillingType))
                ) && 
                (
                    this.ChargeBillingCodeID == input.ChargeBillingCodeID ||
                    (this.ChargeBillingCodeID != null &&
                    this.ChargeBillingCodeID.Equals(input.ChargeBillingCodeID))
                ) && 
                (
                    this.DefaultVendorID == input.DefaultVendorID ||
                    (this.DefaultVendorID != null &&
                    this.DefaultVendorID.Equals(input.DefaultVendorID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DoesNotRequireProcurement == input.DoesNotRequireProcurement ||
                    (this.DoesNotRequireProcurement != null &&
                    this.DoesNotRequireProcurement.Equals(input.DoesNotRequireProcurement))
                ) && 
                (
                    this.ExternalProductID == input.ExternalProductID ||
                    (this.ExternalProductID != null &&
                    this.ExternalProductID.Equals(input.ExternalProductID))
                ) && 
                (
                    this.ImpersonatorCreatorResourceID == input.ImpersonatorCreatorResourceID ||
                    (this.ImpersonatorCreatorResourceID != null &&
                    this.ImpersonatorCreatorResourceID.Equals(input.ImpersonatorCreatorResourceID))
                ) && 
                (
                    this.InternalProductID == input.InternalProductID ||
                    (this.InternalProductID != null &&
                    this.InternalProductID.Equals(input.InternalProductID))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsEligibleForRma == input.IsEligibleForRma ||
                    (this.IsEligibleForRma != null &&
                    this.IsEligibleForRma.Equals(input.IsEligibleForRma))
                ) && 
                (
                    this.IsSerialized == input.IsSerialized ||
                    (this.IsSerialized != null &&
                    this.IsSerialized.Equals(input.IsSerialized))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.ManufacturerName == input.ManufacturerName ||
                    (this.ManufacturerName != null &&
                    this.ManufacturerName.Equals(input.ManufacturerName))
                ) && 
                (
                    this.ManufacturerProductName == input.ManufacturerProductName ||
                    (this.ManufacturerProductName != null &&
                    this.ManufacturerProductName.Equals(input.ManufacturerProductName))
                ) && 
                (
                    this.MarkupRate == input.MarkupRate ||
                    (this.MarkupRate != null &&
                    this.MarkupRate.Equals(input.MarkupRate))
                ) && 
                (
                    this.Msrp == input.Msrp ||
                    (this.Msrp != null &&
                    this.Msrp.Equals(input.Msrp))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PriceCostMethod == input.PriceCostMethod ||
                    (this.PriceCostMethod != null &&
                    this.PriceCostMethod.Equals(input.PriceCostMethod))
                ) && 
                (
                    this.ProductBillingCodeID == input.ProductBillingCodeID ||
                    (this.ProductBillingCodeID != null &&
                    this.ProductBillingCodeID.Equals(input.ProductBillingCodeID))
                ) && 
                (
                    this.ProductCategory == input.ProductCategory ||
                    (this.ProductCategory != null &&
                    this.ProductCategory.Equals(input.ProductCategory))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
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
                    this.VendorProductNumber == input.VendorProductNumber ||
                    (this.VendorProductNumber != null &&
                    this.VendorProductNumber.Equals(input.VendorProductNumber))
                ) && 
                (
                    this.DefaultInstalledProductCategoryID == input.DefaultInstalledProductCategoryID ||
                    (this.DefaultInstalledProductCategoryID != null &&
                    this.DefaultInstalledProductCategoryID.Equals(input.DefaultInstalledProductCategoryID))
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
                if (this.BillingType != null)
                    hashCode = hashCode * 59 + this.BillingType.GetHashCode();
                if (this.ChargeBillingCodeID != null)
                    hashCode = hashCode * 59 + this.ChargeBillingCodeID.GetHashCode();
                if (this.DefaultVendorID != null)
                    hashCode = hashCode * 59 + this.DefaultVendorID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DoesNotRequireProcurement != null)
                    hashCode = hashCode * 59 + this.DoesNotRequireProcurement.GetHashCode();
                if (this.ExternalProductID != null)
                    hashCode = hashCode * 59 + this.ExternalProductID.GetHashCode();
                if (this.ImpersonatorCreatorResourceID != null)
                    hashCode = hashCode * 59 + this.ImpersonatorCreatorResourceID.GetHashCode();
                if (this.InternalProductID != null)
                    hashCode = hashCode * 59 + this.InternalProductID.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsEligibleForRma != null)
                    hashCode = hashCode * 59 + this.IsEligibleForRma.GetHashCode();
                if (this.IsSerialized != null)
                    hashCode = hashCode * 59 + this.IsSerialized.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.ManufacturerName != null)
                    hashCode = hashCode * 59 + this.ManufacturerName.GetHashCode();
                if (this.ManufacturerProductName != null)
                    hashCode = hashCode * 59 + this.ManufacturerProductName.GetHashCode();
                if (this.MarkupRate != null)
                    hashCode = hashCode * 59 + this.MarkupRate.GetHashCode();
                if (this.Msrp != null)
                    hashCode = hashCode * 59 + this.Msrp.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PriceCostMethod != null)
                    hashCode = hashCode * 59 + this.PriceCostMethod.GetHashCode();
                if (this.ProductBillingCodeID != null)
                    hashCode = hashCode * 59 + this.ProductBillingCodeID.GetHashCode();
                if (this.ProductCategory != null)
                    hashCode = hashCode * 59 + this.ProductCategory.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.VendorProductNumber != null)
                    hashCode = hashCode * 59 + this.VendorProductNumber.GetHashCode();
                if (this.DefaultInstalledProductCategoryID != null)
                    hashCode = hashCode * 59 + this.DefaultInstalledProductCategoryID.GetHashCode();
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