// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONDENSATE_S52.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONDENSATE_S52.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONDENSATE_S52.xaml
	/// </summary>
    [Export("CONDENSATE_S52")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONDENSATE_S52 
	{
		public CONDENSATE_S52()
		{
			this.InitializeComponent();
		}
	}
}