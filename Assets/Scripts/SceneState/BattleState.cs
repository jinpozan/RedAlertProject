using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : ISceneState {

    private GameFacade mFacade;

    public BattleState(SceneStateController controller) : base("03BattleScene", controller){}
    public override void StateUpdate() {

        if (mFacade.isGameOver)
            mController.SetState(new MainMenuState(mController));
        mFacade.Update();
    }     public override void StateStart() {
        mFacade = GameFacade.Instance;
        mFacade.Init();
    }     public override void StateEnd() {
        mFacade.Destroy();
    }
}
