/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MasterLoader
	{
		// Fields
		private static bool isLoaded;
		private const string overrideStaticTextLabel = "OVERRIDE_STATICTEXT__";
	
		// Constructors
		public MasterLoader();
		static MasterLoader();
	
		// Methods
		public static void Reload();
		public static void ResetLoadedFlag();
		public static void CustomLoad(Func<string, bool> filteringFunc, bool callForEditorEvent, bool overrideStaticText);
		public static void Load();
		public static void OverrideStaticText();
		private static bool FilteringCsv(string srcPath);
	}
}
