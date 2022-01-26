using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;
using UniRx;

namespace EEE
{
    public class QuestHubPresenter : MonoBehaviour
    {
        [SerializeField]
        private int maxQuests;
        [SerializeField]
        private bool questRegenerate;

        private int questsCount;

        private IQuestFactory questFactory;

        private ReactiveCommand<QuestHubActivateCommand> activateHub;
        private ReactiveCommand<QuestHubDeactivateCommand> deactivateHub;

        private CompositeDisposable disposableCommand;

        [Inject]
        public void Construct(ReactiveCommand<QuestHubActivateCommand> activateHub,
                              ReactiveCommand<QuestHubDeactivateCommand> deactivateHub,
                              IQuestFactory questFactory)
        {
            this.activateHub = activateHub;
            this.deactivateHub = deactivateHub;

            this.questFactory = questFactory;
        }

        private void Awake()
        {
            disposableCommand = new CompositeDisposable();    
        }

        private void OnEnable()
        {
            disposableCommand.Add(activateHub.Subscribe(ActivateQuestHub));
            disposableCommand.Add(deactivateHub.Subscribe(DeactivateQuestHub));
        }

        private void OnDisable()
        {
            disposableCommand.Dispose();
        }

        private void ActivateQuestHub(QuestHubActivateCommand activate)
        {
            /*
            while (questsCount < maxQuests)
            {
                var questTemplate = questFactory.Create();
                var questView = questTemplate.View;

                questView.Show();

                questView.OnClick += () =>
                {
                    var questPrepare = questTemplate.Model;
                    var questModel = questPrepare.Prepare();

                    questView.Hide();
                };

                questsCount++;
            }*/
        }

        private void DeactivateQuestHub(QuestHubDeactivateCommand deactivate)
        {

        }
    }
}