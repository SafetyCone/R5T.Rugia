using System;
using System.Runtime.InteropServices;

using R5T.Magyar;


namespace R5T.Rugia
{
    public static class Utilities
    {
        /// <summary>
        /// If code is running, it's executing on a machine platform.
        /// If the <see cref="RuntimeInformation.IsOSPlatform(OSPlatform)"/> is <see cref="OSPlatform.Windows"/>, then the output is <see cref="Platform.Windows"/>, else <see cref="Platform.NonWindows"/>.
        /// </summary>
        public static Platform GetExecutingMachinePlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Platform.Windows;
            }
            else
            {
                return Platform.NonWindows;
            }
        }

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
                    var message = EnumHelper.UnexpectedEnumerationValueMessage(platform);
                    throw new Exception(message);
            }
        }
    }
}
