// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace NomadCode.MobileCenter.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Hash, type, path and byte range of a file that is required in test run
    /// </summary>
    public partial class TestCloudFileHashDeprecated
    {
        /// <summary>
        /// Initializes a new instance of the TestCloudFileHashDeprecated
        /// class.
        /// </summary>
        public TestCloudFileHashDeprecated() { }

        /// <summary>
        /// Initializes a new instance of the TestCloudFileHashDeprecated
        /// class.
        /// </summary>
        public TestCloudFileHashDeprecated(string fileType, string checksum, string relativePath, string byteRange = default(string))
        {
            FileType = fileType;
            Checksum = checksum;
            RelativePath = relativePath;
            ByteRange = byteRange;
        }

        /// <summary>
        /// Type of the file. Possible values include: 'dsym-file',
        /// 'app-file', 'test-file'
        /// </summary>
        [JsonProperty(PropertyName = "file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// SHA256 hash of the file
        /// </summary>
        [JsonProperty(PropertyName = "checksum")]
        public string Checksum { get; set; }

        /// <summary>
        /// Relative path of the file
        /// </summary>
        [JsonProperty(PropertyName = "relative_path")]
        public string RelativePath { get; set; }

        /// <summary>
        /// Range of bytes required to verify ownership of the file
        /// </summary>
        [JsonProperty(PropertyName = "byte_range")]
        public string ByteRange { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (FileType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileType");
            }
            if (Checksum == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Checksum");
            }
            if (RelativePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RelativePath");
            }
        }
    }
}