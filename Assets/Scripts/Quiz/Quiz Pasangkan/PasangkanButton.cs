using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasangkanButton : MonoBehaviour
{
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
        Vector3 awal = new Vector3(parentSoal.clickPertama.transform.position.x, parentSoal.clickPertama.transform.position.y, 0);
        Vector3 akhir = new Vector3(parentSoal.clickKedua.transform.position.x, parentSoal.clickKedua.transform.position.y, 0);
        var line = gameObject.AddComponent<LineRenderer>();
        line.startWidth = 0.1f;
        line.SetPosition(0, awal);
        line.SetPosition(1, akhir);
        line.startColor = Color.blue;

        parentSoal.clickPertama.ColorDefault();

        parentSoal.ResetClick();
    }
}
