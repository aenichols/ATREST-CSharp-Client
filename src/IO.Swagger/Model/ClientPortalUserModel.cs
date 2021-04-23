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
    /// ClientPortalUserModel
    /// </summary>
    [DataContract]
    public partial class ClientPortalUserModel :  IEquatable<ClientPortalUserModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPortalUserModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contactID">contactID.</param>
        /// <param name="dateFormat">dateFormat.</param>
        /// <param name="isClientPortalActive">isClientPortalActive.</param>
        /// <param name="numberFormat">numberFormat.</param>
        /// <param name="password">password.</param>
        /// <param name="securityLevel">securityLevel.</param>
        /// <param name="timeFormat">timeFormat.</param>
        /// <param name="userName">userName.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ClientPortalUserModel(long? id = default(long?), int? contactID = default(int?), int? dateFormat = default(int?), bool? isClientPortalActive = default(bool?), int? numberFormat = default(int?), string password = default(string), int? securityLevel = default(int?), int? timeFormat = default(int?), string userName = default(string), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.ContactID = contactID;
            this.DateFormat = dateFormat;
            this.IsClientPortalActive = isClientPortalActive;
            this.NumberFormat = numberFormat;
            this.Password = password;
            this.SecurityLevel = securityLevel;
            this.TimeFormat = timeFormat;
            this.UserName = userName;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="contactID", EmitDefaultValue=false)]
        public int? ContactID { get; set; }

        /// <summary>
        /// Gets or Sets DateFormat
        /// </summary>
        [DataMember(Name="dateFormat", EmitDefaultValue=false)]
        public int? DateFormat { get; set; }

        /// <summary>
        /// Gets or Sets IsClientPortalActive
        /// </summary>
        [DataMember(Name="isClientPortalActive", EmitDefaultValue=false)]
        public bool? IsClientPortalActive { get; set; }

        /// <summary>
        /// Gets or Sets NumberFormat
        /// </summary>
        [DataMember(Name="numberFormat", EmitDefaultValue=false)]
        public int? NumberFormat { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets SecurityLevel
        /// </summary>
        [DataMember(Name="securityLevel", EmitDefaultValue=false)]
        public int? SecurityLevel { get; set; }

        /// <summary>
        /// Gets or Sets TimeFormat
        /// </summary>
        [DataMember(Name="timeFormat", EmitDefaultValue=false)]
        public int? TimeFormat { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

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
            sb.Append("class ClientPortalUserModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
            sb.Append("  IsClientPortalActive: ").Append(IsClientPortalActive).Append("\n");
            sb.Append("  NumberFormat: ").Append(NumberFormat).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SecurityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as ClientPortalUserModel);
        }

        /// <summary>
        /// Returns true if ClientPortalUserModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientPortalUserModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientPortalUserModel input)
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
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && 
                (
                    this.DateFormat == input.DateFormat ||
                    (this.DateFormat != null &&
                    this.DateFormat.Equals(input.DateFormat))
                ) && 
                (
                    this.IsClientPortalActive == input.IsClientPortalActive ||
                    (this.IsClientPortalActive != null &&
                    this.IsClientPortalActive.Equals(input.IsClientPortalActive))
                ) && 
                (
                    this.NumberFormat == input.NumberFormat ||
                    (this.NumberFormat != null &&
                    this.NumberFormat.Equals(input.NumberFormat))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SecurityLevel == input.SecurityLevel ||
                    (this.SecurityLevel != null &&
                    this.SecurityLevel.Equals(input.SecurityLevel))
                ) && 
                (
                    this.TimeFormat == input.TimeFormat ||
                    (this.TimeFormat != null &&
                    this.TimeFormat.Equals(input.TimeFormat))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.DateFormat != null)
                    hashCode = hashCode * 59 + this.DateFormat.GetHashCode();
                if (this.IsClientPortalActive != null)
                    hashCode = hashCode * 59 + this.IsClientPortalActive.GetHashCode();
                if (this.NumberFormat != null)
                    hashCode = hashCode * 59 + this.NumberFormat.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SecurityLevel != null)
                    hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
                if (this.TimeFormat != null)
                    hashCode = hashCode * 59 + this.TimeFormat.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
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