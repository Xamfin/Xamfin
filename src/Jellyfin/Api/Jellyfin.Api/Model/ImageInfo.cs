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
    /// Class ImageInfo.
    /// </summary>
    [DataContract]
    public partial class ImageInfo :  IEquatable<ImageInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the type of the image.
        /// </summary>
        /// <value>Gets or sets the type of the image.</value>
        [DataMember(Name="ImageType", EmitDefaultValue=false)]
        public ImageType? ImageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageInfo" /> class.
        /// </summary>
        /// <param name="imageType">Gets or sets the type of the image..</param>
        /// <param name="imageIndex">Gets or sets the index of the image..</param>
        /// <param name="imageTag">Gets or sets the image tag..</param>
        /// <param name="path">Gets or sets the path..</param>
        /// <param name="blurHash">Gets or sets the blurhash..</param>
        /// <param name="height">Gets or sets the height..</param>
        /// <param name="width">Gets or sets the width..</param>
        /// <param name="size">Gets or sets the size..</param>
        public ImageInfo(ImageType? imageType = default(ImageType?), int? imageIndex = default(int?), string imageTag = default(string), string path = default(string), string blurHash = default(string), int? height = default(int?), int? width = default(int?), long size = default(long))
        {
            this.ImageIndex = imageIndex;
            this.ImageTag = imageTag;
            this.Path = path;
            this.BlurHash = blurHash;
            this.Height = height;
            this.Width = width;
            this.ImageType = imageType;
            this.ImageIndex = imageIndex;
            this.ImageTag = imageTag;
            this.Path = path;
            this.BlurHash = blurHash;
            this.Height = height;
            this.Width = width;
            this.Size = size;
        }


        /// <summary>
        /// Gets or sets the index of the image.
        /// </summary>
        /// <value>Gets or sets the index of the image.</value>
        [DataMember(Name="ImageIndex", EmitDefaultValue=true)]
        public int? ImageIndex { get; set; }

        /// <summary>
        /// Gets or sets the image tag.
        /// </summary>
        /// <value>Gets or sets the image tag.</value>
        [DataMember(Name="ImageTag", EmitDefaultValue=true)]
        public string ImageTag { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>Gets or sets the path.</value>
        [DataMember(Name="Path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the blurhash.
        /// </summary>
        /// <value>Gets or sets the blurhash.</value>
        [DataMember(Name="BlurHash", EmitDefaultValue=true)]
        public string BlurHash { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>Gets or sets the height.</value>
        [DataMember(Name="Height", EmitDefaultValue=true)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>Gets or sets the width.</value>
        [DataMember(Name="Width", EmitDefaultValue=true)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>Gets or sets the size.</value>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public long Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageInfo {\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  ImageIndex: ").Append(ImageIndex).Append("\n");
            sb.Append("  ImageTag: ").Append(ImageTag).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  BlurHash: ").Append(BlurHash).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as ImageInfo);
        }

        /// <summary>
        /// Returns true if ImageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageType == input.ImageType ||
                    (this.ImageType != null &&
                    this.ImageType.Equals(input.ImageType))
                ) && 
                (
                    this.ImageIndex == input.ImageIndex ||
                    (this.ImageIndex != null &&
                    this.ImageIndex.Equals(input.ImageIndex))
                ) && 
                (
                    this.ImageTag == input.ImageTag ||
                    (this.ImageTag != null &&
                    this.ImageTag.Equals(input.ImageTag))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.BlurHash == input.BlurHash ||
                    (this.BlurHash != null &&
                    this.BlurHash.Equals(input.BlurHash))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.ImageType != null)
                    hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.ImageIndex != null)
                    hashCode = hashCode * 59 + this.ImageIndex.GetHashCode();
                if (this.ImageTag != null)
                    hashCode = hashCode * 59 + this.ImageTag.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.BlurHash != null)
                    hashCode = hashCode * 59 + this.BlurHash.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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