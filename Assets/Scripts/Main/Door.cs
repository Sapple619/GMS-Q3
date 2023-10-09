using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsLocked;
    [SerializeField] private GameObject InsideObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Open()
    {
        if(!IsLocked){
            InsideObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
