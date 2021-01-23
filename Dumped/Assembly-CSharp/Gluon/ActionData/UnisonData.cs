/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class UnisonData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsUnison.UnisonType _type;
		[HideInInspector]
		[SerializeField]
		private int _primaryActionId;
		[HideInInspector]
		[SerializeField]
		private int _secondryActionId;
		[HideInInspector]
		[SerializeField]
		private Vector3 _primaryOffsetPos;
		[HideInInspector]
		[SerializeField]
		private Vector3 _secondaryOffsetPos;
		[HideInInspector]
		[SerializeField]
		private float _primaryOffsetDir;
		[HideInInspector]
		[SerializeField]
		private float _secondaryOffsetDir;
		[HideInInspector]
		[SerializeField]
		private float _primaryDistace;
		[HideInInspector]
		[SerializeField]
		private float _secondaryDistace;
		[HideInInspector]
		[SerializeField]
		private bool _synchroTarget;
		[HideInInspector]
		[SerializeField]
		private bool _isTargetActionReset;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsUnison.UnisonType type { get; }
		public int primaryActionId { get; }
		public int secondryActionId { get; }
		public Vector3 primaryOffsetPos { get; }
		public Vector3 secondaryOffsetPos { get; }
		public float primaryOffsetDir { get; }
		public float secondaryOffsetDir { get; }
		public float primaryDistace { get; }
		public float secondaryDistace { get; }
		public bool synchroTarget { get; }
		public bool isTargetActionReset { get; }
		public bool guarantee { get; }
	
		// Constructors
		public UnisonData();
	}
}
