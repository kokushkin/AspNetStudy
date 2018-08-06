using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_4
{
    /// <summary>
    /// Summary description for CalculatorCallbackHandler
    /// </summary>
    public class CalculatorCallbackHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;

            // Вывести обычный текст
            response.ContentType = "text/plain";

            // Получить аргументы строки запроса        
            float value1, value2;
            if (Single.TryParse(context.Request.QueryString["value1"], out value1) &&
                Single.TryParse(context.Request.QueryString["value2"], out value2))
            {
                // Вычислить сумму
                response.Write(value1 + value2);
                response.Write(",");

                // Вернуть текущее время
                DateTime now = DateTime.Now;
                response.Write(now.ToLongTimeString());
            }
            else
            {
                // Значения не были предоставлены, или они не были числами.
                // Указать на ошибку
                response.Write("-");
            }
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}