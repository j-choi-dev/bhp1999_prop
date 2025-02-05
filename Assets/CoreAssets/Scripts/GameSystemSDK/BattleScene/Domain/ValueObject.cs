﻿using System.Linq;

namespace GameSystemSDK.BattleScene.Domain
{
    public struct HandTablePath
    {
        public readonly string StageDataMock => "StageDataMock";
        public readonly string PokerHandsCsvName => "PokerHands";
        public readonly string PokerHandsConditionCsvName => "PokerHandsCondition";
        public readonly string PokerHandsLevelCsvName => "PokerHandsLevel";
        public readonly string PlayingCardCsvName => "PlayingCard";
        public readonly string CardUpgradeCsvName => "CardUpgrade";
        public readonly string CardEffectCsvName => "CardEffect";
    }

    public struct UIMessageData
    {
        public readonly string GameOverHader => "GameOver";
        public readonly string GameOverMessage => "GameOver\n메인화면으로 돌아갑니다.";
        public readonly string Confirm => "확인";
    }

    public enum CardType
    {
        None,
        Diamond,
        Heart,
        Club,
        Spade,
        Max,
    }
    public enum PokerNumCheckType
    {
        None,
        Pair,
        Straight,
    }
    public enum OperationType
    {
        None,
        OperationAND,
        OperationOR,
        Max,
    }

    public enum  CardUpgradeType
    {
        Enhancement,    // 강화 혹은 부여
        Edition,        // 카드 특수 처리(포일 같은 거)
        Seal,           // 봉인 추가
        Max,
    }

    public enum ActivateConditionType
    {
        WhenTrigger,    // 카드 자체가 트리거되는 시점
        RoundEnd,       // 라운드 끝났을 때 손에 보유하고 있다면
        CardPlayGetPoint,   // 득점에 사용된 카드 체크
        Discard,        // 버렸을 때
        Always,         // 네거티브 효과인데 트리거됐을 때가 아닌 스스로 슬롯 무게를 차지하지 않는 느낌
    }

    public enum CardEffectOperationType
    {
        Chip,           // AddPoint 추가
        Multiplier,     // MultiPoint 추가
        ChangeSuite,    // CardType 변경
        ChangeRank,     // Card Num 변경
        Xmultiplier,    // MultiPoint 배수
        Destroy,        // 해당 카드 파괴
        Dollar,         // 돈
        AdditionalTrigger,  // 한 번 더 트리거
        Negative,
        GenerateItem,   // 아이템 생성(행성과 타로는 OperationParam으로 구분하자?)
    }

    public struct PlayingCardInfoColumnName
    {
        // 이 변수들은 안 들어가면 게임 뻗는게 맞음
        public readonly string ID => "id";
        public readonly string DeckGroup => "DeckGroup";
        public readonly  string Chip => "Chip";
        public readonly string Rank => "Rank";
        public readonly string Suite => "Suite";
        public readonly string PictureCard => "PictureCard";
        public readonly string IllustResourceID =>"IllustResourceID";
        public readonly string IconResourceID =>"IconResourceID";
    }

    public struct InGameConstValue
    {
        public readonly int MaxSelectCardCount => 5;
    }
}
