using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BonuseSystem : MonoBehaviour
{
    public GameObject[] bonus = new GameObject[10];
    public GameObject[] spawnPount = new GameObject[10];
    public List<int> help = new List<int>();
    private int _spawnCount = 0;
    private int num;


    private void Start()
    {
        help.Add(50);
        StartCoroutine(SpawnBonus());
    }

    IEnumerator SpawnBonus()
    {
        while (_spawnCount < 10) 
        {
            num = Random.Range(0, spawnPount.Length);

            if (!help.Contains(num)) 
            { 
                    Instantiate(bonus[Random.Range(0, bonus.Length)], spawnPount[num].transform.position, Quaternion.identity);
                        help.Add(num);
                        _spawnCount++;
                        yield return new WaitForSeconds(Random.Range(5, 15));
            }

        }
    }
}
