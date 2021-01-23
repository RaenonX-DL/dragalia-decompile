/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EffectTable : ScriptableObject
	{
		// Fields
		private const string FILE_NAME = "EffectTable";
		private const string RESOURCES_PATH = "Effect/EffectTable";
		private const string ASSET_PATH = "Assets/_GluonResources/Resources/Effect/EffectTable";
		[CompilerGenerated]
		private static EffectTable _Instance_k__BackingField;
		[SerializeField]
		private List<EffectTableElement> list;
		private Dictionary<string, List<string>> _dic;
	
		// Properties
		public static EffectTable Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<EffectTableElement> List { get; }
		public Dictionary<string, List<string>> Dic { get; }
	
		// Constructors
		public EffectTable();
	
		// Methods
		public static void Load();
	}
}
