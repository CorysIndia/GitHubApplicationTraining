// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SD_S57.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for SD_S57.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for SD_S57.xaml
	/// </summary>
    [Export("SD_S57")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class SD_S57 
	{
		public SD_S57()
		{
			this.InitializeComponent();
		}
	}
}