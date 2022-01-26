using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class CameraModel
    {
        public readonly FollowCamera Main;

        public CameraModel(FollowCamera main)
        {
            this.Main = main;
        }
    }
}