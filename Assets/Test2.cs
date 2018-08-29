using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Boss
{
    private int mp = 53;    //MP値

    //魔法攻撃をする関数
    public int Magic(int magic)
    {
        
       
            if (mp >= magic)
            {
                mp -= magic;

                Debug.Log("魔法攻撃をした。残りMPは。"+mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
           
        
        return mp;
    }


}


public class Test2 : MonoBehaviour {

	// Use this for initialization

       
	void Start () {
        Boss lastboss = new Boss();
        int i;
        for (i = 0; i <= 10; i++)
        {


            lastboss.Magic(5);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
