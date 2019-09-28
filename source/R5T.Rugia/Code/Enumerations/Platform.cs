using System;


namespace R5T.Rugia
{
    public enum Platform
    {
        /// <summary>
        /// The platform is currently unknown.
        /// Note that there is no option for "None", since code *must* run on some platform!
        /// </summary>
        Unknown,

        Windows,
        NonWindows,
    }
}
