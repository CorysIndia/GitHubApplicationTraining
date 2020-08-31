using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("selection_screen")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SELECTION_SCREEN
    { 
        public SELECTION_SCREEN() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
