// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.Extensions;
using Azure.ResourceManager;

namespace Microsoft.Extensions.Azure
{
    /// <summary>
    /// Extension methods to add <see cref="ArmClientOptions"/> client to clients builder.
    /// </summary>
    public static class ArmClientBuilderExtensions
    {
        /// <summary>
        /// Registers a <see cref="ArmClient"/> instance.
        /// </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="defaultSubscriptionId"> The id of the default Azure subscription. </param>
        public static IAzureClientBuilder<ArmClient, ArmClientOptions> AddArmClient<TBuilder>(this TBuilder builder, string defaultSubscriptionId)
            where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<ArmClient, ArmClientOptions>((options, token) => new ArmClient(token, defaultSubscriptionId, options));
        }
    }
}
