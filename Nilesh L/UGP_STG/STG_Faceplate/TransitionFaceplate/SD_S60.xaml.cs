// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S60.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S60.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S60.xaml
	/// </summary>
    [Export("SD_S60")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S60 
	{
		public SD_S60()
		{
			this.InitializeComponent();
		}
	}
}