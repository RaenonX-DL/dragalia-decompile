/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class RunActionParameterSet : RunActionParameterBase
	{
		// Fields
		[Key]
		public List<RunActionParameterElement> children;
		[Key]
		public List<int> falseConditionParts;
	
		// Constructors
		public RunActionParameterSet();
	
		// Methods
		public static bool IsValidParameterSet(RunActionParameterBase param);
	}
}
