using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using Cysharp.Threading.Tasks;
using GameSystemSDK.BattleScene.Domain;

namespace GameSystemSDK.BattleScene.Model
{
    /// <summary>
    /// @Auth Choi
    /// ������ ������� �� ���� ���࿡ �ʿ��� ��ġ�� Model Ŭ����
    /// </summary>
    public interface IGameProcessModel
    {
        /// <summary>
        /// �ܿ� �ڵ� ī��Ʈ ���� �̺�Ʈ
        /// </summary>
        IObservable<int> OnHandChanged { get; }

        /// <summary>
        /// �ܿ� ī�� ������ ī��Ʈ ���� �̺�Ʈ
        /// </summary>
        IObservable<int> OnDiscardChanged { get; }

        /// <summary>
        /// ���������� ��尪 ���� �̺�Ʈ
        /// </summary>
        IObservable<int> OnGoldChanged { get; }

        /// <summary>
        /// ���������� Circle�� ���� �̺�Ʈ
        /// </summary>
        IObservable<int> OnCircleValueChanged { get; }

        /// <summary>
        /// ���������� Mana�� ���� �̺�Ʈ
        /// </summary>
        IObservable<int> OnManaValueChanged { get; }

        /// <summary>
        /// �ڵ� ����(=���� ����) �̺�Ʈ
        /// </summary>
        IObservable<Unit> OnHandOver { get; }
        /// <summary>
        /// View�� ǥ���� �������� �̸� ���� �̺�Ʈ
        /// </summary>
        IObservable<string> OnStageNameChanged { get; }
        /// <summary>
        /// View�� ǥ���� �������� ����ȿ�� 1 ���� �̺�Ʈ
        /// </summary>
        IObservable<string> OnStageBuff1Change { get; }
        /// <summary>
        /// View�� ǥ���� �������� ����ȿ�� 2 ���� �̺�Ʈ
        /// </summary>
        IObservable<string> OnStageBuff2Change { get; }
        /// <summary>
        /// View�� ǥ���� �������� ����ȿ�� 3 ���� �̺�Ʈ
        /// </summary>
        IObservable<string> OnStageBuff3Change { get; }

        bool IsDiscardOver { get; }

        int CurrHandCount { get; }
        int MaxHandCount { get; }
        int CurrDiscardCount { get; }
        int CurrGold { get; }

        int CircleValue { get; }
        int ManaValue { get; }

        /// <summary>
        /// Initialize
        /// </summary>
        /// <returns>�񵿱� ó�� UniTask</returns>
        UniTask Initialize();

        /// <summary>
        /// �ڵ� ����
        /// </summary>
        /// <returns>�񵿱� ó�� UniTask</returns>
        UniTask RunHand();
        void DiscardProcess( string id );

        /// <summary>
        /// �ܿ� �ڵ� �� ����
        /// </summary>
        /// <param name="val">���� ������ ���� ���, Default�� 1</param>
        void DiscountHandCount( int val = 1 );

        /// <summary>
        /// ī�� ������ �� ����
        /// </summary>
        /// <param name="val">���� ������ ���� ���, Default�� 1</param>
        void DiscountDiscardCount( int val );

        /// <summary>
        /// ���������� ���� ������ �ڵ� �ִ밪 ����
        /// </summary>
        /// <param name="val">�ִ� �ڵ尪(��)</param>
        void SetMaxHandCount( int val );

        /// <summary>
        /// ���������� ���� ������ ī�� ������ �ִ밪 ����
        /// </summary>
        /// <param name="val">�ִ� ī�� ������ ȸ��</param>
        void SetMaxDiscardCount( int val );

        /// <summary>
        /// Gold�� ����
        /// </summary>
        /// <param name="val">Gold��</param>
        void SetGold( int val );

        /// <summary>
        /// Circle�� ����
        /// </summary>
        /// <param name="val">Circle��</param>
        void SetCircleValue( int value );

        /// <summary>
        /// Mana�� ����
        /// </summary>
        /// <param name="val">Mana��</param>
        void SetManaValue( int value );
    } 
}
