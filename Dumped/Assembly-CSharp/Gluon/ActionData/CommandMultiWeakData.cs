﻿/*
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
	public class CommandMultiWeakData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsCommandMultiWeak.CommandType _command;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
		[HideInInspector]
		[SerializeField]
		private int[] _actions;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetIcon;
		[HideInInspector]
		[SerializeField]
		private float _scaleIcon;
	
		// Properties
		public ActionPartsCommandMultiWeak.CommandType command { get; }
		public bool guarantee { get; }
		public int[] actions { get; }
		public Vector3 offsetIcon { get; }
		public float scaleIcon { get; }
	
		// Constructors
		public CommandMultiWeakData();
	}
}
