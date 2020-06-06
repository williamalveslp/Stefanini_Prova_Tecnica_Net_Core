//using System;
//using System.Net;

//namespace StefaniniCore.Infra.CrossCutting
//{
//    public class CustomException : Exception
//    {
//        public CustomException(string customMessage, HttpStatusCode httpStatusCode)
//        {
//            this.CustomMessage = customMessage;
//            this.HttpStatusCode = httpStatusCode;
//        }

//        public string CustomMessage { get; private set; }

//        public HttpStatusCode HttpStatusCode { get; private set; }

//        public static CustomException BadRequest(string message)
//        {
//            throw new CustomException(message, HttpStatusCode.BadRequest);
//        }

//        public static CustomException Forbidden(string message)
//        {
//            throw new CustomException(message, HttpStatusCode.Forbidden);
//        }
//    }
//}
