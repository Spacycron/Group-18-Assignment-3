using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    [SerializeField] private Animator Stereo = null;

    [SerializeField] private bool openTrigger = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                Stereo.Play("Stereo fall", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
} 
