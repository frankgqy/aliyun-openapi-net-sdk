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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveAudioAuditNotifyConfigResponseUnmarshaller
    {
        public static DescribeLiveAudioAuditNotifyConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveAudioAuditNotifyConfigResponse describeLiveAudioAuditNotifyConfigResponse = new DescribeLiveAudioAuditNotifyConfigResponse();

			describeLiveAudioAuditNotifyConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveAudioAuditNotifyConfigResponse.RequestId = context.StringValue("DescribeLiveAudioAuditNotifyConfig.RequestId");

			List<DescribeLiveAudioAuditNotifyConfigResponse.DescribeLiveAudioAuditNotifyConfig_LiveAudioAuditNotifyConfig> describeLiveAudioAuditNotifyConfigResponse_liveAudioAuditNotifyConfigList = new List<DescribeLiveAudioAuditNotifyConfigResponse.DescribeLiveAudioAuditNotifyConfig_LiveAudioAuditNotifyConfig>();
			for (int i = 0; i < context.Length("DescribeLiveAudioAuditNotifyConfig.LiveAudioAuditNotifyConfigList.Length"); i++) {
				DescribeLiveAudioAuditNotifyConfigResponse.DescribeLiveAudioAuditNotifyConfig_LiveAudioAuditNotifyConfig liveAudioAuditNotifyConfig = new DescribeLiveAudioAuditNotifyConfigResponse.DescribeLiveAudioAuditNotifyConfig_LiveAudioAuditNotifyConfig();
				liveAudioAuditNotifyConfig.DomainName = context.StringValue("DescribeLiveAudioAuditNotifyConfig.LiveAudioAuditNotifyConfigList["+ i +"].DomainName");
				liveAudioAuditNotifyConfig.Callback = context.StringValue("DescribeLiveAudioAuditNotifyConfig.LiveAudioAuditNotifyConfigList["+ i +"].Callback");
				liveAudioAuditNotifyConfig.CallbackTemplate = context.StringValue("DescribeLiveAudioAuditNotifyConfig.LiveAudioAuditNotifyConfigList["+ i +"].CallbackTemplate");

				describeLiveAudioAuditNotifyConfigResponse_liveAudioAuditNotifyConfigList.Add(liveAudioAuditNotifyConfig);
			}
			describeLiveAudioAuditNotifyConfigResponse.LiveAudioAuditNotifyConfigList = describeLiveAudioAuditNotifyConfigResponse_liveAudioAuditNotifyConfigList;
        
			return describeLiveAudioAuditNotifyConfigResponse;
        }
    }
}
