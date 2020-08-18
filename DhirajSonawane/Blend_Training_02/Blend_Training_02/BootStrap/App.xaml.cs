using RSI.IndissLike.Controls.Helpers;
using System;
using System.Windows;

namespace Blend_Training_02.BootStrap
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        /// <summary>
        /// Gets the name of the application.
        /// </summary>
        /// <returns></returns>
        protected override string GetApplicationName()
        {
            return "Blend_Training_02";
        }

        /// <summary>
        /// Gets the user setting filename.
        /// </summary>
        /// <returns></returns>
        protected override string GetUserSettingFilename()
        {
            return "Blend_Training_02.xml";
        }
    }
}
