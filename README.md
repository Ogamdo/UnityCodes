


중간고사 대체 과제물 : 게임 기획(이동 및 회전, 애니메이션, 네비게이션, UI, 레이캐스트)<br>
<h1제목 : Doca Doca</h1>


<hr>
2023.12.04 구현기능

1.이동 및 회전 구현. 독특한 기능을 넣어보려다가 잘 안되서 ppt의 코드를 배낌 <br>
2.달리는 애니메이션. asset에 있던 기본 애니메이션 <br>
3.시간관리와 코딩능력, 그 외 자원의 부족으로 인해 제 시간 내에 완성하지 못했음. <br>
4.방학 때에는 전공 복습을 하자...<br>

<hr>

2023.10.23 기획 초안
<p>0.시눕시스 : 견주이자 집사인 김주사씨는 정체불명의 무장세력들에게 납치를 당했다.설산에 자리잡은 무장세력은 자신들이 만들어낸 약으로 주변환경을 오염시키고, 김주사씨에게 무언가를 하려고 한다. 주인이 잡혀갈 때 무장세력에게 저항을 하던 중, 무언가 잘못된 약물에 맞은 수캐‘탕탕’은 자칭 고양이귀마법소녀 ‘시로’에게 구조된다. 무장세력의 정체를 밝히기 위해 움직이는 ‘시로’와 ’탕탕’은 함께 그들의 본거지인 설산으로 가려 한다.</p>
 총 맞는 연기를 잘해서 ‘탕탕’이가 됐지만, 이제는 진짜 총에 맞을 수도 있다. 마법’소녀’이기에 잘못하면 요절할 수 있다. 하지만 싸워야만 한다. 그들의 사투가 시작된다!!!
1.장르 및 유저체험 : FPS 장르로 한다. 나무 괴물들이 플레이어를 발견하면 네비게이션 기능을 통해 달려오도록 한다. 적을 처치하면 Game Manger가 스코어를 기록하고, 남은 적의 수를 감소시킨다. 
 나무 괴물들은 매우 빠른 속도의 불꽃공을 쏟아낸다.(일명 파이어볼트) 이 불꽃공은 피격 부위에 따라 1~3번 맞으면 사망한다. 실제 총격전이 벌어지는 잠입 및 구출 작전을 경험과 유사한 경험을 할 수 있게 한다.<br>
2.학습한 내용들을 녹이기 <br>
(1)플레이어블 캐릭터인 산탄총을 사용하고, 총알은 발사되면서 프랩 등의 기능을 사용한다. 총은 ButtonDown을 통해 발사되고, 플레이어블 캐릭터는 wasd키를 통해서 움직인다.(Inputkey 명령어를 사용하여 제어한다.)<br>
(2)플레이어는 ‘시로’의 도움을 받아서 공중화력지원이나, 박격포 지원 등을 받을 수 있게 한다. 이 때 사용할 지원의 내용이나 남은 사용 횟수는 Unity UI를 통해 표현한다.<br> 지원요청은 우클릭 후 나타나는 드론으로 위치를 지정한다. 드론이 나타나면 잠시동안 플레이어는 드론의 시점으로 지면을 보게 된다. 이 때 카메라가 움직이게 한다. 드론은 회전도 가능하게 한다.<br>
(3)사용자가 특수 구출작전을 펼치는 경험을 하는 것 또한 목표이기에, 웅장한 음악으로 게임의 분위기를 고조시킨다.(오디오 소스 등 사용)<br>
(4)유니티 에셋 스토어에서 게임 보이스를 다운받아서 플레이어블 캐릭터가 움직일 때마다 오디오 소스가 재생되게 한다. 필요하다면 직접 음성을 녹음하거나, AI 기술 등을 사용한다.<br>
(6)총격을 당하거나 가할 때 프랩과 레이캐스트의 기능이 적용되도록 한다.<br>
(7)설산을 배경으로 나무 뒤에서 게임이 시작되며, 적을 모두 제거하거나 ‘김주사’에 도달하면 게임이 클리어된다. (주인을 만나 게임이 클리어될 경우 트리거 기능을 사용하여 구현한다.).<br>
(8)제한시간을 5분으로 하며, 1분이 남았을 때에는 산사태가 일어나서 커다란 눈덩이가 굴러다니게 한다. 이 눈덩이는 바위 등 무생물 오브젝트에 부딪히면 부서지거나 반대쪽으로 회전한다.(Collider 기능 사용하여 구현함)<br>
3. 사용할 툴과 에셋들
버전관리 : git bash와 github의 public resistory를 이용한다.
플레이어블 캐릭터(‘탕탕’)는 왼쪽의 Dog knight(Dog Knight PBR Polyart | 3D 동물 | Unity Asset Store)를 사용한다.)
적 캐릭터는 오른쪽의 Angry log(FREE - Animated Angry Log - Revenge of the Tree | 3D 생물 | Unity Asset Store)를 사용한다
우호 NPC(‘시로)는 FancyDoll - C000: Little Cat Girl(FancyDoll - C000: Little Cat Girl | 2D 캐릭터 | Unity Asset Store)을 이용한다.
 음악은 우측의 Orchestral Fantasy Music - REALM Lite(Orchestral Fantasy Music - REALM Lite | 오케스트라 음악 | Unity Asset Store)을 이용한다.
 그 외에는 더 자료조사와 연구를 하여 보충한다.
![image](https://github.com/Ogamdo/DocaDoca/assets/91306764/2813f578-4972-4df0-bf26-d8b9ceb1e4e8)<h1>DoCaDoCa</h1>
![image](https://github.com/Ogamdo/DocaDoca/assets/91306764/631ecac0-c893-4ee4-bc3d-4adeef560c3b)
![image](https://github.com/Ogamdo/DocaDoca/assets/91306764/6e1f6e26-619e-4926-b582-007bc5909bd7)
![image](https://github.com/Ogamdo/DocaDoca/assets/91306764/b388e09f-91e2-487a-8663-b32770291d4e)
