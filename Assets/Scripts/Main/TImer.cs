using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TImer : MonoBehaviour
{
    double time = 0;
    [SerializeField] TMP_Text time_T;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time%60 < 10){
            time_T.text = "0"+(int)time/60+":0"+(int)time%60;
        }
        else{
            time_T.text = (int)time/60+":"+(int)time%60;
        }
    }
}
