using UnityEngine;

namespace _Scripts.UI
{
    public class PauseGame : MonoBehaviour
    {
        [SerializeField] private GameObject panel;

        public void Play()
        {
            panel.SetActive(false);
            Time.timeScale = 1f;
        }
    
        public void Pause()
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
