using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Camera playerCamera;
    public AudioSource gunshotSound;
    public AudioClip gunshotClip;
    public int bulletsPerMagazine = 10;
    private int currentBullets;
    private bool isReloading = false;

    void Start()
    {
        currentBullets = bulletsPerMagazine;
    }

    void Update()
    {
        if (isReloading)
            return;

        if (Input.GetButtonDown("Fire1") && currentBullets > 0)
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reload());
        }
    }

    void Shoot()
    {
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point;
        }
        else
        {
            targetPoint = ray.GetPoint(100);
        }

        Vector3 direction = targetPoint - firePoint.position;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.LookRotation(direction));
        bullet.GetComponent<Bullet>().Initialize(direction.normalized);

        gunshotSound.PlayOneShot(gunshotClip);

        currentBullets--;
        if (currentBullets <= 0)
        {
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading...");

        yield return new WaitForSeconds(2);

        currentBullets = bulletsPerMagazine;
        isReloading = false;
    }
}
