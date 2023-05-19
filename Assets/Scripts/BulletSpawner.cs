using System.Collections;
using System.Collections.Generic;

public abstract class BaseSpawnParameter
{
    public string Name { get; protected set; }
    public int Power { get; protected set; }
    public int Speed { get; protected set; }

    public void SetNameParam(string name)
    {
        Name = name;
    }

    public void SetPowerParam(int power)
    {
        Power = power;
    }

    public void SetSpeedParam(int speed)
    {
        Speed = speed;
    }
}

public abstract class BulletSpawner
{
    protected BaseSpawnBullet _cache = null;

    public abstract BaseSpawnBullet Spawn<T>(T param) where T : BaseSpawnParameter;
}
