using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoints : MonoBehaviour
{
    [SerializeField] 
    public LayerMask points;
    public ScoreText coins;

    private void Start()
    {
        coins = FindObjectOfType<ScoreText>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (LayerServise.CheckLayersEquality(collision.gameObject.layer, points))
        {
            FindObjectOfType<AudioManager>().Play("Collide");
            coins.AddPoint();
        }
    }
}
