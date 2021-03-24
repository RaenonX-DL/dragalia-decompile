/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupMiasmaData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _actionId;
		[HideInInspector]
		[SerializeField]
		private string _effName;
		[HideInInspector]
		[SerializeField]
		private string _beginSe;
		[HideInInspector]
		[SerializeField]
		private string _endSe;
		[HideInInspector]
		[SerializeField]
		private float _addPointSpeed;
		[HideInInspector]
		[SerializeField]
		private float _waitTimeForAuto;
	
		// Properties
		public int actionId { get; }
		public string effName { get; }
		public string beginSe { get; }
		public string endSe { get; }
		public float addPointSpeed { get; }
		public float waitTimeForAuto { get; }
	
		// Constructors
		public SetupMiasmaData();
	}
}
