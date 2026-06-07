<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# SimpleJSON

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.json.simplejson)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.json.simplejson)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 项目简介

基于 SimpleJSON 的二次修改版本，主要服务于 GameFrameX 作为子库使用。该库提供了适用于 Unity 的改进型 JSON 库。

### 改动功能

1. 增加 `link.xml` 的裁剪过滤
2. 增加 `SimpleJSONCroppingHelper` 防裁剪脚本

## 快速开始

### 安装

选择以下任一方式：

1. 编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：
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

   `scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

2. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：
   ```json
   {
      "com.gameframex.unity.json.simplejson": "https://github.com/gameframex/com.gameframex.unity.json.simplejson.git"
   }
   ```
3. 在 Unity 的 `Package Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/gameframex/com.gameframex.unity.json.simplejson.git`
4. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。
## 文档与资源

- 文档地址: https://gameframex.doc.alianblank.com
- 仓库地址: https://github.com/GameFrameX/com.gameframex.unity.json.simplejson


## 依赖

| 包 | 说明 |
|----|------|
| (无) | - |


## 社区与支持

- QQ群: 467608841 / 233840761

## 更新日志

查看 [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.json.simplejson/releases) 了解更新日志。
## 开源协议

本项目遵循 MIT 许可证。详细信息请查看 [LICENSE](LICENSE) 文件。
