using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistCullUnit : DungeonBgArtistUseCameraBase
	{
		private class RendererData
		{
			public Renderer targetRenderer;

			public bool enableFlag;

			public RendererData(Renderer rend)
			{
			}
		}

		private Transform childTransform;

		private bool enableFlagLog;

		private static readonly float cullDistanceHuman;

		private static readonly float cullDistanceDragon;

		private List<RendererData> rendererDataLogList;

		[SerializeField]
		private float cullDistance;

		protected override void Awake()
		{
		}

		protected void Start()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
