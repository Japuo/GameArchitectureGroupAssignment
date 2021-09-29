using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ObjectPool objectpool;

    public GameObject playerPrefab;
    public GameObject zombiePrefab;

    public GameObject gameOverScreen;
    public float timeBetweenZombieSpawns;

    public Player player;

    private UI UIHandler;

    private void Start()
    {
        // Spawn Player
        // Reference player
    }
    
    private void Update()
    {
        EnemySpawnSystem();
    }
    
    private void EnemySpawnSystem()
    {
        // Spawn enemy every "timeBetweenZombieSpawns" outside of the player topdown view from the objectpool

        // When spawning Zombie get the class and AssignTarget(player)
    }

    // Update all the UI in the screen
    public void UpdateUI(Player p)
    {
        UIHandler.UpdatePlayerHealth(p);
        UIHandler.UpdateWeaponSprite(p.currentGun.gunType);
        UIHandler.UpdateAmmoCount(p.currentGun.gunType);
    }

    public void GameOver()
    {
        // Destroy Player
        // Show gameOverScreen
    }

    public void GiveLoot(Gun gun)
    {
        // Retrieve gun
        // If new gun call player PickUpGun
        // if already owned gun add ammo from retrieved gun to the already owned type of the gun
    }

}