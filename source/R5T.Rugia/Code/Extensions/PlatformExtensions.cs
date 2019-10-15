using System;

using R5T.Magyar;

using BaseConstants = R5T.Rugia.Base.Constants;


namespace R5T.Rugia
{
    public static class PlatformExtensions
    {
        /// <summary>
        /// Returns the standard string representation of the platform enumeration value.
        /// </summary>
        public static string ToStringStandard(this Platform platform)
        {
            switch (platform)
            {
                case Platform.NonWindows:
                    return BaseConstants.NonWindowsPlatformStandardRepresentation;

                case Platform.Windows:
                    return BaseConstants.WindowsPlatformStandardRepresentation;

                default:
                    var message = EnumHelper.UnexpectedEnumerationValueMessage(platform);
                    throw new Exception(message);
            }
        }

        /// <summary>
        /// Returns the alternate platform.
        /// </summary>
        public static Platform GetAlternatePlatform(this Platform platform)
        {
            var alternatePlatform = Utilities.GetAlternatePlatform(platform);
            return alternatePlatform;
        }
    }
}
