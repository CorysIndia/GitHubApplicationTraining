// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S0.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S0.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S0.xaml
	/// </summary>
    [Export("ST_S0")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S0 
	{
		public ST_S0()
		{
			this.InitializeComponent();
		}
	}
}