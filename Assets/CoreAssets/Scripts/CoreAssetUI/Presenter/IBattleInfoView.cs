using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoreAssetUI.Presenter
{
    /// <summary>
    /// @Auth Choi
    /// ���� ���� ������ ���õ� View
    /// </summary>
    public interface IBattleInfoView
    {
        bool IsScorePlateOn { get; }
        void SetHandCountWithoutNotify( int value );
        void SetDiscardCountWithoutNotify( int value );
        void SetGoldWithoutNotify( int value );
        void SetCircleWithoutNotify( int value );
        void SetManaWithoutNotify( int value );
        void SetScorePlateWithoutNotify( string value );
        void SetScorePlateOn( bool isOn );
    }
}
