using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="")]
public abstract class BaseSpawnParameter : ScriptableObject
{
    public string Name => _name;
    public int Power => _power;
    public int Speed => _speed;

    [SerializeField]
    protected string _name;

    [SerializeField]
    protected int _power;

    [SerializeField]
    protected int _speed;
}
