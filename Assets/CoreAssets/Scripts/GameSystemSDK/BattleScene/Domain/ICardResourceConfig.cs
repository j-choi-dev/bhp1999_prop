using GameSystemSDK.Common.Domain;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystemSDK.Resource.Domain
{
    /// <summary>
    /// @Auth Choi
    /// ��Ʋ �÷��� ���࿡ �ʿ��� ���ҽ��� ���
    /// </summary>
    public interface ICardResourceConfig
    {
        /// <summary>
        /// Card Illust List
        /// </summary>
        IReadOnlyList<Sprite> CardIllustList { get; }
        /// <summary>
        /// Card Illust List
        /// </summary>
        IReadOnlyList<Sprite> CardValueTextList { get; }

        /// <summary>
        /// Card Icon Illust List
        /// </summary>
        IReadOnlyList<Sprite> CardIconList { get; }

        IResult<Sprite> GetIllustSprite( string id );
        IResult<Sprite> GetValueTextSprite( string value );
        IResult<Sprite> GetIconSprite( string id );
    }
}
