using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("selection_screen_toggle")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SELECTION_SCREEN_TOGGLE
    { 
        public SELECTION_SCREEN_TOGGLE() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
