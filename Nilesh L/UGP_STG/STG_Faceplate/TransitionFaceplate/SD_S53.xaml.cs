// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S53.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S53.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S53.xaml
	/// </summary>
    [Export("SD_S53")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S53 
	{
		public SD_S53()
		{
			this.InitializeComponent();
		}
	}
}