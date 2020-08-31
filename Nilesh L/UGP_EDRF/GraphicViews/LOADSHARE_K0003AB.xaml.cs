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
    [ExportSynoptic("loadshare_k0003ab")] 
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class LOADSHARE_K0003AB
    {
        public LOADSHARE_K0003AB()
        {
            if (Designer.IsInDesignModeStatic == false)
            {
                ServiceLocator.Instance.RegisterType<ID3Factory, OxyPlotFactory>();
                this.OnceLoaded(fe => ServiceLocator.Instance.UnregisterType<ID3Factory>());
            }
            this.Loaded += LOADSHARE_K0003AB_Loaded;
            this.InitializeComponent();
        }

        private void LOADSHARE_K0003AB_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SurgeReferencePlot.ShowAxis = false;
            ControlReferencePlot.ShowAxis = false;
            HoverPoint.ShowAxis = false;
            OperatingPoint.ShowAxis = false;
            SurgeLinePlot.ShowAxis = false;
            ControlLinePlot.ShowAxis = false;



            SurgeReferencePlot3B.ShowAxis = false;
            ControlReferencePlot3B.ShowAxis = false;
            HoverPoint3B.ShowAxis = false;
            OperatingPoint3B.ShowAxis = false;
            SurgeLinePlot3B.ShowAxis = false;
            ControlLinePlot3B.ShowAxis = false;


        }
    }
} 
