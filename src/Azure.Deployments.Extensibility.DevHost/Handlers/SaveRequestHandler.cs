// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Azure.Deployments.Extensibility.Core;

namespace Azure.Deployments.Extensibility.DevHost.Handlers
{
    public class SaveRequestHandler : ExtensibilityRequestHandler
    {
        public SaveRequestHandler()
            : base("/save")
        {
        }

        protected override ExtensibilityOperation SelectProviderOperation(IExtensibilityProvider provider) => provider.SaveAsync;
    }
}
