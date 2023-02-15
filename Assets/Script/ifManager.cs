using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifManager : MonoBehaviour
{
    public GameObject[] Mons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Monster()
    {
        int monNum = Random.Range(0, Mons.Length);

        if (GameObject.FindGameObjectWithTag("Enemy"))
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));

        switch (monNum)
        {
            case 0:
                {
                    Debug.Log("몬스터 0번");
                    Instantiate(Mons[0]);
                }break;
            case 1: 
                {
                    Debug.Log("몬스터 1번");
                    Instantiate(Mons[1]);
                }
                break;
            case 2:
                {
                    Debug.Log("몬스터 2번");
                    Instantiate(Mons[2]);
                }
                break;
            case 3:
                {
                    Debug.Log("몬스터 3번");
                    Instantiate(Mons[3]);
                }
                break;
            default:
                break;
        }
    }
}
