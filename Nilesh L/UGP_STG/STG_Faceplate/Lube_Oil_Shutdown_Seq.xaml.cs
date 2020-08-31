// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Lube_Oil_Shutdown_Seq.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Lube_Oil_Shutdown_Seq.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for Lube_Oil_Shutdown_Seq.xaml
	/// </summary>
    [Export("Lube_Oil_Shutdown_Seq")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class Lube_Oil_Shutdown_Seq 
	{
		public Lube_Oil_Shutdown_Seq()
		{
			this.InitializeComponent();
		}
	}
}