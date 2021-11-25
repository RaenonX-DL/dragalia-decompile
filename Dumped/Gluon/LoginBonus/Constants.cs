namespace Gluon.LoginBonus
{
	public static class Constants
	{
		public enum UIPlaneKind
		{
			Back,
			Middle,
			Front,
			Nof
		}

		public enum FlashResourceKind
		{
			GetIcon,
			TodayStamp,
			TomorrowStamp,
			TitleBoard,
			Nof
		}

		public const string popupPrefabPath = "Prefabs/OutGame/LoginBonus/LoginBonusPopup";

		public const string charaRootPrefabPath = "Prefabs/OutGame/LoginBonus/LoginBonusCharaRoot";

		public const string unitShaderSettingPath = "Prefabs/OutGame/LoginBonus/LoginBonusUnitShaderSettings";

		public static readonly float[] UIPlaneDistance;

		private static readonly string[] _flashResourcePaths;

		public static string getFlashResourcePaths(int kindIndex)
		{
			return null;
		}
	}
}
