// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S54.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S54.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S54.xaml
	/// </summary>
    [Export("SD_S54")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S54 
	{
		public SD_S54()
		{
			this.InitializeComponent();
		}
	}
}