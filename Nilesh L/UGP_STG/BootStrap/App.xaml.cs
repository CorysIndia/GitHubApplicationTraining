﻿namespace UGP_STG.BootStrap
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
            return "UGP_STG";
        }

        /// <summary>
        /// Gets the user setting filename.
        /// </summary>
        /// <returns></returns>
        protected override string GetUserSettingFilename()
        {
            return "UGP_STG.xml";
        }
    }
}
