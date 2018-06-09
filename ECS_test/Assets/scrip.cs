using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class scrip : MonoBehaviour {

    public float speed;


}

class RotatorSystem : ComponentSystem
{
    //behavior
    struct Components
    {
       
        public RotatorSystem rotator;
        public Transform transform;
    }


    //will run every frame
    protected override void OnUpdate()
    {
        foreach(var e in GetEntities<Components>())
        {
            e.transform.Rotate(0f, e.rotator.speed * Time.deltaTime, 0f);
        }
    }
}
