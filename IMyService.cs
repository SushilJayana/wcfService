using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace wcf
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate =
                "GetName?name={name}"
            )]
        string GetName(String name);
    }
}