using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    const int MAX_BULLET_COUNT = 10;
    NomalBulletSpawner _nomalBulletSpawner = new NomalBulletSpawner();
    BaseSpawnParameter _spawnParam = new NomalBulletParameter();
    List<BaseSpawnBullet> _bullets = new List<BaseSpawnBullet>(MAX_BULLET_COUNT);

    void Awake()
    {
        _spawnParam.Power = 2;
        _spawnParam.Speed = 1;
    }

    void Update()
    {

        if (_bullets.Count < MAX_BULLET_COUNT)
        {
            _spawnParam.Name = "Enemy_" + _bullets.Count;
            var e = GetSpawner(_bullets.Count).Spawner(_spawnParam);
            _bullets.Add(e);
        }
    }

    BulletSpawner GetSpawner(int count)
    {
        return _nomalBulletSpawner;
    }
}

