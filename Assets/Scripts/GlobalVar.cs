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
        GELAP,
        SANGAT_REDUP,
        REDUP,
        TERANG,
        SANGAT_TERANG
    }
    public static TingkatCahaya tingkatCahaya = TingkatCahaya.GELAP;
    //============================================================================


    //======================SETTING PERCOBAAN NAHCO3 ============================//
    public static int jumlahNahco3;
    //============================================================================

}
