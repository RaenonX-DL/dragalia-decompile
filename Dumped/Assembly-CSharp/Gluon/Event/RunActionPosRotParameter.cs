﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class RunActionPosRotParameter : RunActionParameterBase
	{
		// Fields
		[Key]
		public Vector3 position;
		[Key]
		public float rotation;
	
		// Constructors
		public RunActionPosRotParameter();
	}
}
