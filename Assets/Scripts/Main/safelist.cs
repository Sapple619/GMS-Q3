using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class safelist : MonoBehaviour
{
    [SerializeField] int sfn;
    [SerializeField] TextMeshProUGUI sfltxt;
    [SerializeField] private GameObject safepanObject;
    [SerializeField] private GameObject safeOutObject;
    [SerializeField] private GameObject safeInsideObject;
    [SerializeField] public int[] sfar = new int[4];
    public void SFcheck(){
        if(sfar[0]==2 && sfar[1]==6 && sfar[2]==1 && sfar[3]==8){
            safepanObject.SetActive(false);
            safeOutObject.SetActive(false);
            safeInsideObject.SetActive(true);
        }
        sfar[0] = 0;
        sfar[1] = 0;
        sfar[2] = 0;
        sfar[3] = 0;
        sfn = 0;
        sfltxt.text = ""+sfar[0]+sfar[1]+sfar[2]+sfar[3];
    }


    // Start is called before the first frame update
    void Start()
    {
        sfn = 0;
        sfltxt.text = ""+sfar[0]+sfar[1]+sfar[2]+sfar[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void numberput(int SF){
        if(sfn<4){
            sfar[sfn] = SF;
            sfn = sfn+1;
            sfltxt.text = ""+sfar[0]+sfar[1]+sfar[2]+sfar[3];
        }
        
    }
}
