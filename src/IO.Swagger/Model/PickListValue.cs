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
    /// PickListValue
    /// </summary>
    [DataContract]
    public partial class PickListValue :  IEquatable<PickListValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PickListValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="label">label.</param>
        /// <param name="isDefaultValue">isDefaultValue.</param>
        /// <param name="sortOrder">sortOrder.</param>
        /// <param name="parentValue">parentValue.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isSystem">isSystem.</param>
        public PickListValue(string value = default(string), string label = default(string), bool? isDefaultValue = default(bool?), int? sortOrder = default(int?), string parentValue = default(string), bool? isActive = default(bool?), bool? isSystem = default(bool?))
        {
            this.Value = value;
            this.Label = label;
            this.IsDefaultValue = isDefaultValue;
            this.SortOrder = sortOrder;
            this.ParentValue = parentValue;
            this.IsActive = isActive;
            this.IsSystem = isSystem;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultValue
        /// </summary>
        [DataMember(Name="isDefaultValue", EmitDefaultValue=false)]
        public bool? IsDefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets ParentValue
        /// </summary>
        [DataMember(Name="parentValue", EmitDefaultValue=false)]
        public string ParentValue { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name="isSystem", EmitDefaultValue=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PickListValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  IsDefaultValue: ").Append(IsDefaultValue).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  ParentValue: ").Append(ParentValue).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
            return this.Equals(input as PickListValue);
        }

        /// <summary>
        /// Returns true if PickListValue instances are equal
        /// </summary>
        /// <param name="input">Instance of PickListValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PickListValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.IsDefaultValue == input.IsDefaultValue ||
                    (this.IsDefaultValue != null &&
                    this.IsDefaultValue.Equals(input.IsDefaultValue))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.ParentValue == input.ParentValue ||
                    (this.ParentValue != null &&
                    this.ParentValue.Equals(input.ParentValue))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsSystem == input.IsSystem ||
                    (this.IsSystem != null &&
                    this.IsSystem.Equals(input.IsSystem))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.IsDefaultValue != null)
                    hashCode = hashCode * 59 + this.IsDefaultValue.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.ParentValue != null)
                    hashCode = hashCode * 59 + this.ParentValue.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsSystem != null)
                    hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
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