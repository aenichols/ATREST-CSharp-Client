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
    /// EntityInformationModel
    /// </summary>
    [DataContract]
    public partial class EntityInformationModel :  IEquatable<EntityInformationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityInformationModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EntityInformationModel()
        {
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets CanCreate
        /// </summary>
        [DataMember(Name="canCreate", EmitDefaultValue=false)]
        public bool? CanCreate { get; private set; }

        /// <summary>
        /// Gets or Sets CanDelete
        /// </summary>
        [DataMember(Name="canDelete", EmitDefaultValue=false)]
        public bool? CanDelete { get; private set; }

        /// <summary>
        /// Gets or Sets CanQuery
        /// </summary>
        [DataMember(Name="canQuery", EmitDefaultValue=false)]
        public bool? CanQuery { get; private set; }

        /// <summary>
        /// Gets or Sets CanUpdate
        /// </summary>
        [DataMember(Name="canUpdate", EmitDefaultValue=false)]
        public bool? CanUpdate { get; private set; }

        /// <summary>
        /// Gets or Sets UserAccessForCreate
        /// </summary>
        [DataMember(Name="userAccessForCreate", EmitDefaultValue=false)]
        public RestUserAccessLevel UserAccessForCreate { get; private set; }

        /// <summary>
        /// Gets or Sets UserAccessForDelete
        /// </summary>
        [DataMember(Name="userAccessForDelete", EmitDefaultValue=false)]
        public RestUserAccessLevel UserAccessForDelete { get; private set; }

        /// <summary>
        /// Gets or Sets UserAccessForQuery
        /// </summary>
        [DataMember(Name="userAccessForQuery", EmitDefaultValue=false)]
        public RestUserAccessLevel UserAccessForQuery { get; private set; }

        /// <summary>
        /// Gets or Sets UserAccessForUpdate
        /// </summary>
        [DataMember(Name="userAccessForUpdate", EmitDefaultValue=false)]
        public RestUserAccessLevel UserAccessForUpdate { get; private set; }

        /// <summary>
        /// Gets or Sets HasUserDefinedFields
        /// </summary>
        [DataMember(Name="hasUserDefinedFields", EmitDefaultValue=false)]
        public bool? HasUserDefinedFields { get; private set; }

        /// <summary>
        /// Gets or Sets SupportsWebhookCallouts
        /// </summary>
        [DataMember(Name="supportsWebhookCallouts", EmitDefaultValue=false)]
        public bool? SupportsWebhookCallouts { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityInformationModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CanCreate: ").Append(CanCreate).Append("\n");
            sb.Append("  CanDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  CanQuery: ").Append(CanQuery).Append("\n");
            sb.Append("  CanUpdate: ").Append(CanUpdate).Append("\n");
            sb.Append("  UserAccessForCreate: ").Append(UserAccessForCreate).Append("\n");
            sb.Append("  UserAccessForDelete: ").Append(UserAccessForDelete).Append("\n");
            sb.Append("  UserAccessForQuery: ").Append(UserAccessForQuery).Append("\n");
            sb.Append("  UserAccessForUpdate: ").Append(UserAccessForUpdate).Append("\n");
            sb.Append("  HasUserDefinedFields: ").Append(HasUserDefinedFields).Append("\n");
            sb.Append("  SupportsWebhookCallouts: ").Append(SupportsWebhookCallouts).Append("\n");
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
            return this.Equals(input as EntityInformationModel);
        }

        /// <summary>
        /// Returns true if EntityInformationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityInformationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityInformationModel input)
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
                    this.CanCreate == input.CanCreate ||
                    (this.CanCreate != null &&
                    this.CanCreate.Equals(input.CanCreate))
                ) && 
                (
                    this.CanDelete == input.CanDelete ||
                    (this.CanDelete != null &&
                    this.CanDelete.Equals(input.CanDelete))
                ) && 
                (
                    this.CanQuery == input.CanQuery ||
                    (this.CanQuery != null &&
                    this.CanQuery.Equals(input.CanQuery))
                ) && 
                (
                    this.CanUpdate == input.CanUpdate ||
                    (this.CanUpdate != null &&
                    this.CanUpdate.Equals(input.CanUpdate))
                ) && 
                (
                    this.UserAccessForCreate == input.UserAccessForCreate ||
                    (this.UserAccessForCreate != null &&
                    this.UserAccessForCreate.Equals(input.UserAccessForCreate))
                ) && 
                (
                    this.UserAccessForDelete == input.UserAccessForDelete ||
                    (this.UserAccessForDelete != null &&
                    this.UserAccessForDelete.Equals(input.UserAccessForDelete))
                ) && 
                (
                    this.UserAccessForQuery == input.UserAccessForQuery ||
                    (this.UserAccessForQuery != null &&
                    this.UserAccessForQuery.Equals(input.UserAccessForQuery))
                ) && 
                (
                    this.UserAccessForUpdate == input.UserAccessForUpdate ||
                    (this.UserAccessForUpdate != null &&
                    this.UserAccessForUpdate.Equals(input.UserAccessForUpdate))
                ) && 
                (
                    this.HasUserDefinedFields == input.HasUserDefinedFields ||
                    (this.HasUserDefinedFields != null &&
                    this.HasUserDefinedFields.Equals(input.HasUserDefinedFields))
                ) && 
                (
                    this.SupportsWebhookCallouts == input.SupportsWebhookCallouts ||
                    (this.SupportsWebhookCallouts != null &&
                    this.SupportsWebhookCallouts.Equals(input.SupportsWebhookCallouts))
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
                if (this.CanCreate != null)
                    hashCode = hashCode * 59 + this.CanCreate.GetHashCode();
                if (this.CanDelete != null)
                    hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanQuery != null)
                    hashCode = hashCode * 59 + this.CanQuery.GetHashCode();
                if (this.CanUpdate != null)
                    hashCode = hashCode * 59 + this.CanUpdate.GetHashCode();
                if (this.UserAccessForCreate != null)
                    hashCode = hashCode * 59 + this.UserAccessForCreate.GetHashCode();
                if (this.UserAccessForDelete != null)
                    hashCode = hashCode * 59 + this.UserAccessForDelete.GetHashCode();
                if (this.UserAccessForQuery != null)
                    hashCode = hashCode * 59 + this.UserAccessForQuery.GetHashCode();
                if (this.UserAccessForUpdate != null)
                    hashCode = hashCode * 59 + this.UserAccessForUpdate.GetHashCode();
                if (this.HasUserDefinedFields != null)
                    hashCode = hashCode * 59 + this.HasUserDefinedFields.GetHashCode();
                if (this.SupportsWebhookCallouts != null)
                    hashCode = hashCode * 59 + this.SupportsWebhookCallouts.GetHashCode();
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
