using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;
using Cinemachine;

namespace EEE
{
    [RequireComponent(typeof(Camera))]
    [VisualiseCenter(PrimitiveType.Cube, VisualizeColor.Blue, 2)]
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField]
        private Vector3 offset;
        [SerializeField, Range(0.01f, 1f)]
        private float speed = 1;
        [SerializeField]
        private float maxDeviation = 0;
        [SerializeField]
        private float deviationAddSpeed = 0;
        [SerializeField, Range(0.1f, 1f)]
        private float deviationMinusSpeed = 0;

        private float deviationAcc;
        private Vector3 lastLookAtPosition;
        private Vector3 lookAtDeviation;
        private Vector3 last;

        private Camera _camera;
        private Transform lookAt;

        private void Awake()
        {
            this._camera = GetComponent<Camera>();

            if (offset == Vector3.zero)
                this.offset = transform.position;    
        }

        public void Follow(Transform lookAt)
        {
            this.lookAt = lookAt;
            this.lastLookAtPosition = lookAt.position;
            this.lookAtDeviation = Vector3.zero;
            this.deviationAcc = 0;

            _camera.transform.LookAt(lookAt);
        }

        public void Follow(Transform lookAt, Vector3 offset)
        {
            Follow(lookAt);
            this.offset = offset;
        }

        private void LateUpdate()
        {
            if (lookAt != null)
            {
                /*
                var followPosition = cinemachineCamera.position;
                var followRotation = cinemachineCamera.rotation;

                var toPosition = followPosition + (followRotation * offset);
                var currentPosition = Vector3.SmoothDamp(_camera.transform.position, toPosition, ref velocity, distanceDamp);
                */

                //var position = Vector3.SmoothDamp(_camera.transform.position, lookAt.position, ref velocity, speed);
                /*
                var lookAtPosition = lookAt.position;
                var lookAtDeltaPosition = lookAtPosition - lastLookAtPosition;
                
                deviationAcc = lookAtDeltaPosition == Vector3.zero ? 
                if ()
                {
                    lookAtDeviation *= deviationMinusAcc;

                    deviationMinusAcc -= devia
                }
                else
                {

                }*/

                _camera.transform.position = lookAt.position + offset;
            }
        }    
    }
}