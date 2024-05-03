using Cysharp.Threading.Tasks;
using GameSystemSDK.Common.Domain;
using System.Collections.Generic;

namespace GameSystemSDK.BattleScene.Domain
{
    /// <summary>
    /// Stage ���� ������ �ҷ����� Ŭ����
    /// </summary>
    public interface IStageInfoImporterDomain
    {
        IReadOnlyList<IStageInfoData> List { get; }

        UniTask<IResult<IReadOnlyList<IStageInfoData>>> LoadBattleInfo(string rawData);
        IStageInfoData GetBattleInfo( int index );
        IStageInfoData GetBattleInfo(string id);
    }
}
