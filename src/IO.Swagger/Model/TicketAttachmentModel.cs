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
    /// TicketAttachmentModel
    /// </summary>
    [DataContract]
    public partial class TicketAttachmentModel :  IEquatable<TicketAttachmentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketAttachmentModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="attachDate">attachDate.</param>
        /// <param name="attachedByContactID">attachedByContactID.</param>
        /// <param name="attachedByResourceID">attachedByResourceID.</param>
        /// <param name="attachmentType">attachmentType.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="creatorType">creatorType.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="fullPath">fullPath.</param>
        /// <param name="impersonatorCreatorResourceID">impersonatorCreatorResourceID.</param>
        /// <param name="opportunityID">opportunityID.</param>
        /// <param name="parentID">parentID.</param>
        /// <param name="publish">publish.</param>
        /// <param name="title">title.</param>
        /// <param name="data">data.</param>
        public TicketAttachmentModel(long? id = default(long?), DateTime? attachDate = default(DateTime?), long? attachedByContactID = default(long?), long? attachedByResourceID = default(long?), string attachmentType = default(string), string contentType = default(string), int? creatorType = default(int?), double? fileSize = default(double?), string fullPath = default(string), int? impersonatorCreatorResourceID = default(int?), long? opportunityID = default(long?), long? parentID = default(long?), int? publish = default(int?), string title = default(string), byte[] data = default(byte[]))
        {
            this.Id = id;
            this.AttachDate = attachDate;
            this.AttachedByContactID = attachedByContactID;
            this.AttachedByResourceID = attachedByResourceID;
            this.AttachmentType = attachmentType;
            this.ContentType = contentType;
            this.CreatorType = creatorType;
            this.FileSize = fileSize;
            this.FullPath = fullPath;
            this.ImpersonatorCreatorResourceID = impersonatorCreatorResourceID;
            this.OpportunityID = opportunityID;
            this.ParentID = parentID;
            this.Publish = publish;
            this.Title = title;
            this.Data = data;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets AttachDate
        /// </summary>
        [DataMember(Name="attachDate", EmitDefaultValue=false)]
        public DateTime? AttachDate { get; set; }

        /// <summary>
        /// Gets or Sets AttachedByContactID
        /// </summary>
        [DataMember(Name="attachedByContactID", EmitDefaultValue=false)]
        public long? AttachedByContactID { get; set; }

        /// <summary>
        /// Gets or Sets AttachedByResourceID
        /// </summary>
        [DataMember(Name="attachedByResourceID", EmitDefaultValue=false)]
        public long? AttachedByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentType
        /// </summary>
        [DataMember(Name="attachmentType", EmitDefaultValue=false)]
        public string AttachmentType { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets CreatorType
        /// </summary>
        [DataMember(Name="creatorType", EmitDefaultValue=false)]
        public int? CreatorType { get; set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name="fileSize", EmitDefaultValue=false)]
        public double? FileSize { get; set; }

        /// <summary>
        /// Gets or Sets FullPath
        /// </summary>
        [DataMember(Name="fullPath", EmitDefaultValue=false)]
        public string FullPath { get; set; }

        /// <summary>
        /// Gets or Sets ImpersonatorCreatorResourceID
        /// </summary>
        [DataMember(Name="impersonatorCreatorResourceID", EmitDefaultValue=false)]
        public int? ImpersonatorCreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityID
        /// </summary>
        [DataMember(Name="opportunityID", EmitDefaultValue=false)]
        public long? OpportunityID { get; set; }

        /// <summary>
        /// Gets or Sets ParentID
        /// </summary>
        [DataMember(Name="parentID", EmitDefaultValue=false)]
        public long? ParentID { get; set; }

        /// <summary>
        /// Gets or Sets Publish
        /// </summary>
        [DataMember(Name="publish", EmitDefaultValue=false)]
        public int? Publish { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public byte[] Data { get; set; }

        /// <summary>
        /// Gets or Sets ParentType
        /// </summary>
        [DataMember(Name="parentType", EmitDefaultValue=false)]
        public int? ParentType { get; private set; }

        /// <summary>
        /// Gets or Sets IsTaskAttachment
        /// </summary>
        [DataMember(Name="isTaskAttachment", EmitDefaultValue=false)]
        public bool? IsTaskAttachment { get; private set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncAttachmentInfoInt64 SoapParentPropertyId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TicketAttachmentModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttachDate: ").Append(AttachDate).Append("\n");
            sb.Append("  AttachedByContactID: ").Append(AttachedByContactID).Append("\n");
            sb.Append("  AttachedByResourceID: ").Append(AttachedByResourceID).Append("\n");
            sb.Append("  AttachmentType: ").Append(AttachmentType).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  CreatorType: ").Append(CreatorType).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
            sb.Append("  ImpersonatorCreatorResourceID: ").Append(ImpersonatorCreatorResourceID).Append("\n");
            sb.Append("  OpportunityID: ").Append(OpportunityID).Append("\n");
            sb.Append("  ParentID: ").Append(ParentID).Append("\n");
            sb.Append("  Publish: ").Append(Publish).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ParentType: ").Append(ParentType).Append("\n");
            sb.Append("  IsTaskAttachment: ").Append(IsTaskAttachment).Append("\n");
            sb.Append("  SoapParentPropertyId: ").Append(SoapParentPropertyId).Append("\n");
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
            return this.Equals(input as TicketAttachmentModel);
        }

        /// <summary>
        /// Returns true if TicketAttachmentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TicketAttachmentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketAttachmentModel input)
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
                    this.AttachDate == input.AttachDate ||
                    (this.AttachDate != null &&
                    this.AttachDate.Equals(input.AttachDate))
                ) && 
                (
                    this.AttachedByContactID == input.AttachedByContactID ||
                    (this.AttachedByContactID != null &&
                    this.AttachedByContactID.Equals(input.AttachedByContactID))
                ) && 
                (
                    this.AttachedByResourceID == input.AttachedByResourceID ||
                    (this.AttachedByResourceID != null &&
                    this.AttachedByResourceID.Equals(input.AttachedByResourceID))
                ) && 
                (
                    this.AttachmentType == input.AttachmentType ||
                    (this.AttachmentType != null &&
                    this.AttachmentType.Equals(input.AttachmentType))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.CreatorType == input.CreatorType ||
                    (this.CreatorType != null &&
                    this.CreatorType.Equals(input.CreatorType))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
                ) && 
                (
                    this.ImpersonatorCreatorResourceID == input.ImpersonatorCreatorResourceID ||
                    (this.ImpersonatorCreatorResourceID != null &&
                    this.ImpersonatorCreatorResourceID.Equals(input.ImpersonatorCreatorResourceID))
                ) && 
                (
                    this.OpportunityID == input.OpportunityID ||
                    (this.OpportunityID != null &&
                    this.OpportunityID.Equals(input.OpportunityID))
                ) && 
                (
                    this.ParentID == input.ParentID ||
                    (this.ParentID != null &&
                    this.ParentID.Equals(input.ParentID))
                ) && 
                (
                    this.Publish == input.Publish ||
                    (this.Publish != null &&
                    this.Publish.Equals(input.Publish))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.ParentType == input.ParentType ||
                    (this.ParentType != null &&
                    this.ParentType.Equals(input.ParentType))
                ) && 
                (
                    this.IsTaskAttachment == input.IsTaskAttachment ||
                    (this.IsTaskAttachment != null &&
                    this.IsTaskAttachment.Equals(input.IsTaskAttachment))
                ) && 
                (
                    this.SoapParentPropertyId == input.SoapParentPropertyId ||
                    (this.SoapParentPropertyId != null &&
                    this.SoapParentPropertyId.Equals(input.SoapParentPropertyId))
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
                if (this.AttachDate != null)
                    hashCode = hashCode * 59 + this.AttachDate.GetHashCode();
                if (this.AttachedByContactID != null)
                    hashCode = hashCode * 59 + this.AttachedByContactID.GetHashCode();
                if (this.AttachedByResourceID != null)
                    hashCode = hashCode * 59 + this.AttachedByResourceID.GetHashCode();
                if (this.AttachmentType != null)
                    hashCode = hashCode * 59 + this.AttachmentType.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.CreatorType != null)
                    hashCode = hashCode * 59 + this.CreatorType.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.ImpersonatorCreatorResourceID != null)
                    hashCode = hashCode * 59 + this.ImpersonatorCreatorResourceID.GetHashCode();
                if (this.OpportunityID != null)
                    hashCode = hashCode * 59 + this.OpportunityID.GetHashCode();
                if (this.ParentID != null)
                    hashCode = hashCode * 59 + this.ParentID.GetHashCode();
                if (this.Publish != null)
                    hashCode = hashCode * 59 + this.Publish.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.ParentType != null)
                    hashCode = hashCode * 59 + this.ParentType.GetHashCode();
                if (this.IsTaskAttachment != null)
                    hashCode = hashCode * 59 + this.IsTaskAttachment.GetHashCode();
                if (this.SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + this.SoapParentPropertyId.GetHashCode();
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
