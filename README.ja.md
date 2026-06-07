<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# SimpleJSON

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.json.simplejson)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.json.simplejson)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## プロジェクト概要

SimpleJSON をベースにした修正版で、主に GameFrameX のサブライブラリとして使用されます。このライブラリは Unity 向けの改良された JSON ライブラリを提供します。

### 変更点

1. ストリップフィルタリング用の `link.xml` を追加
2. アンチストリップスクリプト `SimpleJSONCroppingHelper` を追加

## クイックスタート

### インストール

以下のいずれかの方法を選択してください：

1. Unity プロジェクトの `Packages/manifest.json` を編集し、`scopedRegistries` セクションを追加してください：
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.json.simplejson": "1.1.1"
     }
   }
   ```

   `scopes` は、どのパッケージをこのレジストリから解決するかを制御します。`com.gameframex` で始まるパッケージのみがこのレジストリから取得されます。

2. `manifest.json` の `dependencies` に直接追加：
   ```json
   {
      "com.gameframex.unity.json.simplejson": "https://github.com/gameframex/com.gameframex.unity.json.simplejson.git"
   }
   ```
3. Unity の **Package Manager** で **Git URL** を使用して追加：`https://github.com/gameframex/com.gameframex.unity.json.simplejson.git`
4. リポジトリを Unity プロジェクトの `Packages` ディレクトリにクローンしてください。自動的に読み込まれます。
## ドキュメントとリソース

- ドキュメント: https://gameframex.doc.alianblank.com
- リポジトリ: https://github.com/GameFrameX/com.gameframex.unity.json.simplejson


## 依存関係

| パッケージ | 説明 |
|----------|------|
| (无) | - |


## コミュニティとサポート

- QQグループ: 467608841 / 233840761

## 変更履歴

[Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.json.simplejson/releases) で変更履歴を確認してください。
## ライセンス

詳しくは [LICENSE.md](LICENSE.md) をご参照ください。
