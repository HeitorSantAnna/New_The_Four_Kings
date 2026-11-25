using UnityEngine;

[CreateAssetMenu(fileName = "Manoplas", menuName = "Scriptable Objects/Manoplas")]
public class Manoplas : ScriptableObject
{
    public string ID;
    
    public string name;

    public float damage;

    public float rangeDa;

    public bool IsMagic;
    
    public bool IsMartial;

    public TypeMagic typemagic;
}

public enum TypeMagic
{
    Fire,
    Ice,
    Water,
    Speed,
    Rock,
    Steal
}