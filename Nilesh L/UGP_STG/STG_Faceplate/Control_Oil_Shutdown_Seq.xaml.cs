// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Control_Oil_Shutdown_Seq.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Control_Oil_Shutdown_Seq.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for Control_Oil_Shutdown_Seq.xaml
	/// </summary>
    [Export("Control_Oil_Shutdown_Seq")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class Control_Oil_Shutdown_Seq 
	{
		public Control_Oil_Shutdown_Seq()
		{
			this.InitializeComponent();
		}
	}
}