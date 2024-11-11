using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public List<Enemy> enemies = new List<Enemy>();
    public List<Projectile> projectiles = new List<Projectile>();
    public List<Item> items = new List<Item>();
    public LevelManager levelManager;
    public SkillSelectionScreen skillSelectionScreen;

    void Start()
    {
        // Initialize game objects here
    }

    void Update()
    {
        // Call update functions and check for conditions here
        CheckCollisions();
    }

    void CheckCollisions()
    {
        // Code to check for collisions between player, enemies, and projectiles
    }

    public void LevelUp()
    {
        // Handle player leveling up here
    }
}
