using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class UI : IUI
    {
        public IUIFreeFlightView FreeFlightUI { get; }
        public IUIQuestView QuestItemUI { get; }

        public UI(IUIFreeFlightView freeFlightUI, IUIQuestView questItemUI)
        {
            this.FreeFlightUI = freeFlightUI;
            this.QuestItemUI = questItemUI;
        }
    }
}