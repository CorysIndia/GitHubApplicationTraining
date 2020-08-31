// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S6.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S6.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S6.xaml
	/// </summary>
    [Export("ST_S6")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S6 
	{
		public ST_S6()
		{
			this.InitializeComponent();
		}
	}
}