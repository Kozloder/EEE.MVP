using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;

namespace EEE
{
    public class UIInstaller : MonoInstaller<UIInstaller>
    {
        [SerializeField]
        private Canvas freeFlightUI;
        [SerializeField]
        private UIQuestModel questUI;

        public override void InstallBindings()
        {
            Container.Bind(typeof(IUI), typeof(UICanvas))
                     .To<UICanvas>()
                     .FromMethod(ctx => 
                     {
                         var freeFlightUI = ctx.Container.InstantiatePrefab(this.freeFlightUI)
                                                         .GetComponent<Canvas>();
                         var questUI = ctx.Container.InstantiatePrefab(this.questUI)
                                                    .GetComponent<UIQuestModel>();

                         var questCanvas = questUI.Canvas;
                         var questTransform = questUI.QuestCanvas;

                         freeFlightUI.enabled = false;
                         questUI.Canvas.enabled = false;

                         var freeFlight = new UIFreeFlightCanvasView(freeFlightUI);
                         var quest = new UIQuestCanvasView(questCanvas, questTransform);

                         return new UICanvas(freeFlight, quest);
                     }).AsSingle().NonLazy();
        }
    }
}