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
    /// ExpressionFuncInstalledProductWebhookFieldInt64
    /// </summary>
    [DataContract]
    public partial class ExpressionFuncInstalledProductWebhookFieldInt64 :  IEquatable<ExpressionFuncInstalledProductWebhookFieldInt64>, IValidatableObject
    {
        /// <summary>
        /// Defines NodeType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NodeTypeEnum
        {
            
            /// <summary>
            /// Enum Add for value: Add
            /// </summary>
            [EnumMember(Value = "Add")]
            Add = 1,
            
            /// <summary>
            /// Enum AddChecked for value: AddChecked
            /// </summary>
            [EnumMember(Value = "AddChecked")]
            AddChecked = 2,
            
            /// <summary>
            /// Enum And for value: And
            /// </summary>
            [EnumMember(Value = "And")]
            And = 3,
            
            /// <summary>
            /// Enum AndAlso for value: AndAlso
            /// </summary>
            [EnumMember(Value = "AndAlso")]
            AndAlso = 4,
            
            /// <summary>
            /// Enum ArrayLength for value: ArrayLength
            /// </summary>
            [EnumMember(Value = "ArrayLength")]
            ArrayLength = 5,
            
            /// <summary>
            /// Enum ArrayIndex for value: ArrayIndex
            /// </summary>
            [EnumMember(Value = "ArrayIndex")]
            ArrayIndex = 6,
            
            /// <summary>
            /// Enum Call for value: Call
            /// </summary>
            [EnumMember(Value = "Call")]
            Call = 7,
            
            /// <summary>
            /// Enum Coalesce for value: Coalesce
            /// </summary>
            [EnumMember(Value = "Coalesce")]
            Coalesce = 8,
            
            /// <summary>
            /// Enum Conditional for value: Conditional
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional = 9,
            
            /// <summary>
            /// Enum Constant for value: Constant
            /// </summary>
            [EnumMember(Value = "Constant")]
            Constant = 10,
            
            /// <summary>
            /// Enum Convert for value: Convert
            /// </summary>
            [EnumMember(Value = "Convert")]
            Convert = 11,
            
            /// <summary>
            /// Enum ConvertChecked for value: ConvertChecked
            /// </summary>
            [EnumMember(Value = "ConvertChecked")]
            ConvertChecked = 12,
            
            /// <summary>
            /// Enum Divide for value: Divide
            /// </summary>
            [EnumMember(Value = "Divide")]
            Divide = 13,
            
            /// <summary>
            /// Enum Equal for value: Equal
            /// </summary>
            [EnumMember(Value = "Equal")]
            Equal = 14,
            
            /// <summary>
            /// Enum ExclusiveOr for value: ExclusiveOr
            /// </summary>
            [EnumMember(Value = "ExclusiveOr")]
            ExclusiveOr = 15,
            
            /// <summary>
            /// Enum GreaterThan for value: GreaterThan
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            GreaterThan = 16,
            
            /// <summary>
            /// Enum GreaterThanOrEqual for value: GreaterThanOrEqual
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqual")]
            GreaterThanOrEqual = 17,
            
            /// <summary>
            /// Enum Invoke for value: Invoke
            /// </summary>
            [EnumMember(Value = "Invoke")]
            Invoke = 18,
            
            /// <summary>
            /// Enum Lambda for value: Lambda
            /// </summary>
            [EnumMember(Value = "Lambda")]
            Lambda = 19,
            
            /// <summary>
            /// Enum LeftShift for value: LeftShift
            /// </summary>
            [EnumMember(Value = "LeftShift")]
            LeftShift = 20,
            
            /// <summary>
            /// Enum LessThan for value: LessThan
            /// </summary>
            [EnumMember(Value = "LessThan")]
            LessThan = 21,
            
            /// <summary>
            /// Enum LessThanOrEqual for value: LessThanOrEqual
            /// </summary>
            [EnumMember(Value = "LessThanOrEqual")]
            LessThanOrEqual = 22,
            
            /// <summary>
            /// Enum ListInit for value: ListInit
            /// </summary>
            [EnumMember(Value = "ListInit")]
            ListInit = 23,
            
            /// <summary>
            /// Enum MemberAccess for value: MemberAccess
            /// </summary>
            [EnumMember(Value = "MemberAccess")]
            MemberAccess = 24,
            
            /// <summary>
            /// Enum MemberInit for value: MemberInit
            /// </summary>
            [EnumMember(Value = "MemberInit")]
            MemberInit = 25,
            
            /// <summary>
            /// Enum Modulo for value: Modulo
            /// </summary>
            [EnumMember(Value = "Modulo")]
            Modulo = 26,
            
            /// <summary>
            /// Enum Multiply for value: Multiply
            /// </summary>
            [EnumMember(Value = "Multiply")]
            Multiply = 27,
            
            /// <summary>
            /// Enum MultiplyChecked for value: MultiplyChecked
            /// </summary>
            [EnumMember(Value = "MultiplyChecked")]
            MultiplyChecked = 28,
            
            /// <summary>
            /// Enum Negate for value: Negate
            /// </summary>
            [EnumMember(Value = "Negate")]
            Negate = 29,
            
            /// <summary>
            /// Enum UnaryPlus for value: UnaryPlus
            /// </summary>
            [EnumMember(Value = "UnaryPlus")]
            UnaryPlus = 30,
            
            /// <summary>
            /// Enum NegateChecked for value: NegateChecked
            /// </summary>
            [EnumMember(Value = "NegateChecked")]
            NegateChecked = 31,
            
            /// <summary>
            /// Enum New for value: New
            /// </summary>
            [EnumMember(Value = "New")]
            New = 32,
            
            /// <summary>
            /// Enum NewArrayInit for value: NewArrayInit
            /// </summary>
            [EnumMember(Value = "NewArrayInit")]
            NewArrayInit = 33,
            
            /// <summary>
            /// Enum NewArrayBounds for value: NewArrayBounds
            /// </summary>
            [EnumMember(Value = "NewArrayBounds")]
            NewArrayBounds = 34,
            
            /// <summary>
            /// Enum Not for value: Not
            /// </summary>
            [EnumMember(Value = "Not")]
            Not = 35,
            
            /// <summary>
            /// Enum NotEqual for value: NotEqual
            /// </summary>
            [EnumMember(Value = "NotEqual")]
            NotEqual = 36,
            
            /// <summary>
            /// Enum Or for value: Or
            /// </summary>
            [EnumMember(Value = "Or")]
            Or = 37,
            
            /// <summary>
            /// Enum OrElse for value: OrElse
            /// </summary>
            [EnumMember(Value = "OrElse")]
            OrElse = 38,
            
            /// <summary>
            /// Enum Parameter for value: Parameter
            /// </summary>
            [EnumMember(Value = "Parameter")]
            Parameter = 39,
            
            /// <summary>
            /// Enum Power for value: Power
            /// </summary>
            [EnumMember(Value = "Power")]
            Power = 40,
            
            /// <summary>
            /// Enum Quote for value: Quote
            /// </summary>
            [EnumMember(Value = "Quote")]
            Quote = 41,
            
            /// <summary>
            /// Enum RightShift for value: RightShift
            /// </summary>
            [EnumMember(Value = "RightShift")]
            RightShift = 42,
            
            /// <summary>
            /// Enum Subtract for value: Subtract
            /// </summary>
            [EnumMember(Value = "Subtract")]
            Subtract = 43,
            
            /// <summary>
            /// Enum SubtractChecked for value: SubtractChecked
            /// </summary>
            [EnumMember(Value = "SubtractChecked")]
            SubtractChecked = 44,
            
            /// <summary>
            /// Enum TypeAs for value: TypeAs
            /// </summary>
            [EnumMember(Value = "TypeAs")]
            TypeAs = 45,
            
            /// <summary>
            /// Enum TypeIs for value: TypeIs
            /// </summary>
            [EnumMember(Value = "TypeIs")]
            TypeIs = 46,
            
            /// <summary>
            /// Enum Assign for value: Assign
            /// </summary>
            [EnumMember(Value = "Assign")]
            Assign = 47,
            
            /// <summary>
            /// Enum Block for value: Block
            /// </summary>
            [EnumMember(Value = "Block")]
            Block = 48,
            
            /// <summary>
            /// Enum DebugInfo for value: DebugInfo
            /// </summary>
            [EnumMember(Value = "DebugInfo")]
            DebugInfo = 49,
            
            /// <summary>
            /// Enum Decrement for value: Decrement
            /// </summary>
            [EnumMember(Value = "Decrement")]
            Decrement = 50,
            
            /// <summary>
            /// Enum Dynamic for value: Dynamic
            /// </summary>
            [EnumMember(Value = "Dynamic")]
            Dynamic = 51,
            
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 52,
            
            /// <summary>
            /// Enum Extension for value: Extension
            /// </summary>
            [EnumMember(Value = "Extension")]
            Extension = 53,
            
            /// <summary>
            /// Enum Goto for value: Goto
            /// </summary>
            [EnumMember(Value = "Goto")]
            Goto = 54,
            
            /// <summary>
            /// Enum Increment for value: Increment
            /// </summary>
            [EnumMember(Value = "Increment")]
            Increment = 55,
            
            /// <summary>
            /// Enum Index for value: Index
            /// </summary>
            [EnumMember(Value = "Index")]
            Index = 56,
            
            /// <summary>
            /// Enum Label for value: Label
            /// </summary>
            [EnumMember(Value = "Label")]
            Label = 57,
            
            /// <summary>
            /// Enum RuntimeVariables for value: RuntimeVariables
            /// </summary>
            [EnumMember(Value = "RuntimeVariables")]
            RuntimeVariables = 58,
            
            /// <summary>
            /// Enum Loop for value: Loop
            /// </summary>
            [EnumMember(Value = "Loop")]
            Loop = 59,
            
            /// <summary>
            /// Enum Switch for value: Switch
            /// </summary>
            [EnumMember(Value = "Switch")]
            Switch = 60,
            
            /// <summary>
            /// Enum Throw for value: Throw
            /// </summary>
            [EnumMember(Value = "Throw")]
            Throw = 61,
            
            /// <summary>
            /// Enum Try for value: Try
            /// </summary>
            [EnumMember(Value = "Try")]
            Try = 62,
            
            /// <summary>
            /// Enum Unbox for value: Unbox
            /// </summary>
            [EnumMember(Value = "Unbox")]
            Unbox = 63,
            
            /// <summary>
            /// Enum AddAssign for value: AddAssign
            /// </summary>
            [EnumMember(Value = "AddAssign")]
            AddAssign = 64,
            
            /// <summary>
            /// Enum AndAssign for value: AndAssign
            /// </summary>
            [EnumMember(Value = "AndAssign")]
            AndAssign = 65,
            
            /// <summary>
            /// Enum DivideAssign for value: DivideAssign
            /// </summary>
            [EnumMember(Value = "DivideAssign")]
            DivideAssign = 66,
            
            /// <summary>
            /// Enum ExclusiveOrAssign for value: ExclusiveOrAssign
            /// </summary>
            [EnumMember(Value = "ExclusiveOrAssign")]
            ExclusiveOrAssign = 67,
            
            /// <summary>
            /// Enum LeftShiftAssign for value: LeftShiftAssign
            /// </summary>
            [EnumMember(Value = "LeftShiftAssign")]
            LeftShiftAssign = 68,
            
            /// <summary>
            /// Enum ModuloAssign for value: ModuloAssign
            /// </summary>
            [EnumMember(Value = "ModuloAssign")]
            ModuloAssign = 69,
            
            /// <summary>
            /// Enum MultiplyAssign for value: MultiplyAssign
            /// </summary>
            [EnumMember(Value = "MultiplyAssign")]
            MultiplyAssign = 70,
            
            /// <summary>
            /// Enum OrAssign for value: OrAssign
            /// </summary>
            [EnumMember(Value = "OrAssign")]
            OrAssign = 71,
            
            /// <summary>
            /// Enum PowerAssign for value: PowerAssign
            /// </summary>
            [EnumMember(Value = "PowerAssign")]
            PowerAssign = 72,
            
            /// <summary>
            /// Enum RightShiftAssign for value: RightShiftAssign
            /// </summary>
            [EnumMember(Value = "RightShiftAssign")]
            RightShiftAssign = 73,
            
            /// <summary>
            /// Enum SubtractAssign for value: SubtractAssign
            /// </summary>
            [EnumMember(Value = "SubtractAssign")]
            SubtractAssign = 74,
            
            /// <summary>
            /// Enum AddAssignChecked for value: AddAssignChecked
            /// </summary>
            [EnumMember(Value = "AddAssignChecked")]
            AddAssignChecked = 75,
            
            /// <summary>
            /// Enum MultiplyAssignChecked for value: MultiplyAssignChecked
            /// </summary>
            [EnumMember(Value = "MultiplyAssignChecked")]
            MultiplyAssignChecked = 76,
            
            /// <summary>
            /// Enum SubtractAssignChecked for value: SubtractAssignChecked
            /// </summary>
            [EnumMember(Value = "SubtractAssignChecked")]
            SubtractAssignChecked = 77,
            
            /// <summary>
            /// Enum PreIncrementAssign for value: PreIncrementAssign
            /// </summary>
            [EnumMember(Value = "PreIncrementAssign")]
            PreIncrementAssign = 78,
            
            /// <summary>
            /// Enum PreDecrementAssign for value: PreDecrementAssign
            /// </summary>
            [EnumMember(Value = "PreDecrementAssign")]
            PreDecrementAssign = 79,
            
            /// <summary>
            /// Enum PostIncrementAssign for value: PostIncrementAssign
            /// </summary>
            [EnumMember(Value = "PostIncrementAssign")]
            PostIncrementAssign = 80,
            
            /// <summary>
            /// Enum PostDecrementAssign for value: PostDecrementAssign
            /// </summary>
            [EnumMember(Value = "PostDecrementAssign")]
            PostDecrementAssign = 81,
            
            /// <summary>
            /// Enum TypeEqual for value: TypeEqual
            /// </summary>
            [EnumMember(Value = "TypeEqual")]
            TypeEqual = 82,
            
            /// <summary>
            /// Enum OnesComplement for value: OnesComplement
            /// </summary>
            [EnumMember(Value = "OnesComplement")]
            OnesComplement = 83,
            
            /// <summary>
            /// Enum IsTrue for value: IsTrue
            /// </summary>
            [EnumMember(Value = "IsTrue")]
            IsTrue = 84,
            
            /// <summary>
            /// Enum IsFalse for value: IsFalse
            /// </summary>
            [EnumMember(Value = "IsFalse")]
            IsFalse = 85
        }

        /// <summary>
        /// Gets or Sets NodeType
        /// </summary>
        [DataMember(Name="nodeType", EmitDefaultValue=false)]
        public NodeTypeEnum? NodeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionFuncInstalledProductWebhookFieldInt64" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ExpressionFuncInstalledProductWebhookFieldInt64()
        {
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }


        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<ParameterExpression> Parameters { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public Expression Body { get; private set; }

        /// <summary>
        /// Gets or Sets ReturnType
        /// </summary>
        [DataMember(Name="returnType", EmitDefaultValue=false)]
        public string ReturnType { get; private set; }

        /// <summary>
        /// Gets or Sets TailCall
        /// </summary>
        [DataMember(Name="tailCall", EmitDefaultValue=false)]
        public bool? TailCall { get; private set; }

        /// <summary>
        /// Gets or Sets CanReduce
        /// </summary>
        [DataMember(Name="canReduce", EmitDefaultValue=false)]
        public bool? CanReduce { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpressionFuncInstalledProductWebhookFieldInt64 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  ReturnType: ").Append(ReturnType).Append("\n");
            sb.Append("  TailCall: ").Append(TailCall).Append("\n");
            sb.Append("  CanReduce: ").Append(CanReduce).Append("\n");
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
            return this.Equals(input as ExpressionFuncInstalledProductWebhookFieldInt64);
        }

        /// <summary>
        /// Returns true if ExpressionFuncInstalledProductWebhookFieldInt64 instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpressionFuncInstalledProductWebhookFieldInt64 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpressionFuncInstalledProductWebhookFieldInt64 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.NodeType == input.NodeType ||
                    (this.NodeType != null &&
                    this.NodeType.Equals(input.NodeType))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.ReturnType == input.ReturnType ||
                    (this.ReturnType != null &&
                    this.ReturnType.Equals(input.ReturnType))
                ) && 
                (
                    this.TailCall == input.TailCall ||
                    (this.TailCall != null &&
                    this.TailCall.Equals(input.TailCall))
                ) && 
                (
                    this.CanReduce == input.CanReduce ||
                    (this.CanReduce != null &&
                    this.CanReduce.Equals(input.CanReduce))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NodeType != null)
                    hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.ReturnType != null)
                    hashCode = hashCode * 59 + this.ReturnType.GetHashCode();
                if (this.TailCall != null)
                    hashCode = hashCode * 59 + this.TailCall.GetHashCode();
                if (this.CanReduce != null)
                    hashCode = hashCode * 59 + this.CanReduce.GetHashCode();
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
