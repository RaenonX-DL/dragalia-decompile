using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class StoryBgToCharaColorTable : ScriptableObject
	{
		private const string fileName = "StoryBgToCharaColorTable";

		private const string resourcesPath = "Images/Story/StoryBgToCharaColorTable";

		private const string assetPath = "Assets/_GluonResources/Resources/Images/Story/StoryBgToCharaColorTable";

		[SerializeField]
		private List<StoryBgToCharaColorTableElement> list;

		public static StoryBgToCharaColorTable Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<StoryBgToCharaColorTableElement> List => null;

		public static void Load()
		{
		}
	}
}
