using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public GameObject LKF;
    public GameObject lckro;
    [SerializeField] Locker[] lockers;
    [SerializeField] Door dr;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LKC(){
        if(lockers[0].LK==5 && lockers[1].LK==4 && lockers[2].LK==5 && lockers[3].LK==2){
            LKF.gameObject.SetActive(false);
            lckro.gameObject.SetActive(false);
            dr.IsLocked = false;
        }
    }
}
