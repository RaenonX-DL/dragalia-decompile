using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gluon
{
	public class BgContentManager : SingletonMonoBehaviour<BgContentManager>
	{
		public class EnemyLoadInfo
		{
			public int index;

			public int id;

			public bool isLoaded;
		}

		private bool isBgLoadCompleted;

		private bool isOnEnemyLoadLoading;

		private int enemyLoadingQuestLocationId;

		private bool isSceneLoadCompleted;

		private Scene createdScene;

		private string fileName;

		private QuestBgSceneSettingKeeper _bgSettingKeeper;

		private const int startFogValue = 0;

		private const int endFogValue = 1000000;

		private const int maxEnemyNum = 3;

		private List<EnemyLoadInfo> enemyInfoList;

		private static DungeonManager.OutDesignerAreaDataCache designerAreaDataCache;

		private List<EnemyCharacter> enemyCharacterList;

		private readonly Vector3[] vecPosList;

		private readonly Vector3[] vecPosListThreeEnemy;

		private readonly Vector3[] vecRotList;

		public bool IsBgLoadCompleted => default(bool);

		public bool IsOnEnemyLoadLoading => default(bool);

		public bool IsSceneLoadCompleted => default(bool);

		public QuestBgSceneSettingKeeper bgSettingKeeper
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public void ResisterLoadBgScene(int questGroup)
		{
		}

		private IEnumerator ResisterLoadBgSceneCorutine(int questGroupId)
		{
			return null;
		}

		public void LoadBgScene(int questId)
		{
		}

		public void LoadBgSceneLocationId(int questLocationId)
		{
		}

		public void LoadBgScene(string resourcePath)
		{
		}

		private IEnumerator LoadBgSceneCoroutine(string resourcePath, int questLocationId = -1)
		{
			return null;
		}

		public void SetEnemyRenderParam()
		{
		}

		private void InitEnemyLoadInfo(EnemyLoadInfo info, int index, int enemyId)
		{
		}

		private GameObject CreateEnemyModel(int enemyId, int actionId)
		{
			return null;
		}

		private EnemyCharacter CreateEnemyModel(int enemyId)
		{
			return null;
		}

		public void CreateEnemyModelAll(List<EnemyLoadInfo> showEnemyLoadInfoList)
		{
		}

		private void SetEnemyAction(EnemyCharacter enemyObj, int enemyId, int actionId)
		{
		}

		public void LoadEnemyOnBg(QuestMainLocationElement elm)
		{
		}

		private bool IsEnemyLoadCompleted()
		{
			return default(bool);
		}

		private int getElement(int mapElement)
		{
			return default(int);
		}

		public void ShowBgScene(bool value)
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Destory()
		{
		}

		public void EnemyDestroy()
		{
		}

		protected IEnumerator LoadEffectResources()
		{
			return null;
		}

		public string GetMainLocationBgPath(QuestMainLocationElement qmle)
		{
			return null;
		}

		public string GetBgSceneName()
		{
			return null;
		}
	}
}
