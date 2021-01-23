/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EffectData
	{
		// Fields
		[CompilerGenerated]
		private GameObject _effectObject_k__BackingField;
		[CompilerGenerated]
		private string _groupName_k__BackingField;
		[CompilerGenerated]
		private string _effectName_k__BackingField;
		private int poolCount;
	
		// Properties
		public GameObject effectObject { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string groupName { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string effectName { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int PoolCount { get; set; }
	
		// Constructors
		public EffectData(string name, string eName, int poolCount);
	
		// Methods
		public void OnLoaded(GameObject obj);
		public bool IsLoaded();
	}
}
