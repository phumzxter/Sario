using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    public GameObject[] projectiles;
    public int projectileType;
    private float spawnRangeX;
    private float spawnPosZ;
    private float spawnPosY;
    private float startDelay = 2;
    private float spawnInterval = 5f;
    // Start is called before the first frame update
    void Start()
    {
        spawnRangeX = transform.position.x;
        spawnPosZ = transform.position.z;
        spawnPosY = transform.position.y;
        InvokeRepeating("SpawnProjectiles", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnProjectiles() {
        spawnRangeX = transform.position.x;
        spawnPosZ = transform.position.z;
        spawnPosY = transform.position.y;
        Vector3 spawnPos = new Vector3(spawnRangeX, Random.Range(spawnPosY - 2, spawnPosY + 2), spawnPosZ);
        GameObject projectilePrefab = projectiles[projectileType];
        Instantiate(projectilePrefab, spawnPos, projectilePrefab.transform.rotation);
   
    }
}
