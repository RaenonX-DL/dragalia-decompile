/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlMultiPrefabComponent : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private bool _editMode;
		[SerializeField]
		private List<FlMultiPrefabItem> _prefabItemList;
		private List<GameObject> _childObjectList;
		private bool _editFromObject;
	
		// Properties
		public List<FlMultiPrefabItem> PrefabItemList { get; }
	
		// Constructors
		public FlMultiPrefabComponent();
	
		// Methods
		private void OnValidate();
		private void OnDrawGizmosSelected();
		private void Awake();
		private void CreateInstanceObject();
		private void UpdateInstanceObject();
		private void ClearChildObject();
	}
}
