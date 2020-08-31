using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_07analyzer")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _07ANALYZER
    { 
        public _07ANALYZER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
