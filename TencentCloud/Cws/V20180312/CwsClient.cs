/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cws.V20180312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cws.V20180312.Models;

   public class CwsClient : AbstractClient{

       private const string endpoint = "cws.tencentcloudapi.com";
       private const string version = "2018-03-12";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public CwsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public CwsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（CreateMonitors）用于新增一个或多个站点的监测任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreateMonitorsRequest"/></param>
        /// <returns>参考<see cref="CreateMonitorsResponse"/>实例</returns>
        public async Task<CreateMonitorsResponse> CreateMonitors(CreateMonitorsRequest req)
        {
             JsonResponseModel<CreateMonitorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMonitors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMonitorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSites）用于新增一个或多个站点。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSitesRequest"/></param>
        /// <returns>参考<see cref="CreateSitesResponse"/>实例</returns>
        public async Task<CreateSitesResponse> CreateSites(CreateSitesRequest req)
        {
             JsonResponseModel<CreateSitesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSitesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSitesScans）用于新增一个或多个站点的单次扫描任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSitesScansRequest"/></param>
        /// <returns>参考<see cref="CreateSitesScansResponse"/>实例</returns>
        public async Task<CreateSitesScansResponse> CreateSitesScans(CreateSitesScansRequest req)
        {
             JsonResponseModel<CreateSitesScansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSitesScans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSitesScansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVulsMisinformation）用于新增一个或多个漏洞误报信息。
        /// </summary>
        /// <param name="req">参考<see cref="CreateVulsMisinformationRequest"/></param>
        /// <returns>参考<see cref="CreateVulsMisinformationResponse"/>实例</returns>
        public async Task<CreateVulsMisinformationResponse> CreateVulsMisinformation(CreateVulsMisinformationRequest req)
        {
             JsonResponseModel<CreateVulsMisinformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulsMisinformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulsMisinformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateVulsReport) 用于生成漏洞报告并返回下载链接。
        /// </summary>
        /// <param name="req">参考<see cref="CreateVulsReportRequest"/></param>
        /// <returns>参考<see cref="CreateVulsReportResponse"/>实例</returns>
        public async Task<CreateVulsReportResponse> CreateVulsReport(CreateVulsReportRequest req)
        {
             JsonResponseModel<CreateVulsReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulsReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulsReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteMonitors) 用于删除监控任务。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMonitorsRequest"/></param>
        /// <returns>参考<see cref="DeleteMonitorsResponse"/>实例</returns>
        public async Task<DeleteMonitorsResponse> DeleteMonitors(DeleteMonitorsRequest req)
        {
             JsonResponseModel<DeleteMonitorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMonitors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMonitorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteSites) 用于删除站点。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSitesRequest"/></param>
        /// <returns>参考<see cref="DeleteSitesResponse"/>实例</returns>
        public async Task<DeleteSitesResponse> DeleteSites(DeleteSitesRequest req)
        {
             JsonResponseModel<DeleteSitesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSitesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeConfig) 用于查询用户配置的详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeConfigResponse"/>实例</returns>
        public async Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeMonitors) 用于查询一个或多个监控任务的详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMonitorsRequest"/></param>
        /// <returns>参考<see cref="DescribeMonitorsResponse"/>实例</returns>
        public async Task<DescribeMonitorsResponse> DescribeMonitors(DescribeMonitorsRequest req)
        {
             JsonResponseModel<DescribeMonitorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonitors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSiteQuota) 用于查询用户购买的扫描次数总数和已使用数。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSiteQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeSiteQuotaResponse"/>实例</returns>
        public async Task<DescribeSiteQuotaResponse> DescribeSiteQuota(DescribeSiteQuotaRequest req)
        {
             JsonResponseModel<DescribeSiteQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSiteQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSiteQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSites) 用于查询一个或多个站点的详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSitesRequest"/></param>
        /// <returns>参考<see cref="DescribeSitesResponse"/>实例</returns>
        public async Task<DescribeSitesResponse> DescribeSites(DescribeSitesRequest req)
        {
             JsonResponseModel<DescribeSitesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSitesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSitesVerification) 用于查询一个或多个待验证站点的验证信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSitesVerificationRequest"/></param>
        /// <returns>参考<see cref="DescribeSitesVerificationResponse"/>实例</returns>
        public async Task<DescribeSitesVerificationResponse> DescribeSitesVerification(DescribeSitesVerificationRequest req)
        {
             JsonResponseModel<DescribeSitesVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSitesVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSitesVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeVuls) 用于查询一个或多个漏洞的详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVulsRequest"/></param>
        /// <returns>参考<see cref="DescribeVulsResponse"/>实例</returns>
        public async Task<DescribeVulsResponse> DescribeVuls(DescribeVulsRequest req)
        {
             JsonResponseModel<DescribeVulsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVuls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeVulsNumber) 用于查询用户网站的漏洞总计数量。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVulsNumberRequest"/></param>
        /// <returns>参考<see cref="DescribeVulsNumberResponse"/>实例</returns>
        public async Task<DescribeVulsNumberResponse> DescribeVulsNumber(DescribeVulsNumberRequest req)
        {
             JsonResponseModel<DescribeVulsNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulsNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulsNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeVulsNumberTimeline) 用于查询漏洞数随时间变化统计信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVulsNumberTimelineRequest"/></param>
        /// <returns>参考<see cref="DescribeVulsNumberTimelineResponse"/>实例</returns>
        public async Task<DescribeVulsNumberTimelineResponse> DescribeVulsNumberTimeline(DescribeVulsNumberTimelineRequest req)
        {
             JsonResponseModel<DescribeVulsNumberTimelineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulsNumberTimeline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulsNumberTimelineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyConfigAttribute) 用于修改用户配置的属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyConfigAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyConfigAttributeResponse"/>实例</returns>
        public async Task<ModifyConfigAttributeResponse> ModifyConfigAttribute(ModifyConfigAttributeRequest req)
        {
             JsonResponseModel<ModifyConfigAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConfigAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyMonitorAttribute) 用于修改监测任务的属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMonitorAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyMonitorAttributeResponse"/>实例</returns>
        public async Task<ModifyMonitorAttributeResponse> ModifyMonitorAttribute(ModifyMonitorAttributeRequest req)
        {
             JsonResponseModel<ModifyMonitorAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMonitorAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMonitorAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifySiteAttribute) 用于修改站点的属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySiteAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifySiteAttributeResponse"/>实例</returns>
        public async Task<ModifySiteAttributeResponse> ModifySiteAttribute(ModifySiteAttributeRequest req)
        {
             JsonResponseModel<ModifySiteAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySiteAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySiteAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (VerifySites) 用于验证一个或多个待验证站点。
        /// </summary>
        /// <param name="req">参考<see cref="VerifySitesRequest"/></param>
        /// <returns>参考<see cref="VerifySitesResponse"/>实例</returns>
        public async Task<VerifySitesResponse> VerifySites(VerifySitesRequest req)
        {
             JsonResponseModel<VerifySitesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifySites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifySitesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
