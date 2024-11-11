using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public Vector3 position;
    public float speed;
    public int level;
    public int experience;

    public void Move(Vector3 direction)
    {
        // Code to move the player
    }

    public Projectile Attack()
    {
        // Code to attack and return a projectile
        return new Projectile();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }
}
