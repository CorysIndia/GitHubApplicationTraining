// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S5.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S5.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S5.xaml
	/// </summary>
    [Export("ST_S5")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S5 
	{
		public ST_S5()
		{
			this.InitializeComponent();
		}
	}
}