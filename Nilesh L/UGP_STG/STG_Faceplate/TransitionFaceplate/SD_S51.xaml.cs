// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S51.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S51.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S51.xaml
	/// </summary>
    [Export("SD_S51")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S51 
	{
		public SD_S51()
		{
			this.InitializeComponent();
		}
	}
}