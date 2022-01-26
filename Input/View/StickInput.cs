using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UniRx;
using Zenject;

namespace EEE
{
    public class StickInput : MonoBehaviour
    {
        [SerializeField]
        private Joystick joystick;

        private InputModel inputStream;

        [Inject]
        public void Construct(InputModel inputStream) 
        {
            this.inputStream = inputStream;
        }

        private void Update()
        {
            var direction = joystick.Direction;

            inputStream.InputCommand.Execute(direction);
        }
    }
}