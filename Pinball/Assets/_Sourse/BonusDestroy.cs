using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDestroy : MonoBehaviour
{
    public ScoreText coins;
    public LayerMask _player;
    public int BounsMoney;
    public BonuseSystem _bonuse;
    void Start()
    {
        coins = FindObjectOfType<ScoreText>();
        _bonuse = FindObjectOfType<BonuseSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (LayerServise.CheckLayersEquality(other.gameObject.layer, _player))
        {
            
            FindObjectOfType<AudioManager>().Play("Cash");
            coins.score += BounsMoney;
            coins.AddPointBonus();
            Destroy(gameObject);
        }
    }
}
