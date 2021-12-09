# ZenmetsuSample
 全滅を確認したら、何か起こす仕組みのサンプル

## テーマ
- interfaceとポリモーフィズムで疎結合にしたい
- システムは汎用的に使えるようにしたい

## システムの構成

### 全滅を監視するオブジェクト NormaDetector
- フィールド
  - 監視する対象のインスタンスを持つ配列
  - 条件を全て満たした時に処理したい処理のメソッドを登録するUnityEvent
- メソッド
  - void Done(DetectedObject)
    - DetectedObjectのオブジェクトが条件を満たした時に、自分のインスタンスを渡して呼び出す

### 監視されるオブジェクト DetectedObject, IDetectedObject
- メソッド
  - void SetDetector(NormaDetector)
    - 管理する監視オブジェクトのインスタンスを渡す。条件を満たしたら、このインスタンスのDone()を呼び出す

### クリックでノルマ達成とするスクリプト ClickDestroyer
- マウスがクリックされたら、同じオブジェクトのIDetectedObjectのDone()を呼び出す

## サンプル
- 画面に2種類の監視されるオブジェクトを4個ずつ配置
- クリックすると、監視されるオブジェクトは消える
- 一方の種類の監視されるオブジェクトが全滅したら、Debug.Log()で結果を表示
- もう一方も全滅したら、別の内容を表示
