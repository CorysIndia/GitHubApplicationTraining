using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_02analyzer")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _02ANALYZER
    { 
        public _02ANALYZER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
