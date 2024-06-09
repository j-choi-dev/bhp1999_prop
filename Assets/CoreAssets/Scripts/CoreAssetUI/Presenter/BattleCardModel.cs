using Cysharp.Threading.Tasks;
using GameSystemSDK.BattleScene.Domain;
using GameSystemSDK.Card.Application;
using GameSystemSDK.Server.Apllication;
using GameSystemSDK.Server.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;

namespace GameSystemSDK.BattleScene.Model
{
    public class BattleCardModel : IBattleCardModel
    {
        private IBattleCardListContext _battleCardListContext;
        private IUserItemDataNetworkContext _networkContext;
        private IBattleCardFactoryContext _battleCardFactoryContext;

        public IReadOnlyList<IBattleCard> CurrentCardList 
            => _battleCardListContext.CardList;

        public IReadOnlyList<IBattleCard> CurrentSelectedList 
            => _battleCardListContext.CurrenSelectedCard;

        public IObservable<IReadOnlyList<IBattleCard>> OnHandCardListChanged 
            => _battleCardListContext.OnHandCardListChanged;

        public IObservable<IBattleCard> OnHandCardAdd 
            => _battleCardListContext.OnHandCardAdd;

        public IObservable<IBattleCard> OnHandCardRemoved 
            => _battleCardListContext.OnHandCardRemoved;

        public IObservable<Unit> OnHandCardCleared 
            => _battleCardListContext.OnHandCardCleared;

        public IObservable<IReadOnlyList<IBattleCard>> OnSelectionCardListCahnged 
            => _battleCardListContext.OnSelectedCardListChanged;

        public IObservable<IBattleCard> OnSelectedCardAdd
            => _battleCardListContext.OnSelectedCardAdd;

        public IObservable<IBattleCard> OnSelectedCardRemoved 
            => _battleCardListContext.OnSelectedCardRemoved;

        public IObservable<Unit> OnSelectedCardCleared 
            => _battleCardListContext.OnSelectedCardCleared;

        public BattleCardModel( IBattleCardListContext battleCardListContext,
            IUserItemDataNetworkContext networkContext,
            IBattleCardFactoryContext battleCardFactoryContext )
        {
            _battleCardListContext = battleCardListContext;
            _networkContext = networkContext;
            _battleCardFactoryContext = battleCardFactoryContext;
        }

        public async UniTask Initialize()
        {
            // �������� ������ ������ ī�� ����Ʈ �޾ƿ�.
            var cardDatas = await _networkContext.UserCardDataRequest();
            var mock = new List<ICardBase>();

            // ������ ������ ī�� ����Ʈ��, ī�� ������ ��ȯ
            // TODO : ���� Context �ʿ�? -> ��쿡 ���󼭴� ���丮 �ʿ�. @Choi 24.06.06
            var cardList = new List<IBattleCard>();
            for(int i = 0; i<cardDatas.Count; i++ )
            {
                var item = cardDatas[i];
                var playingCard = _battleCardFactoryContext.ConvertToBattleCard(item.ID, item.Type, item.Value, item.EnchantSlot1, item.EnchantSlot2, item.EnchantSlot3);
                cardList[i].SetPlayingCardInfo( playingCard );
            }

            // ������ ī�� ������ ����Ʈ ������ Ŭ������ ���
            _battleCardListContext.SetUserCardList( cardList );
        }

        public void AddSelectedCard( string id )
        {
            var targetCard = _battleCardListContext.CardList.First(arg => arg.PlayingCardInfo.ID.Equals(id));
            _battleCardListContext.AddSelectedCard( targetCard );
        }

        public void RemoveSelectedCard( string id )
        {
            _battleCardListContext.RemoveCurrentSelectedCard( id );
        }

        public void ClearSelectedCardList()
        {
            _battleCardListContext.ClearSelectedCardList();
        }
    }
}
