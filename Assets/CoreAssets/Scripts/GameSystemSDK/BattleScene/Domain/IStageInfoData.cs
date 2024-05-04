namespace GameSystemSDK.BattleScene.Domain
{
    /// <summary>
    /// @Auth Choi
    /// Stage Info Data
    /// </summary>
    public interface IStageInfoData
    {
        /// <summary>
        /// Stage Info Unique ID
        /// </summary>
        string ID { get; }

        /// <summary>
            /// �ش� �������������� �ִ� Hand Count
        /// </summary>
        int MaxHandCount { get; }

        /// <summary>
            /// �ش� �������������� �ִ� ī�� ������ ���� ���� Count
        /// </summary>
        int MaxDiscardCount { get; }

        /// <summary>
            /// �ش� �������������� ��� ��
        /// </summary>
        int GoldValue { get; }

        /// <summary>
            /// �ش� ���������� ǥ�ø�
        /// </summary>
        string StageName { get; }

        /// <summary>
            /// �ش� ���������� ȿ�� ���� ������ 1
        /// </summary>
        string StageBuff1 { get; }

        /// <summary>
            /// �ش� ���������� ȿ�� ���� ������ 2
        /// </summary>
        string StageBuff2 { get; }

        /// <summary>
            /// �ش� ���������� ȿ�� ���� ������ 3
        /// </summary>
        string StageBuff3 { get; }

        /// <summary>
            ///  ID ����
        /// </summary>
        /// <param name="val">string type ID Value</param>
        void SetID( string val );

        /// <summary>
            ///  �ִ� Hand Count ����
        /// </summary>
        /// <param name="val">int type Count Value</param>
        void SetMaxHandCount( int val );

        /// <summary>
            ///  �ִ� ī�� ������ Count ����
        /// </summary>
        /// <param name="val">int type Count Value</param>
        void SetMaxDiscardCount( int val );

        /// <summary>
            ///  Gold ����
        /// </summary>
        /// <param name="val">int type Gold Value</param>
        void SetGoldValue( int val );

        /// <summary>
            ///  Gold ����
        /// </summary>
        /// <param name="val">string type Stage Name</param>
        void SetStageName( string val );

        /// <summary>
            ///  Gold ����
        /// </summary>
        /// <param name="val">string type Stage Buff Effect 1</param>
        void SetStageBuff1( string val );

        /// <summary>
            ///  Gold ����
        /// </summary>
        /// <param name="val">string type Stage Buff Effect 2</param>
        void SetStageBuff2( string val );

        /// <summary>
            ///  Gold ����
        /// </summary>
        /// <param name="val">string type Stage Buff Effect 3</param>
        void SetStageBuff3( string val );
    }
}
