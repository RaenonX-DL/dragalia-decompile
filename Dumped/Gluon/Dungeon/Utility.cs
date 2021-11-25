using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Cute.Master;
using SerializableCollections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gluon.Dungeon
{
	public static class Utility
	{
		public delegate bool CameraSettingDelegate(Camera cam);

		public static readonly DungeonSubNode[] PrefabSubNodeList;

		public const string QuestPrefabPathBase = "Prefabs/InGame/Quest/";

		public const string QuestPrefabPath = "Assets/_GluonResources/Resources/Prefabs/InGame/Quest/";

		public static readonly string[] SubNodeNamesAuth;

		public static readonly string[] SubNodeNames;

		public const string PlayerPrefsKeyQuestPath = "DungeonName";

		public const string PlayerPrefsKeyAreaName = "QuestPrefabName";

		private const string UtilCaptureCameraPrefabPath = "Assets/_Debug/Utility/CaptureCamera.prefab";

		public static StringBuilder _bufferedLog;

		public static string GetSubNodeNameAuth(DungeonSubNodeAuth subNode)
		{
			return null;
		}

		public static GameObject FindSubNodeAuth(GameObject parent, DungeonSubNodeAuth subNode)
		{
			return null;
		}

		public static Transform FindSubNodeTransAuth(Transform parent, DungeonSubNodeAuth subNode)
		{
			return null;
		}

		public static string GetSubNodeName(DungeonSubNode subNode)
		{
			return null;
		}

		public static Transform FindSubNodeTrans(GameObject parent, DungeonSubNode subNode)
		{
			return null;
		}

		public static Transform FindSubNodeTrans(Transform parent, DungeonSubNode subNode)
		{
			return null;
		}

		public static GameObject FindSubNode(GameObject parent, DungeonSubNode subNode)
		{
			return null;
		}

		public static GameObject FindSubNode(Transform parent, DungeonSubNode subNode)
		{
			return null;
		}

		public static GameObject FindFirstSubNode(DungeonSubNode subNode)
		{
			return null;
		}

		public static void FindNodesByName(Transform trans, string nodeNameContains, List<GameObject> collection)
		{
		}

		public static List<GameObject> FindNodesByName(Transform trans, string nodeNameContains)
		{
			return null;
		}

		public static GameObject FindRootObject(Scene scene)
		{
			return null;
		}

		public static GameObject FindRootObject()
		{
			return null;
		}

		public static void SortSubNode(Transform rootNode)
		{
		}

		public static bool ConvertColorFromHexCode(out Color color, string hexCode, [Optional] Color defaultColor)
		{
			return default(bool);
		}

		public static string ConvertHexCodeFromColor(Color color)
		{
			return null;
		}

		public static void BufferedLog(string msg)
		{
		}

		public static void BufferedLogLine(string msg)
		{
		}

		public static void BufferedLogFlush()
		{
		}

		public static string GetDifficultyName(DungeonManager.eStageDifficulty diffcult)
		{
			return null;
		}

		public static DungeonManager.eStageDifficulty GetDifficultyFromName(string diffcultName)
		{
			return default(DungeonManager.eStageDifficulty);
		}

		public static bool IsDifficultyNode(Transform node)
		{
			return default(bool);
		}

		public static DungeonManager.eStageDifficulty GetDifficultyOf(Transform diffcultyNode)
		{
			return default(DungeonManager.eStageDifficulty);
		}

		public static Transform FindDifficuliyNodeOf(DungeonManager.eStageDifficulty difficulty)
		{
			return null;
		}

		public static bool IsQuestRootNode(Transform t)
		{
			return default(bool);
		}

		public static GameObject[] GetQuestRootNodes()
		{
			return null;
		}

		public static GameObject GetParentQuestRootNode(GameObject go)
		{
			return null;
		}

		public static bool CalculateBoundsUnder(out Bounds bounds, Transform calculateRoot)
		{
			return default(bool);
		}

		public static Vector3 RoundVec(Vector3 vec)
		{
			return default(Vector3);
		}

		public static void DebugLogWarnColored(string log)
		{
		}

		public static void DebugLogWarnColored(string fmt, string[] args)
		{
		}

		public static void DebugLogColored(string color, string log)
		{
		}

		public static T FindComponentInScene<T>(Scene scene) where T : Component
		{
			return null;
		}

		public static T[] FindComponentsInScene<T>(Scene scene, bool includeInactive) where T : Component
		{
			return null;
		}

		private static bool IsMatchAreaId(string areaName, string masterAreaName)
		{
			return default(bool);
		}

		private static bool IsMatchGimmmickDataLabel(string gimmickName, string masterGimmickName)
		{
			return default(bool);
		}

		private static string GetGimmickDataLabel(string gimmickName, string areaName, int difficulty)
		{
			return null;
		}

		public static T GetAreaQuestSkillData<T>(SerializableDictionary<string, T> AreaQuestSkillkMasterDict, string questSkillDataLable) where T : IMasterElement
		{
			return null;
		}

		public static T GetGimmickDataElement<T>(SerializableDictionary<string, T> gimmickMasterDict, GameObject gimmick) where T : IMasterElement
		{
			return null;
		}
	}
}
