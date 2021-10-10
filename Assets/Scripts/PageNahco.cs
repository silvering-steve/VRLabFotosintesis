using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PageNahco : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI txtJumlahNahco;

    [SerializeField]
    private GameObject prefab_bubble;

    [SerializeField]
    private GameObject bubble;

    [SerializeField]
    private Transform posisiBubble;

    private void OnEnable()
    {
        GlobalVar.jumlahNahco3 = 0;
        txtJumlahNahco.text = GlobalVar.jumlahNahco3.ToString();

        SetBubble();
    }

    private void OnDisable()
    {
        Destroy(bubble);
    }

    public void ClickButtonNahco()
    {
        if (GlobalVar.jumlahNahco3 >= 5)
            return;

        GlobalVar.jumlahNahco3++;
        txtJumlahNahco.text = GlobalVar.jumlahNahco3.ToString();

        var a = bubble.GetComponent<ParticleSystem>().emission;
        switch (GlobalVar.jumlahNahco3)
        {
            case 0:
                a.rateOverTime = 0;
                break;
            case 1:
                a.rateOverTime = 2;
                break;
            case 2:
                a.rateOverTime = 4;
                break;
            case 3:
                a.rateOverTime = 6;
                break;
            case 4:
                a.rateOverTime = 10;
                break;
            case 5:
                a.rateOverTime = 14;
                break;
        }
    }

    private void SetBubble()
    {
        bubble = Instantiate(prefab_bubble.gameObject, posisiBubble.position, Quaternion.identity);
        var a = bubble.GetComponent<ParticleSystem>().emission;
        a.rateOverTime = 0;
    }
}
