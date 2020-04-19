using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStack;
using ServiceStack.Script;
using ServiceStack.DataAnnotations;
using TemplateViewPage.ServiceModel;

namespace TemplateViewPage.ServiceInterface
{
	public class DatabaseServices : Service
	{
		public object Any(Database request)
		{
			return new HttpResult(new DatabaseResponse { DatabaseUrl = $"Database: {request.Name}!" });
			//return new DatabaseResponse { DatabaseUrl = $"Database: {request.Name}!" };
		}
	}
}
