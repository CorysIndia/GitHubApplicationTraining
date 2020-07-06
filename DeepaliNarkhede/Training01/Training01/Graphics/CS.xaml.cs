// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CS.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CS.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TR01.Graphics
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CS.xaml
	/// </summary>
    [Export("CS")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CS 
	{
		public CS()
		{
			this.InitializeComponent();
		}
	}
}