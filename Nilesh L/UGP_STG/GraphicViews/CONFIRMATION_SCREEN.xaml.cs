using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("confirmation_screen")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class CONFIRMATION_SCREEN
    { 
        public CONFIRMATION_SCREEN() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
