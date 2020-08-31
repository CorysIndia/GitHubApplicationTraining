using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("v1_lim_spd_rr")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class V1_LIM_SPD_RR
    { 
        public V1_LIM_SPD_RR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
