﻿using Messaging.Core.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Messaging.Core.Interfaces
{
	public interface IRabbitConsumer
	{
		void Setup(RabbitConfiguration rabbitConfiguration);
		void Get(IRabbitMessageHandler messageHandler);
		Task ConsumeAsync(IRabbitMessageHandler messageHandler, CancellationTokenSource cancellationTokenSource);
	}
}
