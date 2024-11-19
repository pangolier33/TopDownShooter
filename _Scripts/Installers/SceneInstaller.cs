using _Scripts.Components;
using _Scripts.UI;
using TMPro;
using UnityEngine;
using Zenject;

namespace _Scripts.Installers
{
    public class SceneInstaller : MonoInstaller
    {
        [SerializeField] private TMP_Text _timerText;
        
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private TMP_Text _highScoreText;
        [SerializeField] private TMP_Text _multiplierText;
        public override void InstallBindings()
        {
            BindUI();
        }

        private void BindUI()
        {
            Container.Bind<ITickable>()
                .To<Timer>()
                .AsCached()
                .WithArguments(_timerText)
                .NonLazy();

            Container.Bind<IInitializable>()
                .To<ScoreSystem>()
                .AsCached()
                .WithArguments(_scoreText, _highScoreText, _multiplierText)
                .NonLazy();
        }
    }
}