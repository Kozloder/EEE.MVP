using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Unity.Jobs;
using Unity.Collections;

namespace EEE
{
    public static class Util
    {
        public static int Window(int min, int max, int seed, int window)
        {
            var minMax = max - min;
            var cut = seed & window;

            var length = (float)cut / (float)window;
            var delta = (int)(minMax * length);

            return min + delta;
        }
    }
}