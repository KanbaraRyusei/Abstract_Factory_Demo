using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const int MAX_BULLET_COUNT = 10;
    private NomalBulletSpawner _nomalBulletSpawner = new NomalBulletSpawner();
    private BaseSpawnParameter _spawnParam = new NomalBulletParameter();
    private List<BaseSpawnBullet> _bullets = new List<BaseSpawnBullet>(MAX_BULLET_COUNT);

    private void Awake()
    {
        _spawnParam.Power = 2;
        _spawnParam.Speed = 1;
    }

    private void Update()
    {
        if (_bullets.Count < MAX_BULLET_COUNT)
        {
            _spawnParam.Name = "Bullet_" + _bullets.Count;
            var e = GetSpawner(_bullets.Count).Spawner(_spawnParam);
            _bullets.Add(e);
        }
    }

    private BulletSpawner GetSpawner(int count)
    {
        return _nomalBulletSpawner;
    }
}

