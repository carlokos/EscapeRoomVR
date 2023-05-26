using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle4Handler : MonoBehaviour
{
    [SerializeField] private AudioSource puzleSolve;
    [SerializeField] private Animator doorAnim;
    [SerializeField] private Collider doorCollider;
    private bool inRoom = false;

    public void OnVoiceListened(string[] values)
    {
        if (values[0] == "conejo" && inRoom)
        {
            puzleSolve.Play();
            doorAnim.SetTrigger("open");
            doorCollider.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRoom = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRoom = false;
        }
    }
}
