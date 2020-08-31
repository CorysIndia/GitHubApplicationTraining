// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LUBEOIL_S3.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for LUBEOIL_S3.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for LUBEOIL_S3.xaml
	/// </summary>
    [Export("LUBEOIL_S3")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class LUBEOIL_S3 
	{
		public LUBEOIL_S3()
		{
			this.InitializeComponent();
		}
	}
}