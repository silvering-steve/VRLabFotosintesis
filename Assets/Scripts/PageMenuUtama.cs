using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageMenuUtama : MonoBehaviour
{
    public GameObject eval;
    public Transform canvas;
    
    public void ClickCahaya()
    {
        GlobalVar.caseEksperimen = GlobalVar.CaseEksperimen.EKSPERIMEN_LIGHT;
    }

    public void ClickNahco()
    {
        GlobalVar.caseEksperimen = GlobalVar.CaseEksperimen.EKSPERIMEN_NAHCO3;
    }

    public void ClickEval()
    {
        var a = Instantiate(eval, canvas);
        a.SetActive(true);
    }
}