// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestFaceplatesToDo.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for TestFaceplatesToDo.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UGP_EDRF.BootStrap
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for TestFaceplatesToDo.xaml
	/// </summary>
    [Export("TestFaceplatesToDo")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class TestFaceplatesToDo 
	{
		public TestFaceplatesToDo()
		{
			this.InitializeComponent();
		}
	}
}