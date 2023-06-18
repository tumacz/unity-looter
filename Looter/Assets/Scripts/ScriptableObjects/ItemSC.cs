using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSC : ScriptableObject
{
    public string _name;
    public Sprite _sprite;

    public virtual void Use()
    {
        Debug.Log(name + "was used.");
    }
}
