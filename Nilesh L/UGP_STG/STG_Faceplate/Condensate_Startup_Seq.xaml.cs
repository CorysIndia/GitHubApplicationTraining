// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Condensate_Startup_Seq.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Condensate_Startup_Seq.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for Condensate_Startup_Seq.xaml
	/// </summary>
    [Export("Condensate_Startup_Seq")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class Condensate_Startup_Seq 
	{
		public Condensate_Startup_Seq()
		{
			this.InitializeComponent();
		}
	}
}