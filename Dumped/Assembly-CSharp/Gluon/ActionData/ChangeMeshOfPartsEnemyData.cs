/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class ChangeMeshOfPartsEnemyData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsChangeMeshOfPartsEnemy.PartsIndex _partsIdx;
		[HideInInspector]
		[SerializeField]
		private string _newMeshName;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsChangeMeshOfPartsEnemy.PartsIndex partsIdx { get; }
		public string newMeshName { get; }
		public bool guarantee { get; }
	
		// Constructors
		public ChangeMeshOfPartsEnemyData();
	}
}
