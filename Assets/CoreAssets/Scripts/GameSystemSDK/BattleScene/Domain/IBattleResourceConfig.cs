using GameSystemSDK.Common.Domain;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystemSDK.Resource.Domain
{
    /// <summary>
    /// @Auth Choi
    /// ��Ʋ �÷��� ���࿡ �ʿ��� ���ҽ��� ���
    /// </summary>
    public interface IBattleResourceConfig
    {
        /// <summary>
        /// Table(ex: CSV) List
        /// </summary>
        IReadOnlyList<TextAsset> TableList { get; }
        IReadOnlyList<AudioClip> SoundEffectList { get; }

        /// <summary>
        /// ID�� �������� �ش� CSV�� ��ü �ؽ�Ʈ ������(Raw Text)�� ��� 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>All CSV Contents(Raw Text)</returns>
        IResult<string> GetTableRawData( string id );

        /// <summary>
        /// ID�� �������� �ش� ���� Ŭ���� ��� 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>AudioClip</returns>
        IResult<AudioClip> GetSoundEffectData( string id );
    }
}
