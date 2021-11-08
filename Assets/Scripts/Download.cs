using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Download : MonoBehaviour
{
    public void Unduh()
    {
        Application.OpenURL("https://drive.google.com/uc?export=download&id=1T2HCTVelMFINZuag4IGwGjJN-0TLAi4y");
    }
}
