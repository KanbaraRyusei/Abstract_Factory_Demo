using System.Collections;
using System.Collections.Generic;

public class Client
{
    public Client()
    {
        ClientMethod(new Factory());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var bullet = factory.CreateBullet();
    }
}
