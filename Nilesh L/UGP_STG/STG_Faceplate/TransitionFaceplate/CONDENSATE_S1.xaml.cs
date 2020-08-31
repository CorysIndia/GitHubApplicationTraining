// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONDENSATE_S1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONDENSATE_S1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONDENSATE_S1.xaml
	/// </summary>
    [Export("CONDENSATE_S1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONDENSATE_S1 
	{
		public CONDENSATE_S1()
		{
			this.InitializeComponent();
		}
	}
}