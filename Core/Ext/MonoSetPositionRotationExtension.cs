using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public static class MonoSetPositionRotationExtension
    {
        public static T Position<T>(this T mono, Vector2 position) where T : MonoBehaviour
        {
            mono.transform.position = position;

            return mono;
        }

        public static T Position<T>(this T mono, Transform position) where T : MonoBehaviour
        {
            mono.transform.position = position.position;

            return mono;
        }


        public static T Rotation<T>(this T mono, Quaternion rotation) where T : MonoBehaviour
        {
            mono.transform.rotation = rotation;

            return mono;
        }

        public static T Rotation<T>(this T mono, Transform rotation) where T : MonoBehaviour
        {
            mono.transform.rotation = rotation.rotation;

            return mono;
        }

        public static T Parent<T>(this T mono, GameObject parent) where T : MonoBehaviour
        {
            if (parent != null)
                mono.transform.parent = parent.transform;

            return mono;
        }

        public static T Parent<T>(this T mono, MonoBehaviour parent) where T : MonoBehaviour
        {
            if (parent != null)
                mono.transform.parent = parent.transform;

            return mono;
        }

        public static GameObject Parent(this GameObject child, Transform parent)
        {
            if (parent != null)
                child.transform.parent = parent;

            return child;
        }
    }
}