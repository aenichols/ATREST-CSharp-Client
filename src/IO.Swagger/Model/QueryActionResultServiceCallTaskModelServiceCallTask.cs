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
    /// QueryActionResultServiceCallTaskModelServiceCallTask
    /// </summary>
    [DataContract]
    public partial class QueryActionResultServiceCallTaskModelServiceCallTask :  IEquatable<QueryActionResultServiceCallTaskModelServiceCallTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryActionResultServiceCallTaskModelServiceCallTask" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="pageDetails">pageDetails.</param>
        public QueryActionResultServiceCallTaskModelServiceCallTask(List<ServiceCallTaskModel> items = default(List<ServiceCallTaskModel>), PagingModel pageDetails = default(PagingModel))
        {
            this.Items = items;
            this.PageDetails = pageDetails;
        }
        
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ServiceCallTaskModel> Items { get; set; }

        /// <summary>
        /// Gets or Sets PageDetails
        /// </summary>
        [DataMember(Name="pageDetails", EmitDefaultValue=false)]
        public PagingModel PageDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryActionResultServiceCallTaskModelServiceCallTask {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  PageDetails: ").Append(PageDetails).Append("\n");
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
            return this.Equals(input as QueryActionResultServiceCallTaskModelServiceCallTask);
        }

        /// <summary>
        /// Returns true if QueryActionResultServiceCallTaskModelServiceCallTask instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryActionResultServiceCallTaskModelServiceCallTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryActionResultServiceCallTaskModelServiceCallTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.PageDetails == input.PageDetails ||
                    (this.PageDetails != null &&
                    this.PageDetails.Equals(input.PageDetails))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.PageDetails != null)
                    hashCode = hashCode * 59 + this.PageDetails.GetHashCode();
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
