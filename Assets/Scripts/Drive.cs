using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 100.0f;
    public Transform transGun;
    public Transform gun;
    public GameObject bulletObj;


    void Update()
    {
        // Pega as entradas do jogador e multiplica pela velocidade e tempo
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        // Move no eixo Z
        transform.Translate(0, 0, translation);

        // Rotaciona no eixo Y
        transform.Rotate(0, rotation, 0);

        
        
            if (Input.GetKey(KeyCode.T))
            {
                // Acessa o transform para usar position, right e RotateAround
                transGun.RotateAround(transGun.position, transGun.right, -2);
            }
            else if(Input.GetKey(KeyCode.G))
            {
                transGun.RotateAround(transGun.position, transGun.right, 2);
            }
           
            else if (Input.GetKeyDown(KeyCode.B))
            {
                Instantiate(bulletObj, gun.position, gun.rotation);
            }
        }
    }




