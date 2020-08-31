// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S7.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S7.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S7.xaml
	/// </summary>
    [Export("ST_S7")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S7 
	{
		public ST_S7()
		{
			this.InitializeComponent();
		}
	}
}