// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CONTROLOIL_S52.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CONTROLOIL_S52.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for CONTROLOIL_S52.xaml
	/// </summary>
    [Export("CONTROLOIL_S52")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class CONTROLOIL_S52 
	{
		public CONTROLOIL_S52()
		{
			this.InitializeComponent();
		}
	}
}