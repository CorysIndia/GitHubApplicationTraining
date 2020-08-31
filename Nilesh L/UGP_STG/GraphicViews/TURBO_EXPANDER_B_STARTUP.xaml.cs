using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("turbo_expander_b_startup")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TURBO_EXPANDER_B_STARTUP
    { 
        public TURBO_EXPANDER_B_STARTUP() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
