using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("heating_not_completed")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class HEATING_NOT_COMPLETED
    { 
        public HEATING_NOT_COMPLETED() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
