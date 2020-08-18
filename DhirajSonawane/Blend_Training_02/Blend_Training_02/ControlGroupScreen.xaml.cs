﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ControlGroupScreen.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ControlGroupScreen.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blend_Training_02
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Interaction logic for ControlGroupScreen.xaml
    /// </summary>
    [Export("ControlGroupScreen")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ControlGroupScreen
    {
        public ControlGroupScreen()
        {
            this.InitializeComponent();
        }
    }
}