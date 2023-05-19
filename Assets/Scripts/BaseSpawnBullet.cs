using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpawnBullet : MonoBehaviour
{
    public string Name { get; protected set; }
    public int Power { get; protected set; }
    public int Speed { get; protected set; }

    protected Rigidbody2D _rb;

    private void OnEnable()
    {
        Init();
        Shoot();
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetPower(int power)
    {
        Power = power;
    }

    public void SetSpeed(int speed)
    {
        Speed = speed;
    }

    protected void Init()
    {
        _rb ??= GetComponent<Rigidbody2D>();
    }

    protected void Shoot()
    {
        _rb.velocity = new Vector2(0f, Speed);
    }
}
