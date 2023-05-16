using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "BulletData")]
public class BaseBulletData : ScriptableObject
{
    public string Name => _name;
    public int Power => _power;
    public int Speed => _speed;

    [SerializeField]
    private string _name;

    [SerializeField]
    private int _power;

    [SerializeField]
    private int _speed;

    private static BaseBulletData _entity;
    public static BaseBulletData Entity
    {
        get
        {
            if (_entity == null)
            {
                _entity = Resources.Load<BaseBulletData>(BulletPathManager.NOMAL_BULLET_PATH);

                if (_entity == null)
                {
                    Debug.LogError(BulletPathManager.BASE_BULLET_PATH + " not found");
                }
            }

            return _entity;
        }
    }

}