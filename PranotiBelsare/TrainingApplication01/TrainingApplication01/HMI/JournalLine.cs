using System.Windows;
using RSI.Emulation.Controls.Control;

namespace TrainingApplication01.HMI
{
    public class JournalLine : RSIControlModel
    {
        static JournalLine()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(JournalLine), new FrameworkPropertyMetadata(typeof(JournalLine)));
        }
    }
}
