// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S2.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S2.xaml
	/// </summary>
    [Export("ST_S2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S2 
	{
		public ST_S2()
		{
			this.InitializeComponent();
		}
	}
}