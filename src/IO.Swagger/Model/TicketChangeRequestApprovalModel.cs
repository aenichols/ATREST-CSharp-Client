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
    /// TicketChangeRequestApprovalModel
    /// </summary>
    [DataContract]
    public partial class TicketChangeRequestApprovalModel :  IEquatable<TicketChangeRequestApprovalModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketChangeRequestApprovalModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="approveRejectDateTime">approveRejectDateTime.</param>
        /// <param name="approveRejectNote">approveRejectNote.</param>
        /// <param name="contactID">contactID.</param>
        /// <param name="isApproved">isApproved.</param>
        /// <param name="resourceID">resourceID.</param>
        /// <param name="ticketID">ticketID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public TicketChangeRequestApprovalModel(long? id = default(long?), DateTime? approveRejectDateTime = default(DateTime?), string approveRejectNote = default(string), int? contactID = default(int?), bool? isApproved = default(bool?), int? resourceID = default(int?), int? ticketID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.ApproveRejectDateTime = approveRejectDateTime;
            this.ApproveRejectNote = approveRejectNote;
            this.ContactID = contactID;
            this.IsApproved = isApproved;
            this.ResourceID = resourceID;
            this.TicketID = ticketID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ApproveRejectDateTime
        /// </summary>
        [DataMember(Name="approveRejectDateTime", EmitDefaultValue=false)]
        public DateTime? ApproveRejectDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ApproveRejectNote
        /// </summary>
        [DataMember(Name="approveRejectNote", EmitDefaultValue=false)]
        public string ApproveRejectNote { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="contactID", EmitDefaultValue=false)]
        public int? ContactID { get; set; }

        /// <summary>
        /// Gets or Sets IsApproved
        /// </summary>
        [DataMember(Name="isApproved", EmitDefaultValue=false)]
        public bool? IsApproved { get; set; }

        /// <summary>
        /// Gets or Sets ResourceID
        /// </summary>
        [DataMember(Name="resourceID", EmitDefaultValue=false)]
        public int? ResourceID { get; set; }

        /// <summary>
        /// Gets or Sets TicketID
        /// </summary>
        [DataMember(Name="ticketID", EmitDefaultValue=false)]
        public int? TicketID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncTicketChangeRequestApprovalInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class TicketChangeRequestApprovalModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApproveRejectDateTime: ").Append(ApproveRejectDateTime).Append("\n");
            sb.Append("  ApproveRejectNote: ").Append(ApproveRejectNote).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  IsApproved: ").Append(IsApproved).Append("\n");
            sb.Append("  ResourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  TicketID: ").Append(TicketID).Append("\n");
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
            return this.Equals(input as TicketChangeRequestApprovalModel);
        }

        /// <summary>
        /// Returns true if TicketChangeRequestApprovalModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TicketChangeRequestApprovalModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketChangeRequestApprovalModel input)
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
                    this.ApproveRejectDateTime == input.ApproveRejectDateTime ||
                    (this.ApproveRejectDateTime != null &&
                    this.ApproveRejectDateTime.Equals(input.ApproveRejectDateTime))
                ) && 
                (
                    this.ApproveRejectNote == input.ApproveRejectNote ||
                    (this.ApproveRejectNote != null &&
                    this.ApproveRejectNote.Equals(input.ApproveRejectNote))
                ) && 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && 
                (
                    this.IsApproved == input.IsApproved ||
                    (this.IsApproved != null &&
                    this.IsApproved.Equals(input.IsApproved))
                ) && 
                (
                    this.ResourceID == input.ResourceID ||
                    (this.ResourceID != null &&
                    this.ResourceID.Equals(input.ResourceID))
                ) && 
                (
                    this.TicketID == input.TicketID ||
                    (this.TicketID != null &&
                    this.TicketID.Equals(input.TicketID))
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
                if (this.ApproveRejectDateTime != null)
                    hashCode = hashCode * 59 + this.ApproveRejectDateTime.GetHashCode();
                if (this.ApproveRejectNote != null)
                    hashCode = hashCode * 59 + this.ApproveRejectNote.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.IsApproved != null)
                    hashCode = hashCode * 59 + this.IsApproved.GetHashCode();
                if (this.ResourceID != null)
                    hashCode = hashCode * 59 + this.ResourceID.GetHashCode();
                if (this.TicketID != null)
                    hashCode = hashCode * 59 + this.TicketID.GetHashCode();
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
