using System;

using R5T.Rugia.Extensions;

using BaseConstants = R5T.Rugia.Base.Constants;
using BaseUtilities = R5T.Rugia.Base.Utilities;


namespace R5T.Rugia
{
    /// <summary>
    /// Static class providing access to static access to platform operations.
    /// Allows singleton use of a platform value.
    /// </summary>
    public static class PlatformOperations
    {
        public static string WindowsPlatformStandardRepresentation => BaseConstants.WindowsPlatformStandardRepresentation;
        public static string NonWindowsPlatformStandardRepresentation => BaseConstants.NonWindowsPlatformStandardRepresentation;

        private static object SynchronizationValue { get; } = new object();
        private static Platform zPlatform;
        /// <summary>
        /// Allows indirection to explicitly get/set the platform for use in all code.
        /// Thread-safe.
        /// </summary>
        public static Platform Platform
        {
            get
            {
                return PlatformOperations.zPlatform;
            }
            set
            {
                lock(PlatformOperations.SynchronizationValue)
                {
                    PlatformOperations.zPlatform = value;
                }
            }
        }
        /// <summary>
        /// The actual platform value for the machine on which code is currently executing.
        /// The value is produced by <see cref="BaseUtilities.GetExecutingMachinePlatform"/>.
        /// </summary>
        public static Platform ExecutingMachinePlatform => BaseUtilities.GetExecutingMachinePlatform();


        static PlatformOperations()
        {
            PlatformOperations.ResetPlatform();
        }

        /// <summary>
        /// Sets the <see cref="PlatformOperator.Platform"/> to the value produced by <see cref="BaseUtilities.GetExecutingMachinePlatform"/>.
        /// Thread-safe.
        /// </summary>
        public static void ResetPlatform()
        {
            PlatformOperations.Platform = PlatformOperations.ExecutingMachinePlatform;
        }

        public static Platform ToPlatformFromStandard(string standardPlatformRepresentation)
        {
            var output = standardPlatformRepresentation.ToPlatform();
            return output;
        }

        public static string ToStringStandard(Platform platform)
        {
            var output = platform.ToStringStandard();
            return output;
        }
    }
}
