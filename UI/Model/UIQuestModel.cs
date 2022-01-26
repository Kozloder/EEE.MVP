using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class UIQuestModel : MonoBehaviour
    {
        [SerializeField]
        private Canvas canvas;
        [SerializeField]
        private Transform questCanvas;

        public Canvas Canvas => canvas;
        public Transform QuestCanvas => questCanvas;
    }
}