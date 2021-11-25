using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class MyPageSkitMap : MonoBehaviour
	{
		private class SynchronizeAnimatorSet
		{
			private Animator parentCharacterAnimator;

			private Animator specialObjectAnimator;

			public SynchronizeAnimatorSet(Animator parentCharacterAnimator, Animator specialObjectAnimator)
			{
			}

			public void Synchronize()
			{
			}
		}

		public MyPageScene scene;

		public GameObject bgNode;

		public GameObject effectNode;

		public MyPageTransitionController transition;

		public MyPageSkitMapBgContent currentBgContent;

		public MyPageSkitMapBgContent nextBgContent;

		public MyPageSkitMapBgSpeicalEffectHelper specialEffectHelper;

		public GameObject[] characterObjects;

		public GameObject[] touchCubes;

		public string[] characterNames;

		public int[] characterIds;

		public List<GameObject> items;

		public GameObject dragonObject;

		public GameObject enemyObject;

		public List<EffectObject> effectList;

		public List<MyPageMapCharacters.CharacterData> characterDataList;

		public bool isSceneLoadCompleted;

		private GameObject[] specialObjects;

		private string lastMapSceneName;

		private int targetCharacterCount;

		private int loadedCharacterCount;

		private string treasureNpcDragonId;

		private const string spesialObjectNameNewYear = "MO00006";

		private const string spesialObjectNameHunter = "MO00011";

		private const string spesialObjectGoldSnapper = "MO00013";

		private const string spesialObjectRedSnapper = "MO00014";

		private const float goldSnapperDisplayProbability = 0.1f;

		private List<SynchronizeAnimatorSet> synchronizeAnimatorSet;

		public GameObject extraCharacterObject;

		public GameObject extraCharacterTouchCube;

		private const SimpleCharacterModelLoader.OutGameScene modelLoadScene = SimpleCharacterModelLoader.OutGameScene.MyPage;

		private int loopCount;

		private const int synchronizeFalame = 10;

		private void Update()
		{
		}

		public void DestroyMyResources()
		{
		}

		public void LoadBgScene(string filename)
		{
		}

		public void UnLoadLastLigthMapScene()
		{
		}

		public IEnumerator UnLoadLastLigthMapSceneWaitCoroutine()
		{
			return null;
		}

		private IEnumerator LoadBgSceneCoroutine(string filename)
		{
			return null;
		}

		private void LoadCharaPosSetting()
		{
		}

		public void LoadCharacters(MyPageMapCharacters characters)
		{
		}

		public bool IsAllCharacterLoaded()
		{
			return default(bool);
		}

		private void SetupCharacter(int charaIndex, int positionIndex)
		{
		}

		private void SetupCharacterImpl(int charaIndex, int positionIndex)
		{
		}

		private void SetupDragonImpl(int charaIndex, int positionIndex)
		{
		}

		private void SetupExtraCharacter()
		{
		}

		private IEnumerator SetupCharacterCoroutine(int charaIndex, int positionIndex, GameObject character)
		{
			return null;
		}

		private IEnumerator SetupDragonCoroutine(int charaIndex, int positionIndex, GameObject character, string animationName)
		{
			return null;
		}

		private IEnumerator SetupExtraCharaCoroutine(GameObject character)
		{
			return null;
		}

		private void SetupCharacterAnimationCompleted(Object controller, GameObject character, int index, MyPageMapAnimations.Motion motionId)
		{
		}

		private void SetupCharacterItemCompleted(Object itemPrefab, Transform jWeaponR, int charaIndex)
		{
		}

		private void TouchCubeLoaded(Object obj, int charaIndex)
		{
		}

		private void ExtraCharaTouchCubeLoaded(Object obj, int charaIndex)
		{
		}

		public void SetCanvasTouTouchCubes()
		{
		}

		private void ResetTouchCubes()
		{
		}

		private MyPageMapAnimations.Motion GetMotion(int index, int personMotionType)
		{
			return default(MyPageMapAnimations.Motion);
		}

		private MyPageMapAnimations.Motion GetMotionImpl(int index)
		{
			return default(MyPageMapAnimations.Motion);
		}

		private float GetMotionDelay(int index)
		{
			return default(float);
		}

		private Vector3 GetCharacterPos(int index)
		{
			return default(Vector3);
		}

		private Vector3 GetCharacterRotation(int index)
		{
			return default(Vector3);
		}

		public MyPageBalloon.TextType GetWindowType(int index)
		{
			return default(MyPageBalloon.TextType);
		}

		private void LoadTreasureNpc()
		{
		}

		private void LoadTreasureNpcImpl()
		{
		}

		public void SetCharacterAnimationEnable(bool arg)
		{
		}

		public void SetCharacterBlinkEnable(bool enabled)
		{
		}

		public Color GetAmbientColor()
		{
			return default(Color);
		}

		public void LoadSpecialEffect()
		{
		}

		private IEnumerator LoadSpecialEffectCoroutine()
		{
			return null;
		}

		private void SetUpNhaamImpl(int charaIndex, int positionIndex)
		{
		}

		private IEnumerator SetupNhaamCoroutine(int charaIndex, int positionIndex, GameObject character, string modelName)
		{
			return null;
		}
	}
}
