// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONDENSATE_S3.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONDENSATE_S3.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONDENSATE_S3.xaml
	/// </summary>
    [Export("CONDENSATE_S3")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONDENSATE_S3 
	{
		public CONDENSATE_S3()
		{
			this.InitializeComponent();
		}
	}
}