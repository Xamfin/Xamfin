/*
 * Jellyfin API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 10.7.6
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Jellyfin.Api.Client.OpenAPIDateConverter;

namespace Jellyfin.Api.Model
{
    /// <summary>
    /// Class QueueRequestDto.
    /// </summary>
    [DataContract]
    public partial class QueueRequestDto :  IEquatable<QueueRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the mode in which to add the new items.
        /// </summary>
        /// <value>Gets or sets the mode in which to add the new items.</value>
        [DataMember(Name="Mode", EmitDefaultValue=false)]
        public GroupQueueMode? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueRequestDto" /> class.
        /// </summary>
        /// <param name="itemIds">Gets or sets the items to enqueue..</param>
        /// <param name="mode">Gets or sets the mode in which to add the new items..</param>
        public QueueRequestDto(List<Guid> itemIds = default(List<Guid>), GroupQueueMode? mode = default(GroupQueueMode?))
        {
            this.ItemIds = itemIds;
            this.ItemIds = itemIds;
            this.Mode = mode;
        }

        /// <summary>
        /// Gets or sets the items to enqueue.
        /// </summary>
        /// <value>Gets or sets the items to enqueue.</value>
        [DataMember(Name="ItemIds", EmitDefaultValue=true)]
        public List<Guid> ItemIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueRequestDto {\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueueRequestDto);
        }

        /// <summary>
        /// Returns true if QueueRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemIds == input.ItemIds ||
                    this.ItemIds != null &&
                    input.ItemIds != null &&
                    this.ItemIds.SequenceEqual(input.ItemIds)
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.ItemIds != null)
                    hashCode = hashCode * 59 + this.ItemIds.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
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
