using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVar
{
    public enum CaseEksperimen
    {
        EKSPERIMEN_LIGHT,
        EKSPERIMEN_NAHCO3
    }

    /// <summary>
    /// setting untuk mengecek, apakah dia eksperimen dengan cahaya, atau dengan nahco3
    /// </summary>
    public static CaseEksperimen caseEksperimen = CaseEksperimen.EKSPERIMEN_LIGHT;
    

    //======================SETTING PERCOBAAN CAHAYA ============================//
    public enum TingkatCahaya
    {
        GELAP, // Bara api sangat kecil
        SANGAT_REDUP, // Bara api kecil
        REDUP, // Bara api sedang
        TERANG, // Bara api besar
        SANGAT_TERANG // Bara api besar sekali
    }
    public static TingkatCahaya tingkatCahaya = TingkatCahaya.GELAP;
    //============================================================================


    //======================SETTING PERCOBAAN NAHCO3 ============================//
    public static int jumlahNahco3;
    //============================================================================


    public static int ScoreQuiz;

}
