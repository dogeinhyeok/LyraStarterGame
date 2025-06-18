# LyraStarterGame 프로젝트

LyraStarterGame은 언리얼 엔진 학습을 위한 통합 템플릿 프로젝트입니다. 이 프로젝트는 언리얼 엔진 5.6 버전을 기반으로 개발되었습니다.

## 프로젝트 개요

LyraStarterGame은 언리얼 엔진의 다양한 기능과 실전 사용법을 체계적으로 익힐 수 있도록 설계되었습니다. 초보자부터 중급자까지 단계별로 따라갈 수 있는 실습 중심의 구조를 채택하여, 실제 게임 개발에 필요한 핵심 역량을 효과적으로 쌓을 수 있습니다.

### Visual Studio로 개발하기

#### 필수 확장 프로그램 설치하기

Workloads 아래 Game development with C++ 와 다음 옵션을 선택합니다.

- .NET desktop development
- Desktop development with C++
- Universal Windows Platform development
- Game development with C++
  - Unreal Engine installer

#### Visual Studio 프로젝트 생성하기

1. 프로젝트 폴더에서 `HowToUseUnrealEngine.uproject` 파일을 마우스 오른쪽 버튼으로 클릭합니다
2. `Generate Visual Studio project files` 메뉴를 선택합니다
3. 새로 생성된 `HowToUseUnrealEngine.sln` 솔루션 파일을 엽니다

#### Visual Studio에서 프로젝트 실행하기

1. 솔루션 구성을 `Development Editor`로 설정합니다
2. 솔루션 플랫폼을 `Win64`로 설정합니다
3. 솔루션 탐색기에서 HowToUseUnrealEngine 프로젝트를 마우스 오른쪽 버튼으로 클릭하고 `디버그 > 새 인스턴스 시작`을 선택합니다

### VSCode로 개발하기

#### 필수 확장 프로그램 설치하기

- [C/C++ Extension Pack](https://marketplace.visualstudio.com/items?itemName=ms-vscode.cpptools-extension-pack)
- [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
- [.NET SDK](https://dotnet.microsoft.com/ko-kr/download)

#### Visual Studio Code 프로젝트 생성하기

1. 프로젝트 폴더에서 `HowToUseUnrealEngine.uproject` 파일을 마우스 오른쪽 버튼으로 클릭합니다
2. `Generate Visual Studio Code project files` 메뉴를 선택합니다 (없을 경우 언리얼 에디터 환경설정에서 기본 소스 코드 에디터를 VSCode로 변경하세요)
3. VSCode에서 `File > Open Folder`를 선택하고 HowToUseUnrealEngine 프로젝트 폴더를 엽니다

#### Visual Studio Code에서 프로젝트 실행하기

1. VSCode에서 실행 및 디버그 탭을 클릭합니다 (Ctrl+Shift+D)
2. 실행 및 디버그 드롭다운에서 `Launch HowToUseUnrealEngine (Development)`를 선택합니다
3. 실행 버튼을 클릭합니다

#### Cursor에서 프로젝트 실행하기

1. Cursor에서는 라이센스 문제로 언리얼 엔진을 직접 실행할 수 없습니다.
2. 대신 Cursor를 사용하여 소스 코드를 편집하고 저장한 후, VSCode를 백그라운드에서 실행하여 개발 환경을 유지할 수 있습니다.
3. 코드 변경 후에는 언리얼 엔진 에디터로 돌아가 컴파일 버튼(⟳)을 클릭하여 변경사항을 적용하고 실행할 수 있습니다.

### 코드 수정 및 실행하기

1. 언리얼 엔진 에디터에서 `Edit > Editor Preferences > Live Coding > Enable Live Coding`을 비활성화합니다.
2. Visual Studio 또는 VSCode(또는 Cursor)에서 코드를 수정하고 저장합니다 (Ctrl+S).
3. 코드를 컴파일합니다:

   - **언리얼 에디터**: 에디터 내에서 `컴파일` 버튼(⟳) 클릭
   - **Visual Studio**: 솔루션 빌드(F7) 또는 `빌드 > 솔루션 빌드` 메뉴 선택
   - **Visual Studio Code**: 명령 팔레트(Ctrl+Shift+P)에서 `Tasks: Run Build Task` 실행

4. 코드 인텔리센스가 제대로 적용되도록 프로젝트를 새로고침합니다:

   - **Visual Studio**: 언리얼 에디터에서 `Tools > Refresh Visual Studio Project` 클릭
   - **Visual Studio Code**: 언리얼 에디터에서 `Tools > Refresh Visual Studio Code Project` 클릭

5. 언리얼 에디터에서 `Play` 버튼을 클릭하여 레벨을 실행하고 변경 사항을 테스트합니다.

## 개발 환경

- 언리얼 엔진 5.6
- Visual Studio 2022
- Visual Studio Code(+ Cursor)
- Windows 10/11

## 프로젝트 구조

- **Source/**: C++ 소스 코드
- **Content/**: 블루프린트, 에셋, 레벨 등 콘텐츠
- **Config/**: 프로젝트 설정 파일

## 문서화 규칙

자세한 코드 주석 및 문서화 규칙은 `.cursor/rules/` 폴더를 참조해주세요.

## 기여하기

1. 프로젝트를 포크합니다.
2. 새로운 브랜치를 생성합니다.
3. 변경사항을 커밋합니다.
4. 브랜치에 푸시합니다.
5. Pull Request를 제출합니다.
