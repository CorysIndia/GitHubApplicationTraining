// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S12.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S12.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S12.xaml
	/// </summary>
    [Export("ST_S12")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S12 
	{
		public ST_S12()
		{
			this.InitializeComponent();
		}
	}
}