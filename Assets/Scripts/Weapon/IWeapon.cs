using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IWeapon {

    protected int mAtk;
    protected float mAtkRange;
    protected int mAtkPlusValue;

    protected GameObject mGameObject;
    protected ICharacter mOwner;
    protected ParticleSystem mParticle;
    protected LineRenderer mLine;
    protected Light mLight;
    protected AudioSource mAudio;
    protected float mEffectDisplayTime;

    public void Fire(Vector3 targetPosition)
    {
        PlayMuzzleEffect();
        PlayBulletEffect(targetPosition);
        SetEffectDisplayTime();
        PlaySound();
    }

    public void Update()
    {
        if(mEffectDisplayTime > 0)
        {
            mEffectDisplayTime -= Time.deltaTime;
            if(mEffectDisplayTime <= 0)
            {
                DisplayEffect();
            }
        }
    }

    protected abstract void SetEffectDisplayTime();

    protected virtual void PlayMuzzleEffect()
    {
        mParticle.Stop();
        mParticle.Play();
        mLight.enabled = true;
    }

    protected abstract void PlayBulletEffect(Vector3 targetPosition);


    protected void DoPlayBulletEffect(float width,Vector3 targetPosition)
    {
        mLine.enabled = true;
        mLine.startWidth = width;
        mLine.endWidth = width;
        mLine.SetPosition(0, mGameObject.transform.position);
        mLine.SetPosition(1, targetPosition);
    }

    protected abstract void PlaySound();

    protected void DoPlaySound(string clipName)
    {
        AudioClip clip = null; // TODO
        mAudio.clip = clip;
        mAudio.Play();
    }

    private void DisplayEffect()
    {
        mLine.enabled = false;
        mLight.enabled = false;
    }

}
