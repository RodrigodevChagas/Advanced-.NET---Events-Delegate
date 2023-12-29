using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegate.DelegateEvents
{
    public delegate void CalculateVolume(double height, double width, double depth);

    public class GeometricFigure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public event CalculateVolume? CalculateVolume;
        public void EventHandler()
        {
            CalculateVolume?.Invoke(Height, Width, Depth);
        }
    }
}
