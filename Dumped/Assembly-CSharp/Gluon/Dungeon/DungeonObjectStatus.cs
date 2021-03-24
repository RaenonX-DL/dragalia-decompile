/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonObjectStatus : CommonObjectStatus
	{
		// Fields
		private static Dictionary<int, StatusContainer> statustDictionary;
		private static Dictionary<int, DungeonObjectStatus> serialNumberDictionary;
		[Lock]
		[SerializeField]
		public int idNumber;
		protected GameObject[] shadowObjectTable;
		private Transform _shadowTrans;
		protected Projector _shadowProjector;
		private const float kShadowSizeCoef = 0.6f;
		private ShadowCastMethod _shadowCastMethod;
		[SerializeField]
		private DungeonObjectShadow.ShadowData _shadowData;
		private static int serialNumberCounterForSync;
		[CompilerGenerated]
		private int _SerialNumberForSync_k__BackingField;
	
		// Properties
		public static Dictionary<int, DungeonObjectStatus> SerialNumberDictionary { get; }
		public int SerialNumberForSync { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected bool IsMultiPlayHost { get; }
		protected bool IsMultiPlayGuest { get; }
		protected bool IsMultiPlayHostOrSolo { get; }
	
		// Nested types
		private class StatusContainer
		{
			// Fields
			public bool boolValue;
			public int intValue;
	
			// Constructors
			public StatusContainer();
		}
	
		protected enum ShadowCastMethod
		{
			TexturedQuad = 0,
			TextureProjection = 1,
			MaxNum = 2
		}
	
		// Constructors
		public DungeonObjectStatus();
		static DungeonObjectStatus();
	
		// Methods
		public static void ClearStatus();
		private int GetDictionaryKey();
		private StatusContainer GetContainer(int key);
		protected void RecordOddsItem();
		protected void SetStatusBoolValue(bool value);
		protected bool GetStatusBoolValue(bool defaultValue = false);
		public static bool GetStatusBoolValue(int idx, bool defaultValue = false);
		protected void SetStatusIntValue(int value);
		protected int GetStatusIntValue(int defaultValue = 0);
		public static int GetStatusIntValue(int idx, int defaultValue = 0);
		protected override void Awake();
		protected void ResizeShadow(float shadowSize);
		private void ChangeShadowCastMethod(ShadowCastMethod method);
		public virtual void OnEvent(DungeonObject eventObject, GameObject target);
		protected void RaiseEvent(DungeonObject eventObject = null);
		protected void RaiseEvent(GameObject target);
		public static void AssignSerialNumbers(Transform parent);
		public static void ClearSerialNumbers();
		public void AssignSerialNumber();
		public static DungeonObjectStatus GetDungeonObjectStatusBySerialNumber(int serialNumber);
		public static void NotifyDisconnection();
		protected override void OnDestroy();
		public virtual bool CanDetectedForAutoPlayMode();
		public virtual void OnDisconnected();
	}
}
