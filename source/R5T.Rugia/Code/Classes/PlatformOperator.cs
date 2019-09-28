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
        /// Allows explicitly getting/setting the platform for use in all code.
        /// </summary>
        public static Platform Platform { get; set; }


        static PlatformOperator()
        {
            PlatformOperator.Reset();
        }

        /// <summary>
        /// Sets the <see cref="PlatformOperator.Platform"/> to the value produced by <see cref="Utilities.GetExecutingMachinePlatform"/>.
        /// </summary>
        public static void Reset()
        {
            PlatformOperator.Platform = Utilities.GetExecutingMachinePlatform();
        }

        #endregion
    }
}
