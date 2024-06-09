using Cysharp.Threading.Tasks;
using GameSystemSDK.BattleScene.Domain;
using System.Collections.Generic;
using System.Linq;

namespace GameSystemSDK.BattleScene.Infrastructure
{
    public class CardDeckListGenerator : ICardDeckListGenerateDomain
    {
        public async UniTask<IReadOnlyList<IBattleCard>> GenerateShuffledList(IReadOnlyList<IPlayingCardInfo> cardList)
        {
            return GetShuffledCardList( cardList );
        }

        // <TODO>
        // �ϴ� ���� ���ҽ� �̸��� ���缭 -1 �� ����
        // ���ҽ��� ���� �̸��̵� �����͵� ���� �ʿ���
        private static IReadOnlyList<IBattleCard> GetShuffledCardList( IReadOnlyList<IPlayingCardInfo> cardList )
        {
            var rand = new System.Random();

            var list = new List<IBattleCard>();

            foreach (var val in cardList)
            {
                var card = new BattleCard();
                card.SetPlayingCardInfo(val);
                card.SetUsable(true);
                card.SetInHand( true );
                card.SetIsSelected( false );
                card.SetDrawn( false );
                list.Add(card);
            }

            var shuffled = list.OrderBy(_ => rand.Next()).ToList();
            for( int i = 0; i< shuffled.Count; i++ )
            {
                shuffled[i].SetIndex( i );
            }
            return shuffled;
        }
    }
}
