using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public GameObject Fruit;
    public int deleteTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(Fruit, deleteTime);
    }
}
