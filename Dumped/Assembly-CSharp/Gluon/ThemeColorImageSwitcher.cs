/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	[RequireComponent]
	public class ThemeColorImageSwitcher : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Sprite mypageSprite;
		[SerializeField]
		public Sprite growthSprite;
		[SerializeField]
		public Sprite partySprite;
		[SerializeField]
		public Sprite fortSprite;
		[SerializeField]
		public Sprite summonSprite;
		[SerializeField]
		public Sprite menuSprite;
		[SerializeField]
		public Sprite eventSprite;
		[SerializeField]
		public Sprite drillSprite;
		[Header]
		[SerializeField]
		public Material mypageMaterial;
		[SerializeField]
		public Material growthMaterial;
		[SerializeField]
		public Material partyMaterial;
		[SerializeField]
		public Material fortMaterial;
		[SerializeField]
		public Material summonMaterial;
		[SerializeField]
		public Material menuMaterial;
		[SerializeField]
		public Material eventMaterial;
		[SerializeField]
		public Material drillMaterial;
		[Header]
		[SerializeField]
		public Sprite disableSprite;
		public Material disableMaterial;
		private Sprite[] themeSprites;
		private Material[] themeMaterials;
		public Action onInitializedTheme;
		public static string[] searchMaterials;
		public const string atlasPath = "Atlas/";
		private const string atlasCompressPath = "AtlasCompress/";
		private Image _image;
		private static Dictionary<Footer.MenuTab, string[]> menuPath;
		private const string pngExtension = ".png";
		private const string matExtension = ".mat";
	
		// Properties
		private Image image { get; }
	
		// Constructors
		public ThemeColorImageSwitcher();
		static ThemeColorImageSwitcher();
	
		// Methods
		private void Reset();
		private Footer.MenuTab CheckSpriteNamesMatch(string originalPrefix, string checkingName, int suffixIndex, string originalSuffix);
		private bool IsSpriteNameAutoGeneratable(string spriteName, out string prefix, out int suffixIndex, out string suffix);
		private void Start();
		public void ApplyImageAndMaterial();
		public void ApplyDisableSpriteAndMaterial();
	}
}
