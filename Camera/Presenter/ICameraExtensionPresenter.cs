using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public interface ICameraExtensionPresenter
    {
        Vector3 Position(Vector3 cameraPosition, Vector3 lookAtPosition);
    }
}