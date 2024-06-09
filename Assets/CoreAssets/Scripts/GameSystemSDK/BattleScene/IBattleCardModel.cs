using Cysharp.Threading.Tasks;
using GameSystemSDK.BattleScene.Domain;
using System;
using System.Collections.Generic;
using UniRx;

namespace GameSystemSDK.BattleScene.Model
{
    /// <summary>
    /// ��) CardListη��Model
    /// </summary>
    /// Auth : Choi 
    public interface IBattleCardModel
    {
        /// <summary>
        /// ���� (��ȿ��) ī�� ����Ʈ
        /// </summary>
        IReadOnlyList<IBattleCard> CurrentCardList { get; }

        /// <summary>
        /// ���� �������� ī�� ����Ʈ
        /// </summary>
        IReadOnlyList<IBattleCard> CurrentSelectedList { get; }

        /// <summary>
        /// 8�� �̻� �����Ǵ� �ڵ� ī�� ����Ʈ�� ���� �̺�Ʈ
        /// </summary>
        IObservable<IReadOnlyList<IBattleCard>> OnHandCardListChanged { get; }
        /// <summary>
        /// 8�� �̻� �����Ǵ� �ڵ� ī���� �߰� �̺�Ʈ
        /// </summary>
        IObservable<IBattleCard> OnHandCardAdd { get; }
        /// <summary>a
        /// 8�� �̻� �����Ǵ� �ڵ� ī���� ���� �̺�Ʈ
        /// </summary>
        IObservable<IBattleCard> OnHandCardRemoved { get; }
        /// <summary>
        /// 8�� �̻� �����Ǵ� �ڵ� ī���� ��ü ���� �̺�Ʈ
        /// </summary>
        IObservable<Unit> OnHandCardCleared { get; }

        /// <summary>
        /// ���õ� ī�� ����Ʈ�� ���� �̺�Ʈ
        /// </summary>
        IObservable<IReadOnlyList<IBattleCard>> OnSelectionCardListCahnged { get; }

        /// <summary>
        /// ���õ� ī�� ����Ʈ�� �߰� �̺�Ʈ
        /// </summary>
        IObservable<IBattleCard> OnSelectedCardAdd { get; }

        /// <summary>
        /// ���õ� ī�� ����Ʈ�� ���� �̺�Ʈ
        /// </summary>
        IObservable<IBattleCard> OnSelectedCardRemoved { get; }

        /// <summary>
        /// ���õ� ī�� ����Ʈ�� ��ü ���� �̺�Ʈ
        /// </summary>
        /// <remarks>�÷��� ���� ���� �̺�Ʈ �� �߻�</remarks>
        IObservable<Unit> OnSelectedCardCleared { get; }

        /// <summary>
        /// �ʱ�ȭ �Լ�
        /// </summary>
        /// <returns></returns>
        UniTask Initialize();

        /// <summary>
        /// ���õ� ī�� ����Ʈ�� ���� ���� �߰�
        /// </summary>
        /// <param name="id">���õ� ī�� ID</param>
        void AddSelectedCard( string id );

        void RemoveSelectedCard( string id );

        /// <summary>
        /// ���õ� ī�� ����Ʈ�� ��ü ����
        /// </summary>
        /// <remarks>�÷��� ���� ���� �̺�Ʈ �߻� �� ����</remarks>
        void ClearSelectedCardList();
    }
}
