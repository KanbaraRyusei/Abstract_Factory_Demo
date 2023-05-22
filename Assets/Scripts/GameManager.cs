using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private BaseSpawnParameter[] _spawnParams;
    
    private NormalBulletSpawner _nomalBulletSpawner = new NormalBulletSpawner();

    private List<BaseSpawnBullet> _bullets = new List<BaseSpawnBullet>();

    private BulletType _type = BulletType.Nomal;

    private void Update()
    {
        InputKeys();
    }

    private BulletSpawner GetSpawner(BulletType type)
    {
        switch (type)
        {
            case BulletType.Nomal:
                return _nomalBulletSpawner;
            case BulletType.Super:
                return _nomalBulletSpawner;
            case BulletType.Hyper:
                return _nomalBulletSpawner;
            default:
                return _nomalBulletSpawner;
        }
    }

    private void InputKeys()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var e = GetSpawner(_type).Spawn(_spawnParams[(int)_type]);
            Instantiate(e);
            _bullets.Add(e);
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _type = BulletType.Nomal;
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
    Nomal,
    Super,
    Hyper
}
