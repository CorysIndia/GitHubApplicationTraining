using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag08")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag08
    { 
        public Diag08() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
