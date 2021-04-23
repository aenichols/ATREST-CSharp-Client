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
    /// PhaseModel
    /// </summary>
    [DataContract]
    public partial class PhaseModel :  IEquatable<PhaseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhaseModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createDate">createDate.</param>
        /// <param name="creatorResourceID">creatorResourceID.</param>
        /// <param name="description">description.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="estimatedHours">estimatedHours.</param>
        /// <param name="externalID">externalID.</param>
        /// <param name="isScheduled">isScheduled.</param>
        /// <param name="lastActivityDateTime">lastActivityDateTime.</param>
        /// <param name="parentPhaseID">parentPhaseID.</param>
        /// <param name="phaseNumber">phaseNumber.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="title">title.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public PhaseModel(long? id = default(long?), DateTime? createDate = default(DateTime?), int? creatorResourceID = default(int?), string description = default(string), DateTime? dueDate = default(DateTime?), double? estimatedHours = default(double?), string externalID = default(string), bool? isScheduled = default(bool?), DateTime? lastActivityDateTime = default(DateTime?), int? parentPhaseID = default(int?), string phaseNumber = default(string), int? projectID = default(int?), DateTime? startDate = default(DateTime?), string title = default(string), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.CreateDate = createDate;
            this.CreatorResourceID = creatorResourceID;
            this.Description = description;
            this.DueDate = dueDate;
            this.EstimatedHours = estimatedHours;
            this.ExternalID = externalID;
            this.IsScheduled = isScheduled;
            this.LastActivityDateTime = lastActivityDateTime;
            this.ParentPhaseID = parentPhaseID;
            this.PhaseNumber = phaseNumber;
            this.ProjectID = projectID;
            this.StartDate = startDate;
            this.Title = title;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatorResourceID
        /// </summary>
        [DataMember(Name="creatorResourceID", EmitDefaultValue=false)]
        public int? CreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedHours
        /// </summary>
        [DataMember(Name="estimatedHours", EmitDefaultValue=false)]
        public double? EstimatedHours { get; set; }

        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name="externalID", EmitDefaultValue=false)]
        public string ExternalID { get; set; }

        /// <summary>
        /// Gets or Sets IsScheduled
        /// </summary>
        [DataMember(Name="isScheduled", EmitDefaultValue=false)]
        public bool? IsScheduled { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityDateTime
        /// </summary>
        [DataMember(Name="lastActivityDateTime", EmitDefaultValue=false)]
        public DateTime? LastActivityDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ParentPhaseID
        /// </summary>
        [DataMember(Name="parentPhaseID", EmitDefaultValue=false)]
        public int? ParentPhaseID { get; set; }

        /// <summary>
        /// Gets or Sets PhaseNumber
        /// </summary>
        [DataMember(Name="phaseNumber", EmitDefaultValue=false)]
        public string PhaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="projectID", EmitDefaultValue=false)]
        public int? ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncPhaseInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class PhaseModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CreatorResourceID: ").Append(CreatorResourceID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  EstimatedHours: ").Append(EstimatedHours).Append("\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  IsScheduled: ").Append(IsScheduled).Append("\n");
            sb.Append("  LastActivityDateTime: ").Append(LastActivityDateTime).Append("\n");
            sb.Append("  ParentPhaseID: ").Append(ParentPhaseID).Append("\n");
            sb.Append("  PhaseNumber: ").Append(PhaseNumber).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as PhaseModel);
        }

        /// <summary>
        /// Returns true if PhaseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PhaseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhaseModel input)
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
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.CreatorResourceID == input.CreatorResourceID ||
                    (this.CreatorResourceID != null &&
                    this.CreatorResourceID.Equals(input.CreatorResourceID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.EstimatedHours == input.EstimatedHours ||
                    (this.EstimatedHours != null &&
                    this.EstimatedHours.Equals(input.EstimatedHours))
                ) && 
                (
                    this.ExternalID == input.ExternalID ||
                    (this.ExternalID != null &&
                    this.ExternalID.Equals(input.ExternalID))
                ) && 
                (
                    this.IsScheduled == input.IsScheduled ||
                    (this.IsScheduled != null &&
                    this.IsScheduled.Equals(input.IsScheduled))
                ) && 
                (
                    this.LastActivityDateTime == input.LastActivityDateTime ||
                    (this.LastActivityDateTime != null &&
                    this.LastActivityDateTime.Equals(input.LastActivityDateTime))
                ) && 
                (
                    this.ParentPhaseID == input.ParentPhaseID ||
                    (this.ParentPhaseID != null &&
                    this.ParentPhaseID.Equals(input.ParentPhaseID))
                ) && 
                (
                    this.PhaseNumber == input.PhaseNumber ||
                    (this.PhaseNumber != null &&
                    this.PhaseNumber.Equals(input.PhaseNumber))
                ) && 
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.CreatorResourceID != null)
                    hashCode = hashCode * 59 + this.CreatorResourceID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.EstimatedHours != null)
                    hashCode = hashCode * 59 + this.EstimatedHours.GetHashCode();
                if (this.ExternalID != null)
                    hashCode = hashCode * 59 + this.ExternalID.GetHashCode();
                if (this.IsScheduled != null)
                    hashCode = hashCode * 59 + this.IsScheduled.GetHashCode();
                if (this.LastActivityDateTime != null)
                    hashCode = hashCode * 59 + this.LastActivityDateTime.GetHashCode();
                if (this.ParentPhaseID != null)
                    hashCode = hashCode * 59 + this.ParentPhaseID.GetHashCode();
                if (this.PhaseNumber != null)
                    hashCode = hashCode * 59 + this.PhaseNumber.GetHashCode();
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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