using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("pd_k0003b")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class PD_K0003B
    { 
        public PD_K0003B() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
