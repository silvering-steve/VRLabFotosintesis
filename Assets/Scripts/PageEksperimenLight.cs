using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageEksperimenLight : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem bubbleParticles;

    [SerializeField]
    private Image imgCahaya;

    [SerializeField]
    private ParticleSystem prefab_particle;

    [SerializeField]
    private Transform transform_parent_gelas;

    [SerializeField]
    private Slider slider;

    public void ChangeValueSlider(float value)
    {
        if(value >= 0 && value < 0.2)
        {
            //gelap
            GlobalVar.tingkatCahaya = GlobalVar.TingkatCahaya.GELAP;
            var a = bubbleParticles.emission;
            a.rateOverTime = 0;
        }
        else if(value >= 0.2 && value < 0.4)
        {
            //sangat redup
            GlobalVar.tingkatCahaya = GlobalVar.TingkatCahaya.SANGAT_REDUP;
            var a = bubbleParticles.emission;
            a.rateOverTime = 2;
        }
        else if(value >= 0.4 && value < 0.6)
        {
            //redup
            GlobalVar.tingkatCahaya = GlobalVar.TingkatCahaya.REDUP;
            var a = bubbleParticles.emission;
            a.rateOverTime = 4;
        }
        else if(value >= 0.6 && value < 0.8)
        {
            //terang
            GlobalVar.tingkatCahaya = GlobalVar.TingkatCahaya.TERANG;
            var a = bubbleParticles.emission;
            a.rateOverTime = 6;
        }
        else
        {
            //sangat terang
            GlobalVar.tingkatCahaya = GlobalVar.TingkatCahaya.SANGAT_TERANG;
            var a = bubbleParticles.emission;
            a.rateOverTime = 8;
        }

        float maxValueOpacity = 0.4f;
        float opacity = maxValueOpacity * value;
        imgCahaya.color = new Color(1,1,0,opacity);
    }


    private void OnEnable()
    {
        ResetData();
    }

    private void OnDisable()
    {
        Destroy(bubbleParticles.gameObject);
    }


    /// <summary>
    /// fungsi yang digunakan untuk mereset data, apabila masuk lagi ke halaman eksperimen light
    /// </summary>
    private void ResetData()
    {
        //instantiate bubble
        GameObject bbl = Instantiate(prefab_particle.gameObject, transform_parent_gelas.position, Quaternion.identity);
        bbl.SetActive(true);
        bubbleParticles = bbl.GetComponent<ParticleSystem>();


        GlobalVar.tingkatCahaya = GlobalVar.TingkatCahaya.GELAP;

        slider.value = 0f;

        ChangeValueSlider(slider.value);
    }
}
