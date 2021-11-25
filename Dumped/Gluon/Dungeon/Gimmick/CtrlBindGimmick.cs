using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class CtrlBindGimmick
	{
		public class BindAppearance
		{
			public string effectName;

			public float duration;

			public string seName;

			public static BindAppearance Default()
			{
				return null;
			}
		}

		private struct BindTargetInfoData
		{
			public CharacterBase TargetChara
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public EffectObject AttachEffect
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool FromNetwork
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public BindTargetInfoData(CharacterBase target, EffectObject eo, bool fromNetwork)
			{
			}
		}

		private class BindInfoData
		{
			public enum States
			{
				None,
				Catching,
				Confirmed,
				Released
			}

			public States localState;

			public long bindEventId;

			public List<BindTargetInfoData> targets;

			public MultiPlayWaitingList catchingOtherPlayers;

			public bool IsUsing()
			{
				return default(bool);
			}
		}

		private BindGimmick _owner;

		private List<CharacterBase> BindTargets;

		private List<BindInfoData> _bindInfoList;

		private BindAppearance _appearance;

		private bool _canAutoRelease;

		private static long _nextBindEventId;

		public CtrlBindGimmick(BindGimmick owner, bool canAutoRelease, [Optional] BindAppearance appearance)
		{
		}

		public void Clear()
		{
		}

		public void Update()
		{
		}

		public bool OnCatch(long bindEventId, CharacterBase targetChara, Vector3 position, bool isDamagePose = false, int effectTrigger = 0)
		{
			return default(bool);
		}

		public void OnConfirm(long bindEventId)
		{
		}

		public void OnReleaseAll(long bindEventId)
		{
		}

		public void OnReceiveBindEvent(BindEvent recvData)
		{
		}

		private BindTargetInfoData BindCharacter(CharacterBase targetChara, Vector3 position, bool fromNetwork, bool isDamagePose = false, int effectTriger = 0)
		{
			return default(BindTargetInfoData);
		}

		private void UnbindCharacter(ref BindTargetInfoData target)
		{
		}

		private BindInfoData GetBindInfo(long bindEventId)
		{
			return null;
		}

		private BindTargetInfoData ApplyAppearance(CharacterBase chara, int effectTrigger, bool fromNetwork)
		{
			return default(BindTargetInfoData);
		}

		private void ResetAppearance(ref BindTargetInfoData target)
		{
		}

		private bool CheckAutoRelease(BindInfoData info)
		{
			return default(bool);
		}
	}
}
