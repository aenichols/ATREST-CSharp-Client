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
    /// FieldInformationModel
    /// </summary>
    [DataContract]
    public partial class FieldInformationModel :  IEquatable<FieldInformationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldInformationModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="length">length.</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="isReadOnly">isReadOnly.</param>
        /// <param name="isQueryable">isQueryable.</param>
        /// <param name="isReference">isReference.</param>
        /// <param name="referenceEntityType">referenceEntityType.</param>
        /// <param name="isPickList">isPickList.</param>
        /// <param name="picklistValues">picklistValues.</param>
        /// <param name="picklistParentValueField">picklistParentValueField.</param>
        /// <param name="isSupportedWebhookField">isSupportedWebhookField.</param>
        public FieldInformationModel(string name = default(string), string dataType = default(string), int? length = default(int?), bool? isRequired = default(bool?), bool? isReadOnly = default(bool?), bool? isQueryable = default(bool?), bool? isReference = default(bool?), string referenceEntityType = default(string), bool? isPickList = default(bool?), List<PickListValue> picklistValues = default(List<PickListValue>), string picklistParentValueField = default(string), Object isSupportedWebhookField = default(Object))
        {
            this.Name = name;
            this.DataType = dataType;
            this.Length = length;
            this.IsRequired = isRequired;
            this.IsReadOnly = isReadOnly;
            this.IsQueryable = isQueryable;
            this.IsReference = isReference;
            this.ReferenceEntityType = referenceEntityType;
            this.IsPickList = isPickList;
            this.PicklistValues = picklistValues;
            this.PicklistParentValueField = picklistParentValueField;
            this.IsSupportedWebhookField = isSupportedWebhookField;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets IsReadOnly
        /// </summary>
        [DataMember(Name="isReadOnly", EmitDefaultValue=false)]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets IsQueryable
        /// </summary>
        [DataMember(Name="isQueryable", EmitDefaultValue=false)]
        public bool? IsQueryable { get; set; }

        /// <summary>
        /// Gets or Sets IsReference
        /// </summary>
        [DataMember(Name="isReference", EmitDefaultValue=false)]
        public bool? IsReference { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceEntityType
        /// </summary>
        [DataMember(Name="referenceEntityType", EmitDefaultValue=false)]
        public string ReferenceEntityType { get; set; }

        /// <summary>
        /// Gets or Sets IsPickList
        /// </summary>
        [DataMember(Name="isPickList", EmitDefaultValue=false)]
        public bool? IsPickList { get; set; }

        /// <summary>
        /// Gets or Sets PicklistValues
        /// </summary>
        [DataMember(Name="picklistValues", EmitDefaultValue=false)]
        public List<PickListValue> PicklistValues { get; set; }

        /// <summary>
        /// Gets or Sets PicklistParentValueField
        /// </summary>
        [DataMember(Name="picklistParentValueField", EmitDefaultValue=false)]
        public string PicklistParentValueField { get; set; }

        /// <summary>
        /// Gets or Sets IsSupportedWebhookField
        /// </summary>
        [DataMember(Name="isSupportedWebhookField", EmitDefaultValue=false)]
        public Object IsSupportedWebhookField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldInformationModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
            sb.Append("  IsQueryable: ").Append(IsQueryable).Append("\n");
            sb.Append("  IsReference: ").Append(IsReference).Append("\n");
            sb.Append("  ReferenceEntityType: ").Append(ReferenceEntityType).Append("\n");
            sb.Append("  IsPickList: ").Append(IsPickList).Append("\n");
            sb.Append("  PicklistValues: ").Append(PicklistValues).Append("\n");
            sb.Append("  PicklistParentValueField: ").Append(PicklistParentValueField).Append("\n");
            sb.Append("  IsSupportedWebhookField: ").Append(IsSupportedWebhookField).Append("\n");
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
            return this.Equals(input as FieldInformationModel);
        }

        /// <summary>
        /// Returns true if FieldInformationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldInformationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldInformationModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
                ) && 
                (
                    this.IsReadOnly == input.IsReadOnly ||
                    (this.IsReadOnly != null &&
                    this.IsReadOnly.Equals(input.IsReadOnly))
                ) && 
                (
                    this.IsQueryable == input.IsQueryable ||
                    (this.IsQueryable != null &&
                    this.IsQueryable.Equals(input.IsQueryable))
                ) && 
                (
                    this.IsReference == input.IsReference ||
                    (this.IsReference != null &&
                    this.IsReference.Equals(input.IsReference))
                ) && 
                (
                    this.ReferenceEntityType == input.ReferenceEntityType ||
                    (this.ReferenceEntityType != null &&
                    this.ReferenceEntityType.Equals(input.ReferenceEntityType))
                ) && 
                (
                    this.IsPickList == input.IsPickList ||
                    (this.IsPickList != null &&
                    this.IsPickList.Equals(input.IsPickList))
                ) && 
                (
                    this.PicklistValues == input.PicklistValues ||
                    this.PicklistValues != null &&
                    this.PicklistValues.SequenceEqual(input.PicklistValues)
                ) && 
                (
                    this.PicklistParentValueField == input.PicklistParentValueField ||
                    (this.PicklistParentValueField != null &&
                    this.PicklistParentValueField.Equals(input.PicklistParentValueField))
                ) && 
                (
                    this.IsSupportedWebhookField == input.IsSupportedWebhookField ||
                    (this.IsSupportedWebhookField != null &&
                    this.IsSupportedWebhookField.Equals(input.IsSupportedWebhookField))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.IsReadOnly != null)
                    hashCode = hashCode * 59 + this.IsReadOnly.GetHashCode();
                if (this.IsQueryable != null)
                    hashCode = hashCode * 59 + this.IsQueryable.GetHashCode();
                if (this.IsReference != null)
                    hashCode = hashCode * 59 + this.IsReference.GetHashCode();
                if (this.ReferenceEntityType != null)
                    hashCode = hashCode * 59 + this.ReferenceEntityType.GetHashCode();
                if (this.IsPickList != null)
                    hashCode = hashCode * 59 + this.IsPickList.GetHashCode();
                if (this.PicklistValues != null)
                    hashCode = hashCode * 59 + this.PicklistValues.GetHashCode();
                if (this.PicklistParentValueField != null)
                    hashCode = hashCode * 59 + this.PicklistParentValueField.GetHashCode();
                if (this.IsSupportedWebhookField != null)
                    hashCode = hashCode * 59 + this.IsSupportedWebhookField.GetHashCode();
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
