using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilihlahJawaban : MonoBehaviour
{
    public SoalQuiz soal;//menampung soal
    public Image imgBorder;
    public Color color_selected;//merubah warna yg diclick
    public Color color_default;//merubah warna menjadi default
    public int indxJawaban; // index dari jawaban

    public bool clicked = false;
    public Button btn;
    public AudioSource btnAudio;

    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(ClickJawaban);
    }

    

    public void Reset(SoalQuiz _soal)
    {
        soal = _soal;
        imgBorder.color = color_default;
        clicked = false;
    }


    public void ClickJawaban()
    {
        if (!clicked)
        {
            btnAudio.Play();
            clicked = true;
            imgBorder.color = color_selected;
            soal.InsertJawaban(indxJawaban);
        }
    }
}
