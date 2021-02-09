// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test_Pad.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for Test_Pad.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TrainingApplication01.Graphics
{
	using System.ComponentModel.Composition;
	
	/// <summary>
	/// Interaction logic for Test_Pad.xaml
	/// </summary>
    [Export("Test_Pad")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class Test_Pad 
	{
		public Test_Pad()
		{
			this.InitializeComponent();
		}
	}
}