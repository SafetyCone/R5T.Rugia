using System;


namespace R5T.Rugia
{
    /// <summary>
    /// An instantiable operator class allowing access to platform operations.
    /// </summary>
    public class PlatformOperator
    {
        #region Static

        /// <summary>
        /// Allows indirection to explicitly get/set the platform for use in all code.
        /// </summary>
        public static Platform Platform { get; set; }
        /// <summary>
        /// The actual platform value for the machine on which code is currently executing.
        /// The value is produced by <see cref="Utilities.GetExecutingMachinePlatform"/>.
        /// </summary>
        public static Platform ExecutingMachinePlatform => Utilities.GetExecutingMachinePlatform();


        static PlatformOperator()
        {
            PlatformOperator.ResetPlatform();
        }

        /// <summary>
        /// Sets the <see cref="PlatformOperator.Platform"/> to the value produced by <see cref="Utilities.GetExecutingMachinePlatform"/>.
        /// </summary>
        public static void ResetPlatform()
        {
            PlatformOperator.Platform = PlatformOperator.ExecutingMachinePlatform;
        }

        #endregion
    }
}
