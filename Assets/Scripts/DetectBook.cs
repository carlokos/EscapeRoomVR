using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBook : MonoBehaviour
{
    [SerializeField] private AudioSource solveSound;
    [SerializeField] private Animator doorAnim;
    [SerializeField] private Collider doorCollider;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("book"))
        {
            collision.gameObject.SetActive(false);
            solveSound.Play();
            doorAnim.SetTrigger("open");
            doorCollider.enabled = false;
        }
    }
}
