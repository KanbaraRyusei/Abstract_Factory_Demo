using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private BaseSpawnParameter[] _spawnParams;
    
    private NormalBulletSpawner _nomalBulletSpawner = new NormalBulletSpawner();
    private SuperBulletSpawner _superBulletSpawner = new SuperBulletSpawner();
    private HyperBulletSpawner _hyperBulletSpawner = new HyperBulletSpawner();

    private List<BaseSpawnBullet> _bullets = new List<BaseSpawnBullet>();

    private BulletType _type = BulletType.Normal;

    private void Update()
    {
        InputKeys();
    }

    private BulletSpawner GetSpawner(BulletType type)
    {
        switch (type)
        {
            case BulletType.Normal:
                return _nomalBulletSpawner;
            case BulletType.Super:
                return _superBulletSpawner;
            case BulletType.Hyper:
                return _hyperBulletSpawner;
            default:
                return _nomalBulletSpawner;
        }
    }

    private void InputKeys()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var e = GetSpawner(_type).Spawn(_spawnParams[(int)_type]);
            var g = Instantiate(e);
            var c = g.GetComponent<BaseSpawnBullet>();
            c.SetData(e.Name, e.Power, e.Speed);
            c.Init();
            _bullets.Add(e);
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _type = BulletType.Normal;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _type = BulletType.Super;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _type = BulletType.Hyper;
        }
    }
}

enum BulletType
{
    Normal,
    Super,
    Hyper
}
