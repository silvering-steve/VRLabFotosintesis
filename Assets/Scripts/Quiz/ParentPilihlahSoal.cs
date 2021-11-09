using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ParentPilihlahSoal : MonoBehaviour
{
    [System.Serializable]
    public class Soal//digunakan untuk membikin soal
    {
        [SerializeField]
        private string title = "SOAL";
        public string soal;
        public int score;
        public List<int> list_indxJawaban;
    }
    [Header("DATA SOAL")]
    public List<Soal> DataSoal; // digunakan untuk menampung soal

    /// <summary>
    /// untuk menentukan index soal sekarang
    /// </summary>
    public int indxSoal;

    public int totalScore = 0;

    public ParentQuiz parentQuiz;

    [Header("PREFAB SOAL")]
    public GameObject prefab_soal;
    public Transform contentParent;
    public GameObject tampung_soal;

       
    public void Start()
    {

        //randomm soal
        var nilai_random = new System.Random();
        DataSoal = DataSoal.OrderBy(x => nilai_random.Next()).ToList();


        //tampilkan soal pertama
        CreateSoal();

    }

    public void CreateSoal()
    {
        GameObject newSoal = Instantiate(prefab_soal, contentParent);
        SoalQuiz _s = newSoal.GetComponent<SoalQuiz>();
        _s.SetData(DataSoal[indxSoal].soal, DataSoal[indxSoal].list_indxJawaban, this);
        newSoal.SetActive(true);

        tampung_soal = newSoal;
    }

    /// <summary>
    /// dipanggil ketika soal telah terjawab
    /// </summary>
    /// <param name="_scoreTerdapat">score yg didapatkan</param>
    public void CheckSoal(int _scoreTerdapat)
    {
        indxSoal++;
        totalScore += _scoreTerdapat;

        if(indxSoal >= DataSoal.Count) // jika soal sudah terjawab semua
        {
            // GlobalVar.ScoreQuiz += totalScore;
            parentQuiz.QuizSelesai();
        }
        else
        {
            GantiSoal();
        }
    }

    public void GantiSoal()
    {
        Destroy(tampung_soal);

        CreateSoal();
    }

}
