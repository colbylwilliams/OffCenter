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

    public partial class Symbol
    {
        /// <summary>
        /// Initializes a new instance of the Symbol class.
        /// </summary>
        public Symbol() { }

        /// <summary>
        /// Initializes a new instance of the Symbol class.
        /// </summary>
        public Symbol(string symbolId, string type, string appId, string platform, string url, string origin, IList<string> alternateSymbolIds, string status)
        {
            SymbolId = symbolId;
            Type = type;
            AppId = appId;
            Platform = platform;
            Url = url;
            Origin = origin;
            AlternateSymbolIds = alternateSymbolIds;
            Status = status;
        }

        /// <summary>
        /// The unique id for this symbol (uuid)
        /// </summary>
        [JsonProperty(PropertyName = "symbol_id")]
        public string SymbolId { get; set; }

        /// <summary>
        /// The type of the symbol for the current symbol upload. Possible
        /// values include: 'Apple', 'JavaScript'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The application that this symbol belongs to
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// The platform that this symbol is for
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <summary>
        /// The URL at which the client may download the symbol file
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// The origin of the symbol file. Possible values include: 'System',
        /// 'User'
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// The other symbols in the same file
        /// </summary>
        [JsonProperty(PropertyName = "alternate_symbol_ids")]
        public IList<string> AlternateSymbolIds { get; set; }

        /// <summary>
        /// Whether the symbol is ignored. Possible values include:
        /// 'available', 'ignored'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (SymbolId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SymbolId");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (AppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppId");
            }
            if (Platform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Platform");
            }
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (Origin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Origin");
            }
            if (AlternateSymbolIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AlternateSymbolIds");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}