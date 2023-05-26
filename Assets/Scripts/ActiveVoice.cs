using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveVoice : MonoBehaviour
{
    [SerializeField]
    private Wit wit;

    private void Update()
    {
        if(wit == null) wit = GetComponent<Wit>();
        else { WitActivate(); }
    }

    public void WitActivate()
    {
        wit.Activate();
    }

    public void WitDeasctivate()
    {
        wit.Deactivate();
    }
}
