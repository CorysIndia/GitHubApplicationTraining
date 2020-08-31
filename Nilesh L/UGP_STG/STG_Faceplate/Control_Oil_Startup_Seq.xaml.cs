// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Control_Oil_Startup_Seq.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Control_Oil_Startup_Seq.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for Control_Oil_Startup_Seq.xaml
	/// </summary>
    [Export("Control_Oil_Startup_Seq")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class Control_Oil_Startup_Seq 
	{
		public Control_Oil_Startup_Seq()
		{
			this.InitializeComponent();
		}
	}
}