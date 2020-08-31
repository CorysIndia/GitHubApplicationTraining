using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("analyzer_cat")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class ANALYZER_CAT
    { 
        public ANALYZER_CAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
