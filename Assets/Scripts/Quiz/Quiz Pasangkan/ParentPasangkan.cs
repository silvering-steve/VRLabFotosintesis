using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPasangkan : MonoBehaviour
{
    public enum ClickStatus
    {
        NONE = 0,
        KIRI,
        KANAN
    }
    /// <summary>
    /// untuk mengecek,kondisi sekarang sedang click yg mana sebelumnya
    /// </summary>
    public ClickStatus clickWhere;

    /// <summary>
    /// 0 = belum ada yg diclick buat dipasangkan
    /// 1 = baru click 1x
    /// 2 = click ke 2, untuk memasangkan garis, lalu mereset nilainya
    /// </summary>
    public int jumClick = 0;

    public PasangkanButton clickPertama; // untuk menyimpan data click yg pertama
    public PasangkanButton clickKedua; // untuk menyimpan data click yg kedua

    public void ResetClick()
    {
        clickPertama = null;
        clickKedua = null;
        clickWhere= ClickStatus.NONE;
        jumClick = 0;
    }
}
