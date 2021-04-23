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
    /// ContactWebhookUdfFieldModel
    /// </summary>
    [DataContract]
    public partial class ContactWebhookUdfFieldModel :  IEquatable<ContactWebhookUdfFieldModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactWebhookUdfFieldModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isDisplayAlwaysField">isDisplayAlwaysField.</param>
        /// <param name="isSubscribedField">isSubscribedField.</param>
        /// <param name="udfFieldID">udfFieldID.</param>
        /// <param name="webhookID">webhookID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ContactWebhookUdfFieldModel(long? id = default(long?), bool? isDisplayAlwaysField = default(bool?), bool? isSubscribedField = default(bool?), int? udfFieldID = default(int?), int? webhookID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.IsDisplayAlwaysField = isDisplayAlwaysField;
            this.IsSubscribedField = isSubscribedField;
            this.UdfFieldID = udfFieldID;
            this.WebhookID = webhookID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsDisplayAlwaysField
        /// </summary>
        [DataMember(Name="isDisplayAlwaysField", EmitDefaultValue=false)]
        public bool? IsDisplayAlwaysField { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscribedField
        /// </summary>
        [DataMember(Name="isSubscribedField", EmitDefaultValue=false)]
        public bool? IsSubscribedField { get; set; }

        /// <summary>
        /// Gets or Sets UdfFieldID
        /// </summary>
        [DataMember(Name="udfFieldID", EmitDefaultValue=false)]
        public int? UdfFieldID { get; set; }

        /// <summary>
        /// Gets or Sets WebhookID
        /// </summary>
        [DataMember(Name="webhookID", EmitDefaultValue=false)]
        public int? WebhookID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncContactWebhookUdfFieldInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ContactWebhookUdfFieldModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDisplayAlwaysField: ").Append(IsDisplayAlwaysField).Append("\n");
            sb.Append("  IsSubscribedField: ").Append(IsSubscribedField).Append("\n");
            sb.Append("  UdfFieldID: ").Append(UdfFieldID).Append("\n");
            sb.Append("  WebhookID: ").Append(WebhookID).Append("\n");
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
            return this.Equals(input as ContactWebhookUdfFieldModel);
        }

        /// <summary>
        /// Returns true if ContactWebhookUdfFieldModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactWebhookUdfFieldModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactWebhookUdfFieldModel input)
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
                    this.IsDisplayAlwaysField == input.IsDisplayAlwaysField ||
                    (this.IsDisplayAlwaysField != null &&
                    this.IsDisplayAlwaysField.Equals(input.IsDisplayAlwaysField))
                ) && 
                (
                    this.IsSubscribedField == input.IsSubscribedField ||
                    (this.IsSubscribedField != null &&
                    this.IsSubscribedField.Equals(input.IsSubscribedField))
                ) && 
                (
                    this.UdfFieldID == input.UdfFieldID ||
                    (this.UdfFieldID != null &&
                    this.UdfFieldID.Equals(input.UdfFieldID))
                ) && 
                (
                    this.WebhookID == input.WebhookID ||
                    (this.WebhookID != null &&
                    this.WebhookID.Equals(input.WebhookID))
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
                if (this.IsDisplayAlwaysField != null)
                    hashCode = hashCode * 59 + this.IsDisplayAlwaysField.GetHashCode();
                if (this.IsSubscribedField != null)
                    hashCode = hashCode * 59 + this.IsSubscribedField.GetHashCode();
                if (this.UdfFieldID != null)
                    hashCode = hashCode * 59 + this.UdfFieldID.GetHashCode();
                if (this.WebhookID != null)
                    hashCode = hashCode * 59 + this.WebhookID.GetHashCode();
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
