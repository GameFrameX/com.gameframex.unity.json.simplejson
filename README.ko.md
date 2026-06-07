<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# SimpleJSON

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.json.simplejson)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.json.simplejson)](https://github.com/GameFrameX/com.gameframex.unity.json.simplejson/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

SimpleJSON을 기반으로 한 수정 버전으로, 주로 GameFrameX의 서브 라이브러리로 사용됩니다. 이 라이브러리는 Unity용으로 개선된 JSON 라이브러리를 제공합니다.

### 변경 사항

1. 스트립 필터링을 위한 `link.xml` 추가
2. 안티 스트립 스크립트 `SimpleJSONCroppingHelper` 추가

## 빠른 시작

### 설치

Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:

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
  ]
}
```

`scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.json.simplejson": "1.1.1"
  }
}
```

## 문서 및 자료

- 문서: https://gameframex.doc.alianblank.com
- 저장소: https://github.com/GameFrameX/com.gameframex.unity.json.simplejson


## 의존성

| 패키지 | 설명 |
|--------|------|
| (无) | - |


## 커뮤니티 및 지원

- QQ 그룹: 467608841 / 233840761

## 변경 로그

[Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.json.simplejson/releases)에서 변경 로그를 확인하세요.
## 라이선스

자세한 내용은 [LICENSE.md](LICENSE.md) 파일을 참조하세요.
