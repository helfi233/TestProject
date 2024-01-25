using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatPrimitive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {  //создаем примитивы кубы с определеными позициями для того чтобы они появились форме стива из майнкрафта у камеры
        GameObject.CreatePrimitive
        (PrimitiveType.Cube).transform.position = new Vector3(0,0,0);
         GameObject.CreatePrimitive
        (PrimitiveType.Cube).transform.position= new Vector3(-0.5f, 1, 0);
         GameObject.CreatePrimitive
        (PrimitiveType.Cube).transform.position = new Vector3(0.5f, 1, 0);
         GameObject.CreatePrimitive
        (PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2, 0);
         GameObject.CreatePrimitive
        (PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2, 0);
         GameObject.CreatePrimitive
        (PrimitiveType.Cube).transform.position = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
