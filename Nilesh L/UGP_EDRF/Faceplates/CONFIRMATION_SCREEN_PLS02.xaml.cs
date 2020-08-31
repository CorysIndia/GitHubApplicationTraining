﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONFIRMATION_SCREEN_PLS02.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONFIRMATION_SCREEN_PLS02.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.Faceplates
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONFIRMATION_SCREEN_PLS02.xaml
	/// </summary>
    [Export("CONFIRMATION_SCREEN_PLS02")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONFIRMATION_SCREEN_PLS02 
	{
		public CONFIRMATION_SCREEN_PLS02()
		{
			this.InitializeComponent();
		}
	}
}