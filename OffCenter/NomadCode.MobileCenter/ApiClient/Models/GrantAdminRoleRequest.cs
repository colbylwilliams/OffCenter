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

    public partial class GrantAdminRoleRequest
    {
        /// <summary>
        /// Initializes a new instance of the GrantAdminRoleRequest class.
        /// </summary>
        public GrantAdminRoleRequest() { }

        /// <summary>
        /// Initializes a new instance of the GrantAdminRoleRequest class.
        /// </summary>
        public GrantAdminRoleRequest(string adminRole)
        {
            AdminRole = adminRole;
        }

        /// <summary>
        /// The new admin_role. Possible values include: 'superAdmin',
        /// 'admin', 'devOps', 'notAdmin'
        /// </summary>
        [JsonProperty(PropertyName = "admin_role")]
        public string AdminRole { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (AdminRole == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdminRole");
            }
        }
    }
}
