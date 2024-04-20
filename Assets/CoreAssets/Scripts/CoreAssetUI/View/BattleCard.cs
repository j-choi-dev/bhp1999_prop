﻿using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CoreAssetUI.View
{
    public class BattleCard : CellBase, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        private Vector2 prevPos; //保存しておく初期position
        private RectTransform rectTransform; // 移動したいオブジェクトのRectTransform
        private RectTransform parentRectTransform; // 移動したいオブジェクトの親(Panel)のRectTransform

        private Subject<(string id, Vector2 pos)> _onDragStart = new Subject<(string id, Vector2 pos)>();
        public IObservable<(string id, Vector2 pos)> OnDragStart => _onDragStart;

        private Subject<(string id, Vector2 pos)> _onDragEnd = new Subject<(string id, Vector2 pos)>();
        public IObservable<(string id, Vector2 pos)> OnDragEnd => _onDragEnd;

        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
            parentRectTransform = rectTransform.parent as RectTransform;
        }


        // ドラッグ開始時の処理
        public void OnBeginDrag( PointerEventData eventData )
        {
            // ドラッグ前の位置を記憶しておく
            // RectTransformの場合はpositionではなくanchoredPositionを使う
            prevPos = rectTransform.anchoredPosition;
            _onDragStart.OnNext( (this.ID, prevPos) );
        }

        // ドラッグ中の処理
        public void OnDrag( PointerEventData eventData )
        {
            // eventData.positionから、親に従うlocalPositionへの変換を行う
            // オブジェクトの位置をlocalPositionに変更する

            Vector2 localPosition = GetLocalPosition(eventData.position);
            //rectTransform.anchoredPosition = localPosition;
            _onDragStart.OnNext( (this.ID, localPosition) );
        }

        // ドラッグ終了時の処理
        public void OnEndDrag( PointerEventData eventData )
        {
            // オブジェクトをドラッグ前の位置に戻す
            //rectTransform.anchoredPosition = prevPos;
            _onDragEnd.OnNext( (this.ID, prevPos) );
        }

        // ScreenPositionからlocalPositionへの変換関数
        private Vector2 GetLocalPosition( Vector2 screenPosition )
        {
            var result = Vector2.zero;

            // screenPositionを親の座標系(parentRectTransform)に対応するよう変換する.
            RectTransformUtility.ScreenPointToLocalPointInRectangle( parentRectTransform, screenPosition, Camera.main, out result );

            return result;
        }
    }
}
