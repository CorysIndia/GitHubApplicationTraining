using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_05analyzer")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _05ANALYZER
    { 
        public _05ANALYZER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
