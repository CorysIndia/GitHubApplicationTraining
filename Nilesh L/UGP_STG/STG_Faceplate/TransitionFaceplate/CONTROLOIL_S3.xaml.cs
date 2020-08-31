// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONTROLOIL_S3.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONTROLOIL_S3.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONTROLOIL_S3.xaml
	/// </summary>
    [Export("CONTROLOIL_S3")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONTROLOIL_S3 
	{
		public CONTROLOIL_S3()
		{
			this.InitializeComponent();
		}
	}
}