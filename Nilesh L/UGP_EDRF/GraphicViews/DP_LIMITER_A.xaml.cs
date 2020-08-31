using System; 
using System.Windows; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("dp_limiter_a")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DP_LIMITER_A
    { 
        public DP_LIMITER_A() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
