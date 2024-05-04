using Cysharp.Threading.Tasks;
using System;
using UnityEngine;

namespace GameSystemSDK.BattleScene.Domain
{
    /// <summary>
    /// Effect ���� ���� Domain Interface
    /// </summary>
    public interface IBattleEffectLaunchDomain
    {
        IObservable<string> OnSkillNameChanged { get; }
        IObservable<string> OnScoreInfoChanged { get; }
        IObservable<bool> OnIsEffectProccess { get; }
        UniTask RunScoreEffectProcess( IDetailScoreInfo detail, AudioClip effect );
    }
}
