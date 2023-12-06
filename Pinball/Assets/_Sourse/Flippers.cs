using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public float RestPosition = 0f;
    public float PressedPosition = 45f;
    public float HitStrenght = 10000f;
    public float FlipperDamper = 150f;
    HingeJoint hinge;
    public string InputName;
    void Start()
    {
        hinge= GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = HitStrenght;
        spring.damper= FlipperDamper;

        if (Input.GetAxis(InputName) == 1)
        {
            spring.targetPosition = PressedPosition;
            FindObjectOfType<AudioManager>().Play("Push");
        }
        else
        {
            spring.targetPosition = RestPosition;
        }
        hinge.spring = spring;
        hinge.useLimits= true;
    }
}
