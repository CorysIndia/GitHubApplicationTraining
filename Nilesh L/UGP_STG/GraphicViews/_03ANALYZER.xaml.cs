using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_03analyzer")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _03ANALYZER
    { 
        public _03ANALYZER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
