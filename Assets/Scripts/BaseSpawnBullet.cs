using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpawnBullet : MonoBehaviour
{
    public string Name { get; protected set; }
    public int Power { get; protected set; }
    public int Speed { get; protected set; }

    protected Rigidbody2D _rb;

    public void SetData(string name, int power, int speed)
    {
        Name = name;
        Power = power;
        Speed = speed;
    }

    public void Init()
    {
        _rb ??= GetComponent<Rigidbody2D>();
        Shoot();
    }

    protected virtual void Shoot()
    {
        _rb.velocity = new Vector2(0f, Speed);
        Debug.Log("Shoot" + Speed);
    }
}
