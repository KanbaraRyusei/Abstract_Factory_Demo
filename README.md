# Abstract_Factory_Demo

## このプロジェクトについて
* AbstractFactoryPatternを学ぶために作成したプロジェクト
* 弾を発射するコードをAbstractFactoryPatternで書いてみる

## コードの解説
* [BaseSpawnBullet](https://github.com/KanbaraRyusei/Abstract_Factory_Demo/blob/main/Assets/Scripts/BaseSpawnBullet.cs)を継承した3種類のBulletを[BulletSpawner](https://github.com/KanbaraRyusei/Abstract_Factory_Demo/blob/main/Assets/Scripts/BulletSpawner.cs)を継承したそれぞれのSpawnerから生み出す。
* [BulletSpawner](https://github.com/KanbaraRyusei/Abstract_Factory_Demo/blob/main/Assets/Scripts/BulletSpawner.cs)はabstractである。
* パラメータを[BaseSpawnParameter](https://github.com/KanbaraRyusei/Abstract_Factory_Demo/blob/main/Assets/Scripts/BaseSpawnParameter.cs)を継承したそれぞれのクラスから渡している。
* ScriptableObjectを使っているので[BulletDataPathManager](https://github.com/KanbaraRyusei/Abstract_Factory_Demo/blob/main/Assets/Scripts/BulletDataPathManager.cs)からPathを取ってきている。
* また、[BulletPathManager](https://github.com/KanbaraRyusei/Abstract_Factory_Demo/blob/main/Assets/Scripts/BulletPathManager.cs)からResourceを取ってきている。
* Scene上に[GameManager](https://github.com/KanbaraRyusei/Abstract_Factory_Demo/blob/main/Assets/Scripts/GameManager.cs)をつけたGameObjectがあれば動くようになっている。

## 作ってみた感想
* 弾を発射するだけだと、2度手間になったり、他のアプローチの方がいろいろと早かったりするが、いい勉強になったと思う。
* 完全に理解したとは思ってないので間違いの指摘や改善案があれば Issue や Pullrequest をどんどん投げてもらいたい。
