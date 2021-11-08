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
    
    [SerializeField]
    private Transform posisiPage;
    
    [SerializeField]
    private GameObject prefab_pengujian;

    [SerializeField] 
    private GameObject pengujian;
    
    [SerializeField] 
    private Transform mainFrame;
    
    public Animator anim;
    public Animator anim2;
    public Animator anim3;

    public void PlayAnim()
    {
        anim3.Play("Sendok");
    }
    
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
                anim2.enabled = false;
                anim.Play("LRev");
                a.rateOverTime = 0;
                break;
            case 1:
                anim.Play("Light");
                anim2.enabled = true;
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

    public void SetPengujian()
    {
        pengujian = Instantiate(prefab_pengujian.gameObject, posisiPage.position, Quaternion.identity);
        pengujian.SetActive(true);
        pengujian.transform.SetParent(mainFrame, false);
    }
}
