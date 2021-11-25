using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using ExitGames.Client.Photon;

namespace Gluon
{
	public class PhotonSearchBestRegionService
	{
		public struct RequestType
		{
			public PhotonClusterSet clusterSet;

			public PhotonClusterRttResult rttCache;
		}

		public struct ResultType
		{
			public PhotonCluster bestRegionCluster;
		}

		private enum State
		{
			None,
			Running,
			Completed
		}

		private class RttResultType
		{
			public PhotonCluster cluster;

			public float rtt;
		}

		private class GluonPing : PhotonPing
		{
			private Socket sock;

			public override bool StartPing(string ip)
			{
				return default(bool);
			}

			public override bool Done()
			{
				return default(bool);
			}

			public override void Dispose()
			{
			}
		}

		private class PingTask
		{
			private enum State
			{
				None,
				Pinging,
				Completed
			}

			public static readonly int Attempts;

			public static readonly int MaxMilliseconsPerPing;

			private State _state;

			private int _sendCount;

			private GluonPing _ping;

			private RttResultType _result;

			private Stopwatch sw;

			public PhotonCluster Cluster => null;

			public bool IsCompleted => default(bool);

			public bool HasResult => default(bool);

			public RttResultType Result => null;

			public PingTask(PhotonCluster cluster)
			{
			}

			public void Destroy()
			{
			}

			private void StartPing(string hostname)
			{
			}

			public void Update()
			{
			}

			public static string ResolveHost(string hostName)
			{
				return null;
			}
		}

		private RequestType _request;

		private ResultType _result;

		private List<PingTask> _taskList;

		private List<RttResultType> _rttResultList;

		private State _state;

		private bool _isAnyTaskCompleted;

		public void Clear()
		{
		}

		public void Start(RequestType req)
		{
		}

		public void Update()
		{
		}

		public bool IsCompleted()
		{
			return default(bool);
		}

		public ResultType GetResult()
		{
			return default(ResultType);
		}

		public void _StartTask(List<PhotonCluster> clusters)
		{
		}

		private void UpdateTask()
		{
		}
	}
}
