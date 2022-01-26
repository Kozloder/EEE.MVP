using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public static class CollectionRandomExtension
    {
        public static T Random<T>(this List<T> list)
        {
            var randIndex = UnityEngine.Random.Range(0, list.Count);
            return list[randIndex];
        }

        public static T Random<T>(this T[] array)
        {
            var randIndex = UnityEngine.Random.Range(0, array.Length);
            return array[randIndex];
        }

        public static T Random<T>(this T[] array, int seed)
        {
            var rememberSeed = UnityEngine.Random.seed;
            UnityEngine.Random.seed = seed;
            var result = array.Random();
            UnityEngine.Random.seed = rememberSeed;

            return result;
        }
    }
}