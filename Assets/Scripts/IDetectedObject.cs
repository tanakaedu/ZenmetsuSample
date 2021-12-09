public interface IDetectedObject
{
    /// <summary>
    /// 管理元のインスタンスを設定
    /// </summary>
    /// <param name="detector">管理元のインスタンス</param>
    void SetDetector(NormaDetector detector);

    /// <summary>
    /// ノルマ完了時に呼び出す。
    /// </summary>
    void Done();
}
