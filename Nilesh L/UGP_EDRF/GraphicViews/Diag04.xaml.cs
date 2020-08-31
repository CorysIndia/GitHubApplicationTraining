using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag04")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag04
    { 
        public Diag04() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
