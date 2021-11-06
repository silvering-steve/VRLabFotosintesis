using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParentQuiz : MonoBehaviour
{
    public ParentPilihlahSoal _soalPilihlah;

    public GameObject halamanSelesai;
    public TextMeshProUGUI txtScore;

    private void Start()
    {
        //reset nilai score quiz
        GlobalVar.ScoreQuiz = 0;
    }


    /// <summary>
    /// dipanggil apabila sudah menyelesaikan soal bagian Soal jenis Pilihlah
    /// </summary>
    public void QuizSelesai(int _score)
    {
        halamanSelesai.SetActive(true);

        txtScore.text = "SCORE KAMU : " + _score;
    }

    public void ClickSelesai()//destroy soal
    {
        Destroy(gameObject);
    }
}
