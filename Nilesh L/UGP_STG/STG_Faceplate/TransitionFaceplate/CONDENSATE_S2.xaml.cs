// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONDENSATE_S2.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONDENSATE_S2.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONDENSATE_S2.xaml
	/// </summary>
    [Export("CONDENSATE_S2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONDENSATE_S2 
	{
		public CONDENSATE_S2()
		{
			this.InitializeComponent();
		}
	}
}