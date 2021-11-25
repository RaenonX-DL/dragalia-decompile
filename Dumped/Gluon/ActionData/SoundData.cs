using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SoundData : ActionParts.PartsData
	{
		public enum GeneratePos
		{
			Owner,
			Target,
			WorldCenter,
			Marker,
			AreaAnchor,
			Voice2D
		}

		[SerializeField]
		[HideInInspector]
		private string _soundName;

		[SerializeField]
		[HideInInspector]
		private List<string> _randomSoundNameList;

		[SerializeField]
		[HideInInspector]
		private bool _isHitAttributeShift;

		[SerializeField]
		[HideInInspector]
		private string _soundNameHAS;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalSound;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalSoundName;

		[SerializeField]
		[HideInInspector]
		private string _soundControlerKey;

		[SerializeField]
		[HideInInspector]
		private bool _isStoppable;

		[SerializeField]
		[HideInInspector]
		private float _fadeTime;

		[SerializeField]
		[HideInInspector]
		private int _playProbability;

		[SerializeField]
		[HideInInspector]
		private GeneratePos _generatePos;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private bool _enableForceStop;

		[SerializeField]
		[HideInInspector]
		private InGameSound.Priority _priority;

		public string soundName => null;

		public List<string> randomSoundNameList => null;

		public bool isHitAttributeShift => default(bool);

		public string soundNameHAS => null;

		public bool useElementalSound => default(bool);

		public string[] elementalSoundName => null;

		public string controlerKey => null;

		public bool isStoppable => default(bool);

		public float fadeTime => default(float);

		public int playProbability => default(int);

		public GeneratePos generatePos => default(GeneratePos);

		public Vector3 offsetPos => default(Vector3);

		public bool enableForceStop => default(bool);

		public InGameSound.Priority priority => default(InGameSound.Priority);
	}
}
