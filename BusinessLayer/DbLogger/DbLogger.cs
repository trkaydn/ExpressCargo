using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;

namespace BusinessLayer.DbLogger
{
	public static class DbLogger
	{
		static ExceptionLogManager em = new ExceptionLogManager(new EfExceptionLogDal());
		public static void Write(HttpContext context, Exception ex = null)
		{
			//save exception to db

			ExceptionLog savingException = new ExceptionLog()
			{
				RequestMethod = context.Request.Method,
				StatusCode = context.Response.StatusCode,
				ErrorPath = context.Request.Path,
			};

			if (ex != null)  //if exception is a server error, set the exceptionMessage from ex variable
				savingException.ErrorMessage = ex.Message;
			else
				savingException.ErrorMessage = FindErrorMessage(savingException.StatusCode);

			em.ExceptionLogAdd(savingException);
		}

		public static string FindErrorMessage(int statusCode)
		{
			//if exception is a client error, this method sets exceptionMessage.
			string result = null;

			switch (statusCode)
			{
				case 400:
					result = "Bad Request";
					break;
				case 401:
					result = "Unauthorized";
					break;
				case 402:
					result = "Payment Required";
					break;
				case 403:
					result = "Forbidden";
					break;
				case 404:
					result = "Not Found";
					break;
				case 405:
					result = "Method Not Allowed";
					break;
				case 406:
					result = "Not Acceptable";
					break;
				case 407:
					result = "Proxy Authentication Required";
					break;
				case 408:
					result = "Request Timeout";
					break;
				case 409:
					result = "Conflict";
					break;
				case 410:
					result = "Gone";
					break;
				case 411:
					result = "Length Required";
					break;
				case 412:
					result = "Precondition Failed";
					break;
				case 413:
					result = "Payload Too Large";
					break;
				case 414:
					result = "URI Too Long";
					break;
				case 415:
					result = "Unsupported Media Type";
					break;
				case 416:
					result = "Range Not Satisfiable";
					break;
				case 417:
					result = "Expectation Failed";
					break;
				case 422:
					result = "I'm a teapot";
					break;
				case 423:
					result = "Locked";
					break;
				case 424:
					result = "Failed Dependency";
					break;
				case 451:
					result = "Unavailable For Legal Reasons";
					break;
				default:
					statusCode.ToString();
					break;
			}

			return result;
		}
	}
}
