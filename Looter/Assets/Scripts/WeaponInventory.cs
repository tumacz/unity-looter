using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    // 0 = melee, 1 = primary, 2 = secondary
    [SerializeField] private WeaponSC[] weapons;
    [SerializeField] private WeaponSC defaultWeapon = null;

    private WeaponManager _weaponManager;

    private void Awake() //init before EquipmentManager
    {
        GetReferences();
        InitVariables();
    }

    public void AddItem(WeaponSC newItem)
    {
        int newItemIndex = (int)newItem._weaponHolder;
        if (weapons[newItemIndex] != null)
            RemoveItem(newItemIndex);

        weapons[newItemIndex] = newItem;
        _weaponManager.InitAmmo((int)newItem._weaponHolder, newItem);
    }

    public void RemoveItem(int index)
    {
        weapons[index] = null;
    }

    public WeaponSC GetItem(int index)
    {
        return weapons[index];
    }

    private void InitVariables()
    {
        weapons = new WeaponSC[3];
    }

    private void GetReferences()
    {
        _weaponManager = GetComponent<WeaponManager>();
    }
}
