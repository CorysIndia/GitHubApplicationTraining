using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag14")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag14
    { 
        public Diag14() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
