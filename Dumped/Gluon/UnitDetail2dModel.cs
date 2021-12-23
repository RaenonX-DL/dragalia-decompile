using System.Runtime.InteropServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitDetail2dModel : MonoBehaviour
	{
		public static readonly Vector2Int charaDetailSpriteSize;

		private const string unit2dModelPath = "Images/OutGame/UnitDetail/";

		public static readonly string talismanBg;

		public static readonly string talismanFrame;

		private Image image;

		private void Awake()
		{
		}

		public void SetBgCharacterImage(int charaId, Rarity rarity)
		{
		}

		public static Material GetBgCharacterMaterial(int charaId, Rarity rarity)
		{
			return null;
		}

		public static void ReleaseBgCharacterMaterial(int charaId, Rarity rarity)
		{
		}

		public static string GetBgCharacterMaterialPath(int charaId, Rarity rarity)
		{
			return null;
		}

		public void SetBgDragonImage(int dragonId)
		{
		}

		public static Material GetBgDragonMaterial(int dragonId)
		{
			return null;
		}

		public static void ReleaseBgDragonMaterial(int dragonId)
		{
		}

		public static string GetBgDragonMaterialPath(int dragonId)
		{
			return null;
		}

		public void SetBgAmuletImage(int amuletId, int limitBreakLevel)
		{
		}

		public static Material GetBgAmuletMaterial(int amuletId, int limitBreakLevel)
		{
			return null;
		}

		public static void ReleaseBgAmuletMaterial(int amuletId, int limitBreakLevel)
		{
		}

		public static string GetBgAmuletMaterialPath(int amuletId, int limitBreakLevel)
		{
			return null;
		}

		public static Material GetBgTalismanMaterial(string materialName)
		{
			return null;
		}

		public static void ReleaseBgTalismanFrameMaterial(string materialName)
		{
		}

		public static void SetUnitDetailSprite(FlPlane plane, Material replaceMat, [Optional] string planeName)
		{
		}
	}
}
