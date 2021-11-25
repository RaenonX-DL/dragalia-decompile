using System.Collections.Generic;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterAnimationEvent : MonoBehaviour
	{
		private class PlayEffectCommand
		{
			public string effectName;

			public string attachNodeName;

			public int trigger;
		}

		private SimpleCharacterModel simpleCharacterModel;

		private RenderPartsData renderPartsData;

		private Dictionary<string, EffectObject> effectDict;

		private List<PlayEffectCommand> playEffectCommands;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		public void FBXImport_ChangeMesh(string meshpartsName)
		{
		}

		public void ChangeMeshVisibility(string command)
		{
		}

		public void SetFace(string command)
		{
		}

		public void FBXImport_PlayEffect(string commandStr)
		{
		}

		private bool PlayEffect(PlayEffectCommand command)
		{
			return default(bool);
		}

		public static string GetPlayEffectEffectName(string command)
		{
			return null;
		}

		public static string GetPlayEffectAttachNodeName(string command)
		{
			return null;
		}

		public static int GetPlayEffectTrigger(string command)
		{
			return default(int);
		}
	}
}
