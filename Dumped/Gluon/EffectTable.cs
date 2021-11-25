using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class EffectTable : ScriptableObject
	{
		private const string FILE_NAME = "EffectTable";

		private const string RESOURCES_PATH = "Effect/EffectTable";

		public const string ASSET_PATH = "Assets/_GluonResources/Resources/Effect/EffectTable";

		[SerializeField]
		private List<EffectTableElement> list;

		private Dictionary<string, List<string>> _dic;

		public static EffectTable Instance
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

		public List<EffectTableElement> List => null;

		public Dictionary<string, List<string>> Dic => null;

		public static void Load()
		{
		}
	}
}
