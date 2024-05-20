using System;
using Common.Repository;
using Microsoft.EntityFrameworkCore;
using Order.Application;
using Order.Domain.Model;
using Order.Infrastructure.Persistance;

namespace Order.Infrastructure.Repository
{
	public class OrderRepository: RepositoryBase<Orders>, IOrderRepository
	{
		public OrderRepository(OrderContext orderContext): base(orderContext)
		{

		}
	}
}

