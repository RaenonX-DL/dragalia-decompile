using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonObjectStatus : CommonObjectStatus
	{
		private class StatusContainer
		{
			public bool boolValue;

			public int intValue;
		}

		protected enum ShadowCastMethod
		{
			TexturedQuad,
			TextureProjection,
			MaxNum
		}

		private static Dictionary<int, StatusContainer> statustDictionary;

		private static Dictionary<int, DungeonObjectStatus> serialNumberDictionary;

		[SerializeField]
		[Lock]
		public int idNumber;

		protected GameObject[] shadowObjectTable;

		private Transform _shadowTrans;

		protected Projector _shadowProjector;

		private const float kShadowSizeCoef = 0.6f;

		private ShadowCastMethod _shadowCastMethod;

		[SerializeField]
		private DungeonObjectShadow.ShadowData _shadowData;

		private static int serialNumberCounterForSync;

		public static Dictionary<int, DungeonObjectStatus> SerialNumberDictionary => null;

		public int SerialNumberForSync
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected bool IsMultiPlayHost => default(bool);

		protected bool IsMultiPlayGuest => default(bool);

		protected bool IsMultiPlayHostOrSolo => default(bool);

		public static void ClearStatus()
		{
		}

		private int GetDictionaryKey()
		{
			return default(int);
		}

		private StatusContainer GetContainer(int key)
		{
			return null;
		}

		protected void RecordOddsItem()
		{
		}

		protected void SetStatusBoolValue(bool value)
		{
		}

		protected bool GetStatusBoolValue(bool defaultValue = false)
		{
			return default(bool);
		}

		public static bool GetStatusBoolValue(int idx, bool defaultValue = false)
		{
			return default(bool);
		}

		protected void SetStatusIntValue(int value)
		{
		}

		protected int GetStatusIntValue(int defaultValue = 0)
		{
			return default(int);
		}

		public static int GetStatusIntValue(int idx, int defaultValue = 0)
		{
			return default(int);
		}

		protected override void Awake()
		{
		}

		protected void ResizeShadow(float shadowSize)
		{
		}

		private void ChangeShadowCastMethod(ShadowCastMethod method)
		{
		}

		public virtual void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		protected void RaiseEvent([Optional] DungeonObject eventObject)
		{
		}

		protected void RaiseEvent(GameObject target)
		{
		}

		public static void AssignSerialNumbers(Transform parent)
		{
		}

		public static void ClearSerialNumbers()
		{
		}

		public void AssignSerialNumber()
		{
		}

		public static DungeonObjectStatus GetDungeonObjectStatusBySerialNumber(int serialNumber)
		{
			return null;
		}

		public static void NotifyDisconnection()
		{
		}

		protected override void OnDestroy()
		{
		}

		public virtual bool CanDetectedForAutoPlayMode()
		{
			return default(bool);
		}

		public virtual void OnDisconnected()
		{
		}
	}
}
