// ---------------------------------------------------------------------------------------------------------------
// ApplicationScreen.xaml.cs
// ---------------------------------------------------------------------------------------------------------------
// Summary :
// ---------------------------------------------------------------------------------------------------------------
// POINDRON Frederic - 01/02/2016, 20:48
// ---------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows;

namespace Blend_Training_02.BootStrap
{
    /// <summary>
    ///     Interaction logic for ApplicationScreen.xaml
    /// </summary>
    [Export("ApplicationScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ApplicationScreen
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ApplicationScreen" /> class.
        /// </summary>
        public ApplicationScreen()
        {
            this.InitializeComponent();
        }
    }
}
