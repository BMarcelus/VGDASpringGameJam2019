using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeColliders : MonoBehaviour
{
    public GameObject shapeCollider;
    public float prefabSize;
    public int prefabsCount;
    // Start is called before the first frame update
    void Start()
    {
        AddPrefab();
        GetPrefabs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddPrefab()
    {
        for(int i=0;i<10;i++)
        {
            for(int j = 0; j < 10; j++)
            {
                var gameShape = Instantiate(shapeCollider, transform.position + Vector3.right * j * prefabSize + Vector3.down * i * prefabSize, transform.rotation);
                gameShape.transform.localScale *= prefabSize;
                prefabsCount += 1;
            }
        }
    }

    void GetPrefabs()
    {
        print(transform.childCount);
    }
}
