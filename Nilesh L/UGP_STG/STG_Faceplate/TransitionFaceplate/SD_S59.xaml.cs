// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S59.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S59.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S59.xaml
	/// </summary>
    [Export("SD_S59")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S59 
	{
		public SD_S59()
		{
			this.InitializeComponent();
		}
	}
}