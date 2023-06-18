using UnityEngine;

/// <summary>
/// Parameter‚ğİ’è‚·‚éScriptableObject‚ÌƒNƒ‰ƒX
/// </summary>
[CreateAssetMenu(menuName ="Parameter/Base")]
public class BaseSpawnParameter : ScriptableObject
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
