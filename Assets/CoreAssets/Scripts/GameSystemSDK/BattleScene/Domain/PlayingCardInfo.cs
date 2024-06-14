using System.Collections.Generic;

namespace GameSystemSDK.BattleScene.Domain
{
    /// <summary>
    ///  �÷��� ī�� ������
    /// </summary>
    /// <remarks>���ȣ �ۼ�</remarks>
    public interface IPlayingCardInfo
    {
        int ID { get; }
        int DeckGroup { get; }
        int Chip { get; }
        int Rank { get; }
        CardType Suite { get; }
        bool PictureCard { get; }
        string IllustResourceID { get; }
        string IconResourceID { get; }
        // ���ϴ� �ֿ� �μ����� ��ȭ�� �� �߰���.
        /// <summary>
        /// ��ȭȿ���� ���� ��ȭID �� ����1
        /// </summary>
        string EnchantSloat1 { get; }
        /// <summary>
        /// ��ȭȿ���� ���� ��ȭID �� ����2
        /// </summary>
        string EnchantSloat2 { get; }
        /// <summary>
        /// ��ȭȿ���� ���� ��ȭID �� ����3
        /// </summary>
        string EnchantSloat3 { get; }

        void SetDeckGroup( int value );
        void SetRank( int value );
        void SetPicktureCard( bool isVal );
        void SetIllustResourceID( string value );
        void SetIconResourceID( string value );
    }

    public class PlayingCardInfo : IPlayingCardInfo
    {
        public int ID { get; private set; }
        public int DeckGroup { get; private set; }
        public int Chip { get; private set; }
        public int Rank { get; private set; }
        public CardType Suite { get; private set; }
        public bool PictureCard { get; private set; }
        public string IllustResourceID { get; private set; }
        public string IconResourceID { get; private set; }
        public string EnchantSloat1 { get; private set; }
        public string EnchantSloat2 { get; private set; }
        public string EnchantSloat3 { get; private set; }

        public PlayingCardInfo( int id,
            int deckGroup,
            int chip,
            int rank,
            CardType suite,
            bool pictureCard,
            string illustResourceID,
            string iconResourceID )
        {
            this.ID = id;
            this.DeckGroup = deckGroup;
            this.Chip = chip;
            this.Rank = rank;
            this.Suite = suite;
            this.PictureCard = pictureCard;
            this.IllustResourceID = illustResourceID;
            this.IconResourceID = iconResourceID;
        }
        public PlayingCardInfo( int id,
            CardType suite,
            int chip,
            int rank,
            string slot1,
            string slot2,
            string slot3 )
        {
            this.ID = id;
            this.Chip = chip;
            this.Suite = suite;
            this.Rank = rank;
            this.EnchantSloat1 = slot1;
            this.EnchantSloat2 = slot2;
            this.EnchantSloat3 = slot3;
        }

        public void SetDeckGroup( int value )
            => this.DeckGroup = value;
        public void SetRank( int value )
            => this.DeckGroup = value;
        public void SetPicktureCard( bool isVal )
            => this.PictureCard = isVal;
        public void SetIllustResourceID( string value )
            => this.IllustResourceID = value;
        public void SetIconResourceID( string value )
            => this.IconResourceID = value;
    }
}