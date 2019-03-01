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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dyplsapi.Transform;
using Aliyun.Acs.Dyplsapi.Transform.V20170525;
using System.Collections.Generic;

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
    public class QuerySubscriptionDetailRequest : RpcAcsRequest<QuerySubscriptionDetailResponse>
    {
        public QuerySubscriptionDetailRequest()
            : base("Dyplsapi", "2017-05-25", "QuerySubscriptionDetail", "dyplsapi", "openAPI")
        {
        }

		private string poolKey;

		private long? resourceOwnerId;

		private string subsId;

		private string resourceOwnerAccount;

		private string phoneNoX;

		private long? ownerId;

		private string productType;

		public string PoolKey
		{
			get
			{
				return poolKey;
			}
			set
			{
				poolKey = value;
				DictionaryUtil.Add(QueryParameters, "PoolKey", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string SubsId
		{
			get
			{
				return subsId;
			}
			set
			{
				subsId = value;
				DictionaryUtil.Add(QueryParameters, "SubsId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string PhoneNoX
		{
			get
			{
				return phoneNoX;
			}
			set
			{
				phoneNoX = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNoX", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

        public override QuerySubscriptionDetailResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QuerySubscriptionDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}