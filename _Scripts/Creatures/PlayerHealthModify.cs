using UnityEngine;

namespace _Scripts.Creatures
{
    public class PlayerHealthModify : MonoBehaviour
    {
        [SerializeField] private GameObject _restartPanel;
        [SerializeField] private AudioSource _audioSource;
    
        public void TakeHit()
        {
            _audioSource.Play();
        }

        public void Die()
        {
            _restartPanel.gameObject.SetActive(true);
        }
    }
}
