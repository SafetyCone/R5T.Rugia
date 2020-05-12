using System;

using R5T.Magyar;


namespace R5T.Rugia
{
    public static class Utilities
    {
        /// <summary>
        /// Returns the alternate platform given a platform. For example, if <see cref="Platform.Windows"/> is provided, <see cref="Platform.NonWindows"/> is returned, and vice-versa.
        /// </summary>
        public static Platform GetAlternatePlatform(Platform platform)
        {
            switch (platform)
            {
                case Platform.NonWindows:
                    return Platform.Windows;

                case Platform.Windows:
                    return Platform.NonWindows;

                default:
                    throw EnumerationHelper.UnexpectedEnumerationValueException(platform);
            }
        }
    }
}
