using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("pi_0195_voted")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class PI_0195_VOTED
    { 
        public PI_0195_VOTED() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
