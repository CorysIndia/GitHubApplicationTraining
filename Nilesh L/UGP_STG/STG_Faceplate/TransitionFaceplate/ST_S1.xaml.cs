// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S1.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S1.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S1.xaml
	/// </summary>
    [Export("ST_S1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S1 
	{
		public ST_S1()
		{
			this.InitializeComponent();
		}
	}
}