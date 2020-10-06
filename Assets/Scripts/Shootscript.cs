using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootscript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    // Start is called before the first frame update
    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            Destroy(hit.transform.gameObject);

            Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
