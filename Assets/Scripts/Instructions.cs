using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    [SerializeField] private GameObject instruct; 
    void Awake()
    {
        gameObject.SetActive(true);
    }

    public void Play()
    {
        this.gameObject.SetActive(false);
    }
}
