using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsList : ScriptableObject
	{
		public const string EXPORT_ACTOIN_DIRECTORY_PATH = "Assets/_GluonResources/Resources/Actions";

		public const string RESOURCES_PATH = "Actions/ActionPartsList";

		public const string ASSET_PATH = "Assets/_GluonResources/Resources/Actions/ActionPartsList";

		[SerializeField]
		private List<ActionPartsListElement> list;

		private Dictionary<string, List<string>> _dic;

		public static ActionPartsList Instance
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

		public Dictionary<string, List<string>> Dic => null;

		public static void Load()
		{
		}

		public static void Reset()
		{
		}
	}
}
