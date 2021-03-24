/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	public static class RunActionUtil
	{
		// Methods
		public static RunActionParameterBase ComposeIfNeed(RunActionParameterBase baseParam, RunActionParameterBase extParam, RunActionCompositeParameter compositeParam);
		public static void DecomposeIfNeed<ExtParamType>(RunActionParameterBase param, out RunActionParameterBase baseParam, out ExtParamType extParam)
			where ExtParamType : class, RunActionParameterBase;
	}
}
