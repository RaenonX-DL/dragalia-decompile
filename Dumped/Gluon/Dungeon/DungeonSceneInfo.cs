using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonSceneInfo : ScriptableObject
	{
		public const string AssetNamePrefix = "SCENEINFO_";

		public const string ScneneInfoName = "Dungeon/SceneInfo";

		public const string ResourceDir = "Dungeon/SceneInfo/";

		[SerializeField]
		private string[] _setGimmickPrefabNames;

		[SerializeField]
		private string[] _setReactionPrefabNames;

		[SerializeField]
		private string[] _setGatePrefabNames;

		[SerializeField]
		private string[] _setEtcPrefabNames;

		public string[] setGimmickPrefabNames => null;

		public string[] setReactionPrefabNames => null;

		public string[] setGatePrefabNames => null;

		public string[] setEtcPrefabNames => null;

		public static string MakeAssetName(string areaName)
		{
			return null;
		}

		public static DungeonSceneInfo LoadOrDefault(string areaName)
		{
			return null;
		}

		public static string GetAreaNameFromSceneInfoName(string fileNameWithoutExt)
		{
			return null;
		}
	}
}
