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

    public partial class CrashGroupContainer
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroupContainer class.
        /// </summary>
        public CrashGroupContainer() { }

        /// <summary>
        /// Initializes a new instance of the CrashGroupContainer class.
        /// </summary>
        public CrashGroupContainer(IList<CrashGroupAndVersion> crashGroups)
        {
            CrashGroups = crashGroups;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_groups")]
        public IList<CrashGroupAndVersion> CrashGroups { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (CrashGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CrashGroups");
            }
            if (this.CrashGroups != null)
            {
                if (this.CrashGroups.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "CrashGroups", 1);
                }
            }
        }
    }
}