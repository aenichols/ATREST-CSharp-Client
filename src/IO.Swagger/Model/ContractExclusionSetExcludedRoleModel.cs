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
    /// ContractExclusionSetExcludedRoleModel
    /// </summary>
    [DataContract]
    public partial class ContractExclusionSetExcludedRoleModel :  IEquatable<ContractExclusionSetExcludedRoleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractExclusionSetExcludedRoleModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contractExclusionSetID">contractExclusionSetID.</param>
        /// <param name="excludedRoleID">excludedRoleID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ContractExclusionSetExcludedRoleModel(long? id = default(long?), int? contractExclusionSetID = default(int?), int? excludedRoleID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.ContractExclusionSetID = contractExclusionSetID;
            this.ExcludedRoleID = excludedRoleID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ContractExclusionSetID
        /// </summary>
        [DataMember(Name="contractExclusionSetID", EmitDefaultValue=false)]
        public int? ContractExclusionSetID { get; set; }

        /// <summary>
        /// Gets or Sets ExcludedRoleID
        /// </summary>
        [DataMember(Name="excludedRoleID", EmitDefaultValue=false)]
        public int? ExcludedRoleID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncContractExclusionSetExcludedRoleInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ContractExclusionSetExcludedRoleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContractExclusionSetID: ").Append(ContractExclusionSetID).Append("\n");
            sb.Append("  ExcludedRoleID: ").Append(ExcludedRoleID).Append("\n");
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
            return this.Equals(input as ContractExclusionSetExcludedRoleModel);
        }

        /// <summary>
        /// Returns true if ContractExclusionSetExcludedRoleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractExclusionSetExcludedRoleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractExclusionSetExcludedRoleModel input)
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
                    this.ContractExclusionSetID == input.ContractExclusionSetID ||
                    (this.ContractExclusionSetID != null &&
                    this.ContractExclusionSetID.Equals(input.ContractExclusionSetID))
                ) && 
                (
                    this.ExcludedRoleID == input.ExcludedRoleID ||
                    (this.ExcludedRoleID != null &&
                    this.ExcludedRoleID.Equals(input.ExcludedRoleID))
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
                if (this.ContractExclusionSetID != null)
                    hashCode = hashCode * 59 + this.ContractExclusionSetID.GetHashCode();
                if (this.ExcludedRoleID != null)
                    hashCode = hashCode * 59 + this.ExcludedRoleID.GetHashCode();
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