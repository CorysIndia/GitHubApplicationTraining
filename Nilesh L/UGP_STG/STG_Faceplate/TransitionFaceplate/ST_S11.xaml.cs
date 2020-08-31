// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S11.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S11.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S11.xaml
	/// </summary>
    [Export("ST_S11")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S11 
	{
		public ST_S11()
		{
			this.InitializeComponent();
		}
	}
}