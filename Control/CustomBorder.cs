using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PropertApp.Control
{
    public class CustomBorder : Border
    {
        public CustomBorder()
        {
            TranslationX = new Random().Next(minValue: -500, maxValue: 500);
            Rotation = Math.Max(TranslationX, 100);

            AddCornerRadius();

            Loaded += (s, e) =>
            {
                this.TranslateTo(x: 0, y: 0, length: 1500, Easing.SinInOut);
                this.RotateTo(rotation: 0, length: 1500, Easing.SinInOut);
            };
        }

        private List<int> CornerValues = new List<int> { 10, 40, 70, 100 };

        private void AddCornerRadius()
        {
            var index = new Random().Next(maxValue: 4);

            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(CornerValues[index])
            };
        }
    }



}
