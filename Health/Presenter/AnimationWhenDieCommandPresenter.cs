using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animancer;
using UniRx;
using UnityEngine;
using Zenject;

namespace EEE
{
    public class AnimationWhenDieCommandPresenter : MonoBehaviour
    {
        [SerializeField]
        private AnimancerComponent animancer;
        [SerializeField]
        private AnimationClip _animation;

        private ReactiveCommand<DieCommand> die;

        private CompositeDisposable disposable;

        [Inject]
        public void Construct(ReactiveCommand<DieCommand> die) 
        {
            this.die = die;
        }

        private void Awake()
        {
            disposable = new CompositeDisposable();
        }

        private void OnEnable()
        {
            disposable.Add(die.Subscribe(Animate));
        }

        private void OnDisable()
        {
            disposable.Clear();
        }

        private void Animate(DieCommand die) 
        {
            var play = animancer.Play(_animation);
            play.Play();
        }
    }
}