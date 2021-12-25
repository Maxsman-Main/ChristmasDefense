using UnityEngine;
using System.Collections;

namespace DefaultNamespace
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Enemy[] _enemies;
        [SerializeField] private float _minSpawnTimeDelay;
        [SerializeField] private float _maxSpawnTimeDelay;
        
        private float _spawnTimeDelay;
        private int _nextEnemyIndex;
        private Transform _spawnPosition;

        private void Start()
        {
            _spawnPosition = GetComponent<Transform>();
            StartCoroutine(Spawn());
        }
        
        private void RandomizeTime()
        {
            _spawnTimeDelay = Random.Range(_minSpawnTimeDelay, _maxSpawnTimeDelay);
        }

        private void RandomizeNextEnemyIndex()
        {
            _nextEnemyIndex = Random.Range(0, _enemies.Length);
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                RandomizeTime();
                RandomizeNextEnemyIndex();
                Instantiate(_enemies[_nextEnemyIndex], transform);
                yield return new WaitForSeconds(_spawnTimeDelay);
            }
        }
    }
}