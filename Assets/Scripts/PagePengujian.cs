using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PagePengujian : MonoBehaviour
{
    public Button reset;
    public Button play;

    public GameObject api;
    public GameObject exit;

    [SerializeField]
    private int NaHCO3;
    
    [SerializeField]
    private GlobalVar.TingkatCahaya Light;

    private void Update()
    {
        NaHCO3 = GlobalVar.jumlahNahco3;
        Light = GlobalVar.tingkatCahaya;
    }

    public void ResetEnabled()
    {
        reset.interactable = true;
        play.interactable = false;
        ApiEnabled();
    }

    public void PlayEnabled()
    {
        play.interactable = true;
        reset.interactable = false;
    }

    public void ApiDisabled()
    {
        var a =api.GetComponent<ParticleSystem>().emission;
        a.rateOverTime = 0;
    }

    public void ApiEnabled()
    {
        var a = GlobalVar.jumlahNahco3;
        var b = GlobalVar.tingkatCahaya;
        var c =api.GetComponent<ParticleSystem>().emission;
        
        if (a == 0 && b != 0)
        {
            AturCahaya();
        }
        else if (a != 0 && b == 0)
        {
            AturNaHCO3();
        }
        else
        {
            c.rateOverTime = 0;
        }
    }

    private void AturCahaya()
    {
        var b = GlobalVar.tingkatCahaya;
        var c = api.GetComponent<ParticleSystem>().emission;
        
        //Light
        if (b == GlobalVar.TingkatCahaya.GELAP)
        {
            c.rateOverTime = 0;
        } 
        else if (b == GlobalVar.TingkatCahaya.SANGAT_REDUP)
        {
            c.rateOverTime = 5;
        }
        else if (b == GlobalVar.TingkatCahaya.REDUP)
        {
            c.rateOverTime = 13;
        }
        else if (b == GlobalVar.TingkatCahaya.TERANG)
        {
            c.rateOverTime = 20;
        }
        else if (b == GlobalVar.TingkatCahaya.SANGAT_TERANG)
        {
            c.rateOverTime = 35;
        }
    }

    private void AturNaHCO3()
    {
        var c = api.GetComponent<ParticleSystem>().emission;
        var a = GlobalVar.jumlahNahco3;

        //NaHCO3
        if (a == 0)
        {
            c.rateOverTime = 0;
        } 
        else if (a == 1)
        {
            c.rateOverTime = 5;
        }
        else if (a == 2)
        {
            c.rateOverTime = 13;
        }
        else if (a == 3)
        {
            c.rateOverTime = 20;
        }
        else if (a == 4)
        {
            c.rateOverTime = 35;
        }
        else if (a == 5)
        {
            c.rateOverTime = 35;
        }
    }

    private void OnDisable()
    {
        Destroy(this.gameObject);
    }

    public void Exit()
    {
        exit.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
