using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("turbo_expander_a_startup")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TURBO_EXPANDER_A_STARTUP
    { 
        public TURBO_EXPANDER_A_STARTUP() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
