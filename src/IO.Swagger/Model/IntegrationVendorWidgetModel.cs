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
    /// IntegrationVendorWidgetModel
    /// </summary>
    [DataContract]
    public partial class IntegrationVendorWidgetModel :  IEquatable<IntegrationVendorWidgetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationVendorWidgetModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createDateTime">createDateTime.</param>
        /// <param name="description">description.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="referenceUrl">referenceUrl.</param>
        /// <param name="secret">secret.</param>
        /// <param name="title">title.</param>
        /// <param name="vendorSuppliedID">vendorSuppliedID.</param>
        /// <param name="widgetKey">widgetKey.</param>
        /// <param name="width">width.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public IntegrationVendorWidgetModel(long? id = default(long?), DateTime? createDateTime = default(DateTime?), string description = default(string), bool? isActive = default(bool?), DateTime? lastModifiedDateTime = default(DateTime?), string referenceUrl = default(string), string secret = default(string), string title = default(string), string vendorSuppliedID = default(string), string widgetKey = default(string), int? width = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.CreateDateTime = createDateTime;
            this.Description = description;
            this.IsActive = isActive;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.ReferenceUrl = referenceUrl;
            this.Secret = secret;
            this.Title = title;
            this.VendorSuppliedID = vendorSuppliedID;
            this.WidgetKey = widgetKey;
            this.Width = width;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name="createDateTime", EmitDefaultValue=false)]
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="lastModifiedDateTime", EmitDefaultValue=false)]
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceUrl
        /// </summary>
        [DataMember(Name="referenceUrl", EmitDefaultValue=false)]
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets VendorSuppliedID
        /// </summary>
        [DataMember(Name="vendorSuppliedID", EmitDefaultValue=false)]
        public string VendorSuppliedID { get; set; }

        /// <summary>
        /// Gets or Sets WidgetKey
        /// </summary>
        [DataMember(Name="widgetKey", EmitDefaultValue=false)]
        public string WidgetKey { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

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
            sb.Append("class IntegrationVendorWidgetModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  ReferenceUrl: ").Append(ReferenceUrl).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  VendorSuppliedID: ").Append(VendorSuppliedID).Append("\n");
            sb.Append("  WidgetKey: ").Append(WidgetKey).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as IntegrationVendorWidgetModel);
        }

        /// <summary>
        /// Returns true if IntegrationVendorWidgetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationVendorWidgetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationVendorWidgetModel input)
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
                    this.CreateDateTime == input.CreateDateTime ||
                    (this.CreateDateTime != null &&
                    this.CreateDateTime.Equals(input.CreateDateTime))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && 
                (
                    this.ReferenceUrl == input.ReferenceUrl ||
                    (this.ReferenceUrl != null &&
                    this.ReferenceUrl.Equals(input.ReferenceUrl))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.VendorSuppliedID == input.VendorSuppliedID ||
                    (this.VendorSuppliedID != null &&
                    this.VendorSuppliedID.Equals(input.VendorSuppliedID))
                ) && 
                (
                    this.WidgetKey == input.WidgetKey ||
                    (this.WidgetKey != null &&
                    this.WidgetKey.Equals(input.WidgetKey))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.CreateDateTime != null)
                    hashCode = hashCode * 59 + this.CreateDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.ReferenceUrl != null)
                    hashCode = hashCode * 59 + this.ReferenceUrl.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.VendorSuppliedID != null)
                    hashCode = hashCode * 59 + this.VendorSuppliedID.GetHashCode();
                if (this.WidgetKey != null)
                    hashCode = hashCode * 59 + this.WidgetKey.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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