using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private NormalBulletSpawner _nomalBulletSpawner = new NormalBulletSpawner();
    private BaseSpawnParameter _spawnParam = new NormalBulletParameter();
    private List<BaseSpawnBullet> _bullets = new List<BaseSpawnBullet>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var e = GetSpawner(BulletType.Nomal).Spawn(_spawnParam);
            Instantiate(e);
            _bullets.Add(e);
        }
    }

    private BulletSpawner GetSpawner(BulletType type)
    {
        switch (type)
        {
            case BulletType.Nomal:
                return _nomalBulletSpawner;
            default:
                return _nomalBulletSpawner;
        }
    }
}

enum BulletType
{
    Nomal,
    Super,
    Hyper
}
