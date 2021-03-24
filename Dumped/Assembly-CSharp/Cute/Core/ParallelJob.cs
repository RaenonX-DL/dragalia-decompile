/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class ParallelJob
	{
		// Fields
		[CompilerGenerated]
		private bool _IsDone_k__BackingField;
		private Action action;
	
		// Properties
		public bool IsDone { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		private ParallelJob(Action action);
	
		// Methods
		public static ParallelJob Dispatch(Action action);
		internal void Run();
	}
}
