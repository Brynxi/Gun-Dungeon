using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Monsters;

    private int RNG;

    void Start()
    {
        SpawnMonster();
    }

    public void SpawnMonster()
    {
        RNG = Random.Range(0, Monsters.Length);
        Instantiate(Monsters[RNG], transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    
}
