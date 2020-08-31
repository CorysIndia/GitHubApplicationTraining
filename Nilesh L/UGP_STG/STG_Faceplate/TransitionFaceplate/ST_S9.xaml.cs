// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ST_S9.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for ST_S9.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_STG.STG_Faceplate.TransitionFaceplate
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for ST_S9.xaml
	/// </summary>
    [Export("ST_S9")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class ST_S9 
	{
		public ST_S9()
		{
			this.InitializeComponent();
		}
	}
}