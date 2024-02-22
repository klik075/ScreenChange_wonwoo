# 유니티 게임개발 심화주차 개인 프로젝트 (정원우)

## 

### 필수 요구사항

1. 캐릭터 만들기
   
    ![화면 캡처 2024-02-22 104632](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/b9a22362-adc1-4b46-879d-34d04d5cc529)

2. 캐릭터 이동

   WASD로 이동을 하고 마우스를 향한 방향으로 스프라이트가 회전된다.

     ![화면 캡처 2024-02-22 104835](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/7da1d50f-9979-4dc5-ae1a-dc61a01bae26)

3. 방 만들기

    직사각형의 바닥만 존재하고 바닥을 못 넘어가게 타일맵 콜라이더를 설정헸다.

    * 바닥 모습
    
      ![화면 캡처 2024-02-22 104958](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/769489e7-e445-4a17-b40a-3a2468750501)

    * 타일맵 콜라이더 적용
    
      ![화면 캡처 2024-02-22 105333](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/a0167e35-d12e-4215-ab43-ea4970957119)

4. 카메라 따라가기

    플레이어의 위치를 참조하고 자신의 위치를 플레이어의 x,y 값으로 이동하게 했다.

      * 카메라에 스크립트 부착

        ![화면 캡처 2024-02-22 105807](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/24b7cad0-ec90-4412-9098-8b4be1f507da)
---
### 선택 요구사항

1. InputAction 사용

   움직임을 담당하는 Move와 스프라이트 회전을 위한 Look

   * Player InpuAction

      ![화면 캡처 2024-02-22 110438](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/000b4dca-b9df-4130-a16c-7d0d56cef036)

2. Delegate 사용

   Action을 사용해서 구독

   * Player 스크립트

     ![화면 캡처 2024-02-22 110827](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/4d8cbdc0-dd25-48e3-a9b6-45b6f61cd2ac)

3. 로그인 씬에서 코인 애니메이션 추가

   문제 발생 : 코인 애니메이션을 UI에서 적용하려고 처음 시도했을 때 UI 하위에 게임 오브젝트를 생성했는데 UI상에서 안 보이는 문제가 발생했다.

   해결 방법 : UI상에서는 게임 오브젝트가 보이지 않아서 Image 객체를 생성하고 Image의 sprite를 코인으로 변경했다. Image객체를 가지고 애니메이션을 만들어서 적용했다.  

   * Idle 애니메이션 (시작 버튼을 누르지 않았을 때는 가만히 회전만 하는 애니메이션)
   
     ![화면 캡처 2024-02-22 111258](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/6a96f6f9-bae8-4306-a928-2e694e1e39aa)

   * StartGame 애니메이션 (시작 버튼을 누르면 코인이 버튼을 향해 내려갔다가 올라가면서 씬 전환)

     ![화면 캡처 2024-02-22 112306](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/b7e0f7ab-2b0d-4ee0-8e75-2f3aa6f83dd8)

4. 코인 먹는 기능 및 소리 추가

    문제 발생 : 코인을 여러개 먹었을 때 이전 소리가 끝나기전에 다음 소리가 덮어쓰는 문제

    해결 방법 : 기존에는 오디오소스.Play()를 사용했는데 오디오소스.PlayOnShot(클립)으로 변경해주었다.

   ![화면 캡처 2024-02-22 112603](https://github.com/klik075/ScreenChange_wonwoo/assets/54103715/c62f798f-0952-45f1-bfc2-20850f19459e)
---
