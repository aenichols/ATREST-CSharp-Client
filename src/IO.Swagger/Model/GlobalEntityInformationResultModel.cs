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
    /// GlobalEntityInformationResultModel
    /// </summary>
    [DataContract]
    public partial class GlobalEntityInformationResultModel :  IEquatable<GlobalEntityInformationResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalEntityInformationResultModel" /> class.
        /// </summary>
        /// <param name="entityDescriptions">entityDescriptions.</param>
        public GlobalEntityInformationResultModel(List<EntityInformationResultModel> entityDescriptions = default(List<EntityInformationResultModel>))
        {
            this.EntityDescriptions = entityDescriptions;
        }
        
        /// <summary>
        /// Gets or Sets EntityDescriptions
        /// </summary>
        [DataMember(Name="entityDescriptions", EmitDefaultValue=false)]
        public List<EntityInformationResultModel> EntityDescriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalEntityInformationResultModel {\n");
            sb.Append("  EntityDescriptions: ").Append(EntityDescriptions).Append("\n");
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
            return this.Equals(input as GlobalEntityInformationResultModel);
        }

        /// <summary>
        /// Returns true if GlobalEntityInformationResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GlobalEntityInformationResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalEntityInformationResultModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityDescriptions == input.EntityDescriptions ||
                    this.EntityDescriptions != null &&
                    this.EntityDescriptions.SequenceEqual(input.EntityDescriptions)
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
                if (this.EntityDescriptions != null)
                    hashCode = hashCode * 59 + this.EntityDescriptions.GetHashCode();
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