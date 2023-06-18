using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private int _primaryCurrentAmmo;
    [SerializeField] private int _primaryCurrentMagazine;

    [SerializeField] private int _secondaryCurrentAmmo;
    [SerializeField] private int _secondaryCurrentMagazine;

    [SerializeField] private bool _primaryMagazineEmpty = false;
    [SerializeField] private bool _secondaryMagazineEmpty = false;
    private bool _canShoot = true;

    [SerializeField] private Transform _shootPoint;
    private float _lastShootTime = 0f;
    //ref
    [SerializeField] WeaponInventory _weaponInventory;
    [SerializeField] WeaponChanger _weaponChanger;
    //[SerializeField] PlayerHUD _hud;

    private void Start()
    {
        GetReferences();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadWeapon(_weaponChanger._currentlyEquipedWeapon);
        }
    }

    private void RaycastShoot(WeaponSC currentWeapon)
    {
        float weaponRange = currentWeapon._range;
        Instantiate(currentWeapon._particleSystemPrefab, _weaponChanger._currentParticleSystem);
        RaycastHit2D hit = Physics2D.Raycast(_shootPoint.position, _shootPoint.up, weaponRange);
        Debug.DrawRay(_shootPoint.transform.position, _shootPoint.up * weaponRange, Color.red, 0.2f); // delate

        if (hit.collider != null)
        {
            var target = hit.collider.TryGetComponent<ITakeDamage>(out ITakeDamage _healthControl);
            Debug.Log(hit.collider.name); //delate

            //if (_healthControl != null)
            //_healthControl.TakeDamage(_weaponDamage);
            //else
            //CreateHitImpact(hit);
        }
    }

    private void Shoot()
    {
        CheckCanShoot(_weaponChanger._currentlyEquipedWeapon);
        if (_canShoot)
        {
            WeaponSC currentWeapon = _weaponInventory.GetItem(_weaponChanger._currentlyEquipedWeapon);

            if (Time.time > _lastShootTime + currentWeapon._fireRate)
            {
                Debug.Log("bam");
                _lastShootTime = Time.time;
                //a place for audio/anim
                RaycastShoot(currentWeapon);
                UseAmmo((int)currentWeapon._weaponHolder, 1, 0);
            }
        }
        else
            Debug.Log("no ammo");
    }

    private void ReloadWeapon(int slot)
    {
        //primary
        if (slot == 1) //primary (int)currentWeapon._weaponType
        {
            int ammoToReaload = _weaponInventory.GetItem(1)._magazineSize - _primaryCurrentAmmo;

            if (_primaryCurrentMagazine >= ammoToReaload)
            {
                if (_primaryCurrentAmmo == _weaponInventory.GetItem(1)._magazineSize)
                {
                    return;
                }
                AddAmmo(slot, ammoToReaload, 0);
                UseAmmo(slot, 0, ammoToReaload);

                _primaryMagazineEmpty = false;
                CheckCanShoot(1);
            }
            else
                Debug.Log("not enough ammo");
        }
        //secondary
        if (slot == 2) //secondary (int)currentWeapon._weaponType
        {
            int ammoToReaload = _weaponInventory.GetItem(2)._magazineSize - _secondaryCurrentAmmo;

            if (_secondaryCurrentMagazine >= ammoToReaload)
            {
                if (_secondaryCurrentAmmo == _weaponInventory.GetItem(2)._magazineSize)
                {
                    return;
                }
                AddAmmo(slot, ammoToReaload, 0);
                UseAmmo(slot, 0, ammoToReaload);

                _secondaryMagazineEmpty = false;
                CheckCanShoot(2);
            }
            else
                Debug.Log("not enough ammo");
        }
    }

    private void CheckCanShoot(int slot)
    {
        //primary
        if (slot == 1) //primary (int)currentWeapon._weaponType
        {
            if (_primaryMagazineEmpty)
                _canShoot = false;
            else
                _canShoot = true;
        }
        //secondary
        if (slot == 2) //secondary (int)currentWeapon._weaponType
        {
            if (_secondaryMagazineEmpty)
                _canShoot = false;
            else
                _canShoot = true;
        }
    }

    public void InitAmmo(int slot, WeaponSC weapon)
    {
        //primary
        if (slot == 1) //primary (int)currentWeapon._weaponType
        {
            _primaryCurrentAmmo = weapon._magazineSize;
            _primaryCurrentMagazine = weapon._magazineSize;
        }
        //secondary
        if (slot == 2) //secondary (int)currentWeapon._weaponType
        {
            _secondaryCurrentAmmo = weapon._magazineSize;
            _secondaryCurrentMagazine = weapon._magazineSize;
        }
    }

    private void AddAmmo(int slot, int currentAmmoAdded, int currentStoredAmmoAdded)
    {
        //primary
        if (slot == 1) //primary (int)currentWeapon._weaponType
        {
            _primaryCurrentAmmo += currentAmmoAdded;
            _primaryCurrentMagazine += currentStoredAmmoAdded;
        }
        //secondary
        if (slot == 2) //secondary (int)currentWeapon._weaponType
        {
            _secondaryCurrentAmmo += currentAmmoAdded;
            _secondaryCurrentMagazine += currentStoredAmmoAdded;
        }
    }

    private void UseAmmo(int slot, int currentAmmoUsed, int currentStoredAmmoUsed)
    {
        //primary
        if (slot == 1) //primary (int)currentWeapon._weaponType
        {
            if (_primaryCurrentAmmo <= 0)
            {
                _primaryMagazineEmpty = true;
                CheckCanShoot(_weaponChanger._currentlyEquipedWeapon);
            }
            else
            {
                _primaryCurrentAmmo -= currentAmmoUsed;
                _primaryCurrentMagazine -= currentStoredAmmoUsed;
                //_hud.UpdateWeaponAmmoUI(_primaryCurrentAmmo, _primaryCurrentMagazine);
            }
        }
        //secondary
        if (slot == 2) //secondary (int)currentWeapon._weaponType
        {
            if (_secondaryCurrentAmmo <= 0)
            {
                _secondaryMagazineEmpty = true;
                CheckCanShoot(_weaponChanger._currentlyEquipedWeapon);
            }
            else
            {
                _secondaryCurrentAmmo -= currentAmmoUsed;
                _secondaryCurrentMagazine -= currentStoredAmmoUsed;
                //_hud.UpdateWeaponAmmoUI(_secondaryCurrentAmmo, _secondaryCurrentMagazine);
            }
        }
    }

    private void GetReferences()
    {
        _weaponInventory = GetComponent<WeaponInventory>();
        _weaponChanger = GetComponent<WeaponChanger>();
        //_hud = GetComponent<PlayerHUD>();
    }
}
