using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject[] prefabs;

<<<<<<< HEAD
    List<GameObject>[] pools;
=======
    public List<GameObject>[] pools;

>>>>>>> 45a962f740fd06ca80d52dd7ebf48c3ade8ccb33

    void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];

<<<<<<< HEAD
=======

>>>>>>> 45a962f740fd06ca80d52dd7ebf48c3ade8ccb33
        for(int index = 0; index < pools.Length; index++)
        {
            pools[index] = new List<GameObject>();
        }
        Debug.Log(pools.Length);
    }
    public GameObject Get(int index)
    {
        GameObject select = null;
        //...
        foreach(GameObject item in pools[index])
        {
            if (!item.activeSelf)
            {
                select= item;
                select.SetActive(true);
                break;
            }
        }

        if(!select)
        {
            select = Instantiate(prefabs[index], transform);
            pools[index].Add(select);
        }
<<<<<<< HEAD
=======
    }

    public GameObject Get(int index)
    {
        GameObject select = null;
>>>>>>> 45a962f740fd06ca80d52dd7ebf48c3ade8ccb33
        return select;
    }
}
