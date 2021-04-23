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
    /// ResourceRoleModel
    /// </summary>
    [DataContract]
    public partial class ResourceRoleModel :  IEquatable<ResourceRoleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceRoleModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="departmentID">departmentID.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="queueID">queueID.</param>
        /// <param name="resourceID">resourceID.</param>
        /// <param name="roleID">roleID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ResourceRoleModel(long? id = default(long?), long? departmentID = default(long?), bool? isActive = default(bool?), long? queueID = default(long?), long? resourceID = default(long?), long? roleID = default(long?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.DepartmentID = departmentID;
            this.IsActive = isActive;
            this.QueueID = queueID;
            this.ResourceID = resourceID;
            this.RoleID = roleID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets DepartmentID
        /// </summary>
        [DataMember(Name="departmentID", EmitDefaultValue=false)]
        public long? DepartmentID { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets QueueID
        /// </summary>
        [DataMember(Name="queueID", EmitDefaultValue=false)]
        public long? QueueID { get; set; }

        /// <summary>
        /// Gets or Sets ResourceID
        /// </summary>
        [DataMember(Name="resourceID", EmitDefaultValue=false)]
        public long? ResourceID { get; set; }

        /// <summary>
        /// Gets or Sets RoleID
        /// </summary>
        [DataMember(Name="roleID", EmitDefaultValue=false)]
        public long? RoleID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public long? SoapParentPropertyId { get; private set; }

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
            sb.Append("class ResourceRoleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DepartmentID: ").Append(DepartmentID).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  QueueID: ").Append(QueueID).Append("\n");
            sb.Append("  ResourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  RoleID: ").Append(RoleID).Append("\n");
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
            return this.Equals(input as ResourceRoleModel);
        }

        /// <summary>
        /// Returns true if ResourceRoleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceRoleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceRoleModel input)
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
                    this.DepartmentID == input.DepartmentID ||
                    (this.DepartmentID != null &&
                    this.DepartmentID.Equals(input.DepartmentID))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.QueueID == input.QueueID ||
                    (this.QueueID != null &&
                    this.QueueID.Equals(input.QueueID))
                ) && 
                (
                    this.ResourceID == input.ResourceID ||
                    (this.ResourceID != null &&
                    this.ResourceID.Equals(input.ResourceID))
                ) && 
                (
                    this.RoleID == input.RoleID ||
                    (this.RoleID != null &&
                    this.RoleID.Equals(input.RoleID))
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
                if (this.DepartmentID != null)
                    hashCode = hashCode * 59 + this.DepartmentID.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.QueueID != null)
                    hashCode = hashCode * 59 + this.QueueID.GetHashCode();
                if (this.ResourceID != null)
                    hashCode = hashCode * 59 + this.ResourceID.GetHashCode();
                if (this.RoleID != null)
                    hashCode = hashCode * 59 + this.RoleID.GetHashCode();
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