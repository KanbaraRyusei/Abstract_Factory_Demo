using System.Collections;
using System.Collections.Generic;

public abstract class BaseSpawnParameter
{
    public string Name { get; set; }
    public int Power { get; set; }
    public int Speed { get; set; }
}

public abstract class BulletSpawner
{
    public abstract BaseSpawnBullet Spawner<T>(T param) where T : BaseSpawnParameter;
}
