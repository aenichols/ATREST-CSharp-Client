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
    /// DocumentChecklistItemModel
    /// </summary>
    [DataContract]
    public partial class DocumentChecklistItemModel :  IEquatable<DocumentChecklistItemModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentChecklistItemModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="documentID">documentID.</param>
        /// <param name="isImportant">isImportant.</param>
        /// <param name="itemName">itemName.</param>
        /// <param name="position">position.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public DocumentChecklistItemModel(long? id = default(long?), int? documentID = default(int?), bool? isImportant = default(bool?), string itemName = default(string), int? position = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.DocumentID = documentID;
            this.IsImportant = isImportant;
            this.ItemName = itemName;
            this.Position = position;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets DocumentID
        /// </summary>
        [DataMember(Name="documentID", EmitDefaultValue=false)]
        public int? DocumentID { get; set; }

        /// <summary>
        /// Gets or Sets IsImportant
        /// </summary>
        [DataMember(Name="isImportant", EmitDefaultValue=false)]
        public bool? IsImportant { get; set; }

        /// <summary>
        /// Gets or Sets ItemName
        /// </summary>
        [DataMember(Name="itemName", EmitDefaultValue=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncDocumentChecklistItemInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class DocumentChecklistItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DocumentID: ").Append(DocumentID).Append("\n");
            sb.Append("  IsImportant: ").Append(IsImportant).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as DocumentChecklistItemModel);
        }

        /// <summary>
        /// Returns true if DocumentChecklistItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentChecklistItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentChecklistItemModel input)
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
                    this.DocumentID == input.DocumentID ||
                    (this.DocumentID != null &&
                    this.DocumentID.Equals(input.DocumentID))
                ) && 
                (
                    this.IsImportant == input.IsImportant ||
                    (this.IsImportant != null &&
                    this.IsImportant.Equals(input.IsImportant))
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                if (this.DocumentID != null)
                    hashCode = hashCode * 59 + this.DocumentID.GetHashCode();
                if (this.IsImportant != null)
                    hashCode = hashCode * 59 + this.IsImportant.GetHashCode();
                if (this.ItemName != null)
                    hashCode = hashCode * 59 + this.ItemName.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
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
