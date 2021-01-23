/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SoundData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _soundName;
		[HideInInspector]
		[SerializeField]
		private List<string> _randomSoundNameList;
		[HideInInspector]
		[SerializeField]
		private bool _isHitAttributeShift;
		[HideInInspector]
		[SerializeField]
		private string _soundNameHAS;
		[HideInInspector]
		[SerializeField]
		private bool _useElementalSound;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalSoundName;
		[HideInInspector]
		[SerializeField]
		private string _soundControlerKey;
		[HideInInspector]
		[SerializeField]
		private bool _isStoppable;
		[HideInInspector]
		[SerializeField]
		private float _fadeTime;
		[HideInInspector]
		[SerializeField]
		private int _playProbability;
		[HideInInspector]
		[SerializeField]
		private GeneratePos _generatePos;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPos;
		[HideInInspector]
		[SerializeField]
		private bool _enableForceStop;
		[HideInInspector]
		[SerializeField]
		private InGameSound.Priority _priority;
	
		// Properties
		public string soundName { get; }
		public List<string> randomSoundNameList { get; }
		public bool isHitAttributeShift { get; }
		public string soundNameHAS { get; }
		public bool useElementalSound { get; }
		public string[] elementalSoundName { get; }
		public string controlerKey { get; }
		public bool isStoppable { get; }
		public float fadeTime { get; }
		public int playProbability { get; }
		public GeneratePos generatePos { get; }
		public Vector3 offsetPos { get; }
		public bool enableForceStop { get; }
		public InGameSound.Priority priority { get; }
	
		// Nested types
		public enum GeneratePos
		{
			Owner = 0,
			Target = 1,
			WorldCenter = 2,
			Marker = 3,
			AreaAnchor = 4,
			Voice2D = 5
		}
	
		// Constructors
		public SoundData();
	}
}
