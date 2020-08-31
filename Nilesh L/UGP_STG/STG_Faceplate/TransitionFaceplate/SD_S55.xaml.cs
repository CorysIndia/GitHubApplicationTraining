// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S55.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S55.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S55.xaml
	/// </summary>
    [Export("SD_S55")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S55 
	{
		public SD_S55()
		{
			this.InitializeComponent();
		}
	}
}