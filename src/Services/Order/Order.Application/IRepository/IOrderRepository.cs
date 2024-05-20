using System;
using Common.Repository;
using Order.Domain.Model;

namespace Order.Application
{
	public interface IOrderRepository: IAsyncRepository<Orders>
	{
	}
}

