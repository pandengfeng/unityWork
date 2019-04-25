using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    //知道哪些对象可以点击
    //交换每个对象的坐标
    public LayerMask clickableLayer;



    //替换光标
    //光标纹理
    public Texture2D pointer; //正常纹理
    public Texture2D target; //目标纹理
    public Texture2D doorway; //门口纹理
    public Texture2D combat; //战斗


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {
            bool door = false;
            if (hit.collider.gameObject.tag == "Doorway")
            {
                Cursor.SetCursor(doorway, new Vector2(16, 16), CursorMode.Auto);
            }
       
            else {

                Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
             }
        }
        else
        {
            Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
        }
    }
}
