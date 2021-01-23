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

namespace Gluon.Dungeon.Gimmick
{
	public class TrapFieldGroup : MonoBehaviour
	{
		// Fields
		private List<TrapField> fields;
		private Dictionary<int, VictimInfo> victimInfoDic;
		private const float HIT_INTERVAL_SEC = 3f;
		private bool colliderEnabled;
	
		// Nested types
		private class VictimInfo
		{
			// Fields
			public CharacterBase chara;
			public CharacterSelector charaSelector;
			public int enterCount;
			public float hitTimer;
			public CollisionHitAttribute hitAttribute;
			public AbnormalStatusType abs;
			public bool resist;
	
			// Constructors
			public VictimInfo();
		}
	
		// Constructors
		public TrapFieldGroup();
	
		// Methods
		private void Start();
		private void Update();
		private int GetInstanceID(GameObject go);
		private bool IsExitStateCharacter(CharacterSelector charaSelector);
		private bool IsSupportRequestCharacter(CharacterSelector charaSelector);
		private void OnEnterField(TrapField field, Collider other);
		private void OnExitField(TrapField field, Collider other);
	}
}
