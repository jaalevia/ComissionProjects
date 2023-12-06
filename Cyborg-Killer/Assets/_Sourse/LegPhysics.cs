using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegPhysics : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody[] gameObj = new Rigidbody[4];
    private int _count;


    private void Start()
    {
        _count = 0;
        StartCoroutine(LegWalk());
    }

    IEnumerator LegWalk()
    {
        while (_count <= 4)
        {
            gameObj[_count].velocity = new Vector3(0, speed, 0);
            _count++;
            yield return new WaitForSeconds(2);
            if (_count == 4)
            {
                _count = 0;
            }
        }
        
    }
}
