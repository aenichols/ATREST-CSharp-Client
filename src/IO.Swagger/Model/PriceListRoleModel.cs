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
    /// PriceListRoleModel
    /// </summary>
    [DataContract]
    public partial class PriceListRoleModel :  IEquatable<PriceListRoleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListRoleModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="hourlyRate">hourlyRate.</param>
        /// <param name="roleID">roleID.</param>
        /// <param name="usesInternalCurrencyPrice">usesInternalCurrencyPrice.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public PriceListRoleModel(long? id = default(long?), int? currencyID = default(int?), double? hourlyRate = default(double?), int? roleID = default(int?), bool? usesInternalCurrencyPrice = default(bool?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.CurrencyID = currencyID;
            this.HourlyRate = hourlyRate;
            this.RoleID = roleID;
            this.UsesInternalCurrencyPrice = usesInternalCurrencyPrice;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="currencyID", EmitDefaultValue=false)]
        public int? CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets HourlyRate
        /// </summary>
        [DataMember(Name="hourlyRate", EmitDefaultValue=false)]
        public double? HourlyRate { get; set; }

        /// <summary>
        /// Gets or Sets RoleID
        /// </summary>
        [DataMember(Name="roleID", EmitDefaultValue=false)]
        public int? RoleID { get; set; }

        /// <summary>
        /// Gets or Sets UsesInternalCurrencyPrice
        /// </summary>
        [DataMember(Name="usesInternalCurrencyPrice", EmitDefaultValue=false)]
        public bool? UsesInternalCurrencyPrice { get; set; }

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
            sb.Append("class PriceListRoleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  HourlyRate: ").Append(HourlyRate).Append("\n");
            sb.Append("  RoleID: ").Append(RoleID).Append("\n");
            sb.Append("  UsesInternalCurrencyPrice: ").Append(UsesInternalCurrencyPrice).Append("\n");
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
            return this.Equals(input as PriceListRoleModel);
        }

        /// <summary>
        /// Returns true if PriceListRoleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceListRoleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceListRoleModel input)
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
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && 
                (
                    this.HourlyRate == input.HourlyRate ||
                    (this.HourlyRate != null &&
                    this.HourlyRate.Equals(input.HourlyRate))
                ) && 
                (
                    this.RoleID == input.RoleID ||
                    (this.RoleID != null &&
                    this.RoleID.Equals(input.RoleID))
                ) && 
                (
                    this.UsesInternalCurrencyPrice == input.UsesInternalCurrencyPrice ||
                    (this.UsesInternalCurrencyPrice != null &&
                    this.UsesInternalCurrencyPrice.Equals(input.UsesInternalCurrencyPrice))
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
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.HourlyRate != null)
                    hashCode = hashCode * 59 + this.HourlyRate.GetHashCode();
                if (this.RoleID != null)
                    hashCode = hashCode * 59 + this.RoleID.GetHashCode();
                if (this.UsesInternalCurrencyPrice != null)
                    hashCode = hashCode * 59 + this.UsesInternalCurrencyPrice.GetHashCode();
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
