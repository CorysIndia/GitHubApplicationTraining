using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("selection_screen_pls")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SELECTION_SCREEN_PLS
    { 
        public SELECTION_SCREEN_PLS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
