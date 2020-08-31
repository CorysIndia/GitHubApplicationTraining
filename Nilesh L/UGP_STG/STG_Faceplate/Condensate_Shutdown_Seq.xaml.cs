// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Condensate_Shutdown_Seq.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Condensate_Shutdown_Seq.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for Condensate_Shutdown_Seq.xaml
	/// </summary>
    [Export("Condensate_Shutdown_Seq")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class Condensate_Shutdown_Seq 
	{
		public Condensate_Shutdown_Seq()
		{
			this.InitializeComponent();
		}
	}
}