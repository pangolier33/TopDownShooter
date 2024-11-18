using _Scripts.Components;
using UnityEngine;

namespace _Scripts.Creatures
{
    public class PlayerHealthModify : MonoBehaviour
    {
        [SerializeField] private HealthComponent PlayerHealth;
        [SerializeField] private GameObject _restartPanel;
        [SerializeField] private AudioSource _audioSource;
    
        private void OnEnable()
        {
            PlayerHealth.OnHealthChanged += DecreaseHealth;
        }
    
        private void DecreaseHealth(int currenthealth)
        {
            if (currenthealth > 0)
            {
                TakeHit();
            }
            else
            {
                Die();
            }
        }
    
        private void TakeHit()
        {
            _audioSource.Play();
        }

        private void Die()
        {
            _restartPanel.gameObject.SetActive(true);
        }
    
        private void OnDisable()
        {
            PlayerHealth.OnHealthChanged -= DecreaseHealth;
        }
    }
}
