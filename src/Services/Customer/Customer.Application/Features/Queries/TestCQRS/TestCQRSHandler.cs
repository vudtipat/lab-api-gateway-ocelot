using System;
using MediatR;

namespace Customer.Application.Features.Queries.TestCQRS
{
	public class TestCQRSHandler : IRequestHandler<TestCQRSQuery, Result>
    {
		public async Task<Result> Handle(TestCQRSQuery request,CancellationToken cancellationToken)
		{
			var result = new Result();

			result.ErrorCode = "00";
			result.ErrorMessage = "Success!!";

			return result;
		}
	}

	public class Result
	{
		public string ErrorCode { set; get; }
		public string ErrorMessage { set; get; }
	}
}

