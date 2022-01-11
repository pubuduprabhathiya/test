using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    enum State
    {
        working,
        jumping,
        standing
    };
    private Command movecmd;
    private Command firecmd;
    [SerializeField]private Player player;

    private State curstate;
    private void Awake()
    {
        movecmd = new MoveCommand();
        firecmd = new FireCommand();
    }
    // Start is called before the first frame update
    void Start()
    {
        curstate = State.standing;
    }

    // Update is called once per frame
    void Update()
    {
        handleInput();

    }

    public void handleInput() {
        switch (curstate) {
            case State.standing:
                if (Input.GetKey("w"))
                {
                    curstate = State.working;
                    movecmd.execute(player);
                }
                if (Input.GetMouseButtonDown(0))
                {
                    firecmd.execute(player);
                }
                if (Input.GetKey("space"))
                {
                    movecmd.execute(player);
                    curstate = State.jumping;
                }
                break;
            case State.working:
                if (Input.GetKey("w"))
                {
                    movecmd.execute(player);
                }
                
                if (Input.GetMouseButtonDown(0))
                {
                    firecmd.execute(player);
                }
                if (Input.GetKey("space"))
                {
                    movecmd.execute(player);
                    curstate = State.jumping;
                }
                else if (Input.GetKeyUp("w")) {
                    curstate = State.standing;
                }

                    break;
            case State.jumping:
                if (Input.GetMouseButtonDown(0))
                {
                    firecmd.execute(player);
                }
                if (Input.GetKeyUp("space")) {
                    curstate = State.standing;
                }
                break;
         

        }
       
    }
}
