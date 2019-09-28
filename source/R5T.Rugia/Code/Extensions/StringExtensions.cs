using System;

using R5T.Magyar;


namespace R5T.Rugia.Extensions
{
    public static class StringExtensions
    {
        public static Platform ToPlatform(this string representation)
        {
            switch(representation)
            {
                case PlatformExtensions.WindowsStandardRepresentation:
                    return Platform.Windows;

                case PlatformExtensions.NonWindowsStandardRepresentation:
                    return Platform.NonWindows;

                default:
                    var message = EnumHelper.UnrecognizedEnumerationValueMessage<Platform>(representation);
                    throw new Exception(message);
            }
        }
    }
}
