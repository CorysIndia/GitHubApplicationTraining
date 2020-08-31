using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
using RSI.Common.Locator;
using RSI.IndissLike.Controls.Helpers;
using RSI.IndissPlus.Plots.Components;
using RSI.Common.WPFTools.Extensions;
using RSI.IndissPlus.Plots.OxyPlotTools;
using PlotComponent.Interfaces;
namespace UGP_EDRF
{
    [ExportSynoptic("srg_control_m39_k_0007c_stg1")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SRG_CONTROL_M39_K_0007C_STG1
    {
        public SRG_CONTROL_M39_K_0007C_STG1()
        {
            if (Designer.IsInDesignModeStatic == false)
            {
                ServiceLocator.Instance.RegisterType<ID3Factory, OxyPlotFactory>();
                this.OnceLoaded(fe => ServiceLocator.Instance.UnregisterType<ID3Factory>());
            }
            this.Loaded += SRG_CONTROL_M39_K_0007C_STG1_Loaded;
            this.InitializeComponent();
        }

        private void SRG_CONTROL_M39_K_0007C_STG1_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SurgeReferencePlot.ShowAxis = false;
            ControlReferencePlot.ShowAxis = false;
            HoverPoint.ShowAxis = false;
            OperatingPoint.ShowAxis = false;
            SurgeLinePlot.ShowAxis = false;
            ControlLinePlot.ShowAxis = false;
        }
    }
}
