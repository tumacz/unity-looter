using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


[CreateAssetMenu(menuName = "ScriptableObjects/PlayerData")]
[System.Serializable]
public class PlayerSC : ScriptableObject
{
    public float playerSpeed = 10f;
    public float agility = 5f;
    public float smoothInputSpeed = .2f;
    public Sprite reticle;
    public Vector2 playerPos;
    public Vector2 aimPos;

    public void ResetValues()
    {
        playerPos = new Vector2(0,0);
        aimPos = new Vector2(0, 0);
    }

    public virtual void Attack()
    {
        Debug.Log("attack");
    }
}
