using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChanger : MonoBehaviour
{
    //private PlayerHUD _hud;
    private WeaponInventory _WeaponInventroy;
    public int _currentlyEquipedWeapon = 1;
    public Transform _currentParticleSystem = null;
    private GameObject _currentWeaponObject = null;

    [SerializeField] private Transform _weaponHolder = null;
    [SerializeField] private WeaponSC _deafoultWeaponObject = null;

    private void Start()
    {
        GetReferences();
        InitVariables();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && _currentlyEquipedWeapon != 0)
        {
            UnequipWeapon();
            EquipWeapon(_WeaponInventroy.GetItem(0));
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && _currentlyEquipedWeapon != 1 && _WeaponInventroy.GetItem(1) != null)
        {
            UnequipWeapon();
            EquipWeapon(_WeaponInventroy.GetItem(1));
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && _currentlyEquipedWeapon != 2 && _WeaponInventroy.GetItem(2) != null)
        {
            UnequipWeapon();
            EquipWeapon(_WeaponInventroy.GetItem(2));
        }
    }

    private void EquipWeapon(WeaponSC weapon)
    {
        _currentlyEquipedWeapon = (int)weapon._weaponHolder;
        _currentWeaponObject = Instantiate(weapon._prefab, _weaponHolder);
        _currentParticleSystem = _currentWeaponObject.transform.GetChild(0);
        //_hud.UpdateWeaponUI(weapon);
    }

    private void UnequipWeapon()
    {
        Destroy(_currentWeaponObject);
    }

    private void InitVariables()
    {
        _WeaponInventroy.AddItem(_deafoultWeaponObject);
        EquipWeapon(_WeaponInventroy.GetItem(2)); //argument refer to enum weaponHolder
    }

    private void GetReferences()
    {
        //_hud = GetComponent<PlayerHUD>();
        _WeaponInventroy = GetComponent<WeaponInventory>();
    }
}
