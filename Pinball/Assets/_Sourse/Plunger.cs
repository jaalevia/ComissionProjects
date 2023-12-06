using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plunger : MonoBehaviour
{
    float power;
    float minPower = 0f;
    public float MaxPower = 1000f;
    public Slider PowerSlider;
    List<Rigidbody> ballList;
    bool ballReady;
    void Start()
    {
        PowerSlider.minValue = 0f;
        PowerSlider.maxValue = MaxPower;
        ballList = new List<Rigidbody>();
    }

    void Update()
    {
        if (ballReady)
        {
            PowerSlider.gameObject.SetActive(true);
        }
        else
        {
            PowerSlider.gameObject.SetActive(false);
        }
        PowerSlider.value = power;
        if (ballList.Count > 0)
        {
            ballReady = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if (power <= MaxPower)
                {
                    power += 50 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (Rigidbody r in ballList)
                {
                    r.AddForce(power * Vector3.forward);
                    power = minPower;
                }
            }
        }
        else
        {
            ballReady= false;
            power = 0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            power= 0f;
        }
    }
}
