using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageAlatBahan : MonoBehaviour
{
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
    private void Update()
    {
        if (startGlass)
            obj_gelasKimia.transform.position = Vector2.MoveTowards(obj_gelasKimia.transform.position, lokasi_gelas.transform.position, 10 * Time.deltaTime);
    }

    public void ClickGelas()
    {
        obj_gelasKimia.transform.parent = obj_meja.transform;
        startGlass = true;
    }



}
