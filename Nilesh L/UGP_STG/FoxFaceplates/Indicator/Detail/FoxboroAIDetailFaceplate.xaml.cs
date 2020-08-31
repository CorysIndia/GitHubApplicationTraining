

namespace UGP_STG.FoxFaceplates.Indicator.Detail
{
    using System.ComponentModel.Composition;

    [Export("FoxboroAIDetailFaceplate")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FoxboroAIDetailFaceplate
    {
        public FoxboroAIDetailFaceplate()
        {
            this.InitializeComponent();
        }
    }
}