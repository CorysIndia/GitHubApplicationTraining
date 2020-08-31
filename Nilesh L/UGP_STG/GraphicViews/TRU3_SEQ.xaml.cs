using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("tru3_seq")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TRU3_SEQ
    { 
        public TRU3_SEQ() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
