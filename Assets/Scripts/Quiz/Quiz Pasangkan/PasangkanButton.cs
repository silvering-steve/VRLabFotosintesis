using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasangkanButton : MonoBehaviour
{
    public Material mat;
    public enum StatusButton
    {
        KIRI = 1,
        KANAN
    }
    public StatusButton enum_status;

    /// <summary>
    /// index status button
    /// </summary>
    public int indxButton;

    /// <summary>
    /// buat ngecek, apakah sudah diclick atau belum
    /// </summary>
    public bool clicked;

    public ParentPasangkan parentSoal;
    public AudioSource audioButton;

    public Image img_border;
    public Color color_active;
    public Color color_default;
    
    private void Update()
    {
    
    }

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(ClickButton);
        img_border = GetComponent<Image>();
    }

    public void ClickButton()
    {
        if (clicked)
            return;
        else
        {
            //cek dulu sudah ada click atau belum
            if(parentSoal.clickWhere == ParentPasangkan.ClickStatus.NONE)//jika masih kosong
            {
                //cek status button dulu, kiri atau kanan
                if(enum_status == StatusButton.KIRI)
                {
                    parentSoal.clickWhere = ParentPasangkan.ClickStatus.KIRI;
                }
                else
                {
                    parentSoal.clickWhere = ParentPasangkan.ClickStatus.KANAN;
                }

                parentSoal.clickPertama = this;
                parentSoal.jumClick = 1;

                ColorActive();
            }
            else
            {
                if((int)parentSoal.clickWhere == (int)enum_status) // jika posisi yg diclick sama
                {
                    return;
                }
                else
                {
                    parentSoal.clickKedua = this;
                    parentSoal.jumClick = 2;
                }
            }

            clicked = true;
            audioButton.Play();

            if(parentSoal.jumClick == 2)
            {
                CreateLine();
            }
        }
    }

    public void ColorActive()
    {
        img_border.color = color_active;
    }

    public void ColorDefault()
    {
        img_border.color = color_default;
    }


    void CreateLine()
    {
        var titikAwal = parentSoal.clickPertama.gameObject.transform.GetChild(1).gameObject;
        var titikAkhir = parentSoal.clickKedua.gameObject.transform.GetChild(1).gameObject;

        Vector3 awal = new Vector3(titikAwal.transform.position.x, titikAwal.transform.position.y, 0);
        Vector3 akhir = new Vector3(titikAkhir.transform.position.x, titikAkhir.transform.position.y, 0);
        var line = gameObject.AddComponent<LineRenderer>();
        line.startWidth = 0.06f;
        line.material = mat;
        line.SetPosition(0, awal);
        line.SetPosition(1, akhir);

        var click1 = parentSoal.clickPertama.indxButton;
        var click2 = parentSoal.clickKedua.indxButton;

        if(click1 == click2)
        {
            GlobalVar.ScoreQuiz += 1;
        }

        parentSoal.clickPertama.ColorDefault();

        parentSoal.ResetClick();
        
        parentSoal.total += 1;
    }
    
    
}
