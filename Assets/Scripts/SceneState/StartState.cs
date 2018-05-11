using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.UI;  public class StartState :ISceneState {      private Image mLogo;     private float mSmoothingSpeed = 1f;     private float mWaitTime = 2f;     public StartState(SceneStateController controller):base("01StartScene",controller)
    {

    }      public override void StateUpdate()
    {
        mLogo.color = Color.Lerp(mLogo.color, Color.white, mSmoothingSpeed * Time.deltaTime);

        mWaitTime -= Time.deltaTime;
        if(mWaitTime < 0f)
        {
            mController.SetState(new MainMenuState(mController));
        }
    }     public override void StateStart()
    {
        base.StateStart();
        mLogo = GameObject.Find("Logo").GetComponent<Image>();
        mLogo.color = Color.black;

    }     public override void StateEnd() { } } 