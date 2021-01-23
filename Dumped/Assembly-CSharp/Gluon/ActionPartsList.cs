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
	public class ActionPartsList : ScriptableObject
	{
		// Fields
		public const string EXPORT_ACTOIN_DIRECTORY_PATH = "Assets/_GluonResources/Resources/Actions";
		public const string RESOURCES_PATH = "Actions/ActionPartsList";
		private const string ASSET_PATH = "Assets/_GluonResources/Resources/Actions/ActionPartsList";
		[CompilerGenerated]
		private static ActionPartsList _Instance_k__BackingField;
		[SerializeField]
		private List<ActionPartsListElement> list;
		private Dictionary<string, List<string>> _dic;
	
		// Properties
		public static ActionPartsList Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<string, List<string>> Dic { get; }
	
		// Constructors
		public ActionPartsList();
	
		// Methods
		public static void Load();
		public static void Reset();
	}
}
