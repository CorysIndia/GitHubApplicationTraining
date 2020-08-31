using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("tru2_seq")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TRU2_SEQ
    { 
        public TRU2_SEQ() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
