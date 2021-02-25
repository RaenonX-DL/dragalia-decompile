/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRAiChecker
	{
		// Fields
		private Dictionary<CharacterId, AiCheckData> aiCheckDataMap;
		private const float aiCheckIntervalTimer = 15f;
		private float aiCheckTimer;
	
		// Nested types
		private class AiCheckData
		{
			// Fields
			public int prevHp;
			public Vector3 lastPosition;
			public float lastMoveTime;
	
			// Constructors
			public AiCheckData();
		}
	
		// Constructors
		public BRAiChecker();
	
		// Methods
		public void UpdateAiCheck(BRCtrl brCtrl);
	}
}
