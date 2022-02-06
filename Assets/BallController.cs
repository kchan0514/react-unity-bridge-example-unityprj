using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class BallController : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void MoveCallback(string direction, int xpos, int ypos);

    public void ExecMoveCallback(string direction, int xpos, int ypos)
    {
#if UNITY_WEBGL == true && UNITY_EDITOR == false
        MoveCallback (direction, xpos, ypos);
#endif
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveRight(int position)
    { 
        this.gameObject.transform.position += new Vector3(position, 0, 0);
        ExecMoveCallback("right", (int)this.gameObject.transform.position.x, (int)this.gameObject.transform.position.y);
    }
    public void MoveLeft(int position)
    {
        this.gameObject.transform.position += new Vector3(-position, 0, 0);
        ExecMoveCallback("left", (int)this.gameObject.transform.position.x, (int)this.gameObject.transform.position.y);
    }
    public void MoveUp(int position)
    {
        this.gameObject.transform.position += new Vector3(0, position, 0);
        ExecMoveCallback("up", (int)this.gameObject.transform.position.x, (int)this.gameObject.transform.position.y);
    }
    public void MoveDown(int position)
    {
        this.gameObject.transform.position += new Vector3(0, -position, 0);
        ExecMoveCallback("down", (int)this.gameObject.transform.position.x, (int)this.gameObject.transform.position.y);
    }
}
