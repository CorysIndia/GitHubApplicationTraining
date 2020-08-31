using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("tru1_seq")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TRU1_SEQ
    { 
        public TRU1_SEQ() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
