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
    /// TicketCategoryFieldDefaultsModel
    /// </summary>
    [DataContract]
    public partial class TicketCategoryFieldDefaultsModel :  IEquatable<TicketCategoryFieldDefaultsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketCategoryFieldDefaultsModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="estimatedHours">estimatedHours.</param>
        /// <param name="issueTypeID">issueTypeID.</param>
        /// <param name="organizationalLevelAssociationID">organizationalLevelAssociationID.</param>
        /// <param name="priority">priority.</param>
        /// <param name="purchaseOrderNumber">purchaseOrderNumber.</param>
        /// <param name="queueID">queueID.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="serviceLevelAgreementID">serviceLevelAgreementID.</param>
        /// <param name="sourceID">sourceID.</param>
        /// <param name="status">status.</param>
        /// <param name="subIssueTypeID">subIssueTypeID.</param>
        /// <param name="ticketCategoryID">ticketCategoryID.</param>
        /// <param name="ticketTypeID">ticketTypeID.</param>
        /// <param name="title">title.</param>
        /// <param name="workTypeID">workTypeID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public TicketCategoryFieldDefaultsModel(long? id = default(long?), string description = default(string), double? estimatedHours = default(double?), int? issueTypeID = default(int?), int? organizationalLevelAssociationID = default(int?), int? priority = default(int?), string purchaseOrderNumber = default(string), int? queueID = default(int?), string resolution = default(string), int? serviceLevelAgreementID = default(int?), int? sourceID = default(int?), int? status = default(int?), int? subIssueTypeID = default(int?), int? ticketCategoryID = default(int?), int? ticketTypeID = default(int?), string title = default(string), int? workTypeID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.Description = description;
            this.EstimatedHours = estimatedHours;
            this.IssueTypeID = issueTypeID;
            this.OrganizationalLevelAssociationID = organizationalLevelAssociationID;
            this.Priority = priority;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.QueueID = queueID;
            this.Resolution = resolution;
            this.ServiceLevelAgreementID = serviceLevelAgreementID;
            this.SourceID = sourceID;
            this.Status = status;
            this.SubIssueTypeID = subIssueTypeID;
            this.TicketCategoryID = ticketCategoryID;
            this.TicketTypeID = ticketTypeID;
            this.Title = title;
            this.WorkTypeID = workTypeID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedHours
        /// </summary>
        [DataMember(Name="estimatedHours", EmitDefaultValue=false)]
        public double? EstimatedHours { get; set; }

        /// <summary>
        /// Gets or Sets IssueTypeID
        /// </summary>
        [DataMember(Name="issueTypeID", EmitDefaultValue=false)]
        public int? IssueTypeID { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationalLevelAssociationID
        /// </summary>
        [DataMember(Name="organizationalLevelAssociationID", EmitDefaultValue=false)]
        public int? OrganizationalLevelAssociationID { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderNumber
        /// </summary>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets QueueID
        /// </summary>
        [DataMember(Name="queueID", EmitDefaultValue=false)]
        public int? QueueID { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLevelAgreementID
        /// </summary>
        [DataMember(Name="serviceLevelAgreementID", EmitDefaultValue=false)]
        public int? ServiceLevelAgreementID { get; set; }

        /// <summary>
        /// Gets or Sets SourceID
        /// </summary>
        [DataMember(Name="sourceID", EmitDefaultValue=false)]
        public int? SourceID { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets SubIssueTypeID
        /// </summary>
        [DataMember(Name="subIssueTypeID", EmitDefaultValue=false)]
        public int? SubIssueTypeID { get; set; }

        /// <summary>
        /// Gets or Sets TicketCategoryID
        /// </summary>
        [DataMember(Name="ticketCategoryID", EmitDefaultValue=false)]
        public int? TicketCategoryID { get; set; }

        /// <summary>
        /// Gets or Sets TicketTypeID
        /// </summary>
        [DataMember(Name="ticketTypeID", EmitDefaultValue=false)]
        public int? TicketTypeID { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets WorkTypeID
        /// </summary>
        [DataMember(Name="workTypeID", EmitDefaultValue=false)]
        public int? WorkTypeID { get; set; }

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
            sb.Append("class TicketCategoryFieldDefaultsModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EstimatedHours: ").Append(EstimatedHours).Append("\n");
            sb.Append("  IssueTypeID: ").Append(IssueTypeID).Append("\n");
            sb.Append("  OrganizationalLevelAssociationID: ").Append(OrganizationalLevelAssociationID).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  QueueID: ").Append(QueueID).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  ServiceLevelAgreementID: ").Append(ServiceLevelAgreementID).Append("\n");
            sb.Append("  SourceID: ").Append(SourceID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubIssueTypeID: ").Append(SubIssueTypeID).Append("\n");
            sb.Append("  TicketCategoryID: ").Append(TicketCategoryID).Append("\n");
            sb.Append("  TicketTypeID: ").Append(TicketTypeID).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  WorkTypeID: ").Append(WorkTypeID).Append("\n");
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
            return this.Equals(input as TicketCategoryFieldDefaultsModel);
        }

        /// <summary>
        /// Returns true if TicketCategoryFieldDefaultsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TicketCategoryFieldDefaultsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketCategoryFieldDefaultsModel input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EstimatedHours == input.EstimatedHours ||
                    (this.EstimatedHours != null &&
                    this.EstimatedHours.Equals(input.EstimatedHours))
                ) && 
                (
                    this.IssueTypeID == input.IssueTypeID ||
                    (this.IssueTypeID != null &&
                    this.IssueTypeID.Equals(input.IssueTypeID))
                ) && 
                (
                    this.OrganizationalLevelAssociationID == input.OrganizationalLevelAssociationID ||
                    (this.OrganizationalLevelAssociationID != null &&
                    this.OrganizationalLevelAssociationID.Equals(input.OrganizationalLevelAssociationID))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.QueueID == input.QueueID ||
                    (this.QueueID != null &&
                    this.QueueID.Equals(input.QueueID))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.ServiceLevelAgreementID == input.ServiceLevelAgreementID ||
                    (this.ServiceLevelAgreementID != null &&
                    this.ServiceLevelAgreementID.Equals(input.ServiceLevelAgreementID))
                ) && 
                (
                    this.SourceID == input.SourceID ||
                    (this.SourceID != null &&
                    this.SourceID.Equals(input.SourceID))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubIssueTypeID == input.SubIssueTypeID ||
                    (this.SubIssueTypeID != null &&
                    this.SubIssueTypeID.Equals(input.SubIssueTypeID))
                ) && 
                (
                    this.TicketCategoryID == input.TicketCategoryID ||
                    (this.TicketCategoryID != null &&
                    this.TicketCategoryID.Equals(input.TicketCategoryID))
                ) && 
                (
                    this.TicketTypeID == input.TicketTypeID ||
                    (this.TicketTypeID != null &&
                    this.TicketTypeID.Equals(input.TicketTypeID))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.WorkTypeID == input.WorkTypeID ||
                    (this.WorkTypeID != null &&
                    this.WorkTypeID.Equals(input.WorkTypeID))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EstimatedHours != null)
                    hashCode = hashCode * 59 + this.EstimatedHours.GetHashCode();
                if (this.IssueTypeID != null)
                    hashCode = hashCode * 59 + this.IssueTypeID.GetHashCode();
                if (this.OrganizationalLevelAssociationID != null)
                    hashCode = hashCode * 59 + this.OrganizationalLevelAssociationID.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.QueueID != null)
                    hashCode = hashCode * 59 + this.QueueID.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.ServiceLevelAgreementID != null)
                    hashCode = hashCode * 59 + this.ServiceLevelAgreementID.GetHashCode();
                if (this.SourceID != null)
                    hashCode = hashCode * 59 + this.SourceID.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubIssueTypeID != null)
                    hashCode = hashCode * 59 + this.SubIssueTypeID.GetHashCode();
                if (this.TicketCategoryID != null)
                    hashCode = hashCode * 59 + this.TicketCategoryID.GetHashCode();
                if (this.TicketTypeID != null)
                    hashCode = hashCode * 59 + this.TicketTypeID.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.WorkTypeID != null)
                    hashCode = hashCode * 59 + this.WorkTypeID.GetHashCode();
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
