using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageMenuUtama : MonoBehaviour
{
    public void ClickCahaya()
    {
        GlobalVar.caseEksperimen = GlobalVar.CaseEksperimen.EKSPERIMEN_LIGHT;
    }

    public void ClickNahco()
    {
        GlobalVar.caseEksperimen = GlobalVar.CaseEksperimen.EKSPERIMEN_NAHCO3;
    }
}
