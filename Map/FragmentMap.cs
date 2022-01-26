using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.U2D;

namespace EEE
{
    [RequireComponent(typeof(Tilemap))]
    public class FragmentMap : MonoBehaviour
    {
        [SerializeField]
        private Tilemap fragmentMap;

        private Vector3 enter, exit;

        public void Connect(FragmentMap fromFragment)
        {
            transform.SetParent(fromFragment.transform);

            fromFragment.transform.SetParent(transform.parent);
        }

#if UNITY_EDITOR
        public void OnDrawGizmos()
        {
            
        }
#endif
    }
}