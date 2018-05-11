using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuState : ISceneState {

    private Button mStartButton;

    public MainMenuState(SceneStateController controller) : base("02MainMenuScene", controller)
    {

    }
    public override void StateUpdate() { }     public override void StateStart()
    {
        mStartButton = GameObject.Find("StartButton").GetComponent<Button>();
        mStartButton.onClick.AddListener(OnStartButtonClick);
    }     public override void StateEnd() { }

    private void OnStartButtonClick()
    {
        mController.SetState(new BattleState(mController));
    }
}
