using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GameSystemSDK.BattleScene.Domain
{
    /// <summary>
    /// ���� ���� ��� ����
    /// </summary>
    public interface IDetailScoreInfo
    {
        string Name { get; }
        IReadOnlyList<IBattleCard> HandCardList { get; }
        int MultiplePoint { get; }
        int AddPoint { get; }
        public void AddSummitScoreData(IBattleCard addCard);
        public int GetScore();
        public string GetScoreMsg ();
    }

    public class DetailScoreInfo : IDetailScoreInfo
    {
        public string Name { get; private set; }

        private List<IBattleCard> _handCardList = new List<IBattleCard>();
        public IReadOnlyList<IBattleCard> HandCardList => _handCardList;

        public int MultiplePoint { get; private set; }

        public int AddPoint { get; private set; }

        public DetailScoreInfo( IHandConditionInfo conditionInfo )
        {
            this.Name = conditionInfo.Name + $"Lv. {conditionInfo.HandLevel}";
            this.MultiplePoint = conditionInfo.MultiplePoint;
            this.AddPoint = conditionInfo.AddPoint;
        }

        public void AddSummitScoreData( IBattleCard addCard )
        {
            _handCardList.Add( addCard );
            this.AddPoint += addCard.PlayingCardInfo.Chip;

            // <TODO> Card�� ȿ���� �ִٸ� �ش� ȿ�� ����
        }
        public int GetScore()
        {
            return AddPoint * MultiplePoint;
        }

        public string GetScoreMsg()
        {
            var strMsg = $"����: {Name} -> ({AddPoint} X {MultiplePoint} = {GetScore()})";
            return strMsg;
        }
    }
}
