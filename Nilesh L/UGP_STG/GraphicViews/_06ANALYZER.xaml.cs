using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_06analyzer")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _06ANALYZER
    { 
        public _06ANALYZER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
