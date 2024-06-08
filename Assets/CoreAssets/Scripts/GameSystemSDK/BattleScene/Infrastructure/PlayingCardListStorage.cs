using CommonSystem.Util;
using GameSystemSDK.BattleScene.Domain;
using System.Collections.Generic;
using System.Linq;

namespace GameSystemSDK.BattleScene.Infrastructure
{
    public class PlayingCardListStorage : IPlayingCardListStorageDomain
    {
        private List<IPlayingCardInfo> _playingCardList = new List<IPlayingCardInfo>();
        public IReadOnlyList<IPlayingCardInfo> PlayingCardDeckList => _playingCardList;


        public void InitPlayingCardList(IReadOnlyList<Dictionary<string, string>> rawData)
        {
            for (int i = 0; i < rawData.Count; i++)
            {
                // �� �������� �� ���� ���� ���°� ����
                var id = int.Parse(CSVUtil.GetData(rawData, i, "id"));
                var deckGroup = int.Parse(CSVUtil.GetData(rawData, i, "deckGroup"));
                var chip = int.Parse(CSVUtil.GetData(rawData, i, "chip"));
                var rank = int.Parse(CSVUtil.GetData(rawData, i, "rank"));
                var suite = EnumUtil<CardType>.Parse(CSVUtil.GetData(rawData, i, "suite"));

                // �׸�ī���� ���� ����ִٸ� False
                string strPicture = CSVUtil.GetData(rawData, i, "pictureCard");

                var pictureCard = strPicture.Equals(string.Empty) || strPicture == "0" ? false : true;
                string illustResourceID = CSVUtil.GetData(rawData, i, "illustResourceID");
                string iconResourceID = CSVUtil.GetData(rawData, i, "iconResourceID");

                var data = new PlayingCardInfo(id, deckGroup, chip, rank, suite, pictureCard, illustResourceID, iconResourceID);

                _playingCardList.Add(data);
            }
        }
    }
}
