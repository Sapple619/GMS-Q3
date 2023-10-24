using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleCheck : MonoBehaviour
{
    int[] Puzzle = {6,0,7,10,1,8,9,5,12,4,13,2,11,14,15,3};
    [SerializeField] Sprite[] Picutre;
    [SerializeField] GameObject obj;
    [SerializeField] int Blank;
    [SerializeField] GameObject chest;
    [SerializeField] GameObject inside;
    [SerializeField] GameObject pan;
    private Vector3 originalSize;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i<16;i++){
            if(Puzzle[i] == Blank){
                continue;
            }
            GameObject NBlock =  Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
            NBlock.GetComponent<PuzzleBlock>().Setnow(i,this);
            NBlock.transform.SetParent(this.transform,false);
            NBlock.transform.localScale = new Vector3(1,1,0);
            NBlock.GetComponent<PuzzleBlock>().Arrange();
            NBlock.GetComponent<Image>().sprite = Picutre[Puzzle[i]];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsBlank(int now,int place){
        if(Puzzle[place] == Blank){
            Puzzle[place] = Puzzle[now];
            Puzzle[now] = Blank;
            return true;
        }
        return false;
    }

    public void Confirm(){
        for(int i = 0;i<16;i++){
            if(i != Puzzle[i]){
                return;
            }
        }
        pan.SetActive(false);
        chest.SetActive(false);
        inside.SetActive(true);
    }
}
