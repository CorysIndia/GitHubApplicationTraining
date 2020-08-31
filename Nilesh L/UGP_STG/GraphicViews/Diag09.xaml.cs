using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag09")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag09
    { 
        public Diag09() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
