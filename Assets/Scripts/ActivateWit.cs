using Meta.WitAi.CallbackHandlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWit : MonoBehaviour
{
    [SerializeField] private GameObject responseHandler;
    [SerializeField] private ActiveVoice ActiveVoice;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            responseHandler.SetActive(true);
            ActiveVoice.WitActivate();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            responseHandler.SetActive(false);
            ActiveVoice.WitDeasctivate();
        }
    }
}
