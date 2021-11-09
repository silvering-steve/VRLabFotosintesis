using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParentQuiz : MonoBehaviour
{
    public ParentPilihlahSoal _soalPilihlah;

    public GameObject bapakObjek;

    public GameObject halamanSelesai;
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtdesc;

    /// <summary>
    /// dipanggil apabila sudah menyelesaikan soal bagian Soal jenis Pilihlah
    /// </summary>
    public void QuizSelesai()
    {
        halamanSelesai.SetActive(true);
        
        var sekor = (GlobalVar.ScoreQuiz / 2) * 10;
        
        txtScore.text = "SCORE KAMU : " + sekor;

        txtdesc.text = sekor >= 80
            ? "Selamat! Anda mencapai Tuntas Belajar Percobaan Fotosintesis"
            : "Silakan Ulangi Eksperimen Anda!";
    }

    public void ClickSelesai()//destroy soal
    {
        GlobalVar.ScoreQuiz = 0;
        bapakObjek.SetActive(true);
        Destroy(gameObject);
    }
}
