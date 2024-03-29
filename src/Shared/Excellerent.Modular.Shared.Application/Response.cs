﻿using System.ComponentModel.DataAnnotations;

namespace Excellerent.Modular.Shared.Application
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public Exception? Ex { get; set; }
        public T? t { get; set; }

        public Response()
        {
            this.IsSuccess = true;
        }
        public static Response<T> IsSuccessful(T t)
        {
            return new Response<T>
            {
                t = t,
                IsSuccess = true,
            };
        }
        public static Response<T> IsError(Exception ex)
        {
            return new Response<T>
            {
                IsSuccess = false,
                Ex = ex
            };
        }
        public static Response<T> Success()
        {
            return new Response<T>
            {
                IsSuccess = true,
            };
        }
        public static Response<T> IsError(dynamic result)
        {
            return new Response<T>
            {
                IsSuccess = false,
                Ex = result as Exception
            };
        }

    }
}
