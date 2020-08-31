// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S62.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S62.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S62.xaml
	/// </summary>
    [Export("SD_S62")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S62 
	{
		public SD_S62()
		{
			this.InitializeComponent();
		}
	}
}