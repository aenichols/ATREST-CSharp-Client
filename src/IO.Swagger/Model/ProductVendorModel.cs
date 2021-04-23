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
    /// ProductVendorModel
    /// </summary>
    [DataContract]
    public partial class ProductVendorModel :  IEquatable<ProductVendorModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVendorModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="productID">productID.</param>
        /// <param name="vendorCost">vendorCost.</param>
        /// <param name="vendorID">vendorID.</param>
        /// <param name="vendorPartNumber">vendorPartNumber.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ProductVendorModel(long? id = default(long?), bool? isActive = default(bool?), bool? isDefault = default(bool?), int? productID = default(int?), double? vendorCost = default(double?), int? vendorID = default(int?), string vendorPartNumber = default(string), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.IsActive = isActive;
            this.IsDefault = isDefault;
            this.ProductID = productID;
            this.VendorCost = vendorCost;
            this.VendorID = vendorID;
            this.VendorPartNumber = vendorPartNumber;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="productID", EmitDefaultValue=false)]
        public int? ProductID { get; set; }

        /// <summary>
        /// Gets or Sets VendorCost
        /// </summary>
        [DataMember(Name="vendorCost", EmitDefaultValue=false)]
        public double? VendorCost { get; set; }

        /// <summary>
        /// Gets or Sets VendorID
        /// </summary>
        [DataMember(Name="vendorID", EmitDefaultValue=false)]
        public int? VendorID { get; set; }

        /// <summary>
        /// Gets or Sets VendorPartNumber
        /// </summary>
        [DataMember(Name="vendorPartNumber", EmitDefaultValue=false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncProductVendorInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ProductVendorModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  VendorCost: ").Append(VendorCost).Append("\n");
            sb.Append("  VendorID: ").Append(VendorID).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
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
            return this.Equals(input as ProductVendorModel);
        }

        /// <summary>
        /// Returns true if ProductVendorModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductVendorModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductVendorModel input)
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
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
                ) && 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.VendorCost == input.VendorCost ||
                    (this.VendorCost != null &&
                    this.VendorCost.Equals(input.VendorCost))
                ) && 
                (
                    this.VendorID == input.VendorID ||
                    (this.VendorID != null &&
                    this.VendorID.Equals(input.VendorID))
                ) && 
                (
                    this.VendorPartNumber == input.VendorPartNumber ||
                    (this.VendorPartNumber != null &&
                    this.VendorPartNumber.Equals(input.VendorPartNumber))
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
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsDefault != null)
                    hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.VendorCost != null)
                    hashCode = hashCode * 59 + this.VendorCost.GetHashCode();
                if (this.VendorID != null)
                    hashCode = hashCode * 59 + this.VendorID.GetHashCode();
                if (this.VendorPartNumber != null)
                    hashCode = hashCode * 59 + this.VendorPartNumber.GetHashCode();
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