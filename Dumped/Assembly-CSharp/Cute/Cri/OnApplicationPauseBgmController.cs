/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class OnApplicationPauseBgmController
	{
		// Fields
		[CompilerGenerated]
		private static bool _IsInitialized_k__BackingField;
		[CompilerGenerated]
		private static Action<bool> PauseMyselfBgmAction;
	
		// Properties
		public static bool IsInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Events
		public static event Action<bool> PauseMyselfBgmAction {
			add;
			remove;
		}
	
		// Constructors
		public OnApplicationPauseBgmController();
		static OnApplicationPauseBgmController();
	
		// Methods
		public static void Initialize();
		private static void OnApplicationPausePreProcess(bool pause);
		private static void OnApplicationPausePostProcess(bool pause);
		private static void PauseMyselfAudio(bool isPauseMyselfAudio);
	}
}
