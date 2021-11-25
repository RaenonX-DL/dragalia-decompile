using System;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Cri.Audio;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class InteractiveBgmController : MonoBehaviour
	{
		public struct TransitionInfo
		{
			public long LastPastMarkerTime
			{
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public long NextPastMarkerTime
			{
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public long TimeToNextPastMarker
			{
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public long TimeToTransition
			{
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int NextPastMarkerType
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool IsTransitionMarkerEnd
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool IsError
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public static TransitionInfo Error()
			{
				return default(TransitionInfo);
			}
		}

		private Action _transitionStartCallback;

		private Action _beatActionCallback;

		private bool _reservedTransitionStart;

		private long comparisonNextPastEventTime;

		private InteractiveBGMElement GetInteractiveBgmSetting(string cueName)
		{
			return null;
		}

		private void Update()
		{
		}

		public void SetTransitionStartCallback(Action transitionStartCallback)
		{
		}

		public void RemoveTransitionStartCallback(Action transitionStartCallback)
		{
		}

		public void ClearAllTransitionCallbacks()
		{
		}

		public void SetBeatActionCallback(Action beatActionCallback)
		{
		}

		public void RemoveBeatActionCallback(Action beatActionCallback)
		{
		}

		public void ClearAllBeatActionCallbacks()
		{
		}

		public static AudioPlayback Play(RequestCueInfo info, PlayParameters param)
		{
			return default(AudioPlayback);
		}

		public TransitionInfo IndicateTransition(AudioPlayback playback)
		{
			return default(TransitionInfo);
		}

		private static void TransitionSequencePosition(AudioPlayback playback, int transitionBlockId, float fadeTime)
		{
		}

		public TransitionInfo GetTransitionInfo()
		{
			return default(TransitionInfo);
		}

		private TransitionInfo GetTransitionInfo(InteractiveBGMElement interactiveBGMSetting, AudioPlayback playback)
		{
			return default(TransitionInfo);
		}
	}
}
