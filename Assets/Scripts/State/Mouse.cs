//Mouse handler class as a singleton

public class Mouse {
     private static Mouse instance = null;
     private  IMouseState mouseState;

    public Mouse() {}

    
    public static Mouse Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Mouse();
            }
            return instance;
        }
        
    }

    
    
    public void SetState(IMouseState state)
    {
        if(mouseState!=null)
        {
            mouseState.OnExitState();
        }
        mouseState=state;

        if(mouseState!=null)
        {
            mouseState.OnEnterState();
        }
    }

    public void Update()
    {
        if(mouseState!=null)
        {
            mouseState.OnUpdateState();
        }
    }
}