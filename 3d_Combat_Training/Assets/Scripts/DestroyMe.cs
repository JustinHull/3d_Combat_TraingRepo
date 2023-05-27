using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyMe : MonoBehaviour
{
    public float lifeTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}