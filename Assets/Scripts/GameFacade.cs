using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFacade{

    private static GameFacade _instance;
    public static GameFacade Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameFacade();
            return _instance;
        }
    }

    private GameFacade() { }

    private ArchievementSystem mArchievementSystem;
    private CampSystem mCampSystem;
    private CharacterSystem mCharacterSystem;
    private EnergySystem mEnergySystem;
    private StageSystem mStageSystem;

    private CampInfoUI mCampInfoUI;
    private GamePauseUI mGamePauseUI;
    private GameStateInfo mGameStateInfo;
    private SoldierInfoUI mSoldierInfoUI;

    private bool mIsGameOver = false;
    public bool isGameOver { get { return mIsGameOver; } }

    public void Init()
    {
        mArchievementSystem = new ArchievementSystem();
        mCampSystem = new CampSystem();
        mCharacterSystem = new CharacterSystem();
        mEnergySystem = new EnergySystem();
        mStageSystem = new StageSystem();

        mCampInfoUI = new CampInfoUI();
        mGamePauseUI = new GamePauseUI();
        mGameStateInfo = new GameStateInfo();
        mSoldierInfoUI = new SoldierInfoUI();

        mArchievementSystem.Init();
        mCampSystem.Init();
        mCharacterSystem.Init();
        mEnergySystem.Init();
        mStageSystem.Init();

        mCampInfoUI.Init();
        mGamePauseUI.Init();
        mGameStateInfo.Init();
        mSoldierInfoUI.Init();


    }

    public void Update()
    {
        mArchievementSystem.Update();
        mCampSystem.Update();
        mCharacterSystem.Update();
        mEnergySystem.Update();
        mStageSystem.Update();

        mCampInfoUI.Update();
        mGamePauseUI.Update();
        mGameStateInfo.Update();
        mSoldierInfoUI.Update();
    }

    public void Destroy()
    {
        mArchievementSystem.Release();
        mCampSystem.Release();
        mCharacterSystem.Release();
        mEnergySystem.Release();
        mStageSystem.Release();

        mCampInfoUI.Release();
        mGamePauseUI.Release();
        mGameStateInfo.Release();
        mSoldierInfoUI.Release();
    }
}
