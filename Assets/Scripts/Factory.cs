using System.Collections;
using System.Collections.Generic;

public class Factory : IAbstractFactory
{
    public IAbstractBullet CreateBullet()
    {
        return new BulletBase();
    }
}
