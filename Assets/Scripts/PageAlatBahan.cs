using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageAlatBahan : MonoBehaviour
{
    [Header("HALAMAN PERCOBAAN")]
    public GameObject page_cahaya;
    public GameObject page_nahco3;

    [SerializeField]
    public GameObject obj_gelasKimia;

    [SerializeField]
    public GameObject kawat_pengait;

    [SerializeField]
    public GameObject corong_kaca;

    [SerializeField]
    public GameObject tabung_reaksi;

    [SerializeField]
    public GameObject obj_air;

    [SerializeField]
    public GameObject obj_kimia;

    [SerializeField]
    public GameObject tanaman;

    [SerializeField]
    public GameObject obj_meja;


    [Header("LOKASI POSISI")]
    [SerializeField]
    private Transform lokasi_gelas;
    bool startGlass;

    public enum StateObj
    {
        GELAS = 0,
        KAWAT,
        CORONG,
        TABUNG,
        AIR,
        NAHCO,
        TUMBUHAN,
        SELESAI
    }
    [SerializeField]
    private StateObj state_menu;//setting buat urutan menaruh obj

    [SerializeField]
    private Sprite[] urutan_img;

    [SerializeField]
    private bool animating = false; // cek, apakah sedang melakukan animasi atau tidak
    private void Update()
    {
        //if (startGlass)
        //    obj_gelasKimia.transform.position = Vector2.MoveTowards(obj_gelasKimia.transform.position, lokasi_gelas.transform.position, 10 * Time.deltaTime);
    }

    public void ClickItem(StateObj state)
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state != state_menu)
        {
            return;
        }

        switch (state)
        {
            case StateObj.GELAS:
                {
                    if (state_menu == StateObj.GELAS)
                    {
                        // gelas masuk;
                        state_menu++;
                        StartCoroutine(ie_gelas());
                    }
                    else
                        break;
                }
                break;
            case StateObj.KAWAT:
                {
                    if (state_menu == StateObj.KAWAT)
                    {
                        // kawat masuk;
                        state_menu++;
                    }
                    else
                        break;
                }
                break;
            case StateObj.CORONG:
                {
                    if (state_menu == StateObj.CORONG)
                    {
                        // corong masuk;
                        state_menu++;
                    }
                    else
                        break;
                }
                break;
            case StateObj.TABUNG:
                {
                    if (state_menu == StateObj.TABUNG)
                    {
                        // tabung masuk;
                        state_menu++;
                    }
                    else
                        break;
                }
                break;
            case StateObj.AIR:
                {
                    if (state_menu == StateObj.AIR)
                    {
                        // air masuk;
                        state_menu++;
                    }
                    else
                        break;
                }
                break;
            case StateObj.NAHCO:
                {
                    if (state_menu == StateObj.NAHCO)
                    {
                        // nahco masuk;
                        state_menu++;
                    }
                    else
                        break;
                }
                break;
            case StateObj.TUMBUHAN:
                {
                    if (state_menu == StateObj.TUMBUHAN)
                    {
                        // tumbuhan masuk;
                        state_menu++;
                    }
                    else
                        break;
                }
                break;
        }
    }

    public void ClickGelas()
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state_menu != StateObj.GELAS)
        {
            return;
        }

        obj_gelasKimia.transform.parent = obj_meja.transform;
        // gelas masuk;
        state_menu++;
        StartCoroutine(ie_gelas());

    }

    public void ClickNext()
    {
        gameObject.SetActive(false);

        //cek 
        if (GlobalVar.caseEksperimen == GlobalVar.CaseEksperimen.EKSPERIMEN_LIGHT)
        {
            //buka halaman cahaya
            page_cahaya.SetActive(true);
        }
        else
        {
            //buka halaman nahco
            page_nahco3.SetActive(true);
        }
    }

    IEnumerator ie_gelas()
    {
        animating = true;
        float speed = 10 * Time.deltaTime;
        float distance = 0f;
        distance = Vector2.Distance(obj_gelasKimia.transform.position, lokasi_gelas.transform.position);
        while (distance >= 0.01f)
        {
            yield return Time.deltaTime;
            obj_gelasKimia.transform.position = obj_gelasKimia.transform.position = Vector2.MoveTowards(obj_gelasKimia.transform.position, lokasi_gelas.transform.position, speed);
            distance = Vector2.Distance(obj_gelasKimia.transform.localPosition, lokasi_gelas.transform.localPosition);
        }
        animating = false;
    }
}