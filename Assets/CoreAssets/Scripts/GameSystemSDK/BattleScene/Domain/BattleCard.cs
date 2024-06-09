using CoreAssetUI.View;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystemSDK.BattleScene.Domain
{
    public class BattleCard : IBattleCard
    {
        //public string ID { get; private set; } = string.Empty;

        //public CardType Type { get; private set; } = CardType.None;

        //public int Value { get; private set; } = 0;

        //public int Chip { get; private set; } = 0;

        //public string IllustResourceID { get; private set; } = string.Empty;

        //public string IconResourceID { get; private set; } = string.Empty;

        public IPlayingCardInfo PlayingCardInfo { get; private set; }
        public int Index { get; private set; } = 0;
        public bool IsInHand { get; private set; } = false;
        public bool IsSelected { get; private set; } = false;
        public bool IsDrawn { get; private set; } = false;
        public bool IsUsable { get; private set; } = true;

        //public void SetID( string value )
        //    => ID = value;

        //public void SetIllustResourceID( string sprite )
        //    => IllustResourceID = sprite;

        //public void SetType( CardType type )
        //    => Type = type;

        //public void SetValue( int value )
        //    => Value = value;

        //public void SetChip(int value)
        //    => Chip = value;

        //public void SetIconResourceID( string sprite )
        //    => IconResourceID = sprite;

        public void SetPlayingCardInfo( IPlayingCardInfo playingCardInfo )
            => PlayingCardInfo = playingCardInfo;

        public void SetIndex( int value )
            => Index = value;

        public void SetInHand( bool isValue )
            => IsInHand = isValue;

        public void SetIsSelected( bool isValue )
            => IsSelected = isValue;

        public void SetDrawn( bool isValue )
            => IsDrawn = isValue;

        public void SetUsable( bool isValue )
            => IsUsable = isValue;

        //// <TODO>
        //// ī�尡 ������ ����� Type�̶� Value ���ٰ� ���� ī����� �� �� ����.
        //// ī�� ó���� ������ �� ���� UID�� �����ؼ� �ְ� �װ� ���ؾ� �Ѵ�.
        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //    {
        //        return false;
        //    }
        //    if (!(obj is BattleCard))
        //    {
        //        return false;
        //    }

        //    var other = (BattleCard)obj;

        //    return Type == other.Type && Value == other.Value;
        //}

        //public override int GetHashCode()
        //{
        //    var hashCode = HashCode.Combine(Type, Value);
        //    return hashCode;
        //}
    }
}
