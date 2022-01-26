using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EEE
{
    public class AnchorJoystick : FixedJoystick
    {
        [SerializeField]
        private float speed;
        [SerializeField]
        private float anchorTime;

        public bool HasInput => Magnitude > DeadZone;

        public override void OnPointerUp(PointerEventData eventData) 
        {
            
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
        }
    }
}