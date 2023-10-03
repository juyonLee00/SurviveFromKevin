using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Color m_oldColor = Color.white;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Renderer render = GetComponent<Renderer>();

        m_oldColor = render.material.color;
        render.material.color = Color.green;

        SceneManager.LoadScene(2);
    }

}
