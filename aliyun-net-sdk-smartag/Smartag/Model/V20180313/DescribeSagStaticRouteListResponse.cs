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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSagStaticRouteListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSagStaticRouteList_StaticRoute> staticRoutes;

		private List<DescribeSagStaticRouteList_TaskState> taskStates;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeSagStaticRouteList_StaticRoute> StaticRoutes
		{
			get
			{
				return staticRoutes;
			}
			set	
			{
				staticRoutes = value;
			}
		}

		public List<DescribeSagStaticRouteList_TaskState> TaskStates
		{
			get
			{
				return taskStates;
			}
			set	
			{
				taskStates = value;
			}
		}

		public class DescribeSagStaticRouteList_StaticRoute
		{

			private string portName;

			private string destinationCidr;

			private string nextHop;

			private string vlan;

			public string PortName
			{
				get
				{
					return portName;
				}
				set	
				{
					portName = value;
				}
			}

			public string DestinationCidr
			{
				get
				{
					return destinationCidr;
				}
				set	
				{
					destinationCidr = value;
				}
			}

			public string NextHop
			{
				get
				{
					return nextHop;
				}
				set	
				{
					nextHop = value;
				}
			}

			public string Vlan
			{
				get
				{
					return vlan;
				}
				set	
				{
					vlan = value;
				}
			}
		}

		public class DescribeSagStaticRouteList_TaskState
		{

			private string state;

			private string errorCode;

			private string errorMessage;

			private string createTime;

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}
		}
	}
}
