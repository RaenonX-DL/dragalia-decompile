using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QSLandMarkController : MonoBehaviour
	{
		public class landMarkPosInfo
		{
			public Vector3 landMarkPosition;

			public Vector3[] dotPositionArray;

			public QuestLocationInfo questLocation;
		}

		public class chapterLandMarkPosInfo
		{
			public List<landMarkPosInfo> landMarkPosInfoList;
		}

		[SerializeField]
		public GameObject originalCell;

		protected LinkedList<GameObject> cellList;

		private List<QSTableViewData> tableData;

		private readonly string landmarkPosPrefabPathFormat;

		private Dictionary<int, chapterLandMarkPosInfo> chapterLandMarkInfoDic;

		private chapterLandMarkPosInfo GetChapterLandMarkPosInfo(int chapterNo)
		{
			return null;
		}

		private GameObject GetGameObjectByIndex(GameObject[] objs, int index)
		{
			return null;
		}

		public Vector3 GetLandmarkPos(int chapterNo, int routeGroupNumber, int routeIndex)
		{
			return default(Vector3);
		}

		private landMarkPosInfo GetLandmarkPosByQuestLocationInfo(chapterLandMarkPosInfo chapterLandMarkPosInfo, int routeGroupNumber, int routeIndex)
		{
			return null;
		}

		public Vector3 GetRouteDotPos(int chapterNo, int routeGroupNumber, int routeIndex, int dotIndex)
		{
			return default(Vector3);
		}

		public int GetRouteDotNum(int chapterNo, int routeGroupNumber, int routeIndex)
		{
			return default(int);
		}

		public void LoadData()
		{
		}

		private void Sort(ref List<QSTableViewData> table)
		{
		}

		public bool IsEnable(QuestMainMenuElement qmme)
		{
			return default(bool);
		}

		public bool IsAppear(QuestMainMenuElement a_qmme)
		{
			return default(bool);
		}

		public bool IsExist(QuestMainMenuElement a_qmme)
		{
			return default(bool);
		}

		protected void ClearCellsList()
		{
		}
	}
}
