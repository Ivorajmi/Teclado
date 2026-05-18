using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{

    public Key[] keys;

    // Start is called before the first frame update
    void Start()
    {
        keys = GameObject.FindObjectsOfType<Key>();
        if (keys.Length > 0)
        {
            int randomIndex = Random.Range(0, keys.Length);
            Destroy(keys[randomIndex].gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
