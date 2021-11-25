using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class RenderTextureManager : FastUpdateMonoBehaviour
	{
		[Flags]
		public enum CameraLabelFlags
		{
			Main = 0x1,
			Story3D = 0x2,
			Story2D = 0x4
		}

		[Serializable]
		private class RenderTextureData
		{
			[Tooltip("ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083¼ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®å\u0090\u008då\u0089\u008d")]
			public string name;

			[Tooltip("ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083¼ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®ã\u0082µã\u0082¤ã\u0082º")]
			public Vector2Int size;

			[Tooltip("ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083¼ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®ã\u0083\u0087ã\u0083\u0097ã\u0082¹å\u0080¤")]
			public int depth;

			[Tooltip("å\u00b8\u00b8ã\u0081«ã\u0082¹ã\u0082\u00afã\u0083ªã\u0083¼ã\u0083³ã\u0082µã\u0082¤ã\u0082ºã\u0081«ã\u0081\u0082ã\u0082\u008fã\u0081\u009bã\u0082\u008bã\u0081\u008b")]
			public bool isAlwaysScreenSize;

			[EnumFlags]
			[Tooltip("ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083¼ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®ä½\u009cæ\u0088\u0090ã\u0083\u0095ã\u0083©ã\u0082°")]
			public CameraLabelFlags createFlags;

			[Tooltip("ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083¼ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u009eã\u0083\u0083ã\u0083\u0088")]
			public RenderTextureFormat format;

			[NonSerialized]
			public RenderTexture renderTexture;
		}

		public delegate bool RenewRenderTexture(RenderTexture oldTexture, RenderTexture newTexture);

		private const CameraLabelFlags CameraLabelFlagsNone = (CameraLabelFlags)0;

		private const CameraLabelFlags CameraLabelFlagsAll = (CameraLabelFlags)2147483647;

		[SerializeField]
		[Tooltip("ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083¼ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®ä½\u009cæ\u0088\u0090ã\u0083\u0087ã\u0083¼ã\u0082¿")]
		private RenderTextureData[] _renderTextureData;

		private Dictionary<string, RenderTextureData> _renderTextureDataDictionary;

		public event RenewRenderTexture eventRenewRenderTexture
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void CreateTexture(CameraLabelFlags createFlags)
		{
		}

		public void ReleaseTexture(CameraLabelFlags releaseFlags)
		{
		}

		private void OnDestroy()
		{
		}

		public RenderTexture GetRenderTexture(int id)
		{
			return null;
		}

		public RenderTexture GetRenderTexture(string name)
		{
			return null;
		}

		public override void FastUpdate()
		{
		}
	}
}
