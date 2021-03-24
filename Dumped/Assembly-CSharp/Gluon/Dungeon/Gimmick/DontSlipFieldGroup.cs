/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class DontSlipFieldGroup : MonoBehaviour
	{
		// Fields
		private List<DontSlipField> fields;
		private Dictionary<int, VictimInfo> victimInfoDic;
	
		// Nested types
		private class VictimInfo
		{
			// Fields
			public CharacterSelector chara;
			public int enterCount;
			public bool dontSlip;
	
			// Constructors
			public VictimInfo();
		}
	
		// Constructors
		public DontSlipFieldGroup();
	
		// Methods
		private void Start();
		private void Update();
		private int GetInstanceID(GameObject go);
		private void SetSlipState(VictimInfo info, bool b);
		private void OnTriggerEnter(Collider other);
		private void OnTriggerExit(Collider other);
		private void OnStayField(DontSlipField field, Collider other);
		private void OnExitField(DontSlipField field, Collider other);
	}
}
