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
                card.SetID(val.ID.ToString());
                card.SetType(val.Suite);
                card.SetValue(val.Rank);
                card.SetChip(val.Chip);
                card.SetIllustResourceID($"card-type-{((int)val.Suite) - 1}");   
                card.SetIconResourceID($"icon-type-{((int)val.Suite) - 1}");
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
