using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarImagen : MonoBehaviour
{
    public Camera camera;

    public GameObject plano1, plano2;
    int currentImage = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray  = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                Debug.Log(hitInfo.collider.gameObject.name);
                
                if(hitInfo.collider.gameObject.tag == "Plano") 
                {
                    currentImage++;
                    if(currentImage>2)
                    {
                        currentImage = 1;
                    }
                    Debug.Log(currentImage);
                }
            }

            if(currentImage == 1)
            {
                plano1.SetActive(true);
                plano2.SetActive(false);
            }else 
            {
                plano2.SetActive(true);
                plano1.SetActive(false);
            }
        }
    }
}
