using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("standby")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class STANDBY
    { 
        public STANDBY() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
