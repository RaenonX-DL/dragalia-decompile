/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetail2dModel : MonoBehaviour
	{
		// Fields
		public static readonly Vector2Int charaDetailSpriteSize;
		private const string unit2dModelPath = "Images/OutGame/UnitDetail/";
		private Image image;
	
		// Constructors
		public UnitDetail2dModel();
		static UnitDetail2dModel();
	
		// Methods
		private void Awake();
		public void SetBgCharacterImage(int charaId, Rarity rarity);
		public static Material GetBgCharacterMaterial(int charaId, Rarity rarity);
		public static void ReleaseBgCharacterMaterial(int charaId, Rarity rarity);
		public static string GetBgCharacterMaterialPath(int charaId, Rarity rarity);
		public void SetBgDragonImage(int dragonId);
		public static Material GetBgDragonMaterial(int dragonId);
		public static void ReleaseBgDragonMaterial(int dragonId);
		public static string GetBgDragonMaterialPath(int dragonId);
		public void SetBgAmuletImage(int amuletId, int limitBreakLevel);
		public static Material GetBgAmuletMaterial(int amuletId, int limitBreakLevel);
		public static void ReleaseBgAmuletMaterial(int amuletId, int limitBreakLevel);
		public static string GetBgAmuletMaterialPath(int amuletId, int limitBreakLevel);
		public static void SetUnitDetailSprite(FlPlane plane, Material replaceMat, string planeName = null);
	}
}
