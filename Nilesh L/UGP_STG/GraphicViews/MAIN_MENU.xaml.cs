using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("main_menu")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class MAIN_MENU
    { 
        public MAIN_MENU() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
