using System;
using UnityEngine;

namespace Characters
{
    public class Player : MonoBehaviour, IPlayer
    {
        [SerializeField] private int _health;
        [SerializeField] private int _score;
        
        private int _currentHealth;

        public event Action<int> OnDamaged;
        public event Action OnDied;
        public event Action<int> OnScoreUpdated;

        private void Start()
        {
            _currentHealth = _health;
        }
        
        public void TakeScorePoints(int points)
        {
            _score += points;
            OnScoreUpdated?.Invoke(_score);
        }

        public void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            if (_currentHealth <= 0)
            {
                _currentHealth = 0;
                OnDamaged?.Invoke(_currentHealth);
                OnDied?.Invoke();
            }
            OnDamaged?.Invoke(_currentHealth);
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.TryGetComponent(out Enemy enemy))
            {
                TakeDamage(enemy.Damage);
            }
        }
    }
}