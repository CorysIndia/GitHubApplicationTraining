using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("dep_seq")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DEP_SEQ
    { 
        public DEP_SEQ() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
