using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

namespace Gluon
{
	public class CutSceneCtrl : SingletonMonoBehaviour<CutSceneCtrl>
	{
		private GameObject cutSceneObject;

		private CutSceneInitializer initializer;

		private List<AudioPlayback> playbackList;

		public bool playing
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

		public string cutSceneName
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

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void LoadCutScene(string cutSceneName)
		{
		}

		public bool CutSceneInitialized()
		{
			return default(bool);
		}

		public void ReleaseCutScene()
		{
		}

		public void PlayCut(string cutName)
		{
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		public void PlaySound(string cueName)
		{
		}

		public void StopSound()
		{
		}
	}
}
