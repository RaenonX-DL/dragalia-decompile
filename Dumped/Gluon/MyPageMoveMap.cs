using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class MyPageMoveMap : MonoBehaviour
	{
		public static int maxWindmills;

		public GameObject bgNode;

		public GameObject playerNode;

		public GameObject groundBase;

		public GameObject walkBase;

		public GameObject groundNode;

		public GameObject buildingTavernNode;

		public GameObject buildingInnNode;

		public GameObject buildingShopNode;

		public GameObject runningBuildingNode1;

		public GameObject runningBuildingNode2;

		public GameObject runningBuildingNode3;

		public GameObject[] windmillNodes;

		public GameObject charaNodesParent;

		public GameObject talkingPairCharaNode1;

		public GameObject talkingPairCharaNode2;

		public GameObject byeCharaNode;

		public GameObject walkingCharaNode;

		public GameObject runMapCharaNode1;

		public GameObject runMapCharaNode2;

		public GameObject runMapCharaNode3;

		public GameObject runMapCharaNode4;

		public GameObject windmillWatchPoint;

		public GameObject windmillWatchPoint2;

		public GameObject windmillWatchPoint3;

		public GameObject windmillWatchPoint4;

		public GameObject birdEffectWatchPoint;

		public GameObject buildingWatchPoint;

		public GameObject runningBuildingWatchPoint1;

		public GameObject runningBuildingWatchPoint2;

		public GameObject runningBuildingWatchPoint3;

		public GameObject birdEffectNode;

		public MyPageScene scene;

		public MyPageTransitionController transition;

		public GameObject playerObject;

		public GameObject nhaamObject;

		public GameObject ExtraCharaObject;

		public GameObject[] characterObjects;

		public string[] characterNames;

		public int[] characterIds;

		public List<MyPageMapCharacters.CharacterData> characterDataList;

		[HideInInspector]
		public MyPageMoveMapWindmill[] windmills;

		[HideInInspector]
		public EffectObject birdEffectObject;

		[HideInInspector]
		public MyPageMoveMapBgContent bgContent;

		[HideInInspector]
		public MyPageMoveMapGround currentGround;

		[HideInInspector]
		public MyPageMoveMapGround nextGround;

		[HideInInspector]
		public List<MyPageMoveMapBuilding> currentBuilding;

		[HideInInspector]
		public List<MyPageMoveMapBuilding> nextBuilding;

		[HideInInspector]
		public List<MyPageMoveMapWindmill> nextWindmills;

		private const int loadWindmillWaitCount = 10;

		private string lastGroundSceneName;

		private List<string> lastBuildingSceneNames;

		private List<string> loadingBuildingSceneNames;

		private string lastWindmillSceneName;

		private int loadedCharacterModelCount;

		private int loadedCharacterAnimCount;

		private int targetCharacterCount;

		private const SimpleCharacterModelLoader.OutGameScene modelLoadScene = SimpleCharacterModelLoader.OutGameScene.MyPage;

		public bool isGroundSceneLoadCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int buildingSceneLoadCompletedCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int windmillSceneLoadCompletedCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool hasBuilding
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool hasWindmill
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool existsBirdEffect
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool existsWindmill
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int numOfWindmills
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void DestroyMyResources()
		{
		}

		public void LoadBG(string filename, Action<MyPageMoveMapBgContent> onCompleted)
		{
		}

		private void LoadBgOnCompleted(UnityEngine.Object asset, Action<MyPageMoveMapBgContent> onCompleted)
		{
		}

		public void LoadPlayer(int charaId, string filename, Action<GameObject> onCompletedAction)
		{
		}

		private void LoadPlayerOnCompleted(GameObject obj, Action<GameObject> onCompletedAction, int charaId)
		{
		}

		public void LoadNhaam(Action<GameObject> onCompletedAction)
		{
		}

		private void LoadNhaamOnCompleted(GameObject obj, Action<GameObject> onCompletedAction)
		{
		}

		private IEnumerator AddNhaamEffectCoroutine()
		{
			return null;
		}

		public void LoadExtraChara(Action<GameObject> onCompletedAction)
		{
		}

		private void LoadExtraCharaOnCompleted(GameObject obj, Action<GameObject> onCompletedAction)
		{
		}

		public void LoadGroundScene(string filename)
		{
		}

		public AsyncOperation UnLoadLastGroundScene()
		{
			return null;
		}

		public IEnumerator UnLoadLastGroundSceneWaitCoroutine()
		{
			return null;
		}

		private IEnumerator LoadGroundCoroutine(string filename)
		{
			return null;
		}

		public void LoadBuildingScene(string filename, bool isAdditive)
		{
		}

		public void UnLoadLastBuildingScene()
		{
		}

		public IEnumerator UnLoadLastBuildingSceneWaitCoroutine()
		{
			return null;
		}

		private IEnumerator LoadBuildingCoroutine(string filename, bool isAdditive)
		{
			return null;
		}

		public void LoadWindmillScene(string filename)
		{
		}

		private IEnumerator LoadWindmillCoroutine(string filename)
		{
			return null;
		}

		public void CreateWindmill()
		{
		}

		private IEnumerator CreateWindmillCoroutine()
		{
			return null;
		}

		public void UnLoadWindmillScene()
		{
		}

		public void LoadCharacters(MyPageTransitionController.MoveMapType currentMapType, MyPageTransitionController.DayTimeType dayTimeType, MyPageMapCharacters characters, bool isRunning)
		{
		}

		public bool IsAllCharacterModelLoaded()
		{
			return default(bool);
		}

		public bool IsAllCharacterAnimationLoaded()
		{
			return default(bool);
		}

		private void SetupCharater(int index, GameObject[] parentNodes, MyPageTransitionController.DayTimeType dayTimeType, bool isRunning)
		{
		}

		private IEnumerator SetupCharaterCoroutine(int index, GameObject character, GameObject[] parentNodes, MyPageTransitionController.DayTimeType dayTimeType, bool isRunning)
		{
			return null;
		}

		private void SetupCharacterAnimationCompleted(GameObject character, UnityEngine.Object controller, int index, MyPageTransitionController.DayTimeType dayTimeType, bool isRunning)
		{
		}

		private IEnumerator SetCharacterDefaultFacialAnimation(GameObject character)
		{
			return null;
		}

		public void SyncCharacterMotionWithBgm(int animationCount)
		{
		}

		public static MyPageMapAnimations.Motion GetMotion(MyPageMoveMapCharaPosSettings moveMapCharaPosSettings, int index, int personMotionType, bool isRunning)
		{
			return default(MyPageMapAnimations.Motion);
		}

		public MyPageBalloon.TextType GetWindowType(int index, bool isRunning)
		{
			return default(MyPageBalloon.TextType);
		}

		public void SetCharacterAnimationEnable(bool arg)
		{
		}

		public void ResetBirdEffect()
		{
		}

		public void LoadBirdEffect(MyPageTransitionController.DayTimeType dayTimeType)
		{
		}

		private IEnumerator LoadBirdEffectCoroutine(MyPageTransitionController.DayTimeType dayTimeType)
		{
			return null;
		}

		public void SetCharacterBlinkEnable(bool enabled)
		{
		}
	}
}
