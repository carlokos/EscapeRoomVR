using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class thirdPuzzle : MonoBehaviour
{
    [SerializeField] private TextMeshPro txtPW;
    [SerializeField] private Animator doorAnim;
    [SerializeField] private Collider doorCollider;
    [SerializeField] private AudioSource solveSource;
    [SerializeField] private AudioSource failSource;
    private bool done;
    public void write9()
    {
        txtPW.text = txtPW.text + "9";
    }

    public void write4()
    {
        txtPW.text = txtPW.text + "4";
    }

    public void write0()
    {
        txtPW.text = txtPW.text + "0";
    }

    public void write2()
    {
        txtPW.text = txtPW.text + "2";
    }

    public void write1()
    {
        txtPW.text = txtPW.text + "1";
    }

    public void write3()
    {
        txtPW.text = txtPW.text + "3";
    }

    private void Update()
    {
        if(txtPW.text.Length >= 4)
        {
            if (txtPW.text == "9402" && !done)
            {
                done = true;
                solveSource.Play();
                doorAnim.SetTrigger("open");
                doorCollider.enabled = false;
            }
            else{
                txtPW.text = "";
            }
        }
    }
}
