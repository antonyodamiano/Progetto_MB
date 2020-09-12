using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState {SPAWNING, WAITING, COUNTING};

    [System.Serializable]
    public class Wave {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] wazes;

    private int nextWave = 0;
    public float timeBetweenWaze = 5f;
    public float waveCountdown;

    private SpawnState state = SpawnState.COUNTING;

    void Start()
    {
        waveCountdown = timeBetweenWaze;    
    }

    void Update()
    {
        if(waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(wazes[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        state = SpawnState.SPAWNING;

        for(int i=0; i<_wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        Debug.Log("SpawningEnemy: " + _enemy.name);
    }
}
