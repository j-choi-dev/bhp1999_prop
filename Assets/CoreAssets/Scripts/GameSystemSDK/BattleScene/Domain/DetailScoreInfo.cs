using System.Collections.Generic;
using System.Linq;

namespace GameSystemSDK.BattleScene.Domain
{
    /// <summary>
    /// ���� ���� ��� ����
    /// </summary>
    public interface IDetailScoreInfo
    {
        string Name { get; }
        IReadOnlyList<IBattleCard> HandCardList { get; }
        IReadOnlyList<int> PointList { get; }
        int MultiplePoint { get; }
        int AddPoint { get; }
        public int Score { get; }
        public string GetScoreMsg ();
    }

    public class DetailScoreInfo : IDetailScoreInfo
    {
        public string Name { get; private set; }

        public IReadOnlyList<IBattleCard> HandCardList { get; private set; }

        public IReadOnlyList<int> PointList { get; private set; }

        public int MultiplePoint { get; private set; }

        public int AddPoint { get; private set; }

        public int Score { get; private set; }


        // Todo.
        // ����� ������ �ڵ忡 �ִ� ī��� ���
        // �߰������� ���� �� �տ� ���� �ִ� ī�带 ������� Ʈ���� + ��Ŀ�� ������� Ʈ�����ϴ� ������ ���ľ� �Ѵ�.
        // ����� �ѹ濡 ������ �̰� �ִµ� ��������δ� ������ ī�� �ϳ��� ����Ʈ �����鼭 ������� Ʈ�����ϴ� �������
        // �����ؾ� �� ������ ���δ�.
        public DetailScoreInfo( IReadOnlyList<IBattleCard> cardList, IHandConditionInfo conditionInfo )
        {
            this.Name = conditionInfo.Name;
            this.MultiplePoint = conditionInfo.MultiplePoint;
            this.AddPoint = conditionInfo.AddPoint;
            this.HandCardList = cardList;
            this.PointList = cardList.Select( arg => arg.PlayingCardInfo.Chip ).ToList();

            var realAddPoint = conditionInfo.AddPoint;
            for( var i = 0; i< cardList.Count; i++ )
            {
                realAddPoint += cardList[i].PlayingCardInfo.Chip;
            }
            this.Score = realAddPoint * conditionInfo.MultiplePoint;
        }

        public string GetScoreMsg()
        {
            var strMsg = $"����: {Name} -> ({AddPoint} + {string.Join(" + ", PointList)}) X {MultiplePoint} = {this.Score}";
            return strMsg;
        }
    }
}
