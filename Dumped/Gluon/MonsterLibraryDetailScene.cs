using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class MonsterLibraryDetailScene : SceneBase
	{
		public GameObject bgPanel;

		public Canvas mainCanvas;

		public GameObject monsterNode;

		public GameObject mainCamera;

		public static int showMonsterId;

		private MonsterViewBase monsterViewBase;

		private MonsterInfoBase monsterInfoBase;

		private MonsterHeaderBase monsterHeaderBase;

		private MonsterDetailStep nowDetailStep;

		private int nowPieceCount;

		private int maxPieceCount;

		private EnemyDataElement masterEnemyData;

		private EnemyListElement masterEnemyList;

		private const string scenePrefabPath = "Prefabs/OutGame/Note/MonsterLibrary/MonsterLibraryDetail/";

		[SerializeField]
		private MonsterLibraryCamera libraryCameras;

		private Vector3 cameraPositionOffset;

		private List<MonsterLibraryPlayerData> playerDataList;

		private int nowPlayerDataIndex;

		private void Start()
		{
		}

		private void BackButtonPressed()
		{
		}

		private void ChangePageButtonPressed(MonsterDetailArrow arrowDirection)
		{
		}

		private void PreviewButtonPressed()
		{
		}

		private void SetMonsterModel()
		{
		}

		private void SetNowDetailStep()
		{
		}

		private void SetMonsterHeader()
		{
		}

		private void SetMonsterInfo()
		{
		}

		private void SetCameraProperty()
		{
		}

		private void ReloadNowDetail()
		{
		}

		private bool SetupMonsterMasterData()
		{
			return default(bool);
		}
	}
}
