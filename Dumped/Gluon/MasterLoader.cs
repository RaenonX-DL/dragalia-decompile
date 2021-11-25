using System;

namespace Gluon
{
	public class MasterLoader
	{
		private static bool isLoaded;

		private const string overrideStaticTextLabel = "OVERRIDE_STATICTEXT__";

		public static void Reload()
		{
		}

		public static void ResetLoadedFlag()
		{
		}

		public static void CustomLoad(Func<string, bool> filteringFunc, bool callForEditorEvent, bool overrideStaticText)
		{
		}

		public static void Load()
		{
		}

		public static void OverrideStaticText()
		{
		}

		private static bool FilteringCsv(string srcPath)
		{
			return default(bool);
		}
	}
}
