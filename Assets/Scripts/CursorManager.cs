using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    // REF FOR RENDER.
    //public bool needsRender;

    // REF FOR TYPE OF CURSOR CONTEXT.
    //public bool isBusyWithButton;

    public Texture2D cursorGeneral;
    public Texture2D cursorClick;
    


    // Start is called before the first frame update
    void Start()
    {

            Cursor.SetCursor(cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);

    }

    public void Update()
    {
        //if (isBusyWithButton == false)
        //{
            if (Input.GetMouseButtonDown(0))
            {

                    Cursor.SetCursor(cursorClick, Vector2.zero, CursorMode.ForceSoftware);

            }


            else if (Input.GetMouseButtonUp(0))
            {


                    Cursor.SetCursor(cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);

                    //mouse_over_clicked = false;

            }
        //}
    }
}
