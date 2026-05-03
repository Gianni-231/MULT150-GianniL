using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{    public GameObject prefab;
      public float spacing = 2f;
      int amount = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amount; i++)
    {
        Vector3 position = transform.position + new Vector3(0, 0, i * spacing);
        Instantiate(prefab, position, transform.rotation);
    }
    }

   void Update()
      {
          
          if (Input.GetKeyDown(KeyCode.B))
          {
               Instantiate(prefab);
          }
          if (Input.GetKeyDown(KeyCode.Space))
          {
               Instantiate(prefab, transform.position, transform.rotation);
          }
      }
}
