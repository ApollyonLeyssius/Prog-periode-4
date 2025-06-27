using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schieten : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform dummyTarget;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<HomingShot>().target = dummyTarget;
        }
    }
}
