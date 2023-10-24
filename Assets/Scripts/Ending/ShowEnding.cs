using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowEnding : MonoBehaviour
{
    [SerializeField] TMP_Text NameT;
    [SerializeField] TMP_Text TimeT;
    // Start is called before the first frame update
    void Start()
    {
        NameT.text = PlayerPrefs.GetString("PlayerName","최재령");
        TimeT.text = PlayerPrefs.GetString("time","??:??");
    }

}
