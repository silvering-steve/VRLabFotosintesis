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

    public Color color;
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;

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
        var c = api.GetComponent<ParticleSystem>().colorOverLifetime;
        c.color = color;
    }

    public void ApiEnabled()
    {
        var a = GlobalVar.jumlahNahco3;
        var b = GlobalVar.tingkatCahaya;
        var c = api.GetComponent<ParticleSystem>().colorOverLifetime;
        
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
            c.color = color;
        }
    }

    private void AturCahaya()
    {
        var b = GlobalVar.tingkatCahaya;
        var c = api.GetComponent<ParticleSystem>().colorOverLifetime;
        
        //Light
        if (b == GlobalVar.TingkatCahaya.GELAP)
        {
            c.color = color;
        } 
        else if (b == GlobalVar.TingkatCahaya.SANGAT_REDUP)
        {
            c.color = color1;
        }
        else if (b == GlobalVar.TingkatCahaya.REDUP)
        {
            c.color = color2;
        }
        else if (b == GlobalVar.TingkatCahaya.TERANG)
        {
            c.color = color3;
        }
        else if (b == GlobalVar.TingkatCahaya.SANGAT_TERANG)
        {
            c.color = color4;
        }
    }

    private void AturNaHCO3()
    {
        var c = api.GetComponent<ParticleSystem>().colorOverLifetime;
        var a = GlobalVar.jumlahNahco3;

        //NaHCO3
        if (a == 0)
        {
            c.color = color;

        } 
        else if (a == 1)
        {
            c.color = color1;

        }
        else if (a == 2)
        {
            c.color = color2;

        }
        else if (a == 3)
        {
            c.color = color3;

        }
        else if (a == 4)
        {
            c.color = color4;

        }
        else if (a == 5)
        {
            c.color = color4;

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
