using _Scripts.Components;
using UnityEngine.Events;
using UnityEngine;

namespace _Scripts.Creatures
{
    public class HealthModify : MonoBehaviour
    {
        [SerializeField] private HealthComponent Health;
        
        [Header("Take Hit")]
        [SerializeField] private UnityEvent _takeHit;
        
        [Header("Die")]
        [SerializeField] private UnityEvent _die;
    
        private void OnEnable()
        {
            Health.OnHealthChanged += DecreaseHealth;
        }
    
        private void DecreaseHealth(int currenthealth)
        {
            if (currenthealth > 0)
            {
                _takeHit?.Invoke();
            }
            else
            {
                _die?.Invoke();
            }
        }
    
        private void OnDisable()
        {
            Health.OnHealthChanged -= DecreaseHealth;
        }
    }
}
