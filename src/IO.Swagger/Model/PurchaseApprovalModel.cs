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
    /// PurchaseApprovalModel
    /// </summary>
    [DataContract]
    public partial class PurchaseApprovalModel :  IEquatable<PurchaseApprovalModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseApprovalModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="costType">costType.</param>
        /// <param name="isApproved">isApproved.</param>
        /// <param name="rejectNote">rejectNote.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public PurchaseApprovalModel(long? id = default(long?), string costType = default(string), bool? isApproved = default(bool?), string rejectNote = default(string), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.CostType = costType;
            this.IsApproved = isApproved;
            this.RejectNote = rejectNote;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CostType
        /// </summary>
        [DataMember(Name="costType", EmitDefaultValue=false)]
        public string CostType { get; set; }

        /// <summary>
        /// Gets or Sets IsApproved
        /// </summary>
        [DataMember(Name="isApproved", EmitDefaultValue=false)]
        public bool? IsApproved { get; set; }

        /// <summary>
        /// Gets or Sets RejectNote
        /// </summary>
        [DataMember(Name="rejectNote", EmitDefaultValue=false)]
        public string RejectNote { get; set; }

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
            sb.Append("class PurchaseApprovalModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CostType: ").Append(CostType).Append("\n");
            sb.Append("  IsApproved: ").Append(IsApproved).Append("\n");
            sb.Append("  RejectNote: ").Append(RejectNote).Append("\n");
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
            return this.Equals(input as PurchaseApprovalModel);
        }

        /// <summary>
        /// Returns true if PurchaseApprovalModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseApprovalModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseApprovalModel input)
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
                    this.CostType == input.CostType ||
                    (this.CostType != null &&
                    this.CostType.Equals(input.CostType))
                ) && 
                (
                    this.IsApproved == input.IsApproved ||
                    (this.IsApproved != null &&
                    this.IsApproved.Equals(input.IsApproved))
                ) && 
                (
                    this.RejectNote == input.RejectNote ||
                    (this.RejectNote != null &&
                    this.RejectNote.Equals(input.RejectNote))
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
                if (this.CostType != null)
                    hashCode = hashCode * 59 + this.CostType.GetHashCode();
                if (this.IsApproved != null)
                    hashCode = hashCode * 59 + this.IsApproved.GetHashCode();
                if (this.RejectNote != null)
                    hashCode = hashCode * 59 + this.RejectNote.GetHashCode();
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
