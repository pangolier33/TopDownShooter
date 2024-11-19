using System;
using _Scripts.Components;
using UnityEngine;
using UnityEngine.AI;

namespace _Scripts.Creatures
{
    public class Zombie : MonoBehaviour
    {
        public static event Action Died;
        
        [SerializeField] float _attackRange = 1f;
    
        private NavMeshAgent _navMeshAgent;
        private Animator _animator;
        private AnimatorStateInfo _animatorState;
        private PlayerMovement player;
        private Collider _zombieCollider;
        
        private bool Alive = true;
        
        
        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _animator = GetComponent<Animator>();
            _zombieCollider = gameObject.GetComponent<Collider>();
            player = FindObjectOfType<PlayerMovement>();
        }
        
        private void Update()
        {
            if (_navMeshAgent.enabled)
                _navMeshAgent.SetDestination(player.transform.position);

            if ((Vector3.Distance(transform.position, player.transform.position) < _attackRange) && _navMeshAgent.enabled)
                Attack();
        }
        
        private void Attack()
        {
            _navMeshAgent.enabled = false;
            _animator.SetTrigger("Attack");
        }
    
        // Animation Callback
        private void AttackComplete()
        {
            if (Alive)
            {
                _navMeshAgent.enabled = true;
            }
        }

        // Animation Callback
        private void AttackHit()
        {
            DamageComponent.Apply(player.gameObject);
        }

        public void Die()
        {
            Alive = false;
            _animator.SetTrigger("Died");
            _zombieCollider.enabled = false;
            _navMeshAgent.enabled = false;
            Died?.Invoke();
            Destroy(gameObject, 5f);
        }

        public void TakeHit()
        {
            _navMeshAgent.enabled = false;
            _animator.SetTrigger("Hit");
        }

        // Animation Callback
        private void HitComplete()
        {
            if (Alive)
                _navMeshAgent.enabled = true;
        }
        
    }
}
