﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/invokecloudfunction 接口的请求。</para>
    /// </summary>
    public class TcbInvokeCloudFunctionRequest : WechatApiRequest, IInferable<TcbInvokeCloudFunctionRequest, TcbInvokeCloudFunctionResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FunctionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数传入参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Data { get; set; }
    }
}
