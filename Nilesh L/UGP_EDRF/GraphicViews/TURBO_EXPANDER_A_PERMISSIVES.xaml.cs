using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("turbo_expander_a_permissives")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TURBO_EXPANDER_A_PERMISSIVES
    { 
        public TURBO_EXPANDER_A_PERMISSIVES() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
