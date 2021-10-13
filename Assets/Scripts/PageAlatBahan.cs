﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PageAlatBahan : MonoBehaviour
{
    [Header("HALAMAN PERCOBAAN")]
    public GameObject page_cahaya;
    public GameObject page_nahco3;

    [Header("Group Button Alat dan bahan")]
    [SerializeField]
    private GameObject[] alat_bahan;

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
        SELESAI,
        MULAI
    }
    [SerializeField]
    private StateObj state_menu;//setting buat urutan menaruh obj

    [SerializeField]
    private GameObject[] urutan_img;

    [Header("PANEL ERROR")]
    [SerializeField]
    private GameObject panelError;

    [SerializeField]
    private bool animating = false; // cek, apakah sedang melakukan animasi atau tidak

    #region FUNGSI RESET
    public void ResetData()
    {

        foreach (var a in alat_bahan)
            a.SetActive(true);

        foreach (var a in urutan_img)
            a.SetActive(false);

        state_menu = StateObj.GELAS;
        animating = false;
        //imgPercobaan.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        GlobalVar.jumlahNahco3 = 0;
        GlobalVar.tingkatCahaya = GlobalVar.TingkatCahaya.GELAP;
        ResetData();
        state_menu = StateObj.MULAI;
    }
    #endregion


    #region FUNGSI CLICK ALAT BAHAN
    public void ClickGelas()
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state_menu != StateObj.GELAS)
        {
            return;
        }
        // gelas masuk;
        state_menu++;
        StartCoroutine(ie_gelas());

    }

    public void ClickKawat()
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state_menu != StateObj.KAWAT)
        {
            return;
        }
        // gelas masuk;
        state_menu++;
        StartCoroutine(ie_kawat());

    }

    public void ClickCorong()
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state_menu != StateObj.CORONG)
        {
            return;
        }
        // gelas masuk;
        state_menu++;
        StartCoroutine(ie_corong());
    }

    public void ClickTabung()
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state_menu != StateObj.TABUNG)
        {
            return;
        }
        // gelas masuk;
        state_menu++;
        StartCoroutine(ie_tabung());
    }

    public void ClickAir()
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state_menu != StateObj.AIR)
        {
            return;
        }
        // gelas masuk;
        state_menu++;
        StartCoroutine(ie_air());
    }
    public void ClickNahco()
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state_menu != StateObj.NAHCO)
        {
            return;
        }
        // gelas masuk;
        state_menu++;
        StartCoroutine(ie_nahco());
    }

    public void ClickTumbuhan()
    {
        if (animating)
            return;

        //cek kondisi sekarang, apakah sama
        if (state_menu != StateObj.TUMBUHAN)
        {
            return;
        }
        // gelas masuk;
        state_menu++;
        StartCoroutine(ie_tanaman());
    }
    #endregion



    #region IENUMERATOR ANIMASI
    IEnumerator ie_gelas()
    {
        animating = true;
        float speed = 10 * Time.deltaTime;
        float distance = 0f;

        GameObject p = Instantiate(obj_gelasKimia, obj_gelasKimia.transform);
        p.transform.parent = lokasi_gelas;

        distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);

        //disable obj gelas
        alat_bahan[(int)state_menu - 1].SetActive(false);

        while (distance >= 0.01f)
        {
            yield return Time.deltaTime;
            p.transform.position = Vector2.MoveTowards(p.transform.position, lokasi_gelas.transform.position, speed);
            distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);
        }
        p.SetActive(false);
        animating = false;
        //imgPercobaan.gameObject.SetActive(true);
        //imgPercobaan.sprite = urutan_img[(int)state_menu - 1];
        urutan_img[(int)state_menu - 1].SetActive(true);
    }

    IEnumerator ie_kawat()
    {
        animating = true;
        float speed = 10 * Time.deltaTime;
        float distance = 0f;

        GameObject p = Instantiate(kawat_pengait, kawat_pengait.transform);
        p.transform.parent = lokasi_gelas;

        distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);

        //disable obj gelas
        alat_bahan[(int)state_menu - 1].SetActive(false);

        while (distance >= 0.01f)
        {
            yield return Time.deltaTime;
            p.transform.position = Vector2.MoveTowards(p.transform.position, lokasi_gelas.transform.position, speed);
            distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);
        }
        p.SetActive(false);
        animating = false;
        //imgPercobaan.sprite = urutan_img[(int)state_menu - 1];
        urutan_img[(int)state_menu - 1].SetActive(true);
    }

    IEnumerator ie_corong()
    {
        animating = true;
        float speed = 10 * Time.deltaTime;
        float distance = 0f;

        GameObject p = Instantiate(corong_kaca, corong_kaca.transform);
        p.transform.parent = lokasi_gelas;

        distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);

        //disable obj gelas
        alat_bahan[(int)state_menu - 1].SetActive(false);

        while (distance >= 0.01f)
        {
            yield return Time.deltaTime;
            p.transform.position = Vector2.MoveTowards(p.transform.position, lokasi_gelas.transform.position, speed);
            distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);
        }
        p.SetActive(false);
        animating = false;
        //imgPercobaan.sprite = urutan_img[(int)state_menu - 1];
        urutan_img[(int)state_menu - 1].SetActive(true);
    }

    IEnumerator ie_tabung()
    {
        animating = true;
        float speed = 10 * Time.deltaTime;
        float distance = 0f;

        GameObject p = Instantiate(tabung_reaksi, tabung_reaksi.transform);
        p.transform.parent = lokasi_gelas;

        distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);

        //disable obj gelas

        alat_bahan[(int)state_menu - 1].SetActive(false);

        while (distance >= 0.01f)
        {
            yield return Time.deltaTime;
            p.transform.position = Vector2.MoveTowards(p.transform.position, lokasi_gelas.transform.position, speed);
            distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);
        }
        p.SetActive(false);
        animating = false;
        //imgPercobaan.sprite = urutan_img[(int)state_menu - 1];
        urutan_img[(int)state_menu - 1].SetActive(true);
    }

    IEnumerator ie_air()
    {
        animating = true;
        float speed = 10 * Time.deltaTime;
        float distance = 0f;

        GameObject p = Instantiate(obj_air, obj_air.transform);
        p.transform.parent = lokasi_gelas;

        distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);

        //disable obj gelas

        alat_bahan[(int)state_menu - 1].SetActive(false);

        while (distance >= 0.01f)
        {
            yield return Time.deltaTime;
            p.transform.position = Vector2.MoveTowards(p.transform.position, lokasi_gelas.transform.position, speed);
            distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);
        }
        p.SetActive(false);
        animating = false;
        //imgPercobaan.sprite = urutan_img[(int)state_menu - 1];
        urutan_img[(int)state_menu - 1].SetActive(true);
    }

    IEnumerator ie_nahco()
    {
        animating = true;
        float speed = 10 * Time.deltaTime;
        float distance = 0f;

        GameObject p = Instantiate(obj_kimia, obj_kimia.transform);
        p.transform.parent = lokasi_gelas;

        distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);

        //disable obj gelas

        alat_bahan[(int)state_menu - 1].SetActive(false);

        while (distance >= 0.01f)
        {
            yield return Time.deltaTime;
            p.transform.position = Vector2.MoveTowards(p.transform.position, lokasi_gelas.transform.position, speed);
            distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);
        }
        p.SetActive(false);
        animating = false;
        //imgPercobaan.sprite = urutan_img[(int)state_menu - 1];
        urutan_img[(int)state_menu - 1].SetActive(true);
    }

    IEnumerator ie_tanaman()
    {
        animating = true;
        float speed = 10 * Time.deltaTime;
        float distance = 0f;

        GameObject p = Instantiate(tanaman, tanaman.transform);
        p.transform.parent = lokasi_gelas;

        distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);

        //disable obj gelas

        alat_bahan[(int)state_menu - 1].SetActive(false);

        while (distance >= 0.01f)
        {
            yield return Time.deltaTime;
            p.transform.position = Vector2.MoveTowards(p.transform.position, lokasi_gelas.transform.position, speed);
            distance = Vector2.Distance(p.transform.position, lokasi_gelas.transform.position);
        }
        p.SetActive(false);
        animating = false;
        //imgPercobaan.sprite = urutan_img[(int)state_menu - 1];
        urutan_img[(int)state_menu - 1].SetActive(true);
    }
    #endregion

    public void ClickNext()
    {
        if (state_menu != StateObj.SELESAI)
        {
            panelError.SetActive(true);
            return;
        }

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

    public void ClickSiapkanAlatBahan()
    {
        if (state_menu == StateObj.MULAI)
            state_menu = StateObj.GELAS;
    }
}