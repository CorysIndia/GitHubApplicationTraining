using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("security_account")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SECURITY_ACCOUNT
    { 
        public SECURITY_ACCOUNT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
