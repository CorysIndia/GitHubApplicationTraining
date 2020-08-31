using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_01analyzer")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _01ANALYZER
    { 
        public _01ANALYZER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
