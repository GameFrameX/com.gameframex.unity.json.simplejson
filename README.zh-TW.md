<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# SimpleJSON

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.json.simplejson)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.json.simplejson)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

基於 SimpleJSON 的二次修改版本，主要服務於 GameFrameX 作為子庫使用。該庫提供了適用於 Unity 的改進型 JSON 庫。

### 改動功能

1. 增加 `link.xml` 的裁剪過濾
2. 增加 `SimpleJSONCroppingHelper` 防裁剪腳本

## 快速開始

### 安裝

任選以下方式之一：

1. 直接在 `manifest.json` 的文件中的 `dependencies` 節點下添加以下內容：
   ```json
   {"com.gameframex.unity.json.simplejson": "https://github.com/AlianBlank/com.gameframex.unity.json.simplejson.git"}
   ```

2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加庫，地址為：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.json.simplejson.git
   ```

3. 直接下載倉庫放置到 Unity 項目的 `Packages` 目錄下，會自動加載識別。

## 文檔與資源

- 文檔地址: https://gameframex.doc.alianblank.com
- 倉庫地址: https://github.com/GameFrameX/com.gameframex.unity.json.simplejson

## 開源協議

本項目遵循 MIT 許可證。詳細信息請查看 [LICENSE](LICENSE) 文件。
