using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondPuzzleResolve : MonoBehaviour
{
    [SerializeField] private Animator doorAnim;
    [SerializeField] private Collider doorCollider;
    [SerializeField] private AudioSource mysteriSolve;
    [SerializeField] private Image pose;
    private bool done = false;

    public void puzzleSolve() {
        if (!done)
        {
            done = true;
            doorAnim.SetTrigger("open");
            doorCollider.enabled = false;
            mysteriSolve.Play();
            pose.color = Color.green;
        }
    }
}
