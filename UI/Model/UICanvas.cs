using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class UICanvas : IUI
    {
        public IUIFreeFlightView FreeFlightUI => FreeFlightCanvas;
        public IUIQuestView QuestItemUI => QuestCanvas;

        public UIFreeFlightCanvasView FreeFlightCanvas { get; }
        public UIQuestCanvasView QuestCanvas { get; }

        public UICanvas(UIFreeFlightCanvasView freeFlightCanvas, UIQuestCanvasView questCanvas) 
        {
            this.FreeFlightCanvas = freeFlightCanvas;
            this.QuestCanvas = questCanvas;
        }
    }
}