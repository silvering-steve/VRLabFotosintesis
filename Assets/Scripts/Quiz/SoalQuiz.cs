using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class SoalQuiz : MonoBehaviour
{

    public ParentPilihlahSoal parentSoal;
    public TextMeshProUGUI txtSoal;//text soalnya
    public TextMeshProUGUI txtSoalKe;//text untuk menunjukan ke user kita sedang ke soal berapa

    public List<int> list_indxJawaban;//digunakan untuk mengecek jawaban dia pada index ke berapa
    /// <summary>
    /// untuk mengecek jumlah jawaban yg sudah dipilih, apabila jumlah jawabannya sudah sama dengan indxjawaban
    /// maka akan melakukan pengecekan jawaban, apakah benar atau tidak
    /// </summary>
    public List<int> list_indxJawabanTerselect;

    public string str_soal;//menampung soal
    public int scoreBenar;//menampung jumlah score yg didapat

    [Header("BUTTON CLICK JAWABAN")]
    public List<PilihlahJawaban> list_pilihJawaban;

    /// <summary>
    /// untuk mengeset data soalnya dan juga jawaban
    /// </summary>
    /// <param name="soal"></param>
    public void SetData(string soal, List<int> _listJawaban,ParentPilihlahSoal _parentSoal)
    {
        parentSoal = _parentSoal;
        str_soal = soal;
        txtSoal.text = soal;
        list_indxJawaban = _listJawaban.ToList();
        txtSoalKe.text = "Pilihlah-" + (_parentSoal.indxSoal + 1).ToString() + "/" + (parentSoal.DataSoal.Count).ToString();

        //reset pilihjawaban
        foreach (var a in list_pilihJawaban)
        {
            a.Reset(this);
        }

    }

    public void InsertJawaban(int indxMasuk)
    {
        list_indxJawabanTerselect.Add(indxMasuk);

        //cek apakah jumlah list indx jawaban yg dipilih == list indxjawabannya
        if (list_indxJawaban.Count == list_indxJawabanTerselect.Count) // jika jumlahnya sudah sama
        {
            CheckJawaban();
        }
        else//jika belum
        {
            //do nothing
        }
    }

    public void CheckJawaban()
    {
        list_indxJawaban.Sort();
        list_indxJawabanTerselect.Sort();

        int i = 0;
        foreach (var a in list_indxJawaban)
        {

            if (a == list_indxJawabanTerselect[i])
            {
                GlobalVar.ScoreQuiz += 1;
            }            
            i++;
        }

        parentSoal.CheckSoal(GlobalVar.ScoreQuiz);

    }

}
