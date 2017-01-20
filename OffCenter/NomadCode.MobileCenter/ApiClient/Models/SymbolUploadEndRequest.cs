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
    /// A request containing information pertaining to completing a symbol
    /// upload process
    /// </summary>
    public partial class SymbolUploadEndRequest
    {
        /// <summary>
        /// Initializes a new instance of the SymbolUploadEndRequest class.
        /// </summary>
        public SymbolUploadEndRequest() { }

        /// <summary>
        /// Initializes a new instance of the SymbolUploadEndRequest class.
        /// </summary>
        public SymbolUploadEndRequest(string status)
        {
            Status = status;
        }

        /// <summary>
        /// The desired operation for the symbol upload. Possible values
        /// include: 'committed', 'aborted'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}