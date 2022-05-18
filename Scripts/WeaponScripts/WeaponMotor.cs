using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMotor : MonoBehaviour
{
    [SerializeField] private GunData gunData;
    [SerializeField] private Transform muzzle;
    [SerializeField] private GameObject bullet;
    private PlayerUI playerUI;

    float timeSinceLastShot;

    private void Start()
    {
        playerUI = GetComponentInParent<PlayerUI>();
    }

    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    public void Shoot()
    {
        if (gunData.currentAmmo > 0)
        {
            if (CanShoot())
            {
                if (Physics.Raycast(muzzle.position, transform.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    IDamageable damageable = hitInfo.transform.GetComponent<IDamageable>();
                    damageable?.Damage(gunData.damage);
                }

                gunData.currentAmmo--;
                timeSinceLastShot = 0;
                OnGunShot();
            }

        }
    }

    public void StartReload()
    {
        if (!gunData.reloading)
        {
            if (gunData.currentAmmo != gunData.magSize)
            StartCoroutine(Reload());
        }
    }

    private IEnumerator Reload()
    {
        playerUI.UpdateAmmoText("reloading...");

        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        gunData.currentAmmo = gunData.magSize;

        gunData.reloading = false;
    }

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        Debug.DrawRay(muzzle.position, muzzle.forward);

        if (!gunData.reloading)
        playerUI.UpdateAmmoText(gunData.currentAmmo + "/" + gunData.magSize);
    }

    private void OnGunShot()
    {
        
    }
}
