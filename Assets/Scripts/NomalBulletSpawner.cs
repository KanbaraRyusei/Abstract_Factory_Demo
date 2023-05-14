using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class NomalBulletSpawner : BulletSpawner
{
    public override BaseSpawnBullet Spawner<T>(T param)
    {
        var bulletParam = param as BaseSpawnParameter;
        var b = GameObject.Instantiate<NomalBullet>(null);
        Assert.IsNotNull(b, "[NomalBulletSpawner] is Null");
        b.Name = bulletParam.Name;
        b.Power = bulletParam.Power;
        b.Speed = bulletParam.Speed;
        return b;
    }
}
