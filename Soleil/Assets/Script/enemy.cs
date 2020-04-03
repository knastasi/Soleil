using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deatheffect;

    public void takedamage(int damage)
	{
        health -= damage;
        if (health <= 0)
		{
            death();
		}
	}

    void death()
	{
        Instantiate(deatheffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
	}
}
