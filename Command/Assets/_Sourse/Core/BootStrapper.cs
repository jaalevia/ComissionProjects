using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrapper : MonoBehaviour
{
    [SerializeField] private InputListener inputListener;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Transform player;

    void Start()
    {
        inputListener.Construct(mainCamera, new CommandInvoker(player));
    }
}
