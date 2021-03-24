/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Master
{
	public class MasterLoader
	{
		// Fields
		[CompilerGenerated]
		private static Action<Type> OnLoadRequest;
	
		// Events
		public static event Action<Type> OnLoadRequest {
			add;
			remove;
		}
	
		// Constructors
		public MasterLoader();
	
		// Methods
		public static void RequestLoadMaster(Type type);
	}
}
