# UniCopyField

## What is
クラスにおいて子同士の関係にあるメンバ変数の値をコピーするエディタ拡張。
1. メニューのWindow/CopyComponentPropertyを選択
2. コピー元とコピー先のコンポーネントをドラッグ・アンド・ドロップ
3. 実行を押す
4. コピーが実行される

※UnityのContextMenuでは異なるクラス間の値のコピーができないため作った。

## Example
基底クラスCommonはメンバ変数をいくつか持つ。
Commonを継承したOriginとTarget間のメンバ変数のコピーを行う。
![result](https://github.com/tetsujp84/UniCopyField/blob/add-gif/copygif.gif)

