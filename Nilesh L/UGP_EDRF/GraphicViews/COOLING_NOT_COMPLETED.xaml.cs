using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("cooling_not_completed")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class COOLING_NOT_COMPLETED
    { 
        public COOLING_NOT_COMPLETED() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
