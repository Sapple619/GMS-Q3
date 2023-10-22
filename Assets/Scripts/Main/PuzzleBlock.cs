using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlock : MonoBehaviour
{
    [SerializeField]int now;
    PuzzleCheck Puzzle;

    public void Setnow(int where,PuzzleCheck p){
        now = where;
        Puzzle = p;
    }

    // Update is called once per frame
    public void Move()
    {
        if(now/4 != 0 && Puzzle.IsBlank(now,now-4)){
            now -= 4;
        }
        else if(now/4 != 3 && Puzzle.IsBlank(now,now+4)){
            now +=4;
        }
        else if(now%4 != 0 && Puzzle.IsBlank(now,now-1)){
            now--;
        }
        else if(now%4 != 3 && Puzzle.IsBlank(now,now+1)){
            now++;
        }
        Arrange();
    }

    public void Arrange(){
        GetComponent<RectTransform>().anchoredPosition = new Vector3(-300+(200*(now%4)), 300-(200*(now/4)),0);
    }
}
