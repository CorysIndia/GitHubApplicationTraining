using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("rep_seq")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class REP_SEQ
    { 
        public REP_SEQ() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
