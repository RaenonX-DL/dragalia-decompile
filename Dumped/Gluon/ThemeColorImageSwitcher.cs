using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class ThemeColorImageSwitcher : MonoBehaviour
	{
		[SerializeField]
		[Header("Sprites")]
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

		[SerializeField]
		[Header("Materials")]
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

		[SerializeField]
		[Header("Disable Sprite& Material")]
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

		private Image image => null;

		private void Reset()
		{
		}

		private Footer.MenuTab CheckSpriteNamesMatch(string originalPrefix, string checkingName, int suffixIndex, string originalSuffix)
		{
			return default(Footer.MenuTab);
		}

		private bool IsSpriteNameAutoGeneratable(string spriteName, out string prefix, out int suffixIndex, out string suffix)
		{
			return default(bool);
		}

		private void Start()
		{
		}

		public void ApplyImageAndMaterial()
		{
		}

		public void ApplyDisableSpriteAndMaterial()
		{
		}
	}
}
