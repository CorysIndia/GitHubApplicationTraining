using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("turbo_expander_b_permissives")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TURBO_EXPANDER_B_PERMISSIVES
    { 
        public TURBO_EXPANDER_B_PERMISSIVES() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
