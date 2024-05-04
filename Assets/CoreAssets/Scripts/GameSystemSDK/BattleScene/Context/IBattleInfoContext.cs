using Cysharp.Threading.Tasks;
using GameSystemSDK.BattleScene.Domain;
using GameSystemSDK.Common.Domain;
using System.Collections.Generic;

namespace GameSystemSDK.BattleScene.Application
{
    /// <summary>
    /// @Auth Choi 
    /// Stage ���࿡ �ʿ��� ������ ���
    /// </summary>
    public interface IBattleInfoContext
    {
        /// <summary>
        /// �������� ���� ������ ����Ʈ
        /// </summary>
        IReadOnlyList<IStageInfoData> StageInfoList { get; }
        IReadOnlyList<IHandInfoData> HandInfoDataList { get; }
        IReadOnlyDictionary<int, IHandConditionData> HandConditionDictionary { get; }

        /// <summary>
        /// �������� ���� ������ ����Ʈ�� �ε�
        /// </summary>
        /// <returns>�������� ���� ������ ����Ʈ</returns>
        /// <param name="rawData">Raw Text Data</param>
        UniTask<IResult<IReadOnlyList<IStageInfoData>>> LoadStageInfo( string rawData );

        /// <summary>
        /// Find Stage Info By Index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Stage Info Data</returns>
        IStageInfoData GetStageInfo( int index );

        /// <summary>
        /// Find Stage Info By ID(string)
        /// </summary>
        /// <param name="id">ID(string)</param>
        /// <returns>Stage Info Data</returns>
        IStageInfoData GetStageInfo( string id );

        /// <summary>
        /// ���� ������ ����Ʈ ó���� �����Ͽ� �ʱ�ȭ�� ����
        /// </summary>
        /// <param name="rawData">���� ���̺� ID</param>
        /// <returns>None</returns>
        UniTask InitHandDataList( string rawData );

        /// <summary>
        /// ���� ���� ����Ʈ ó���� �����Ͽ� �ʱ�ȭ�� ����
        /// </summary>
        /// <param name="rawData">���� ���� ���̺� Raw Data</param>
        /// <returns>None</returns>
        UniTask InitHandConditionDataList( string rawData );
    }
}
