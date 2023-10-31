using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform ballInstance;
    [SerializeField]
    Vector3 ballStart=new Vector3 (-5,0,0);
    [SerializeField]
    Vector3 ballend = new Vector3(5, 0, 0);
    [SerializeField]
    uint nBall = 5;
    //BoundCountAll boundCountAll = new BoundCountAll();

    void Start()
    {
        for(int i = 0; i < nBall; i++) {
            var ball =GameObject.Instantiate(
                ballInstance,
                Vector3.Lerp(ballStart,ballend,(float)i/nBall),
                Quaternion.identity);
            ball.gameObject.name=$"ball[{i}]";
        }
        var l0 = ballStart.magnitude;
        var l1 = Vector3.Magnitude(ballStart);
        var t0 = transform.forward;
        var t1 = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Debug.Log($"BALL MANAGER countAll={BoundCountAll.countAll}");
        } 
    }
}
