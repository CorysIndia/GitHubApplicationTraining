using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("dryerb")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DRYERB
    { 
        public DRYERB() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
