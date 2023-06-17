using UnityEngine;

/// <summary>
/// ��������Bullet�ɂ���N���X
/// ���N���X�ł���A�h�������Ďg�p����
/// </summary>
public class BaseSpawnBullet : MonoBehaviour
{
    public string Name { get; protected set; }
    public int Power { get; protected set; }
    public int Speed { get; protected set; }

    protected Rigidbody2D _rb;

    public virtual void SetData(string name, int power, int speed)
    {
        Name = name;
        Power = power;
        Speed = speed;
    }

    public virtual void Init()
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
