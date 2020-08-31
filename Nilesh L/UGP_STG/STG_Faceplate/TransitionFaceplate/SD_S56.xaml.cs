// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S56.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S56.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S56.xaml
	/// </summary>
    [Export("SD_S56")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S56 
	{
		public SD_S56()
		{
			this.InitializeComponent();
		}
	}
}