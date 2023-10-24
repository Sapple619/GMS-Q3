using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject stamp;
    [SerializeField] GameObject topSecret;
    public void start(){
        SceneManager.LoadScene("Start");
    }
    public void main(){
        stamp.SetActive(true);
        topSecret.SetActive(true);
        StartCoroutine(WaitForIt());
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main");
    }
}
