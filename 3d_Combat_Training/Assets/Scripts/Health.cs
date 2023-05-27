using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    #region Variables
    public int maxHealth;
    public int currentHealth;
    #endregion

    public void ChangeHealth(int damage)
    {
        //Health goes up or down
        currentHealth = currentHealth + damage;


        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        ChangeHealth(-10);
        Debug.Log(gameObject.name + "max health:" + maxHealth);
        Debug.Log(gameObject.name + "current health:" + currentHealth);
    }


}

