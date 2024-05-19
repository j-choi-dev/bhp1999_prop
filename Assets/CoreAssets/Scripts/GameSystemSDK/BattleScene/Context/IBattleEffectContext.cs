using Cysharp.Threading.Tasks;
using GameSystemSDK.BattleScene.Domain;
using System;
using UnityEngine;

namespace GameSystemSDK.BattleScene.Application
{
    /// <summary>
    /// @Auth Choi
    /// ���� ���� Context
    /// </summary>
    public interface IBattleEffectContext
    {
        IObservable<string> OnSkillNameChanged { get; }
        IObservable<(int index, int score)> OnScoreInfoChanged { get; }
        IObservable<bool> OnIsEffectProccess { get; }
        UniTask RunScoreEffectProcess( IDetailScoreInfo detail, AudioClip effect );

        void SelectHandProcess(IHandConditionInfo conditionInfo);
    }
}
