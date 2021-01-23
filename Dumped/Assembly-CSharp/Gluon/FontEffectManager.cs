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
	public class FontEffectManager
	{
		// Fields
		[CompilerGenerated]
		private bool _isActive_k__BackingField;
		private List<EffectData> _listBooked;
		private int bookedIdx;
		private List<PlayedData> _listPlaying;
		private const float TERRITORY_PIXEL = 150f;
		private const int NUM_MAX = 3;
		private const float OFFSET_Y = 3f;
		private const int START_CAPACITY = 16;
	
		// Properties
		public bool isActive { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private struct EffectData
		{
			// Fields
			public int _idx;
			public string _name;
			public CharacterBase _owner;
			public Vector3 _position;
			public Quaternion _rotation;
			public Vector3 _scale;
			public GameObject _attach;
			public EffectObject.FollowRotType _followRot;
			public float _duration;
			public EffectObject.EraseType _eraseType;
			public float _dissapearTime;
			public int _trigger;
	
			// Constructors
			public EffectData(int idx, string name, CharacterBase owner, Vector3 position, Quaternion rot, Vector3 localScale, GameObject attach = null, EffectObject.FollowRotType followRot = EffectObject.FollowRotType.NONE, float duration = 0f, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, float dissapearTime = 0f, int trigger = 0);
		}
	
		private struct PlayedData
		{
			// Fields
			public EffectObject eff;
			public Vector3 pos;
		}
	
		// Constructors
		public FontEffectManager();
	
		// Methods
		public void Update();
		public void PlayDamageEffect(CharacterBase owner, string fontEffectName, Vector3 hitPos);
		public void Book(string name, CharacterBase owner, Vector3 position, Vector3 offset, Quaternion rot, Vector3 localScale, GameObject attach = null, EffectObject.FollowRotType followRot = EffectObject.FollowRotType.NONE, float duration = 0f, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, float dissapearTime = 0f, int trigger = 0);
		private bool CanPlay(int booked_id);
		private static int SortDistance(EffectData a, EffectData b);
		private float CalcCameraScale();
	}
}
