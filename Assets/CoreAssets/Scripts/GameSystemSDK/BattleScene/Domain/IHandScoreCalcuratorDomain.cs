using System;
using System.Collections.Generic;

namespace GameSystemSDK.BattleScene.Domain
{
    /// <summary>
    /// Poker ���� ��� ��ũ��Ʈ
    /// </summary>
    /// <remarks>��ȣ�� �ۼ��Ͻ� ��ũ��Ʈ</remarks>
    public interface IHandScoreCalcuratorDomain
    {
        public IObservable<IDetailScoreInfo> OnDetailScoreInfo { get; }

        /// <summary>
        /// Get Max Score
        /// </summary>
        /// <param name="cardList">�ִ� 5�� ������ ���� ī�� ����Ʈ</param>
        /// <returns></returns>
        /// <remarks>�̰ɷ� ���� ã���ݴϴ�. to �翬��</remarks>
        (int id, IReadOnlyList<IBattleCard>) GetMaxPokerScore( IReadOnlyList<IHandInfoData> handDataList,
            IReadOnlyList<IBattleCard> cardList );

        /// <summary>
        /// ����(�ڵ�) ���꿡 �ʿ��� ������ Ž��
        /// </summary>
        /// <param name="handDataList">���� ������ ����Ʈ</param>
        /// <param name="id">���� ���� ID</param>
        /// <returns>���� ���� ������</returns>
        IHandConditionInfo GetPokerHandsInfoByID( IReadOnlyList<IHandInfoData> handDataList, int id );


        /// <summary>
        /// ���� ���ھ ���� �⺻ ���� ����
        /// </summary>
        /// <param name="condition">���� ���� ���� ������</param>
        /// <returns>������ ���� ���� ���ھ� ��ü �⺻ ����</returns>
        /// ���� �Ǿ���
        IDetailScoreInfo GetScoreData( IHandConditionInfo condition );
    }
}
