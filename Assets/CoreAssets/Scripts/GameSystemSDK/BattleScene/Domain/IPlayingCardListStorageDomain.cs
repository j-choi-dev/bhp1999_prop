using System.Collections.Generic;

namespace GameSystemSDK.BattleScene.Domain
{
    /// <summary>
    /// @Auth Samdong
    /// �÷��� ī�忡 ���õ� �����͸� �����ϰ� ����
    /// </summary>
    public interface IPlayingCardListStorageDomain
    {
        /// <summary>
        /// �ܺο��� ������ �� ����Ʈ ����
        /// </summary>
        IReadOnlyList<IPlayingCardInfo> PlayingCardDeckList { get; }


        /// <summary>
        /// �÷��� ī�带 �а� ����
        /// </summary>
        void InitPlayingCardList(IReadOnlyList<Dictionary<string, string>> rawData);
    }
}