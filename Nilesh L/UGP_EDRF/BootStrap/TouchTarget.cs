#region Assembly Yokogawa.IA.iPCS.Platform.View.Graphic.Components.Controls.DomainControls, Version=3.6.1.1004, Culture=neutral, PublicKeyToken=null
// C:\Vaibhav\Project\1Petrorabigh-CDU-Graphics\Github-Application-CDU\bin\Debug\Yokogawa.IA.iPCS.Platform.View.Graphic.Components.Controls.DomainControls.dll
#endregion

using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Yokogawa.Core.Interfaces;
using Yokogawa.IA.iPCS.Platform.View.Graphic.Components.Common.Data;
using Yokogawa.WPFTools.Interfaces;

namespace Yokogawa.IA.iPCS.Platform.View.Graphic.Components.Controls.DomainControls
{
    public class TouchTarget : TaskControlBase, ISupportGenericNameChanged, IGraphicTagNameProvider
    {
        public static readonly DependencyProperty BorderStyleProperty;
        public static readonly DependencyProperty HighLighterBorderBrushProperty;

        public TouchTarget();

        public LineStyle BorderStyle { get; set; }
        public Brush HighLighterBorderBrush { get; set; }

        protected static object TouchTargetCoerceHeight(DependencyObject d, object value);
        protected static object TouchTargetCoerceWidth(DependencyObject d, object value);
        public void ProcessGenericNameChanged(Dictionary<string, string> genericNames);
        protected override void OnClick();
        protected override void OnKeyDown(KeyEventArgs e);
        protected override void OnKeyUp(KeyEventArgs e);
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
        protected override void OnQueryCursor(QueryCursorEventArgs e);
    }
}