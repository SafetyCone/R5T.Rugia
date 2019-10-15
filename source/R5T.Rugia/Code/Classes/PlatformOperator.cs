using System;

using R5T.Rugia.Base;
using R5T.Rugia.Extensions;

using BaseUtilities = R5T.Rugia.Base.Utilities;


namespace R5T.Rugia
{
    /// <summary>
    /// An instantiable operator class allowing access to platform operations.
    /// </summary>
    public class PlatformOperator : IPlatformOperator
    {
        public string WindowsPlatformStandardRepresentation => Constants.WindowsPlatformStandardRepresentation;
        public string NonWindowsPlatformStandardRepresentation => Constants.NonWindowsPlatformStandardRepresentation;


        private object SynchronizationValue { get; } = new object();
        private Platform zPlatform;
        /// <summary>
        /// Thread-safe.
        /// </summary>
        public Platform Platform
        {
            get
            {
                return this.zPlatform;
            }
            set
            {
                lock (this.SynchronizationValue)
                {
                    this.zPlatform = value;
                }
            }
        }
        public Platform ExecutingMachinePlatform => BaseUtilities.GetExecutingMachinePlatform();


        public PlatformOperator()
        {
            this.ResetPlatform();
        }

        public Platform GetAlternatePlatform(Platform platform)
        {
            var alternatePlatform = Utilities.GetAlternatePlatform(platform);
            return alternatePlatform;
        }

        /// <summary>
        /// Thread-safe.
        /// </summary>
        public void ResetPlatform()
        {
            this.Platform = this.ExecutingMachinePlatform;
        }

        public Platform ToPlatformFromStandard(string standardPlatformRepresentation)
        {
            var output = standardPlatformRepresentation.ToPlatform();
            return output;
        }

        public string ToStringStandard(Platform platform)
        {
            var output = platform.ToStringStandard();
            return output;
        }
    }
}
