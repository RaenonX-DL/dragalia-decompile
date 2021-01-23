/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttEventParam_ChangeEyeTrackTarget : CuttEventParamBase
	{
		// Fields
		public Target target;
	
		// Nested types
		public enum Target
		{
			Arena = 0,
			Camera = 1,
			StageLeftSide = 2,
			StageRightSide = 3
		}
	
		// Constructors
		public CuttEventParam_ChangeEyeTrackTarget();
	}
}
