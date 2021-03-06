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
    /// Device characteristics.
    /// </summary>
    public partial class Device
    {
        /// <summary>
        /// Initializes a new instance of the Device class.
        /// </summary>
        public Device() { }

        /// <summary>
        /// Initializes a new instance of the Device class.
        /// </summary>
        public Device(string sdkName, string sdkVersion, string model, string oemName, string osName, string osVersion, string locale, int timeZoneOffset, string screenSize, string appVersion, string appBuild, string wrapperSdkVersion = default(string), string wrapperSdkName = default(string), string osBuild = default(string), int? osApiLevel = default(int?), string carrierName = default(string), string carrierCode = default(string), string carrierCountry = default(string), string appNamespace = default(string))
        {
            SdkName = sdkName;
            SdkVersion = sdkVersion;
            WrapperSdkVersion = wrapperSdkVersion;
            WrapperSdkName = wrapperSdkName;
            Model = model;
            OemName = oemName;
            OsName = osName;
            OsVersion = osVersion;
            OsBuild = osBuild;
            OsApiLevel = osApiLevel;
            Locale = locale;
            TimeZoneOffset = timeZoneOffset;
            ScreenSize = screenSize;
            AppVersion = appVersion;
            CarrierName = carrierName;
            CarrierCode = carrierCode;
            CarrierCountry = carrierCountry;
            AppBuild = appBuild;
            AppNamespace = appNamespace;
        }

        /// <summary>
        /// Name of the SDK. Consists of the name of the SDK and the platform,
        /// e.g. "avalanchesdk.ios", "hockeysdk.android".
        /// </summary>
        [JsonProperty(PropertyName = "sdk_name")]
        public string SdkName { get; set; }

        /// <summary>
        /// Version of the SDK in semver format, e.g. "1.2.0" or
        /// "0.12.3-alpha.1".
        /// </summary>
        [JsonProperty(PropertyName = "sdk_version")]
        public string SdkVersion { get; set; }

        /// <summary>
        /// Version of the wrapper SDK in semver format. When the SDK is
        /// embedding another base SDK (for example Xamarin.Android wraps
        /// Android), the Xamarin specific version is populated into this
        /// field while sdkVersion refers to the original Android SDK.
        /// </summary>
        [JsonProperty(PropertyName = "wrapper_sdk_version")]
        public string WrapperSdkVersion { get; set; }

        /// <summary>
        /// Name of the wrapper SDK. Consists of the name of the SDK and the
        /// wrapper platform, e.g. "avalanchesdk.xamarin",
        /// "hockeysdk.cordova".
        /// </summary>
        [JsonProperty(PropertyName = "wrapper_sdk_name")]
        public string WrapperSdkName { get; set; }

        /// <summary>
        /// Device model (example: iPad2,3).
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; }

        /// <summary>
        /// Device manufacturer (example: HTC).
        /// </summary>
        [JsonProperty(PropertyName = "oem_name")]
        public string OemName { get; set; }

        /// <summary>
        /// OS name (example: iOS). The following OS names are standardized
        /// (non-exclusive): Android, iOS, macOS, tvOS, Windows.
        /// </summary>
        [JsonProperty(PropertyName = "os_name")]
        public string OsName { get; set; }

        /// <summary>
        /// OS version (example: 9.3.0).
        /// </summary>
        [JsonProperty(PropertyName = "os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// OS build code (example: LMY47X).
        /// </summary>
        [JsonProperty(PropertyName = "os_build")]
        public string OsBuild { get; set; }

        /// <summary>
        /// API level when applicable like in Android (example: 15).
        /// </summary>
        [JsonProperty(PropertyName = "os_api_level")]
        public int? OsApiLevel { get; set; }

        /// <summary>
        /// Language code (example: en_US).
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// The offset in minutes from UTC for the device time zone, including
        /// daylight savings time.
        /// </summary>
        [JsonProperty(PropertyName = "time_zone_offset")]
        public int TimeZoneOffset { get; set; }

        /// <summary>
        /// Screen size of the device in pixels (example: 640x480).
        /// </summary>
        [JsonProperty(PropertyName = "screen_size")]
        public string ScreenSize { get; set; }

        /// <summary>
        /// Application version name, e.g. 1.1.0
        /// </summary>
        [JsonProperty(PropertyName = "app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// Carrier name (for mobile devices).
        /// </summary>
        [JsonProperty(PropertyName = "carrier_name")]
        public string CarrierName { get; set; }

        /// <summary>
        /// Carrier country code (for mobile devices).
        /// </summary>
        [JsonProperty(PropertyName = "carrier_code")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Carrier country.
        /// </summary>
        [JsonProperty(PropertyName = "carrier_country")]
        public string CarrierCountry { get; set; }

        /// <summary>
        /// The app's build number, e.g. 42.
        /// </summary>
        [JsonProperty(PropertyName = "app_build")]
        public string AppBuild { get; set; }

        /// <summary>
        /// The bundle identifier, package identifier, or namespace, depending
        /// on what the individual plattforms use,  .e.g
        /// com.microsoft.example.
        /// </summary>
        [JsonProperty(PropertyName = "app_namespace")]
        public string AppNamespace { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (SdkName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SdkName");
            }
            if (SdkVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SdkVersion");
            }
            if (Model == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Model");
            }
            if (OemName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OemName");
            }
            if (OsName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsName");
            }
            if (OsVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsVersion");
            }
            if (Locale == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Locale");
            }
            if (ScreenSize == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScreenSize");
            }
            if (AppVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppVersion");
            }
            if (AppBuild == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppBuild");
            }
        }
    }
}
