<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# SimpleJSON

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.json.simplejson?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.json.simplejson?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/blob/main/LICENSE)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援**

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · [QQグループ](https://qm.qq.com/q/5s5e1e6e6e)

**言語**: [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

---

## プロジェクト概要

SimpleJSON をベースにした修正版で、主に GameFrameX のサブライブラリとして使用されます。このライブラリは Unity 向けの改良された JSON ライブラリを提供します。

### 変更点

1. ストリップフィルタリング用の `link.xml` を追加
2. アンチストリップスクリプト `SimpleJSONCroppingHelper` を追加

## クイックスタート

### インストール

以下のいずれかの方法をお選びください：

1. プロジェクトの `manifest.json` の `dependencies` セクションに以下を追加：
   ```json
   {"com.gameframex.unity.json.simplejson": "https://github.com/AlianBlank/com.gameframex.unity.json.simplejson.git"}
   ```

2. Unity の Package Manager で `Git URL` を使用：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.json.simplejson.git
   ```

3. リポジトリをダウンロードして Unity プロジェクトの `Packages` ディレクトリに配置。自動的にロードされます。

## ドキュメントとリソース

- ドキュメント: https://gameframex.doc.alianblank.com
- リポジトリ: https://github.com/GameFrameX/com.gameframex.unity.json.simplejson

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE](LICENSE) ファイルを参照してください。
