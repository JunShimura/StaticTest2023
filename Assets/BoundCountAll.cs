using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundCountAll : MonoBehaviour
{
    [SerializeField]
    public uint countSelf = 0;
    //[SerializeField]
    public static uint countAll = 0;
    // Start is called before the first frame update
    void Start()
    {
        countSelf = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.countSelf++;
        BoundCountAll.countAll++;
        Debug.Log($"at {gameObject.name}/countSelf={countSelf}/countAll={countAll}");

    }
    public uint CountAll()
    {
        return countAll;
    }

}
