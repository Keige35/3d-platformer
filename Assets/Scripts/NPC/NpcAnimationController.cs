using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAnimationController : MonoBehaviour
{
    private Animator _animator;
    private Dictionary<NpcAnimationType, int> hashStorage = new Dictionary<NpcAnimationType, int>();

    public Animator Animator => _animator;

    public NpcAnimationController(Animator animator)
    {
        _animator = animator;
        foreach (NpcAnimationType caType in Enum.GetValues(typeof(NpcAnimationType)))
        {
            hashStorage.Add(caType, Animator.StringToHash(caType.ToString()));
        }
    }

    public void SetBool(NpcAnimationType animationType, bool value)
    {
        _animator.SetBool(hashStorage[animationType], value);
    }

    public void SetFloat(NpcAnimationType animationType, float value)
    {
        _animator.SetFloat(hashStorage[animationType], value);
    }

    public void SetPlay(NpcAnimationType characterAnimationType)
    {
        _animator.Play((hashStorage[characterAnimationType]));
    }

    public void SetTrigger(NpcAnimationType characterAnimationType)
    {
        _animator.SetTrigger((hashStorage[characterAnimationType]));
    }

    public bool IsAnimationPlay(string animationStateName)
    {
        return _animator.GetCurrentAnimatorStateInfo(0).IsName(animationStateName);
    }

    public float NormalizedAnimationPlayTime()
    {
        return _animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }
}
public enum NpcAnimationType
{
    Idle,
    Walk,
    Run,
    Dead,
    Eat,
}