using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;
using Zenject;
using UnityEngine;

namespace EEE
{
    public class JumpInputPresenter : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody _rigidbody;
        [SerializeField]
        private float jumpForce;

        private InputModel input;

        private IDisposable inputRotateDisposable;

        [Inject]
        public void Construct(InputModel input)
        {
            this.input = input;
        }

        private void OnEnable()
        {
            inputRotateDisposable = input.InputCommand.Subscribe(input => 
            {
                //targetDestination = AngleAroundYAxisByCircle(input);
            });
        }

        private void OnDisable()
        {
            inputRotateDisposable.Dispose();
        }

        private void Start()
        {
            //targetDestination = transform.rotation;
        }

        private void Update()
        {
            /*
            if (targetDestination != transform.rotation)
            {
                var rotation = Quaternion.Slerp(transform.rotation, targetDestination, jumpForce); 
                
                _rigidbody.MoveRotation(rotation);
            }*/
        }

        private Quaternion AngleAroundYAxisByCircle(Vector2 circle)
        {
            var ang = Vector2.Angle(Vector2.left, circle) - 90;

            if (circle.y < 0)
                ang = 180 - ang;

            return Quaternion.AngleAxis(ang, Vector3.up);
        }
    }
}