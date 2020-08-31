// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONDENSATE_S53.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONDENSATE_S53.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONDENSATE_S53.xaml
	/// </summary>
    [Export("CONDENSATE_S53")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONDENSATE_S53 
	{
		public CONDENSATE_S53()
		{
			this.InitializeComponent();
		}
	}
}