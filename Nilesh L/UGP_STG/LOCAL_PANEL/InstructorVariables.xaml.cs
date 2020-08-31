// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InstructorVariables.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for InstructorVariables.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PetroRabigh_CDU.LocalPanel
{
    using System.ComponentModel.Composition;
    /// <summary>
    /// Interaction logic for InstructorVariables.xaml
    /// </summary>
    [Export("InstructorVariables")] 
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class InstructorVariables
    {
        public InstructorVariables()
        {
            this.InitializeComponent();
        }
    }
}