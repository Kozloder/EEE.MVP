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
    public class MoveInputPresenter : MonoBehaviour
    {
        [SerializeField]
        private CharacterController2D _character;
        [SerializeField]
        private float speed;

        private InputModel input;

        private IDisposable inputForceDisposable;

        [Inject]
        public void Construct(InputModel input)
        {
            this.input = input;
        }

        private void OnEnable()
        {
            inputForceDisposable = input.InputCommand.Subscribe(input => 
            {
                var force = input.x * speed;

                _character.Move(force);
            });
        }

        private void OnDisable()
        {
            inputForceDisposable.Dispose();
        }
    }
}