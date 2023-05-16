using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalBulletSpawner : BulletSpawner
{
    public override BaseSpawnBullet Spawner<T>(T param)
    {
        var bulletParam = param as BaseSpawnParameter;
        var b = GameObject.Instantiate(new NomalBullet());
        b.Name = bulletParam.Name;
        b.Power = bulletParam.Power;
        b.Speed = bulletParam.Speed;
        return b;
    }
}
