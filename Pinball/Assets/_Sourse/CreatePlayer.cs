using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreatePlayer : MonoBehaviour
{
    public GameObject Death;
    public GameObject Panel;
    public LayerMask _layerDeath;
    private int _ballsCount;
    public GameObject[] Balls = new GameObject[3];
    private BoxCollider colliderr;
    public ScoreText coins;

    private void Start()
    {
        coins = FindObjectOfType<ScoreText>();
        colliderr = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (LayerServise.CheckLayersEquality(other.gameObject.layer, _layerDeath) && _ballsCount <= 4)
        {
            if (_ballsCount<=3)
            {
            Instantiate(Balls[Random.Range(0, Balls.Length)], new Vector3(9.70f, -2.3f, 0.5f), Quaternion.identity);
                FindObjectOfType<AudioManager>().Play("Lives");
            }
            coins.TakePoints();
            _ballsCount++;
            
        }

    }
    private void Update()
    {
        if (_ballsCount == 5)
        {
            CountBalls();
        }
    }

    private void CountBalls()
    {
        colliderr.enabled = false;
            Panel.SetActive(true);
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        
    }
}
