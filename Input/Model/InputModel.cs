using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace EEE
{
    public class InputModel
    {
        public readonly ReactiveCommand<Vector2> InputCommand;

        public InputModel()
        {
            this.InputCommand = new ReactiveCommand<Vector2>();
        }
    }
}