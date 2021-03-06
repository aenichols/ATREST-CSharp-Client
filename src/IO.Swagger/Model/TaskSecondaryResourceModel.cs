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
    /// TaskSecondaryResourceModel
    /// </summary>
    [DataContract]
    public partial class TaskSecondaryResourceModel :  IEquatable<TaskSecondaryResourceModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSecondaryResourceModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="resourceID">resourceID.</param>
        /// <param name="roleID">roleID.</param>
        /// <param name="taskID">taskID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public TaskSecondaryResourceModel(long? id = default(long?), int? resourceID = default(int?), int? roleID = default(int?), int? taskID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.ResourceID = resourceID;
            this.RoleID = roleID;
            this.TaskID = taskID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ResourceID
        /// </summary>
        [DataMember(Name="resourceID", EmitDefaultValue=false)]
        public int? ResourceID { get; set; }

        /// <summary>
        /// Gets or Sets RoleID
        /// </summary>
        [DataMember(Name="roleID", EmitDefaultValue=false)]
        public int? RoleID { get; set; }

        /// <summary>
        /// Gets or Sets TaskID
        /// </summary>
        [DataMember(Name="taskID", EmitDefaultValue=false)]
        public int? TaskID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncTaskSecondaryResourceInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class TaskSecondaryResourceModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  RoleID: ").Append(RoleID).Append("\n");
            sb.Append("  TaskID: ").Append(TaskID).Append("\n");
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
            return this.Equals(input as TaskSecondaryResourceModel);
        }

        /// <summary>
        /// Returns true if TaskSecondaryResourceModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskSecondaryResourceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskSecondaryResourceModel input)
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
                    this.TaskID == input.TaskID ||
                    (this.TaskID != null &&
                    this.TaskID.Equals(input.TaskID))
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
                if (this.ResourceID != null)
                    hashCode = hashCode * 59 + this.ResourceID.GetHashCode();
                if (this.RoleID != null)
                    hashCode = hashCode * 59 + this.RoleID.GetHashCode();
                if (this.TaskID != null)
                    hashCode = hashCode * 59 + this.TaskID.GetHashCode();
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
