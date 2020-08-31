// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S61.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S61.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S61.xaml
	/// </summary>
    [Export("SD_S61")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S61 
	{
		public SD_S61()
		{
			this.InitializeComponent();
		}
	}
}