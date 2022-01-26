using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace EEE
{
    [AttributeUsage(validOn: AttributeTargets.Class, AllowMultiple = false)]
    public class VisualiseCenterAttribute : PropertyAttribute
    {
        public PrimitiveType Primitive { get; private set; }
        public Color Color { get; private set; }
        public float Size { get; private set; }

        public VisualiseCenterAttribute(PrimitiveType primitive, VisualizeColor color, float size = 1) 
        {
            this.Primitive = primitive;
            this.Color = AsColor(color);
            this.Size = size;
        }

        private Color AsColor(VisualizeColor color) 
        {
            return color switch
            {
                VisualizeColor.Black => Color.black,
                VisualizeColor.Red => Color.red,
                VisualizeColor.Blue => Color.blue,
                _ => Color.white
            };
        }
    }

    public enum VisualizeColor 
    {
        Black,
        Red,
        Blue
    }
}