using System;

using R5T.Magyar;

using BaseConstants = R5T.Rugia.Base.Constants;


namespace R5T.Rugia.Extensions
{
    public static class StringExtensions
    {
        public static Platform ToPlatform(this string representation)
        {
            switch(representation)
            {
                case BaseConstants.WindowsPlatformStandardRepresentation:
                    return Platform.Windows;

                case BaseConstants.NonWindowsPlatformStandardRepresentation:
                    return Platform.NonWindows;

                default:
                    throw EnumerationHelper.UnrecognizedEnumerationValueException<Platform>(representation);
            }
        }
    }
}
