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
    /// OrganizationalLevelAssociationModel
    /// </summary>
    [DataContract]
    public partial class OrganizationalLevelAssociationModel :  IEquatable<OrganizationalLevelAssociationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationalLevelAssociationModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="organizationalLevel1ID">organizationalLevel1ID.</param>
        /// <param name="organizationalLevel2ID">organizationalLevel2ID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public OrganizationalLevelAssociationModel(long? id = default(long?), bool? isActive = default(bool?), int? organizationalLevel1ID = default(int?), int? organizationalLevel2ID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.IsActive = isActive;
            this.OrganizationalLevel1ID = organizationalLevel1ID;
            this.OrganizationalLevel2ID = organizationalLevel2ID;
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
        /// Gets or Sets OrganizationalLevel1ID
        /// </summary>
        [DataMember(Name="organizationalLevel1ID", EmitDefaultValue=false)]
        public int? OrganizationalLevel1ID { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationalLevel2ID
        /// </summary>
        [DataMember(Name="organizationalLevel2ID", EmitDefaultValue=false)]
        public int? OrganizationalLevel2ID { get; set; }

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
            sb.Append("class OrganizationalLevelAssociationModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  OrganizationalLevel1ID: ").Append(OrganizationalLevel1ID).Append("\n");
            sb.Append("  OrganizationalLevel2ID: ").Append(OrganizationalLevel2ID).Append("\n");
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
            return this.Equals(input as OrganizationalLevelAssociationModel);
        }

        /// <summary>
        /// Returns true if OrganizationalLevelAssociationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationalLevelAssociationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationalLevelAssociationModel input)
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
                    this.OrganizationalLevel1ID == input.OrganizationalLevel1ID ||
                    (this.OrganizationalLevel1ID != null &&
                    this.OrganizationalLevel1ID.Equals(input.OrganizationalLevel1ID))
                ) && 
                (
                    this.OrganizationalLevel2ID == input.OrganizationalLevel2ID ||
                    (this.OrganizationalLevel2ID != null &&
                    this.OrganizationalLevel2ID.Equals(input.OrganizationalLevel2ID))
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
                if (this.OrganizationalLevel1ID != null)
                    hashCode = hashCode * 59 + this.OrganizationalLevel1ID.GetHashCode();
                if (this.OrganizationalLevel2ID != null)
                    hashCode = hashCode * 59 + this.OrganizationalLevel2ID.GetHashCode();
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
