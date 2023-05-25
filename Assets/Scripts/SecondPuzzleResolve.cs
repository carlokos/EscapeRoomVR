using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPuzzleResolve : MonoBehaviour
{
    [SerializeField] private Animator doorAnim;
    [SerializeField] private Collider doorCollider;
    [SerializeField] private AudioSource mysteriSolve;
    private bool done = false;

    public void puzzleSolve() {
        if (!done)
        {
            done = true;
            doorAnim.SetTrigger("open");
            doorCollider.enabled = false;
            mysteriSolve.Play();
        }
    }
}
