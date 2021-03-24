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
	public class ActiveCancelData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _actionId;
		[HideInInspector]
		[SerializeField]
		protected ActionPartsActiveCancel.ActionType _actionType;
		[HideInInspector]
		[SerializeField]
		protected bool _motionEnd;
	
		// Properties
		public int actionId { get; }
		public ActionPartsActiveCancel.ActionType actionType { get; }
		public bool motionEnd { get; }
	
		// Constructors
		public ActiveCancelData();
	}
}
