﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public abstract class ProductionTimeCallback : MonoBehaviour
	{
		// Fields
		private static List<ProductionTimeCallback> callbackList;
	
		// Constructors
		protected ProductionTimeCallback();
		static ProductionTimeCallback();
	
		// Methods
		protected virtual void Awake();
		public static void ClearList();
		public static void SetProductionTime();
		public virtual void OnProductionTime();
	}
}
