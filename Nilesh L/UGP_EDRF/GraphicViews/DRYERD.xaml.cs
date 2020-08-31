using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("dryerd")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DRYERD
    { 
        public DRYERD() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
