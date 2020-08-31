// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S52.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S52.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S52.xaml
	/// </summary>
    [Export("SD_S52")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S52 
	{
		public SD_S52()
		{
			this.InitializeComponent();
		}
	}
}