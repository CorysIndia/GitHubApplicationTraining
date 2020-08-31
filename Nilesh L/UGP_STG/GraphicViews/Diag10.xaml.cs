using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag10")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag10
    { 
        public Diag10() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
