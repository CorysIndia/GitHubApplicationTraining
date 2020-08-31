using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("turbine_startup")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TURBINE_STARTUP
    { 
        public TURBINE_STARTUP() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
