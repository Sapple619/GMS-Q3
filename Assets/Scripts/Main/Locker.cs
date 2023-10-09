using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Locker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI LKtxt;
    public int LK;
    public void LKl(){
        if(LK!=10){
            LK = LK-1;
        }
        if(LK==0){
            LK=9;
        }
    }
    public void LKr(){
        if(LK!=10){
            LK = LK+1;
        }
        if(LK==10){
            LK=1;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        LK = 1;
    }

    // Update is called once per frame
    void Update()
    {
        LKtxt.text = ""+LK;
    }
}
