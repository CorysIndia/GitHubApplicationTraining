// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S58.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S58.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S58.xaml
	/// </summary>
    [Export("SD_S58")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S58 
	{
		public SD_S58()
		{
			this.InitializeComponent();
		}
	}
}