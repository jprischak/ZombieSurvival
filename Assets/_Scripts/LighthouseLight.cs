using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighthouseLight : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 5f;



    private void Update()
    {
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }
}
